using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vlc_cmd_arduino {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private SerialPort mySerialPort = new SerialPort();
        private cmdAr cmd = new cmdAr();

        private void Form1_Load(object sender, EventArgs e) {
            mySerialPort.BaudRate = 9600;
            mySerialPort.DataBits = 8;
            mySerialPort.StopBits = StopBits.One;
            mySerialPort.Parity = Parity.None;
            mySerialPort.Handshake = Handshake.None;
            mySerialPort.RtsEnable = true;
            mySerialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

            string[] arrport;
            ManagementObjectSearcher objOSDetails2 = new ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity WHERE Caption like '%(COM%'");
            ManagementObjectCollection osDetailsCollection2 = objOSDetails2.Get();
            foreach (ManagementObject usblist in osDetailsCollection2) {
                if (usblist["Description"].ToString() != "USB-SERIAL CH340" &&
                    usblist["Description"].ToString() != "USB Serial Port" &&
                    usblist["Description"].ToString() != "USB Serial Device" &&
                    usblist["Description"].ToString() != "Arduino Mega 2560") continue;
                arrport = usblist.GetPropertyValue("NAME").ToString().Split('(', ')');
                try { cbb_comport.Items.Add(arrport[1]); } catch { Log(LogMsgType.Error_Red, "\nname port not format " + usblist.GetPropertyValue("NAME").ToString()); return; }
            }

            cbb_set_led.SelectedIndex = 0;
        }

        #region====================================================== region Display_Message ======================================================
        private Color[] LogMsgTypeColor = { Color.Blue, Color.Green, Color.Black, Color.Orange, Color.Red };
        public enum LogMsgType { Incoming_Blue, Outgoing_Green, Normal_Black, Warning_Orange, Error_Red };
        public void Log(LogMsgType msgtype, string msg) {
            try {
                rtb_cmd.Invoke(new EventHandler(delegate {
                    rtb_cmd.SelectedText = string.Empty;
                    rtb_cmd.SelectionFont = new Font(rtb_cmd.SelectionFont, FontStyle.Bold);
                    rtb_cmd.SelectionColor = LogMsgTypeColor[(int)msgtype];
                    rtb_cmd.AppendText(msg);
                    rtb_cmd.ScrollToCaret();
                }));
            } catch (Exception) { }
        }

        #endregion

        private void bt_start_Click(object sender, EventArgs e) {
            byte[] data = { };
            send_cmd(cmd.Start, data);
            if (rx_hex.Count != 1) return;
            if (rx_hex[0] == cmd.Ack) cbb_comport.BackColor = Color.Lime;
        }
        private void send_cmd(byte cmds, byte[] data_send) {
            List<byte> cmdData = new List<byte>();
            cmdData.Add(cmd.Head);
            cmdData.Add(cmds);
            byte[] intBytes = BitConverter.GetBytes(data_send.Length);
            intBytes[0] += 1;
            cmdData.Add(intBytes[0]);
            foreach (byte xx in data_send) cmdData.Add(xx);
            byte checkSum = 0;
            foreach (byte xx in cmdData) checkSum += xx;
            cmdData.Add(checkSum);
            byte[] sends = cmdData.ToArray();
            rx_hex.Clear();
            mySerialPort.DiscardInBuffer();
            mySerialPort.DiscardOutBuffer();
            flag_rx_evet = false;
            try { mySerialPort.Write(sends, 0, sends.Length); } catch {
                Log(LogMsgType.Error_Red, "\n<< err");
                return;
            }
            Log(LogMsgType.Normal_Black, "\n>> " + byte2string(sends));
            Stopwatch time_rx = new Stopwatch();
            time_rx.Restart();
            while (time_rx.ElapsedMilliseconds < 750000) {
                if (!flag_rx_evet) { DelaymS(50); continue; }
                time_rx.Stop();
                break;
            }
            while (time_rx.ElapsedMilliseconds < 750000) {
                flag_rx_evet = false;
                DelaymS(100);
                if (flag_rx_evet) { continue; }
                break;
            }
            cbb_comport.BackColor = Color.Red;
        }
        private string byte2string(byte[] data) {
            string ss = "";
            foreach (byte x in data) ss += x.ToString("X2") + " ";
            return ss;
        }
        private byte check_sum(List<int> dd) {
            byte ss = 0;
            for (int i = 0; i < dd.Count - 1; i++) ss += Convert.ToByte(dd[i]);
            return ss;
        }
        private byte[] StringToByteArray(string hex) {
            if (hex.Length == 1) hex = "0" + hex;
            return Enumerable.Range(0, hex.Length)
                             .Where(x => x % 2 == 0)
                             .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                             .ToArray();
        }
        private string ToHexString(float f) {
            var bytes = BitConverter.GetBytes(f);
            var i = BitConverter.ToInt32(bytes, 0);
            return i.ToString("X8");
        }
        private float FromHexString(string s) {
            var i = Convert.ToInt32(s, 16);
            var bytes = BitConverter.GetBytes(i);
            return BitConverter.ToSingle(bytes, 0);
        }

        private void cbb_comport_SelectedValueChanged(object sender, EventArgs e) {
            mySerialPort.PortName = cbb_comport.Text;
            Stopwatch t = new Stopwatch();
            t.Restart();
            while (t.ElapsedMilliseconds < 5000) {
                try {
                    mySerialPort.Open();
                    t.Stop();
                    break;
                } catch { Thread.Sleep(250); }
                try { mySerialPort.Close(); } catch { }
            }
            if (t.IsRunning) {
                Log(LogMsgType.Error_Red, "\nOpen port err");
                return;
            }
            Log(LogMsgType.Incoming_Blue, "\nOpen port " + mySerialPort.PortName);
        }

        private List<int> rx_hex = new List<int>();
        private bool flag_rx_evet = false;
        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e) {
            Thread.Sleep(50);
            int length = 0;
            while (true) {
                mySerialPort = (SerialPort)sender;
                try { length = mySerialPort.BytesToRead; } catch { return; }
                if (length == 0) return;
                int buf = 0;
                for (int i = 0; i < length; i++) {
                    buf = mySerialPort.ReadByte();
                    rx_hex.Add(buf);
                }
                if(current_vdd2) Thread.Sleep(3500);
                else Thread.Sleep(50);
                if (mySerialPort.BytesToRead != 0) continue;
                break;
            }
            mySerialPort.DiscardInBuffer();
            mySerialPort.DiscardOutBuffer();
            string zz = "";
            foreach (int xx in rx_hex) zz += xx.ToString("X2") + " ";
            Log(LogMsgType.Warning_Orange, "\n<< " + zz);
            flag_rx_evet = true;
        }
        public static void DelaymS(int mS) {
            Stopwatch stopwatchDelaymS = new Stopwatch();
            stopwatchDelaymS.Restart();
            while (mS > stopwatchDelaymS.ElapsedMilliseconds) {
                if (!stopwatchDelaymS.IsRunning) stopwatchDelaymS.Start();
                Application.DoEvents();
            }
            stopwatchDelaymS.Stop();
        }

        private void bt_clear_Click(object sender, EventArgs e) {
            rtb_cmd.Clear();
        }
        private void bt_stop_Click(object sender, EventArgs e) {
            byte[] data = { };
            send_cmd(cmd.Stop, data);
            if (rx_hex.Count != 1) return;
            if (rx_hex[0] == cmd.Ack) cbb_comport.BackColor = Color.Lime;
        }
        private void bt_tester_id_Click(object sender, EventArgs e) {
            byte[] data = { };
            send_cmd(cmd.TesterID, data);
            if (rx_hex.Count != 5) return;
            if (rx_hex[0] != cmd.Head) return;
            if (rx_hex[1] != cmd.TesterID) return;
            if (rx_hex[2] != (rx_hex.Count - 3)) return;
            if (rx_hex[3] < 1 || rx_hex[3] > 20) return;
            if (rx_hex[rx_hex.Count - 1] != check_sum(rx_hex)) return;
            cbb_comport.BackColor = Color.Lime;
        }
        private void bt_uid_Click(object sender, EventArgs e) {
            byte[] data = { };
            send_cmd(cmd.UID, data);
            if (rx_hex.Count != 12) return;
            if (rx_hex[0] != cmd.Head) return;
            if (rx_hex[1] != cmd.UID) return;
            if (rx_hex[2] != (rx_hex.Count - 3)) return;

            string sss = "";
            for (int i = 3; i < rx_hex.Count - 1; i++) {
                sss += rx_hex[i].ToString("X2");
            }
            Log(LogMsgType.Incoming_Blue, "\n " + sss);

            if (rx_hex[rx_hex.Count - 1] != check_sum(rx_hex)) return;
            cbb_comport.BackColor = Color.Lime;
        }
        private void bt_spec_version_Click(object sender, EventArgs e) {
            byte[] data = { };
            send_cmd(cmd.SpecVersion, data);
            if (rx_hex.Count != 8) return;
            if (rx_hex[0] != cmd.Head) return;
            if (rx_hex[1] != cmd.SpecVersion) return;
            if (rx_hex[2] != (rx_hex.Count - 3)) return;

            //string ghf = ToHexString(5);
            //byte[] jjj = StringToByteArray(ghf);
            string sss = "";
            for (int i = 6; i > 2; i--) sss += rx_hex[i].ToString("X2");
            float ccvb = FromHexString(sss);
            Log(LogMsgType.Incoming_Blue, "\n " + ccvb);

            if (rx_hex[rx_hex.Count - 1] != check_sum(rx_hex)) return;
            cbb_comport.BackColor = Color.Lime;
        }
        private void bt_result_Click(object sender, EventArgs e) {
            byte[] data = { };
            send_cmd(cmd.Result, data);
            if (rx_hex.Count == 0) return;
            if (rx_hex[0] != cmd.Head) return;
            if (rx_hex[1] != cmd.Result) return;
            if (rx_hex[2] != (rx_hex.Count - 3)) return;

            if (rx_hex[rx_hex.Count - 1] != check_sum(rx_hex)) return;
            cbb_comport.BackColor = Color.Lime;
        }
        private void bt_calibrate_Click(object sender, EventArgs e) {
            byte[] data = { 0x01 };
            send_cmd(cmd.Calibrate, data);
            if (rx_hex.Count != 20) return;
            if (rx_hex[0] != cmd.Head) return;
            if (rx_hex[1] != cmd.Calibrate) return;
            if (rx_hex[2] != (rx_hex.Count - 3)) return;
            if (rx_hex[3] != data[0]) return;

            string sss = "";
            for (int i = 4; i <= 10; i++) sss += rx_hex[i].ToString("X2");
            Log(LogMsgType.Incoming_Blue, "\n " + sss);
            sss = "";
            for (int i = 14; i >= 11; i--) sss += rx_hex[i].ToString("X2");
            float ccvb = FromHexString(sss);
            Log(LogMsgType.Incoming_Blue, "\nslop = " + ccvb);
            sss = "";
            for (int i = 18; i >= 15; i--) sss += rx_hex[i].ToString("X2");
            ccvb = FromHexString(sss);
            Log(LogMsgType.Incoming_Blue, "\noffset = " + ccvb);

            if (rx_hex[rx_hex.Count - 1] != check_sum(rx_hex)) return;
            cbb_comport.BackColor = Color.Lime;
        }
        private void bt_Calibrate_VLED_Click(object sender, EventArgs e) {
            byte[] data = { 0x02 };
            send_cmd(cmd.Calibrate, data);
            if (rx_hex.Count != 20) return;
            if (rx_hex[0] != cmd.Head) return;
            if (rx_hex[1] != cmd.Calibrate) return;
            if (rx_hex[2] != (rx_hex.Count - 3)) return;
            if (rx_hex[3] != data[0]) return;

            string sss = "";
            for (int i = 4; i <= 10; i++) sss += rx_hex[i].ToString("X2");
            Log(LogMsgType.Incoming_Blue, "\n " + sss);
            sss = "";
            for (int i = 14; i >= 11; i--) sss += rx_hex[i].ToString("X2");
            float ccvb = FromHexString(sss);
            Log(LogMsgType.Incoming_Blue, "\nslop = " + ccvb);
            sss = "";
            for (int i = 18; i >= 15; i--) sss += rx_hex[i].ToString("X2");
            ccvb = FromHexString(sss);
            Log(LogMsgType.Incoming_Blue, "\noffset = " + ccvb);

            if (rx_hex[rx_hex.Count - 1] != check_sum(rx_hex)) return;
            cbb_comport.BackColor = Color.Lime;
        }
        private bool current_vdd2 = false;
        private void bt_current_VDD2_Click(object sender, EventArgs e) {
            current_vdd2 = true;
            byte[] data = { 0x05 };
            send_cmd(cmd.Current, data);
            string sss = "";
            int jjj = 1;
            int loop = 0;
            bool gtyu = true;
            bool cxzx = true;
            foreach (int hghg in rx_hex) {
                if (gtyu) {
                    if (jjj < 4) {
                        sss += hghg.ToString("X2");
                        jjj++;
                        continue;
                    } else {
                        sss += hghg.ToString("X2");
                        string kkk = sss.Substring(6, 2);
                        kkk += sss.Substring(4, 2);
                        kkk += sss.Substring(2, 2);
                        kkk += sss.Substring(0, 2);
                        float ccvb = FromHexString(kkk);
                        sss = "";
                        Log(LogMsgType.Incoming_Blue, "\n" + ccvb);
                        jjj = 1;
                        loop++;
                    }
                }
                if(loop == 5) {
                    gtyu = false;
                    if (cxzx) { cxzx = false; continue; }
                    if (jjj < 4) {
                        sss += hghg.ToString("X2");
                        jjj++;
                        continue;
                    } else {
                        sss += hghg.ToString("X2");
                        string kkk = sss.Substring(6, 2);
                        kkk += sss.Substring(4, 2);
                        kkk += sss.Substring(2, 2);
                        kkk += sss.Substring(0, 2);
                        float ccvb = FromHexString(kkk);
                        sss = "";
                        Log(LogMsgType.Incoming_Blue, "\nSum = " + ccvb);
                        jjj = 1;
                        gtyu = true;
                        loop = 0;
                        cxzx = true;
                    }
                }
            }
            cbb_comport.BackColor = Color.Lime;
            current_vdd2 = false;
        }
        private void bt_current_VDD_Click(object sender, EventArgs e) {
            byte[] data = { 0x01 };
            send_cmd(cmd.Current, data);
            if (rx_hex.Count != 9) return;
            if (rx_hex[0] != cmd.Head) return;
            if (rx_hex[1] != cmd.Current) return;
            if (rx_hex[2] != (rx_hex.Count - 3)) return;

            string sss = "";
            for (int i = 7; i > 3; i--) sss += rx_hex[i].ToString("X2");
            float ccvb = FromHexString(sss);
            Log(LogMsgType.Incoming_Blue, "\n" + ccvb);

            if (rx_hex[rx_hex.Count - 1] != check_sum(rx_hex)) return;
            cbb_comport.BackColor = Color.Lime;
        }
        private void bt_Current_VLED_Click(object sender, EventArgs e) {
            byte[] data = { 0x02 };
            send_cmd(cmd.Current, data);
            if (rx_hex.Count != 9) return;
            if (rx_hex[0] != cmd.Head) return;
            if (rx_hex[1] != cmd.Current) return;
            if (rx_hex[2] != (rx_hex.Count - 3)) return;

            string sss = "";
            for (int i = 7; i > 3; i--) sss += rx_hex[i].ToString("X2");
            float ccvb = FromHexString(sss);
            Log(LogMsgType.Incoming_Blue, "\n" + ccvb);

            if (rx_hex[rx_hex.Count - 1] != check_sum(rx_hex)) return;
            cbb_comport.BackColor = Color.Lime;
        }
        private void bt_Curr_VDD_ORI_Click(object sender, EventArgs e) {
            byte[] data = { 0x03 };
            send_cmd(cmd.Current, data);
            if (rx_hex.Count != 9) return;
            if (rx_hex[0] != cmd.Head) return;
            if (rx_hex[1] != cmd.Current) return;
            if (rx_hex[2] != (rx_hex.Count - 3)) return;

            string sss = "";
            for (int i = 7; i > 3; i--) sss += rx_hex[i].ToString("X2");
            float ccvb = FromHexString(sss);
            Log(LogMsgType.Incoming_Blue, "\n" + ccvb);

            if (rx_hex[rx_hex.Count - 1] != check_sum(rx_hex)) return;
            cbb_comport.BackColor = Color.Lime;
        }
        private void bt_Curr_VLED_ORI_Click(object sender, EventArgs e) {
            byte[] data = { 0x04 };
            send_cmd(cmd.Current, data);
            if (rx_hex.Count != 9) return;
            if (rx_hex[0] != cmd.Head) return;
            if (rx_hex[1] != cmd.Current) return;
            if (rx_hex[2] != (rx_hex.Count - 3)) return;

            string sss = "";
            for (int i = 7; i > 3; i--) sss += rx_hex[i].ToString("X2");
            float ccvb = FromHexString(sss);
            Log(LogMsgType.Incoming_Blue, "\n" + ccvb);

            if (rx_hex[rx_hex.Count - 1] != check_sum(rx_hex)) return;
            cbb_comport.BackColor = Color.Lime;
        }
        private void bt_Load_OFF_Click(object sender, EventArgs e) {
            byte[] data = { 0x00 };
            send_cmd(cmd.Load, data);
            if (rx_hex.Count != 1) return;
            if (rx_hex[0] == cmd.Ack) cbb_comport.BackColor = Color.Lime;
        }
        private void bt_Load_MIN_Click(object sender, EventArgs e) {
            byte[] data = { 0x01 };
            send_cmd(cmd.Load, data);
            if (rx_hex.Count != 1) return;
            if (rx_hex[0] == cmd.Ack) cbb_comport.BackColor = Color.Lime;
        }
        private void bt_Load_MIDDLE_Click(object sender, EventArgs e) {
            byte[] data = { 0x02 };
            send_cmd(cmd.Load, data);
            if (rx_hex.Count != 1) return;
            if (rx_hex[0] == cmd.Ack) cbb_comport.BackColor = Color.Lime;
        }
        private void bt_Load_MAX_Click(object sender, EventArgs e) {
            byte[] data = { 0x03 };
            send_cmd(cmd.Load, data);
            if (rx_hex.Count != 1) return;
            if (rx_hex[0] == cmd.Ack) cbb_comport.BackColor = Color.Lime;
        }
        private void bt_Drive_OFF_Click(object sender, EventArgs e) {
            byte[] data = { 0x00 };
            send_cmd(cmd.Drive, data);
            if (rx_hex.Count != 1) return;
            if (rx_hex[0] == cmd.Ack) cbb_comport.BackColor = Color.Lime;
            bt_led1.BackColor = Color.White;
            bt_led2.BackColor = Color.White;
            bt_led3.BackColor = Color.White;
        }
        private void bt_Drive_MIN_Click(object sender, EventArgs e) {
            byte[] data = { 0x01 };
            send_cmd(cmd.Drive, data);
            if (rx_hex.Count != 1) return;
            if (rx_hex[0] == cmd.Ack) cbb_comport.BackColor = Color.Lime;
        }
        private void bt_Drive_MAX_Click(object sender, EventArgs e) {
            byte[] data = { 0x02 };
            send_cmd(cmd.Drive, data);
            if (rx_hex.Count != 1) return;
            if (rx_hex[0] == cmd.Ack) cbb_comport.BackColor = Color.Lime;
        }
        private void bt_Set_Factor_VDD_Click(object sender, EventArgs e) {
            List<byte> dataSup = new List<byte>();
            dataSup.Add(0x01);
            string dfg = DateTime.Now.ToString("yyyyMMddHHmmss", System.Globalization.CultureInfo.CreateSpecificCulture("en-US"));
            byte[] aase = StringToByteArray(dfg);
            foreach (byte gg in aase) dataSup.Add(gg);
            float slop = float.Parse(tb_set_factor.Text);
            float offset = float.Parse(tb_offset.Text);
            byte[] slop_b = StringToByteArray(ToHexString(slop));
            byte[] offset_b = StringToByteArray(ToHexString(offset));
            for (int i = 3; i >= 0; i--) dataSup.Add(slop_b[i]);
            for (int i = 3; i >= 0; i--) dataSup.Add(offset_b[i]);

            byte[] data = dataSup.ToArray();
            send_cmd(cmd.SetFactor, data);

            if (rx_hex.Count != 1) return;
            if (rx_hex[0] == cmd.Ack) cbb_comport.BackColor = Color.Lime;
        }
        private void bt_Set_Factor_VLED_Click(object sender, EventArgs e) {
            List<byte> dataSup = new List<byte>();
            dataSup.Add(0x02);
            string dfg = DateTime.Now.ToString("yyyyMMddHHmmss", System.Globalization.CultureInfo.CreateSpecificCulture("en-US"));
            byte[] aase = StringToByteArray(dfg);
            foreach (byte gg in aase) dataSup.Add(gg);
            float slop = float.Parse(tb_set_factor.Text);
            float offset = float.Parse(tb_offset.Text);
            byte[] slop_b = StringToByteArray(ToHexString(slop));
            byte[] offset_b = StringToByteArray(ToHexString(offset));
            for (int i = 3; i >= 0; i--) dataSup.Add(slop_b[i]);
            for (int i = 3; i >= 0; i--) dataSup.Add(offset_b[i]);

            byte[] data = dataSup.ToArray();
            send_cmd(cmd.SetFactor, data);

            if (rx_hex.Count != 1) return;
            if (rx_hex[0] == cmd.Ack) cbb_comport.BackColor = Color.Lime;
        }
        private void bt_update_Click(object sender, EventArgs e) {
            List<byte> dataSup = new List<byte>();
            float spec = float.Parse(tb_spec.Text);
            byte[] spec_b = StringToByteArray(ToHexString(spec));
            for (int i = 3; i >= 0; i--) dataSup.Add(spec_b[i]);
            string times = DateTime.Now.ToString("yyyyMMddHHmmss", System.Globalization.CultureInfo.CreateSpecificCulture("en-US"));
            byte[] times_b = StringToByteArray(times);
            foreach (byte t in times_b) dataSup.Add(t);
            string[] dataFile = File.ReadAllLines("data.csv");
            foreach(string vv in dataFile) {
                string[] mmz = vv.Split(',');
                foreach (string t in mmz) {
                    byte[] nnjh = StringToByteArray(t);
                    dataSup.Add(nnjh[0]);
                }
            }
                
            byte[] data = dataSup.ToArray();
            send_cmd(cmd.Update, data);

            if (rx_hex.Count != 1) return;
            if (rx_hex[0] == cmd.Ack) cbb_comport.BackColor = Color.Lime;
        }
        private void bt_close_port_Click(object sender, EventArgs e) {
            try { mySerialPort.Close(); } catch { }
            Log(LogMsgType.Incoming_Blue, "\nClose port " + mySerialPort.PortName);
        }
        private void bt_open_port_Click(object sender, EventArgs e) {
            mySerialPort.PortName = cbb_comport.Text;
            Stopwatch t = new Stopwatch();
            t.Restart();
            while (t.ElapsedMilliseconds < 5000) {
                try {
                    mySerialPort.Open();
                    t.Stop();
                    break;
                } catch { Thread.Sleep(250); }
                try { mySerialPort.Close(); } catch { }
            }
            if (t.IsRunning) {
                Log(LogMsgType.Error_Red, "\nOpen port err");
                return;
            }
            Log(LogMsgType.Incoming_Blue, "\nOpen port " + mySerialPort.PortName);
        }
        private void bt_Power_ON_Click(object sender, EventArgs e) {
            byte[] data = { 0x01 };
            send_cmd(cmd.Power, data);
            if (rx_hex.Count != 1) return;
            if (rx_hex[0] == cmd.Ack) cbb_comport.BackColor = Color.Lime;
        }
        private void bt_Power_OFF_Click(object sender, EventArgs e) {
            byte[] data = { 0x00 };
            send_cmd(cmd.Power, data);
            if (rx_hex.Count != 1) return;
            if (rx_hex[0] == cmd.Ack) cbb_comport.BackColor = Color.Lime;
        }
        private void bt_set_led_Click(object sender, EventArgs e) {
            byte[] data = { 0x00 };
            switch (cbb_set_led.Text ) {
                case "LED 1": data[0] = 0x01; bt_led1.BackColor = Color.Lime; break;
                case "LED 2": data[0] = 0x02; bt_led2.BackColor = Color.Lime; break;
                case "LED 3": data[0] = 0x03; bt_led3.BackColor = Color.Lime; break;
                case "LED 1, LED 2":
                    data[0] = 0x04;
                    bt_led1.BackColor = Color.Lime;
                    bt_led2.BackColor = Color.Lime;
                    break;
            }
            if(data[0] == 0x00) {
                bt_led1.BackColor = Color.Lime;
                bt_led2.BackColor = Color.Lime;
                bt_led3.BackColor = Color.Lime;
            }
            send_cmd(cmd.Set_Led, data);
            if (rx_hex.Count != 1) return;
            if (rx_hex[0] == cmd.Ack) cbb_comport.BackColor = Color.Lime;
        }
        private void bt_get_led_Click(object sender, EventArgs e) {
            byte[] data = { 0x00 };
            switch (cbb_set_led.Text) {
                case "LED 1": data[0] = 0x01; break;
                case "LED 2": data[0] = 0x02; break;
                case "LED 3": data[0] = 0x03; break;
                case "LED 1, LED 2": return;
            }
            send_cmd(cmd.Get_Led, data);
            if (rx_hex.Count != 9) return;
            if (rx_hex[0] != cmd.Head) return;
            if (rx_hex[1] != cmd.Get_Led) return;
            if (rx_hex[2] != (rx_hex.Count - 3)) return;

            string sss = "";
            for (int i = 7; i > 3; i--) sss += rx_hex[i].ToString("X2");
            float ccvb = FromHexString(sss);
            Log(LogMsgType.Incoming_Blue, "\n" + ccvb);

            if (rx_hex[rx_hex.Count - 1] != check_sum(rx_hex)) return;
            cbb_comport.BackColor = Color.Lime;
        }

        private void bt_Reset_Unit_Click(object sender, EventArgs e) {
            byte[] data = { 0x00 };
            send_cmd(cmd.debug, data);
            if (rx_hex.Count != 1) return;
            if (rx_hex[0] == cmd.Ack) cbb_comport.BackColor = Color.Lime;
        }
        private void bt_vdd_low_Click(object sender, EventArgs e) {
            byte[] data = { 0x01 };
            send_cmd(cmd.debug, data);
            if (rx_hex.Count != 1) return;
            if (rx_hex[0] == cmd.Ack) cbb_comport.BackColor = Color.Lime;
        }
        private void bt_vdd_high_Click(object sender, EventArgs e) {
            byte[] data = { 0x02 };
            send_cmd(cmd.debug, data);
            if (rx_hex.Count != 1) return;
            if (rx_hex[0] == cmd.Ack) cbb_comport.BackColor = Color.Lime;
        }
        private void bt_get_uid_2_Click(object sender, EventArgs e) {
            byte[] data = { 0x03 };
            send_cmd(cmd.debug, data);
            if (rx_hex.Count != 13) return;
            if (rx_hex[0] != cmd.Head) return;
            if (rx_hex[1] != cmd.debug) return;
            if (rx_hex[2] != (rx_hex.Count - 3)) return;
            if (rx_hex[3] != data[0]) return;

            string sss = "";
            for (int i = 4; i < rx_hex.Count - 1; i++) {
                sss += rx_hex[i].ToString("X2");
            }
            Log(LogMsgType.Incoming_Blue, "\n " + sss);

            if (rx_hex[rx_hex.Count - 1] != check_sum(rx_hex)) return;
            cbb_comport.BackColor = Color.Lime;
        }
        private void bt_fw_2_Click(object sender, EventArgs e) {
            byte[] data = { 0x04 };
            send_cmd(cmd.debug, data);
            if (rx_hex.Count != 9) return;
            if (rx_hex[0] != cmd.Head) return;
            if (rx_hex[1] != cmd.debug) return;
            if (rx_hex[2] != (rx_hex.Count - 3)) return;
            if (rx_hex[3] != data[0]) return;

            string sss = "";
            for (int i = 4; i < rx_hex.Count - 1; i++) {
                sss += rx_hex[i].ToString("X2");
            }
            if (sss.Length != 4) { Log(LogMsgType.Incoming_Blue, "\n " + sss); return; } else {
                string gh = sss.Substring(0, 2) + "." + sss.Substring(2, 2);
                Log(LogMsgType.Incoming_Blue, "\n " + gh);
            }

            if (rx_hex[rx_hex.Count - 1] != check_sum(rx_hex)) return;
            cbb_comport.BackColor = Color.Lime;
        }
        private void bt_get_reg13_Click(object sender, EventArgs e) {
            byte[] data = { 0x05 };
            send_cmd(cmd.debug, data);
            if (rx_hex.Count != 7) return;
            if (rx_hex[0] != cmd.Head) return;
            if (rx_hex[1] != cmd.debug) return;
            if (rx_hex[2] != (rx_hex.Count - 3)) return;
            if (rx_hex[3] != data[0]) return;

            string sss = "";
            for (int i = 4; i < rx_hex.Count - 1; i++) {
                sss += rx_hex[i].ToString("X2");
            }
            Log(LogMsgType.Incoming_Blue, "\n " + sss);

            if (rx_hex[rx_hex.Count - 1] != check_sum(rx_hex)) return;
            cbb_comport.BackColor = Color.Lime;
        }
        private void bt_get_C_Click(object sender, EventArgs e) {
            byte[] data = { 0x06 };
            send_cmd(cmd.debug, data);
            if (rx_hex.Count != 15) return;
            if (rx_hex[0] != cmd.Head) return;
            if (rx_hex[1] != cmd.debug) return;
            if (rx_hex[2] != (rx_hex.Count - 3)) return;
            if (rx_hex[3] != data[0]) return;

            string sss = "";
            bool flag_C = false;
            for (int i = 4; i < rx_hex.Count - 1; i++) {
                sss += rx_hex[i].ToString("X2") + " ";
                if (rx_hex[i].ToString("X2") == "43") flag_C = true;
            }
            Log(LogMsgType.Incoming_Blue, "\n " + sss);
            if (!flag_C) return;

            if (rx_hex[rx_hex.Count - 1] != check_sum(rx_hex)) return;
            cbb_comport.BackColor = Color.Lime;
        }
        private void bt_get_reg0b_Click(object sender, EventArgs e) {
            byte[] data = { 0x08 };
            send_cmd(cmd.debug, data);
            if (rx_hex.Count != 7) return;
            if (rx_hex[0] != cmd.Head) return;
            if (rx_hex[1] != cmd.debug) return;
            if (rx_hex[2] != (rx_hex.Count - 3)) return;
            if (rx_hex[3] != data[0]) return;

            string sss = "";
            for (int i = 4; i < rx_hex.Count - 1; i++) {
                sss += rx_hex[i].ToString("X2") + " ";
            }
            Log(LogMsgType.Incoming_Blue, "\n " + sss);

            if (rx_hex[rx_hex.Count - 1] != check_sum(rx_hex)) return;
            cbb_comport.BackColor = Color.Lime;
        }
        private void bt_post_pin_Click(object sender, EventArgs e) {
            byte[] data = { 0x07 };
            send_cmd(cmd.debug, data);
            if (rx_hex.Count != 6) return;
            if (rx_hex[0] != cmd.Head) return;
            if (rx_hex[1] != cmd.debug) return;
            if (rx_hex[2] != (rx_hex.Count - 3)) return;
            if (rx_hex[3] != data[0]) return;

            string sss = "";
            for (int i = 4; i < rx_hex.Count - 1; i++) {
                sss += rx_hex[i].ToString("X2") + " ";
            }
            Log(LogMsgType.Incoming_Blue, "\n " + sss);

            if (rx_hex[rx_hex.Count - 1] != check_sum(rx_hex)) return;
            cbb_comport.BackColor = Color.Lime;
        }
        private void bt_a1_low_Click(object sender, EventArgs e) {
            byte[] data = { 0x09 };
            send_cmd(cmd.debug, data);
            if (rx_hex.Count != 1) return;
            if (rx_hex[0] == cmd.Ack) cbb_comport.BackColor = Color.Lime;
        }
        private void bt_a1_high_Click(object sender, EventArgs e) {
            byte[] data = { 0x0A };
            send_cmd(cmd.debug, data);
            if (rx_hex.Count != 1) return;
            if (rx_hex[0] == cmd.Ack) cbb_comport.BackColor = Color.Lime;
        }

        private void button3_Click(object sender, EventArgs e) {
            try { mySerialPort.Close(); } catch { }
            Log(LogMsgType.Incoming_Blue, "\nClose port " + mySerialPort.PortName);
        }
        private void button2_Click(object sender, EventArgs e) {
            rtb_cmd.Clear();
        }
        private void button1_Click(object sender, EventArgs e) {
            mySerialPort.PortName = cbb_comport.Text;
            Stopwatch t = new Stopwatch();
            t.Restart();
            while (t.ElapsedMilliseconds < 5000) {
                try {
                    mySerialPort.Open();
                    t.Stop();
                    break;
                } catch { Thread.Sleep(250); }
                try { mySerialPort.Close(); } catch { }
            }
            if (t.IsRunning) {
                Log(LogMsgType.Error_Red, "\nOpen port err");
                return;
            }
            Log(LogMsgType.Incoming_Blue, "\nOpen port " + mySerialPort.PortName);
        }
        private void button5_Click(object sender, EventArgs e) {
            byte[] data = { 0x01 };
            send_cmd(cmd.Power, data);
            if (rx_hex.Count != 1) return;
            if (rx_hex[0] == cmd.Ack) cbb_comport.BackColor = Color.Lime;
        }
        private void button4_Click(object sender, EventArgs e) {
            byte[] data = { 0x00 };
            send_cmd(cmd.Power, data);
            if (rx_hex.Count != 1) return;
            if (rx_hex[0] == cmd.Ack) cbb_comport.BackColor = Color.Lime;
        }

        private void button6_Click(object sender, EventArgs e) {
            byte[] data = { 0x0B };
            send_cmd(cmd.debug, data);
            if (rx_hex.Count != 1) return;
            if (rx_hex[0] == cmd.Ack) cbb_comport.BackColor = Color.Lime;
        }
        private void button7_Click(object sender, EventArgs e) {
            byte[] data = { 0x0C };
            send_cmd(cmd.debug, data);
            if (rx_hex.Count != 1) return;
            if (rx_hex[0] == cmd.Ack) cbb_comport.BackColor = Color.Lime;
        }
        private void bt_d10_low_Click(object sender, EventArgs e) {
            byte[] data = { 0x0D };
            send_cmd(cmd.debug, data);
            if (rx_hex.Count != 1) return;
            if (rx_hex[0] == cmd.Ack) cbb_comport.BackColor = Color.Lime;
        }
        private void bt_d10_high_Click(object sender, EventArgs e) {
            byte[] data = { 0x0E };
            send_cmd(cmd.debug, data);
            if (rx_hex.Count != 1) return;
            if (rx_hex[0] == cmd.Ack) cbb_comport.BackColor = Color.Lime;
        }
    }

    public class cmdAr {
        public byte Start = 0x01;
        public byte Stop = 0x02;
        public byte TesterID = 0x03;
        public byte Result = 0x04;
        public byte UID = 0x05;
        public byte SpecVersion = 0x06;
        public byte Calibrate = 0x08;
        public byte Current = 0x09;
        public byte Load = 0x0A;
        public byte Drive = 0x0B;
        public byte SetFactor = 0x0C;
        public byte Update = 0x0D;
        public byte Power = 0x0F;
        public byte Head = 0x49;
        public byte Ack = 0x94;
        public byte Set_Led = 0x10;
        public byte Get_Led = 0x11;
        public byte debug = 0x12;
    }
}
