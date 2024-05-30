namespace vlc_cmd_arduino {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rtb_cmd = new System.Windows.Forms.RichTextBox();
            this.bt_start = new System.Windows.Forms.Button();
            this.cbb_comport = new System.Windows.Forms.ComboBox();
            this.bt_clear = new System.Windows.Forms.Button();
            this.bt_stop = new System.Windows.Forms.Button();
            this.bt_tester_id = new System.Windows.Forms.Button();
            this.bt_uid = new System.Windows.Forms.Button();
            this.bt_spec_version = new System.Windows.Forms.Button();
            this.bt_result = new System.Windows.Forms.Button();
            this.bt_calibrate = new System.Windows.Forms.Button();
            this.bt_Calibrate_VLED = new System.Windows.Forms.Button();
            this.bt_current_VDD = new System.Windows.Forms.Button();
            this.bt_Current_VLED = new System.Windows.Forms.Button();
            this.bt_Curr_VDD_ORI = new System.Windows.Forms.Button();
            this.bt_Curr_VLED_ORI = new System.Windows.Forms.Button();
            this.bt_Load_OFF = new System.Windows.Forms.Button();
            this.bt_Load_MIN = new System.Windows.Forms.Button();
            this.bt_Load_MIDDLE = new System.Windows.Forms.Button();
            this.bt_Load_MAX = new System.Windows.Forms.Button();
            this.bt_Drive_OFF = new System.Windows.Forms.Button();
            this.bt_Drive_MIN = new System.Windows.Forms.Button();
            this.bt_Drive_MAX = new System.Windows.Forms.Button();
            this.bt_Set_Factor_VDD = new System.Windows.Forms.Button();
            this.bt_Set_Factor_VLED = new System.Windows.Forms.Button();
            this.tb_set_factor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_offset = new System.Windows.Forms.TextBox();
            this.bt_update = new System.Windows.Forms.Button();
            this.tb_spec = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_close_port = new System.Windows.Forms.Button();
            this.bt_open_port = new System.Windows.Forms.Button();
            this.bt_Power_ON = new System.Windows.Forms.Button();
            this.bt_Power_OFF = new System.Windows.Forms.Button();
            this.bt_set_led = new System.Windows.Forms.Button();
            this.bt_get_led = new System.Windows.Forms.Button();
            this.cbb_set_led = new System.Windows.Forms.ComboBox();
            this.bt_led3 = new System.Windows.Forms.Button();
            this.bt_led2 = new System.Windows.Forms.Button();
            this.bt_led1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.bt_current_VDD2 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bt_d10_high = new System.Windows.Forms.Button();
            this.bt_d10_low = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.bt_a1_high = new System.Windows.Forms.Button();
            this.bt_a1_low = new System.Windows.Forms.Button();
            this.bt_get_reg0b = new System.Windows.Forms.Button();
            this.bt_post_pin = new System.Windows.Forms.Button();
            this.bt_get_C = new System.Windows.Forms.Button();
            this.bt_get_reg13 = new System.Windows.Forms.Button();
            this.bt_fw_2 = new System.Windows.Forms.Button();
            this.bt_get_uid_2 = new System.Windows.Forms.Button();
            this.bt_vdd_high = new System.Windows.Forms.Button();
            this.bt_vdd_low = new System.Windows.Forms.Button();
            this.bt_Reset_Unit = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtb_cmd
            // 
            this.rtb_cmd.Location = new System.Drawing.Point(12, 194);
            this.rtb_cmd.Name = "rtb_cmd";
            this.rtb_cmd.Size = new System.Drawing.Size(1049, 323);
            this.rtb_cmd.TabIndex = 0;
            this.rtb_cmd.Text = "";
            // 
            // bt_start
            // 
            this.bt_start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bt_start.Location = new System.Drawing.Point(131, 4);
            this.bt_start.Name = "bt_start";
            this.bt_start.Size = new System.Drawing.Size(95, 23);
            this.bt_start.TabIndex = 1;
            this.bt_start.Text = "Start";
            this.bt_start.UseVisualStyleBackColor = false;
            this.bt_start.Click += new System.EventHandler(this.bt_start_Click);
            // 
            // cbb_comport
            // 
            this.cbb_comport.FormattingEnabled = true;
            this.cbb_comport.Location = new System.Drawing.Point(12, 12);
            this.cbb_comport.Name = "cbb_comport";
            this.cbb_comport.Size = new System.Drawing.Size(119, 21);
            this.cbb_comport.TabIndex = 2;
            this.cbb_comport.SelectedValueChanged += new System.EventHandler(this.cbb_comport_SelectedValueChanged);
            // 
            // bt_clear
            // 
            this.bt_clear.BackColor = System.Drawing.Color.Red;
            this.bt_clear.Location = new System.Drawing.Point(941, 4);
            this.bt_clear.Name = "bt_clear";
            this.bt_clear.Size = new System.Drawing.Size(95, 23);
            this.bt_clear.TabIndex = 3;
            this.bt_clear.Text = "Clear";
            this.bt_clear.UseVisualStyleBackColor = false;
            this.bt_clear.Click += new System.EventHandler(this.bt_clear_Click);
            // 
            // bt_stop
            // 
            this.bt_stop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bt_stop.Location = new System.Drawing.Point(232, 4);
            this.bt_stop.Name = "bt_stop";
            this.bt_stop.Size = new System.Drawing.Size(95, 23);
            this.bt_stop.TabIndex = 4;
            this.bt_stop.Text = "Stop";
            this.bt_stop.UseVisualStyleBackColor = false;
            this.bt_stop.Click += new System.EventHandler(this.bt_stop_Click);
            // 
            // bt_tester_id
            // 
            this.bt_tester_id.BackColor = System.Drawing.Color.White;
            this.bt_tester_id.Location = new System.Drawing.Point(333, 4);
            this.bt_tester_id.Name = "bt_tester_id";
            this.bt_tester_id.Size = new System.Drawing.Size(95, 23);
            this.bt_tester_id.TabIndex = 5;
            this.bt_tester_id.Text = "Tester ID";
            this.bt_tester_id.UseVisualStyleBackColor = false;
            this.bt_tester_id.Click += new System.EventHandler(this.bt_tester_id_Click);
            // 
            // bt_uid
            // 
            this.bt_uid.BackColor = System.Drawing.Color.White;
            this.bt_uid.Location = new System.Drawing.Point(434, 4);
            this.bt_uid.Name = "bt_uid";
            this.bt_uid.Size = new System.Drawing.Size(95, 23);
            this.bt_uid.TabIndex = 6;
            this.bt_uid.Text = "UID";
            this.bt_uid.UseVisualStyleBackColor = false;
            this.bt_uid.Click += new System.EventHandler(this.bt_uid_Click);
            // 
            // bt_spec_version
            // 
            this.bt_spec_version.BackColor = System.Drawing.Color.White;
            this.bt_spec_version.Location = new System.Drawing.Point(535, 4);
            this.bt_spec_version.Name = "bt_spec_version";
            this.bt_spec_version.Size = new System.Drawing.Size(95, 23);
            this.bt_spec_version.TabIndex = 7;
            this.bt_spec_version.Text = "Spec Version";
            this.bt_spec_version.UseVisualStyleBackColor = false;
            this.bt_spec_version.Click += new System.EventHandler(this.bt_spec_version_Click);
            // 
            // bt_result
            // 
            this.bt_result.BackColor = System.Drawing.Color.White;
            this.bt_result.Location = new System.Drawing.Point(636, 4);
            this.bt_result.Name = "bt_result";
            this.bt_result.Size = new System.Drawing.Size(95, 23);
            this.bt_result.TabIndex = 8;
            this.bt_result.Text = "Result";
            this.bt_result.UseVisualStyleBackColor = false;
            this.bt_result.Click += new System.EventHandler(this.bt_result_Click);
            // 
            // bt_calibrate
            // 
            this.bt_calibrate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bt_calibrate.Location = new System.Drawing.Point(737, 4);
            this.bt_calibrate.Name = "bt_calibrate";
            this.bt_calibrate.Size = new System.Drawing.Size(95, 23);
            this.bt_calibrate.TabIndex = 9;
            this.bt_calibrate.Text = "Calibrate VDD";
            this.bt_calibrate.UseVisualStyleBackColor = false;
            this.bt_calibrate.Click += new System.EventHandler(this.bt_calibrate_Click);
            // 
            // bt_Calibrate_VLED
            // 
            this.bt_Calibrate_VLED.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bt_Calibrate_VLED.Location = new System.Drawing.Point(838, 4);
            this.bt_Calibrate_VLED.Name = "bt_Calibrate_VLED";
            this.bt_Calibrate_VLED.Size = new System.Drawing.Size(95, 23);
            this.bt_Calibrate_VLED.TabIndex = 10;
            this.bt_Calibrate_VLED.Text = "Calibrate VLED";
            this.bt_Calibrate_VLED.UseVisualStyleBackColor = false;
            this.bt_Calibrate_VLED.Click += new System.EventHandler(this.bt_Calibrate_VLED_Click);
            // 
            // bt_current_VDD
            // 
            this.bt_current_VDD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bt_current_VDD.Location = new System.Drawing.Point(131, 33);
            this.bt_current_VDD.Name = "bt_current_VDD";
            this.bt_current_VDD.Size = new System.Drawing.Size(95, 23);
            this.bt_current_VDD.TabIndex = 11;
            this.bt_current_VDD.Text = "Current VDD";
            this.bt_current_VDD.UseVisualStyleBackColor = false;
            this.bt_current_VDD.Click += new System.EventHandler(this.bt_current_VDD_Click);
            // 
            // bt_Current_VLED
            // 
            this.bt_Current_VLED.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bt_Current_VLED.Location = new System.Drawing.Point(232, 33);
            this.bt_Current_VLED.Name = "bt_Current_VLED";
            this.bt_Current_VLED.Size = new System.Drawing.Size(95, 23);
            this.bt_Current_VLED.TabIndex = 12;
            this.bt_Current_VLED.Text = "Current VLED";
            this.bt_Current_VLED.UseVisualStyleBackColor = false;
            this.bt_Current_VLED.Click += new System.EventHandler(this.bt_Current_VLED_Click);
            // 
            // bt_Curr_VDD_ORI
            // 
            this.bt_Curr_VDD_ORI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bt_Curr_VDD_ORI.Location = new System.Drawing.Point(333, 33);
            this.bt_Curr_VDD_ORI.Name = "bt_Curr_VDD_ORI";
            this.bt_Curr_VDD_ORI.Size = new System.Drawing.Size(95, 23);
            this.bt_Curr_VDD_ORI.TabIndex = 13;
            this.bt_Curr_VDD_ORI.Text = "Curr VDD ORI";
            this.bt_Curr_VDD_ORI.UseVisualStyleBackColor = false;
            this.bt_Curr_VDD_ORI.Click += new System.EventHandler(this.bt_Curr_VDD_ORI_Click);
            // 
            // bt_Curr_VLED_ORI
            // 
            this.bt_Curr_VLED_ORI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bt_Curr_VLED_ORI.Location = new System.Drawing.Point(434, 33);
            this.bt_Curr_VLED_ORI.Name = "bt_Curr_VLED_ORI";
            this.bt_Curr_VLED_ORI.Size = new System.Drawing.Size(95, 23);
            this.bt_Curr_VLED_ORI.TabIndex = 14;
            this.bt_Curr_VLED_ORI.Text = "Curr VLED ORI";
            this.bt_Curr_VLED_ORI.UseVisualStyleBackColor = false;
            this.bt_Curr_VLED_ORI.Click += new System.EventHandler(this.bt_Curr_VLED_ORI_Click);
            // 
            // bt_Load_OFF
            // 
            this.bt_Load_OFF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bt_Load_OFF.Location = new System.Drawing.Point(535, 33);
            this.bt_Load_OFF.Name = "bt_Load_OFF";
            this.bt_Load_OFF.Size = new System.Drawing.Size(95, 23);
            this.bt_Load_OFF.TabIndex = 15;
            this.bt_Load_OFF.Text = "Load OFF";
            this.bt_Load_OFF.UseVisualStyleBackColor = false;
            this.bt_Load_OFF.Click += new System.EventHandler(this.bt_Load_OFF_Click);
            // 
            // bt_Load_MIN
            // 
            this.bt_Load_MIN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bt_Load_MIN.Location = new System.Drawing.Point(636, 33);
            this.bt_Load_MIN.Name = "bt_Load_MIN";
            this.bt_Load_MIN.Size = new System.Drawing.Size(95, 23);
            this.bt_Load_MIN.TabIndex = 16;
            this.bt_Load_MIN.Text = "Load MIN";
            this.bt_Load_MIN.UseVisualStyleBackColor = false;
            this.bt_Load_MIN.Click += new System.EventHandler(this.bt_Load_MIN_Click);
            // 
            // bt_Load_MIDDLE
            // 
            this.bt_Load_MIDDLE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bt_Load_MIDDLE.Location = new System.Drawing.Point(737, 33);
            this.bt_Load_MIDDLE.Name = "bt_Load_MIDDLE";
            this.bt_Load_MIDDLE.Size = new System.Drawing.Size(95, 23);
            this.bt_Load_MIDDLE.TabIndex = 17;
            this.bt_Load_MIDDLE.Text = "Load MIDDLE";
            this.bt_Load_MIDDLE.UseVisualStyleBackColor = false;
            this.bt_Load_MIDDLE.Click += new System.EventHandler(this.bt_Load_MIDDLE_Click);
            // 
            // bt_Load_MAX
            // 
            this.bt_Load_MAX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bt_Load_MAX.Location = new System.Drawing.Point(838, 33);
            this.bt_Load_MAX.Name = "bt_Load_MAX";
            this.bt_Load_MAX.Size = new System.Drawing.Size(95, 23);
            this.bt_Load_MAX.TabIndex = 18;
            this.bt_Load_MAX.Text = "Load MAX";
            this.bt_Load_MAX.UseVisualStyleBackColor = false;
            this.bt_Load_MAX.Click += new System.EventHandler(this.bt_Load_MAX_Click);
            // 
            // bt_Drive_OFF
            // 
            this.bt_Drive_OFF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bt_Drive_OFF.Location = new System.Drawing.Point(131, 62);
            this.bt_Drive_OFF.Name = "bt_Drive_OFF";
            this.bt_Drive_OFF.Size = new System.Drawing.Size(95, 23);
            this.bt_Drive_OFF.TabIndex = 19;
            this.bt_Drive_OFF.Text = "Drive OFF";
            this.bt_Drive_OFF.UseVisualStyleBackColor = false;
            this.bt_Drive_OFF.Click += new System.EventHandler(this.bt_Drive_OFF_Click);
            // 
            // bt_Drive_MIN
            // 
            this.bt_Drive_MIN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bt_Drive_MIN.Location = new System.Drawing.Point(232, 62);
            this.bt_Drive_MIN.Name = "bt_Drive_MIN";
            this.bt_Drive_MIN.Size = new System.Drawing.Size(95, 23);
            this.bt_Drive_MIN.TabIndex = 20;
            this.bt_Drive_MIN.Text = "Drive MIN";
            this.bt_Drive_MIN.UseVisualStyleBackColor = false;
            this.bt_Drive_MIN.Click += new System.EventHandler(this.bt_Drive_MIN_Click);
            // 
            // bt_Drive_MAX
            // 
            this.bt_Drive_MAX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bt_Drive_MAX.Location = new System.Drawing.Point(333, 62);
            this.bt_Drive_MAX.Name = "bt_Drive_MAX";
            this.bt_Drive_MAX.Size = new System.Drawing.Size(95, 23);
            this.bt_Drive_MAX.TabIndex = 21;
            this.bt_Drive_MAX.Text = "Drive MAX";
            this.bt_Drive_MAX.UseVisualStyleBackColor = false;
            this.bt_Drive_MAX.Click += new System.EventHandler(this.bt_Drive_MAX_Click);
            // 
            // bt_Set_Factor_VDD
            // 
            this.bt_Set_Factor_VDD.BackColor = System.Drawing.Color.Silver;
            this.bt_Set_Factor_VDD.Enabled = false;
            this.bt_Set_Factor_VDD.Location = new System.Drawing.Point(737, 62);
            this.bt_Set_Factor_VDD.Name = "bt_Set_Factor_VDD";
            this.bt_Set_Factor_VDD.Size = new System.Drawing.Size(95, 23);
            this.bt_Set_Factor_VDD.TabIndex = 22;
            this.bt_Set_Factor_VDD.Text = "Set Factor VDD";
            this.bt_Set_Factor_VDD.UseVisualStyleBackColor = false;
            this.bt_Set_Factor_VDD.Click += new System.EventHandler(this.bt_Set_Factor_VDD_Click);
            // 
            // bt_Set_Factor_VLED
            // 
            this.bt_Set_Factor_VLED.BackColor = System.Drawing.Color.Silver;
            this.bt_Set_Factor_VLED.Enabled = false;
            this.bt_Set_Factor_VLED.Location = new System.Drawing.Point(838, 62);
            this.bt_Set_Factor_VLED.Name = "bt_Set_Factor_VLED";
            this.bt_Set_Factor_VLED.Size = new System.Drawing.Size(95, 23);
            this.bt_Set_Factor_VLED.TabIndex = 23;
            this.bt_Set_Factor_VLED.Text = "Set Factor VLED";
            this.bt_Set_Factor_VLED.UseVisualStyleBackColor = false;
            this.bt_Set_Factor_VLED.Click += new System.EventHandler(this.bt_Set_Factor_VLED_Click);
            // 
            // tb_set_factor
            // 
            this.tb_set_factor.BackColor = System.Drawing.Color.Silver;
            this.tb_set_factor.Location = new System.Drawing.Point(45, 35);
            this.tb_set_factor.Name = "tb_set_factor";
            this.tb_set_factor.Size = new System.Drawing.Size(80, 20);
            this.tb_set_factor.TabIndex = 24;
            this.tb_set_factor.Text = "2.45";
            this.tb_set_factor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Slop";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Offset";
            // 
            // tb_offset
            // 
            this.tb_offset.BackColor = System.Drawing.Color.Silver;
            this.tb_offset.Location = new System.Drawing.Point(45, 64);
            this.tb_offset.Name = "tb_offset";
            this.tb_offset.Size = new System.Drawing.Size(80, 20);
            this.tb_offset.TabIndex = 27;
            this.tb_offset.Text = "99";
            this.tb_offset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bt_update
            // 
            this.bt_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bt_update.Enabled = false;
            this.bt_update.Location = new System.Drawing.Point(636, 62);
            this.bt_update.Name = "bt_update";
            this.bt_update.Size = new System.Drawing.Size(95, 23);
            this.bt_update.TabIndex = 28;
            this.bt_update.Text = "Update";
            this.bt_update.UseVisualStyleBackColor = false;
            this.bt_update.Click += new System.EventHandler(this.bt_update_Click);
            // 
            // tb_spec
            // 
            this.tb_spec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.tb_spec.Location = new System.Drawing.Point(535, 64);
            this.tb_spec.Name = "tb_spec";
            this.tb_spec.Size = new System.Drawing.Size(95, 20);
            this.tb_spec.TabIndex = 30;
            this.tb_spec.Text = "5";
            this.tb_spec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(459, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Spec Version";
            // 
            // bt_close_port
            // 
            this.bt_close_port.BackColor = System.Drawing.Color.Black;
            this.bt_close_port.ForeColor = System.Drawing.Color.White;
            this.bt_close_port.Location = new System.Drawing.Point(941, 33);
            this.bt_close_port.Name = "bt_close_port";
            this.bt_close_port.Size = new System.Drawing.Size(95, 23);
            this.bt_close_port.TabIndex = 31;
            this.bt_close_port.Text = "Close Port";
            this.bt_close_port.UseVisualStyleBackColor = false;
            this.bt_close_port.Click += new System.EventHandler(this.bt_close_port_Click);
            // 
            // bt_open_port
            // 
            this.bt_open_port.BackColor = System.Drawing.Color.Lime;
            this.bt_open_port.Location = new System.Drawing.Point(941, 62);
            this.bt_open_port.Name = "bt_open_port";
            this.bt_open_port.Size = new System.Drawing.Size(95, 23);
            this.bt_open_port.TabIndex = 32;
            this.bt_open_port.Text = "Open Port";
            this.bt_open_port.UseVisualStyleBackColor = false;
            this.bt_open_port.Click += new System.EventHandler(this.bt_open_port_Click);
            // 
            // bt_Power_ON
            // 
            this.bt_Power_ON.BackColor = System.Drawing.Color.Maroon;
            this.bt_Power_ON.ForeColor = System.Drawing.Color.White;
            this.bt_Power_ON.Location = new System.Drawing.Point(131, 90);
            this.bt_Power_ON.Name = "bt_Power_ON";
            this.bt_Power_ON.Size = new System.Drawing.Size(95, 23);
            this.bt_Power_ON.TabIndex = 33;
            this.bt_Power_ON.Text = "Power ON";
            this.bt_Power_ON.UseVisualStyleBackColor = false;
            this.bt_Power_ON.Click += new System.EventHandler(this.bt_Power_ON_Click);
            // 
            // bt_Power_OFF
            // 
            this.bt_Power_OFF.BackColor = System.Drawing.Color.Maroon;
            this.bt_Power_OFF.ForeColor = System.Drawing.Color.White;
            this.bt_Power_OFF.Location = new System.Drawing.Point(232, 90);
            this.bt_Power_OFF.Name = "bt_Power_OFF";
            this.bt_Power_OFF.Size = new System.Drawing.Size(95, 23);
            this.bt_Power_OFF.TabIndex = 34;
            this.bt_Power_OFF.Text = "Power OFF";
            this.bt_Power_OFF.UseVisualStyleBackColor = false;
            this.bt_Power_OFF.Click += new System.EventHandler(this.bt_Power_OFF_Click);
            // 
            // bt_set_led
            // 
            this.bt_set_led.BackColor = System.Drawing.Color.Purple;
            this.bt_set_led.ForeColor = System.Drawing.Color.White;
            this.bt_set_led.Location = new System.Drawing.Point(434, 90);
            this.bt_set_led.Name = "bt_set_led";
            this.bt_set_led.Size = new System.Drawing.Size(95, 23);
            this.bt_set_led.TabIndex = 35;
            this.bt_set_led.Text = "Set LED";
            this.bt_set_led.UseVisualStyleBackColor = false;
            this.bt_set_led.Click += new System.EventHandler(this.bt_set_led_Click);
            // 
            // bt_get_led
            // 
            this.bt_get_led.BackColor = System.Drawing.Color.Purple;
            this.bt_get_led.ForeColor = System.Drawing.Color.White;
            this.bt_get_led.Location = new System.Drawing.Point(535, 90);
            this.bt_get_led.Name = "bt_get_led";
            this.bt_get_led.Size = new System.Drawing.Size(95, 23);
            this.bt_get_led.TabIndex = 36;
            this.bt_get_led.Text = "Get LED";
            this.bt_get_led.UseVisualStyleBackColor = false;
            this.bt_get_led.Click += new System.EventHandler(this.bt_get_led_Click);
            // 
            // cbb_set_led
            // 
            this.cbb_set_led.BackColor = System.Drawing.Color.Purple;
            this.cbb_set_led.ForeColor = System.Drawing.Color.White;
            this.cbb_set_led.FormattingEnabled = true;
            this.cbb_set_led.Items.AddRange(new object[] {
            "ALL",
            "LED 1",
            "LED 2",
            "LED 3",
            "LED 1, LED 2"});
            this.cbb_set_led.Location = new System.Drawing.Point(333, 92);
            this.cbb_set_led.Name = "cbb_set_led";
            this.cbb_set_led.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbb_set_led.Size = new System.Drawing.Size(95, 21);
            this.cbb_set_led.TabIndex = 37;
            // 
            // bt_led3
            // 
            this.bt_led3.BackColor = System.Drawing.Color.White;
            this.bt_led3.ForeColor = System.Drawing.Color.Black;
            this.bt_led3.Location = new System.Drawing.Point(68, 90);
            this.bt_led3.Name = "bt_led3";
            this.bt_led3.Size = new System.Drawing.Size(26, 23);
            this.bt_led3.TabIndex = 38;
            this.bt_led3.Text = "3";
            this.bt_led3.UseVisualStyleBackColor = false;
            // 
            // bt_led2
            // 
            this.bt_led2.BackColor = System.Drawing.Color.White;
            this.bt_led2.ForeColor = System.Drawing.Color.Black;
            this.bt_led2.Location = new System.Drawing.Point(36, 90);
            this.bt_led2.Name = "bt_led2";
            this.bt_led2.Size = new System.Drawing.Size(26, 23);
            this.bt_led2.TabIndex = 39;
            this.bt_led2.Text = "2";
            this.bt_led2.UseVisualStyleBackColor = false;
            // 
            // bt_led1
            // 
            this.bt_led1.BackColor = System.Drawing.Color.White;
            this.bt_led1.ForeColor = System.Drawing.Color.Black;
            this.bt_led1.Location = new System.Drawing.Point(4, 90);
            this.bt_led1.Name = "bt_led1";
            this.bt_led1.Size = new System.Drawing.Size(26, 23);
            this.bt_led1.TabIndex = 40;
            this.bt_led1.Text = "1";
            this.bt_led1.UseVisualStyleBackColor = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 41);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1049, 147);
            this.tabControl1.TabIndex = 41;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.bt_current_VDD2);
            this.tabPage1.Controls.Add(this.bt_led1);
            this.tabPage1.Controls.Add(this.bt_start);
            this.tabPage1.Controls.Add(this.bt_led2);
            this.tabPage1.Controls.Add(this.bt_stop);
            this.tabPage1.Controls.Add(this.bt_led3);
            this.tabPage1.Controls.Add(this.bt_tester_id);
            this.tabPage1.Controls.Add(this.cbb_set_led);
            this.tabPage1.Controls.Add(this.bt_uid);
            this.tabPage1.Controls.Add(this.bt_get_led);
            this.tabPage1.Controls.Add(this.bt_set_led);
            this.tabPage1.Controls.Add(this.bt_spec_version);
            this.tabPage1.Controls.Add(this.bt_Power_OFF);
            this.tabPage1.Controls.Add(this.bt_result);
            this.tabPage1.Controls.Add(this.bt_Power_ON);
            this.tabPage1.Controls.Add(this.bt_calibrate);
            this.tabPage1.Controls.Add(this.bt_Calibrate_VLED);
            this.tabPage1.Controls.Add(this.bt_open_port);
            this.tabPage1.Controls.Add(this.tb_spec);
            this.tabPage1.Controls.Add(this.bt_clear);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.bt_close_port);
            this.tabPage1.Controls.Add(this.bt_update);
            this.tabPage1.Controls.Add(this.bt_current_VDD);
            this.tabPage1.Controls.Add(this.tb_offset);
            this.tabPage1.Controls.Add(this.bt_Current_VLED);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.bt_Curr_VDD_ORI);
            this.tabPage1.Controls.Add(this.bt_Set_Factor_VLED);
            this.tabPage1.Controls.Add(this.bt_Curr_VLED_ORI);
            this.tabPage1.Controls.Add(this.bt_Set_Factor_VDD);
            this.tabPage1.Controls.Add(this.bt_Load_OFF);
            this.tabPage1.Controls.Add(this.bt_Drive_MAX);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.bt_Drive_MIN);
            this.tabPage1.Controls.Add(this.bt_Load_MIN);
            this.tabPage1.Controls.Add(this.bt_Drive_OFF);
            this.tabPage1.Controls.Add(this.tb_set_factor);
            this.tabPage1.Controls.Add(this.bt_Load_MIDDLE);
            this.tabPage1.Controls.Add(this.bt_Load_MAX);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1041, 121);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Debug 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // bt_current_VDD2
            // 
            this.bt_current_VDD2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bt_current_VDD2.Location = new System.Drawing.Point(636, 90);
            this.bt_current_VDD2.Name = "bt_current_VDD2";
            this.bt_current_VDD2.Size = new System.Drawing.Size(95, 23);
            this.bt_current_VDD2.TabIndex = 41;
            this.bt_current_VDD2.Text = "Current VDD 2";
            this.bt_current_VDD2.UseVisualStyleBackColor = false;
            this.bt_current_VDD2.Click += new System.EventHandler(this.bt_current_VDD2_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.bt_d10_high);
            this.tabPage2.Controls.Add(this.bt_d10_low);
            this.tabPage2.Controls.Add(this.button7);
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.bt_a1_high);
            this.tabPage2.Controls.Add(this.bt_a1_low);
            this.tabPage2.Controls.Add(this.bt_get_reg0b);
            this.tabPage2.Controls.Add(this.bt_post_pin);
            this.tabPage2.Controls.Add(this.bt_get_C);
            this.tabPage2.Controls.Add(this.bt_get_reg13);
            this.tabPage2.Controls.Add(this.bt_fw_2);
            this.tabPage2.Controls.Add(this.bt_get_uid_2);
            this.tabPage2.Controls.Add(this.bt_vdd_high);
            this.tabPage2.Controls.Add(this.bt_vdd_low);
            this.tabPage2.Controls.Add(this.bt_Reset_Unit);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1041, 121);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Debug 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // bt_d10_high
            // 
            this.bt_d10_high.BackColor = System.Drawing.Color.Aqua;
            this.bt_d10_high.Location = new System.Drawing.Point(737, 35);
            this.bt_d10_high.Name = "bt_d10_high";
            this.bt_d10_high.Size = new System.Drawing.Size(95, 23);
            this.bt_d10_high.TabIndex = 41;
            this.bt_d10_high.Text = "D10 HIGH";
            this.bt_d10_high.UseVisualStyleBackColor = false;
            this.bt_d10_high.Click += new System.EventHandler(this.bt_d10_high_Click);
            // 
            // bt_d10_low
            // 
            this.bt_d10_low.BackColor = System.Drawing.Color.Aqua;
            this.bt_d10_low.Location = new System.Drawing.Point(636, 35);
            this.bt_d10_low.Name = "bt_d10_low";
            this.bt_d10_low.Size = new System.Drawing.Size(95, 23);
            this.bt_d10_low.TabIndex = 40;
            this.bt_d10_low.Text = "D10 LOW";
            this.bt_d10_low.UseVisualStyleBackColor = false;
            this.bt_d10_low.Click += new System.EventHandler(this.bt_d10_low_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(535, 35);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(95, 23);
            this.button7.TabIndex = 39;
            this.button7.Text = "Reset HIGH";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(434, 35);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(95, 23);
            this.button6.TabIndex = 38;
            this.button6.Text = "Reset LOW";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Maroon;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(232, 92);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(95, 23);
            this.button4.TabIndex = 37;
            this.button4.Text = "Power OFF";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Maroon;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(131, 92);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(95, 23);
            this.button5.TabIndex = 36;
            this.button5.Text = "Power ON";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(939, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 35;
            this.button1.Text = "Open Port";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(939, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 23);
            this.button2.TabIndex = 33;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(939, 35);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 23);
            this.button3.TabIndex = 34;
            this.button3.Text = "Close Port";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // bt_a1_high
            // 
            this.bt_a1_high.BackColor = System.Drawing.Color.Aqua;
            this.bt_a1_high.Location = new System.Drawing.Point(333, 35);
            this.bt_a1_high.Name = "bt_a1_high";
            this.bt_a1_high.Size = new System.Drawing.Size(95, 23);
            this.bt_a1_high.TabIndex = 12;
            this.bt_a1_high.Text = "A1 HIGH";
            this.bt_a1_high.UseVisualStyleBackColor = false;
            this.bt_a1_high.Click += new System.EventHandler(this.bt_a1_high_Click);
            // 
            // bt_a1_low
            // 
            this.bt_a1_low.BackColor = System.Drawing.Color.Aqua;
            this.bt_a1_low.Location = new System.Drawing.Point(232, 35);
            this.bt_a1_low.Name = "bt_a1_low";
            this.bt_a1_low.Size = new System.Drawing.Size(95, 23);
            this.bt_a1_low.TabIndex = 11;
            this.bt_a1_low.Text = "A1 LOW";
            this.bt_a1_low.UseVisualStyleBackColor = false;
            this.bt_a1_low.Click += new System.EventHandler(this.bt_a1_low_Click);
            // 
            // bt_get_reg0b
            // 
            this.bt_get_reg0b.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bt_get_reg0b.ForeColor = System.Drawing.Color.White;
            this.bt_get_reg0b.Location = new System.Drawing.Point(838, 6);
            this.bt_get_reg0b.Name = "bt_get_reg0b";
            this.bt_get_reg0b.Size = new System.Drawing.Size(95, 23);
            this.bt_get_reg0b.TabIndex = 10;
            this.bt_get_reg0b.Text = "Reg 0x0B";
            this.bt_get_reg0b.UseVisualStyleBackColor = false;
            this.bt_get_reg0b.Click += new System.EventHandler(this.bt_get_reg0b_Click);
            // 
            // bt_post_pin
            // 
            this.bt_post_pin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bt_post_pin.Location = new System.Drawing.Point(131, 35);
            this.bt_post_pin.Name = "bt_post_pin";
            this.bt_post_pin.Size = new System.Drawing.Size(95, 23);
            this.bt_post_pin.TabIndex = 9;
            this.bt_post_pin.Text = "Post Pin";
            this.bt_post_pin.UseVisualStyleBackColor = false;
            this.bt_post_pin.Click += new System.EventHandler(this.bt_post_pin_Click);
            // 
            // bt_get_C
            // 
            this.bt_get_C.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bt_get_C.ForeColor = System.Drawing.Color.White;
            this.bt_get_C.Location = new System.Drawing.Point(737, 6);
            this.bt_get_C.Name = "bt_get_C";
            this.bt_get_C.Size = new System.Drawing.Size(95, 23);
            this.bt_get_C.TabIndex = 8;
            this.bt_get_C.Text = "get C";
            this.bt_get_C.UseVisualStyleBackColor = false;
            this.bt_get_C.Click += new System.EventHandler(this.bt_get_C_Click);
            // 
            // bt_get_reg13
            // 
            this.bt_get_reg13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bt_get_reg13.ForeColor = System.Drawing.Color.White;
            this.bt_get_reg13.Location = new System.Drawing.Point(636, 6);
            this.bt_get_reg13.Name = "bt_get_reg13";
            this.bt_get_reg13.Size = new System.Drawing.Size(95, 23);
            this.bt_get_reg13.TabIndex = 7;
            this.bt_get_reg13.Text = "get reg13";
            this.bt_get_reg13.UseVisualStyleBackColor = false;
            this.bt_get_reg13.Click += new System.EventHandler(this.bt_get_reg13_Click);
            // 
            // bt_fw_2
            // 
            this.bt_fw_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bt_fw_2.Location = new System.Drawing.Point(535, 6);
            this.bt_fw_2.Name = "bt_fw_2";
            this.bt_fw_2.Size = new System.Drawing.Size(95, 23);
            this.bt_fw_2.TabIndex = 6;
            this.bt_fw_2.Text = "get FW 2";
            this.bt_fw_2.UseVisualStyleBackColor = false;
            this.bt_fw_2.Click += new System.EventHandler(this.bt_fw_2_Click);
            // 
            // bt_get_uid_2
            // 
            this.bt_get_uid_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bt_get_uid_2.Location = new System.Drawing.Point(434, 6);
            this.bt_get_uid_2.Name = "bt_get_uid_2";
            this.bt_get_uid_2.Size = new System.Drawing.Size(95, 23);
            this.bt_get_uid_2.TabIndex = 5;
            this.bt_get_uid_2.Text = "get UID 2";
            this.bt_get_uid_2.UseVisualStyleBackColor = false;
            this.bt_get_uid_2.Click += new System.EventHandler(this.bt_get_uid_2_Click);
            // 
            // bt_vdd_high
            // 
            this.bt_vdd_high.BackColor = System.Drawing.Color.Yellow;
            this.bt_vdd_high.Location = new System.Drawing.Point(333, 6);
            this.bt_vdd_high.Name = "bt_vdd_high";
            this.bt_vdd_high.Size = new System.Drawing.Size(95, 23);
            this.bt_vdd_high.TabIndex = 4;
            this.bt_vdd_high.Text = "VDD HIGH";
            this.bt_vdd_high.UseVisualStyleBackColor = false;
            this.bt_vdd_high.Click += new System.EventHandler(this.bt_vdd_high_Click);
            // 
            // bt_vdd_low
            // 
            this.bt_vdd_low.BackColor = System.Drawing.Color.Yellow;
            this.bt_vdd_low.Location = new System.Drawing.Point(232, 6);
            this.bt_vdd_low.Name = "bt_vdd_low";
            this.bt_vdd_low.Size = new System.Drawing.Size(95, 23);
            this.bt_vdd_low.TabIndex = 3;
            this.bt_vdd_low.Text = "VDD LOW";
            this.bt_vdd_low.UseVisualStyleBackColor = false;
            this.bt_vdd_low.Click += new System.EventHandler(this.bt_vdd_low_Click);
            // 
            // bt_Reset_Unit
            // 
            this.bt_Reset_Unit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bt_Reset_Unit.Location = new System.Drawing.Point(131, 6);
            this.bt_Reset_Unit.Name = "bt_Reset_Unit";
            this.bt_Reset_Unit.Size = new System.Drawing.Size(95, 23);
            this.bt_Reset_Unit.TabIndex = 2;
            this.bt_Reset_Unit.Text = "Reset Unit";
            this.bt_Reset_Unit.UseVisualStyleBackColor = false;
            this.bt_Reset_Unit.Click += new System.EventHandler(this.bt_Reset_Unit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 529);
            this.Controls.Add(this.cbb_comport);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.rtb_cmd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_cmd;
        private System.Windows.Forms.Button bt_start;
        private System.Windows.Forms.ComboBox cbb_comport;
        private System.Windows.Forms.Button bt_clear;
        private System.Windows.Forms.Button bt_stop;
        private System.Windows.Forms.Button bt_tester_id;
        private System.Windows.Forms.Button bt_uid;
        private System.Windows.Forms.Button bt_spec_version;
        private System.Windows.Forms.Button bt_result;
        private System.Windows.Forms.Button bt_calibrate;
        private System.Windows.Forms.Button bt_Calibrate_VLED;
        private System.Windows.Forms.Button bt_current_VDD;
        private System.Windows.Forms.Button bt_Current_VLED;
        private System.Windows.Forms.Button bt_Curr_VDD_ORI;
        private System.Windows.Forms.Button bt_Curr_VLED_ORI;
        private System.Windows.Forms.Button bt_Load_OFF;
        private System.Windows.Forms.Button bt_Load_MIN;
        private System.Windows.Forms.Button bt_Load_MIDDLE;
        private System.Windows.Forms.Button bt_Load_MAX;
        private System.Windows.Forms.Button bt_Drive_OFF;
        private System.Windows.Forms.Button bt_Drive_MIN;
        private System.Windows.Forms.Button bt_Drive_MAX;
        private System.Windows.Forms.Button bt_Set_Factor_VDD;
        private System.Windows.Forms.Button bt_Set_Factor_VLED;
        private System.Windows.Forms.TextBox tb_set_factor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_offset;
        private System.Windows.Forms.Button bt_update;
        private System.Windows.Forms.TextBox tb_spec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_close_port;
        private System.Windows.Forms.Button bt_open_port;
        private System.Windows.Forms.Button bt_Power_ON;
        private System.Windows.Forms.Button bt_Power_OFF;
        private System.Windows.Forms.Button bt_set_led;
        private System.Windows.Forms.Button bt_get_led;
        private System.Windows.Forms.ComboBox cbb_set_led;
        private System.Windows.Forms.Button bt_led3;
        private System.Windows.Forms.Button bt_led2;
        private System.Windows.Forms.Button bt_led1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button bt_a1_high;
        private System.Windows.Forms.Button bt_a1_low;
        private System.Windows.Forms.Button bt_get_reg0b;
        private System.Windows.Forms.Button bt_post_pin;
        private System.Windows.Forms.Button bt_get_C;
        private System.Windows.Forms.Button bt_get_reg13;
        private System.Windows.Forms.Button bt_fw_2;
        private System.Windows.Forms.Button bt_get_uid_2;
        private System.Windows.Forms.Button bt_vdd_high;
        private System.Windows.Forms.Button bt_vdd_low;
        private System.Windows.Forms.Button bt_Reset_Unit;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button bt_current_VDD2;
        private System.Windows.Forms.Button bt_d10_high;
        private System.Windows.Forms.Button bt_d10_low;
    }
}

