
namespace AgIO
{
    partial class FormLoop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLoop));
            this.lblToAOG = new System.Windows.Forms.Label();
            this.lblFromAOG = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.lblFromGPS = new System.Windows.Forms.Label();
            this.lblToGPS = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblFromUDP = new System.Windows.Forms.Label();
            this.lblToUDP = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblFromSteer = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblToSteer = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblFromModule1 = new System.Windows.Forms.Label();
            this.lblToModule1 = new System.Windows.Forms.Label();
            this.cboxIsTrafficOn = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblWatch = new System.Windows.Forms.Label();
            this.btnStartStopNtrip = new System.Windows.Forms.Button();
            this.lblNTRIPBytes = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblBytes = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCurentLon = new System.Windows.Forms.Label();
            this.lblCurrentLat = new System.Windows.Forms.Label();
            this.pcCPU = new System.Diagnostics.PerformanceCounter();
            this.pcRAM = new System.Diagnostics.PerformanceCounter();
            this.pbarCPU = new System.Windows.Forms.ProgressBar();
            this.pbarRAM = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblCPU = new System.Windows.Forms.Label();
            this.lblRAM = new System.Windows.Forms.Label();
            this.lblFromModule2 = new System.Windows.Forms.Label();
            this.lblToModule2 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblFromMU = new System.Windows.Forms.Label();
            this.lblToIMU = new System.Windows.Forms.Label();
            this.serialSendTimer = new System.Windows.Forms.Timer(this.components);
            this.lblPortList = new System.Windows.Forms.Label();
            this.lblIMUComm = new System.Windows.Forms.Label();
            this.lblGPS1Comm = new System.Windows.Forms.Label();
            this.lblMod1Comm = new System.Windows.Forms.Label();
            this.lblMod2Comm = new System.Windows.Forms.Label();
            this.lblMod3Comm = new System.Windows.Forms.Label();
            this.btnRescanPorts = new System.Windows.Forms.Button();
            this.btnDeviceManager = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.stripGPSPortsConfig = new System.Windows.Forms.ToolStripDropDownButton();
            this.stripIMUConnect = new System.Windows.Forms.ToolStripDropDownButton();
            this.stripSerialPortsConfig = new System.Windows.Forms.ToolStripDropDownButton();
            this.stripRunDrive = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.saveToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.wizardToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.nTRIPToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.uDPToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcRAM)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblToAOG
            // 
            this.lblToAOG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblToAOG.BackColor = System.Drawing.Color.Gainsboro;
            this.lblToAOG.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToAOG.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblToAOG.Location = new System.Drawing.Point(191, 4);
            this.lblToAOG.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToAOG.Name = "lblToAOG";
            this.lblToAOG.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblToAOG.Size = new System.Drawing.Size(53, 18);
            this.lblToAOG.TabIndex = 123;
            this.lblToAOG.Text = "0000";
            this.lblToAOG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFromAOG
            // 
            this.lblFromAOG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFromAOG.BackColor = System.Drawing.Color.Gainsboro;
            this.lblFromAOG.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromAOG.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFromAOG.Location = new System.Drawing.Point(123, 4);
            this.lblFromAOG.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFromAOG.Name = "lblFromAOG";
            this.lblFromAOG.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblFromAOG.Size = new System.Drawing.Size(56, 18);
            this.lblFromAOG.TabIndex = 126;
            this.lblFromAOG.Text = "0000";
            this.lblFromAOG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gainsboro;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(396, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 18);
            this.label2.TabIndex = 127;
            this.label2.Text = "From";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gainsboro;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(73, 29);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 18);
            this.label3.TabIndex = 131;
            this.label3.Text = "UDP";
            // 
            // lblFromGPS
            // 
            this.lblFromGPS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFromGPS.BackColor = System.Drawing.Color.Gainsboro;
            this.lblFromGPS.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromGPS.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFromGPS.Location = new System.Drawing.Point(123, 61);
            this.lblFromGPS.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFromGPS.Name = "lblFromGPS";
            this.lblFromGPS.Size = new System.Drawing.Size(56, 18);
            this.lblFromGPS.TabIndex = 130;
            this.lblFromGPS.Text = "---";
            this.lblFromGPS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblToGPS
            // 
            this.lblToGPS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblToGPS.BackColor = System.Drawing.Color.Gainsboro;
            this.lblToGPS.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToGPS.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblToGPS.Location = new System.Drawing.Point(191, 61);
            this.lblToGPS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToGPS.Name = "lblToGPS";
            this.lblToGPS.Size = new System.Drawing.Size(53, 18);
            this.lblToGPS.TabIndex = 128;
            this.lblToGPS.Text = "---";
            this.lblToGPS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Gainsboro;
            this.label7.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label7.Location = new System.Drawing.Point(68, 61);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 18);
            this.label7.TabIndex = 135;
            this.label7.Text = "GPS 1";
            // 
            // lblFromUDP
            // 
            this.lblFromUDP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFromUDP.BackColor = System.Drawing.Color.Gainsboro;
            this.lblFromUDP.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromUDP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFromUDP.Location = new System.Drawing.Point(123, 29);
            this.lblFromUDP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFromUDP.Name = "lblFromUDP";
            this.lblFromUDP.Size = new System.Drawing.Size(56, 18);
            this.lblFromUDP.TabIndex = 134;
            this.lblFromUDP.Text = "---";
            this.lblFromUDP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblToUDP
            // 
            this.lblToUDP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblToUDP.BackColor = System.Drawing.Color.Gainsboro;
            this.lblToUDP.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToUDP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblToUDP.Location = new System.Drawing.Point(191, 29);
            this.lblToUDP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToUDP.Name = "lblToUDP";
            this.lblToUDP.Size = new System.Drawing.Size(53, 18);
            this.lblToUDP.TabIndex = 132;
            this.lblToUDP.Text = "---";
            this.lblToUDP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Gainsboro;
            this.label11.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label11.Location = new System.Drawing.Point(67, 170);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 18);
            this.label11.TabIndex = 139;
            this.label11.Text = "Mod 3";
            // 
            // lblFromSteer
            // 
            this.lblFromSteer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFromSteer.BackColor = System.Drawing.Color.Gainsboro;
            this.lblFromSteer.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromSteer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFromSteer.Location = new System.Drawing.Point(123, 170);
            this.lblFromSteer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFromSteer.Name = "lblFromSteer";
            this.lblFromSteer.Size = new System.Drawing.Size(56, 18);
            this.lblFromSteer.TabIndex = 138;
            this.lblFromSteer.Text = "---";
            this.lblFromSteer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Gainsboro;
            this.label13.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label13.Location = new System.Drawing.Point(67, 118);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 18);
            this.label13.TabIndex = 137;
            this.label13.Text = "Mod 1";
            // 
            // lblToSteer
            // 
            this.lblToSteer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblToSteer.BackColor = System.Drawing.Color.Gainsboro;
            this.lblToSteer.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToSteer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblToSteer.Location = new System.Drawing.Point(191, 170);
            this.lblToSteer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToSteer.Name = "lblToSteer";
            this.lblToSteer.Size = new System.Drawing.Size(53, 18);
            this.lblToSteer.TabIndex = 136;
            this.lblToSteer.Text = "---";
            this.lblToSteer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Gainsboro;
            this.label15.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label15.Location = new System.Drawing.Point(462, 35);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(26, 18);
            this.label15.TabIndex = 140;
            this.label15.Text = "To";
            // 
            // lblFromModule1
            // 
            this.lblFromModule1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFromModule1.BackColor = System.Drawing.Color.Gainsboro;
            this.lblFromModule1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromModule1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFromModule1.Location = new System.Drawing.Point(123, 118);
            this.lblFromModule1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFromModule1.Name = "lblFromModule1";
            this.lblFromModule1.Size = new System.Drawing.Size(56, 18);
            this.lblFromModule1.TabIndex = 142;
            this.lblFromModule1.Text = "---";
            this.lblFromModule1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblToModule1
            // 
            this.lblToModule1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblToModule1.BackColor = System.Drawing.Color.Gainsboro;
            this.lblToModule1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToModule1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblToModule1.Location = new System.Drawing.Point(191, 118);
            this.lblToModule1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToModule1.Name = "lblToModule1";
            this.lblToModule1.Size = new System.Drawing.Size(53, 18);
            this.lblToModule1.TabIndex = 141;
            this.lblToModule1.Text = "---";
            this.lblToModule1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboxIsTrafficOn
            // 
            this.cboxIsTrafficOn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboxIsTrafficOn.Appearance = System.Windows.Forms.Appearance.Button;
            this.cboxIsTrafficOn.AutoSize = true;
            this.cboxIsTrafficOn.BackColor = System.Drawing.Color.Gainsboro;
            this.cboxIsTrafficOn.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cboxIsTrafficOn.Checked = true;
            this.cboxIsTrafficOn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cboxIsTrafficOn.FlatAppearance.CheckedBackColor = System.Drawing.Color.PaleGreen;
            this.cboxIsTrafficOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboxIsTrafficOn.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxIsTrafficOn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cboxIsTrafficOn.Location = new System.Drawing.Point(256, 11);
            this.cboxIsTrafficOn.Margin = new System.Windows.Forms.Padding(2);
            this.cboxIsTrafficOn.Name = "cboxIsTrafficOn";
            this.cboxIsTrafficOn.Size = new System.Drawing.Size(94, 33);
            this.cboxIsTrafficOn.TabIndex = 143;
            this.cboxIsTrafficOn.Text = "Bytes/s";
            this.cboxIsTrafficOn.UseVisualStyleBackColor = false;
            this.cboxIsTrafficOn.CheckedChanged += new System.EventHandler(this.cboxIsTrafficOn_CheckedChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Gainsboro;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(71, 4);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 18);
            this.label4.TabIndex = 144;
            this.label4.Text = "Drive";
            // 
            // lblWatch
            // 
            this.lblWatch.AutoSize = true;
            this.lblWatch.BackColor = System.Drawing.Color.Gainsboro;
            this.lblWatch.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWatch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblWatch.Location = new System.Drawing.Point(11, 155);
            this.lblWatch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWatch.Name = "lblWatch";
            this.lblWatch.Size = new System.Drawing.Size(50, 16);
            this.lblWatch.TabIndex = 146;
            this.lblWatch.Text = "Watch";
            // 
            // btnStartStopNtrip
            // 
            this.btnStartStopNtrip.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnStartStopNtrip.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnStartStopNtrip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartStopNtrip.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartStopNtrip.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnStartStopNtrip.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnStartStopNtrip.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnStartStopNtrip.Location = new System.Drawing.Point(13, 126);
            this.btnStartStopNtrip.Margin = new System.Windows.Forms.Padding(4);
            this.btnStartStopNtrip.Name = "btnStartStopNtrip";
            this.btnStartStopNtrip.Size = new System.Drawing.Size(77, 26);
            this.btnStartStopNtrip.TabIndex = 147;
            this.btnStartStopNtrip.Text = "StartStop";
            this.btnStartStopNtrip.UseVisualStyleBackColor = false;
            this.btnStartStopNtrip.Click += new System.EventHandler(this.btnStartStopNtrip_Click);
            // 
            // lblNTRIPBytes
            // 
            this.lblNTRIPBytes.AutoSize = true;
            this.lblNTRIPBytes.BackColor = System.Drawing.Color.Gainsboro;
            this.lblNTRIPBytes.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNTRIPBytes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNTRIPBytes.Location = new System.Drawing.Point(44, 173);
            this.lblNTRIPBytes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNTRIPBytes.Name = "lblNTRIPBytes";
            this.lblNTRIPBytes.Size = new System.Drawing.Size(45, 16);
            this.lblNTRIPBytes.TabIndex = 148;
            this.lblNTRIPBytes.Text = "Bytes";
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.BackColor = System.Drawing.Color.Gainsboro;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(64, 64);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripGPSPortsConfig,
            this.stripIMUConnect,
            this.stripSerialPortsConfig,
            this.stripRunDrive,
            this.toolStripDropDownButton1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 307);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 11, 0);
            this.statusStrip1.Size = new System.Drawing.Size(521, 86);
            this.statusStrip1.TabIndex = 149;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblBytes
            // 
            this.lblBytes.AutoSize = true;
            this.lblBytes.BackColor = System.Drawing.Color.Gainsboro;
            this.lblBytes.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBytes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBytes.Location = new System.Drawing.Point(11, 173);
            this.lblBytes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBytes.Name = "lblBytes";
            this.lblBytes.Size = new System.Drawing.Size(41, 14);
            this.lblBytes.TabIndex = 150;
            this.lblBytes.Text = "Bytes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Gainsboro;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label6.Location = new System.Drawing.Point(7, 6);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 23);
            this.label6.TabIndex = 151;
            this.label6.Text = "Lat";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Gainsboro;
            this.label8.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label8.Location = new System.Drawing.Point(3, 31);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 23);
            this.label8.TabIndex = 152;
            this.label8.Text = "Lon";
            // 
            // lblCurentLon
            // 
            this.lblCurentLon.AutoSize = true;
            this.lblCurentLon.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCurentLon.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurentLon.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCurentLon.Location = new System.Drawing.Point(36, 31);
            this.lblCurentLon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurentLon.Name = "lblCurentLon";
            this.lblCurentLon.Size = new System.Drawing.Size(54, 23);
            this.lblCurentLon.TabIndex = 154;
            this.lblCurentLon.Text = "-111";
            // 
            // lblCurrentLat
            // 
            this.lblCurrentLat.AutoSize = true;
            this.lblCurrentLat.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCurrentLat.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentLat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCurrentLat.Location = new System.Drawing.Point(36, 6);
            this.lblCurrentLat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrentLat.Name = "lblCurrentLat";
            this.lblCurrentLat.Size = new System.Drawing.Size(34, 23);
            this.lblCurrentLat.TabIndex = 153;
            this.lblCurrentLat.Text = "53";
            // 
            // pcCPU
            // 
            this.pcCPU.CategoryName = "Processor";
            this.pcCPU.CounterName = "% Processor Time";
            this.pcCPU.InstanceName = "_Total";
            // 
            // pcRAM
            // 
            this.pcRAM.CategoryName = "Memory";
            this.pcRAM.CounterName = "% Committed Bytes In Use";
            // 
            // pbarCPU
            // 
            this.pbarCPU.Location = new System.Drawing.Point(52, 75);
            this.pbarCPU.Margin = new System.Windows.Forms.Padding(2);
            this.pbarCPU.Name = "pbarCPU";
            this.pbarCPU.Size = new System.Drawing.Size(80, 6);
            this.pbarCPU.TabIndex = 156;
            // 
            // pbarRAM
            // 
            this.pbarRAM.Location = new System.Drawing.Point(52, 94);
            this.pbarRAM.Margin = new System.Windows.Forms.Padding(2);
            this.pbarRAM.Name = "pbarRAM";
            this.pbarRAM.Size = new System.Drawing.Size(80, 6);
            this.pbarRAM.TabIndex = 157;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Gainsboro;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(1, 90);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 14);
            this.label5.TabIndex = 158;
            this.label5.Text = "RAM%";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Gainsboro;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(6, 70);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 14);
            this.label9.TabIndex = 159;
            this.label9.Text = "CPU%";
            // 
            // lblCPU
            // 
            this.lblCPU.AutoSize = true;
            this.lblCPU.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCPU.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPU.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCPU.Location = new System.Drawing.Point(139, 71);
            this.lblCPU.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCPU.Name = "lblCPU";
            this.lblCPU.Size = new System.Drawing.Size(23, 14);
            this.lblCPU.TabIndex = 160;
            this.lblCPU.Text = "33";
            // 
            // lblRAM
            // 
            this.lblRAM.AutoSize = true;
            this.lblRAM.BackColor = System.Drawing.Color.Gainsboro;
            this.lblRAM.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRAM.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRAM.Location = new System.Drawing.Point(139, 91);
            this.lblRAM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRAM.Name = "lblRAM";
            this.lblRAM.Size = new System.Drawing.Size(23, 14);
            this.lblRAM.TabIndex = 161;
            this.lblRAM.Text = "33";
            // 
            // lblFromModule2
            // 
            this.lblFromModule2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFromModule2.BackColor = System.Drawing.Color.Gainsboro;
            this.lblFromModule2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromModule2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFromModule2.Location = new System.Drawing.Point(123, 143);
            this.lblFromModule2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFromModule2.Name = "lblFromModule2";
            this.lblFromModule2.Size = new System.Drawing.Size(56, 18);
            this.lblFromModule2.TabIndex = 164;
            this.lblFromModule2.Text = "---";
            this.lblFromModule2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblToModule2
            // 
            this.lblToModule2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblToModule2.BackColor = System.Drawing.Color.Gainsboro;
            this.lblToModule2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToModule2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblToModule2.Location = new System.Drawing.Point(191, 143);
            this.lblToModule2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToModule2.Name = "lblToModule2";
            this.lblToModule2.Size = new System.Drawing.Size(53, 18);
            this.lblToModule2.TabIndex = 163;
            this.lblToModule2.Text = "---";
            this.lblToModule2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Gainsboro;
            this.label14.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label14.Location = new System.Drawing.Point(67, 143);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 18);
            this.label14.TabIndex = 162;
            this.label14.Text = "Mod 2";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Gainsboro;
            this.label10.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label10.Location = new System.Drawing.Point(68, 86);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 18);
            this.label10.TabIndex = 172;
            this.label10.Text = "I M U";
            // 
            // lblFromMU
            // 
            this.lblFromMU.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFromMU.BackColor = System.Drawing.Color.Gainsboro;
            this.lblFromMU.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromMU.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFromMU.Location = new System.Drawing.Point(123, 86);
            this.lblFromMU.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFromMU.Name = "lblFromMU";
            this.lblFromMU.Size = new System.Drawing.Size(56, 18);
            this.lblFromMU.TabIndex = 171;
            this.lblFromMU.Text = "---";
            this.lblFromMU.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblToIMU
            // 
            this.lblToIMU.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblToIMU.BackColor = System.Drawing.Color.Gainsboro;
            this.lblToIMU.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToIMU.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblToIMU.Location = new System.Drawing.Point(191, 86);
            this.lblToIMU.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToIMU.Name = "lblToIMU";
            this.lblToIMU.Size = new System.Drawing.Size(53, 18);
            this.lblToIMU.TabIndex = 170;
            this.lblToIMU.Text = "---";
            this.lblToIMU.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // serialSendTimer
            // 
            this.serialSendTimer.Enabled = true;
            this.serialSendTimer.Interval = 33;
            this.serialSendTimer.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lblPortList
            // 
            this.lblPortList.AutoSize = true;
            this.lblPortList.BackColor = System.Drawing.Color.Gainsboro;
            this.lblPortList.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPortList.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPortList.Location = new System.Drawing.Point(102, 270);
            this.lblPortList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPortList.Name = "lblPortList";
            this.lblPortList.Size = new System.Drawing.Size(45, 19);
            this.lblPortList.TabIndex = 174;
            this.lblPortList.Text = "Ports";
            // 
            // lblIMUComm
            // 
            this.lblIMUComm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIMUComm.BackColor = System.Drawing.Color.Gainsboro;
            this.lblIMUComm.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIMUComm.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblIMUComm.Location = new System.Drawing.Point(4, 86);
            this.lblIMUComm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIMUComm.Name = "lblIMUComm";
            this.lblIMUComm.Size = new System.Drawing.Size(54, 18);
            this.lblIMUComm.TabIndex = 175;
            this.lblIMUComm.Text = "--";
            this.lblIMUComm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGPS1Comm
            // 
            this.lblGPS1Comm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGPS1Comm.BackColor = System.Drawing.Color.Gainsboro;
            this.lblGPS1Comm.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGPS1Comm.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblGPS1Comm.Location = new System.Drawing.Point(4, 61);
            this.lblGPS1Comm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGPS1Comm.Name = "lblGPS1Comm";
            this.lblGPS1Comm.Size = new System.Drawing.Size(54, 18);
            this.lblGPS1Comm.TabIndex = 176;
            this.lblGPS1Comm.Text = "--";
            this.lblGPS1Comm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMod1Comm
            // 
            this.lblMod1Comm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMod1Comm.BackColor = System.Drawing.Color.Gainsboro;
            this.lblMod1Comm.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMod1Comm.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblMod1Comm.Location = new System.Drawing.Point(4, 118);
            this.lblMod1Comm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMod1Comm.Name = "lblMod1Comm";
            this.lblMod1Comm.Size = new System.Drawing.Size(54, 18);
            this.lblMod1Comm.TabIndex = 177;
            this.lblMod1Comm.Text = "--";
            this.lblMod1Comm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMod2Comm
            // 
            this.lblMod2Comm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMod2Comm.BackColor = System.Drawing.Color.Gainsboro;
            this.lblMod2Comm.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMod2Comm.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblMod2Comm.Location = new System.Drawing.Point(4, 143);
            this.lblMod2Comm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMod2Comm.Name = "lblMod2Comm";
            this.lblMod2Comm.Size = new System.Drawing.Size(54, 18);
            this.lblMod2Comm.TabIndex = 178;
            this.lblMod2Comm.Text = "--";
            this.lblMod2Comm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMod3Comm
            // 
            this.lblMod3Comm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMod3Comm.BackColor = System.Drawing.Color.Gainsboro;
            this.lblMod3Comm.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMod3Comm.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblMod3Comm.Location = new System.Drawing.Point(4, 170);
            this.lblMod3Comm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMod3Comm.Name = "lblMod3Comm";
            this.lblMod3Comm.Size = new System.Drawing.Size(54, 18);
            this.lblMod3Comm.TabIndex = 179;
            this.lblMod3Comm.Text = "--";
            this.lblMod3Comm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRescanPorts
            // 
            this.btnRescanPorts.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnRescanPorts.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnRescanPorts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRescanPorts.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRescanPorts.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRescanPorts.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRescanPorts.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnRescanPorts.Location = new System.Drawing.Point(14, 262);
            this.btnRescanPorts.Margin = new System.Windows.Forms.Padding(4);
            this.btnRescanPorts.Name = "btnRescanPorts";
            this.btnRescanPorts.Size = new System.Drawing.Size(77, 33);
            this.btnRescanPorts.TabIndex = 180;
            this.btnRescanPorts.Text = "Port Scan";
            this.btnRescanPorts.UseVisualStyleBackColor = false;
            this.btnRescanPorts.Click += new System.EventHandler(this.btnRescanPorts_Click);
            // 
            // btnDeviceManager
            // 
            this.btnDeviceManager.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnDeviceManager.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnDeviceManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeviceManager.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeviceManager.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDeviceManager.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDeviceManager.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDeviceManager.Location = new System.Drawing.Point(13, 211);
            this.btnDeviceManager.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeviceManager.Name = "btnDeviceManager";
            this.btnDeviceManager.Size = new System.Drawing.Size(77, 33);
            this.btnDeviceManager.TabIndex = 180;
            this.btnDeviceManager.Text = "Dev Mgr";
            this.btnDeviceManager.UseVisualStyleBackColor = false;
            this.btnDeviceManager.Click += new System.EventHandler(this.btnDeviceManager_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.9084F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.0916F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel1.Controls.Add(this.lblToAOG, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblToUDP, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblFromUDP, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblFromAOG, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblMod3Comm, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.label11, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.lblFromSteer, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.lblToSteer, 3, 8);
            this.tableLayoutPanel1.Controls.Add(this.lblToModule2, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblToModule1, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblFromModule2, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblFromModule1, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.label14, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.label13, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblMod2Comm, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblMod1Comm, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label10, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblIMUComm, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblFromMU, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblToIMU, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblToGPS, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblFromGPS, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label7, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblGPS1Comm, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(256, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(253, 194);
            this.tableLayoutPanel1.TabIndex = 181;
            // 
            // stripGPSPortsConfig
            // 
            this.stripGPSPortsConfig.AutoSize = false;
            this.stripGPSPortsConfig.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stripGPSPortsConfig.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stripGPSPortsConfig.Image = global::AgIO.Properties.Resources.GPSSignalGood;
            this.stripGPSPortsConfig.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.stripGPSPortsConfig.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stripGPSPortsConfig.Name = "stripGPSPortsConfig";
            this.stripGPSPortsConfig.ShowDropDownArrow = false;
            this.stripGPSPortsConfig.Size = new System.Drawing.Size(100, 84);
            this.stripGPSPortsConfig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.stripGPSPortsConfig.Click += new System.EventHandler(this.stripGPSPortsConfig_Click);
            // 
            // stripIMUConnect
            // 
            this.stripIMUConnect.AutoSize = false;
            this.stripIMUConnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stripIMUConnect.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stripIMUConnect.Image = global::AgIO.Properties.Resources.gyro;
            this.stripIMUConnect.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.stripIMUConnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stripIMUConnect.Name = "stripIMUConnect";
            this.stripIMUConnect.ShowDropDownArrow = false;
            this.stripIMUConnect.Size = new System.Drawing.Size(100, 84);
            this.stripIMUConnect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.stripIMUConnect.Click += new System.EventHandler(this.stripIMUConnect_Click);
            // 
            // stripSerialPortsConfig
            // 
            this.stripSerialPortsConfig.AutoSize = false;
            this.stripSerialPortsConfig.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stripSerialPortsConfig.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stripSerialPortsConfig.Image = global::AgIO.Properties.Resources.ComPorts;
            this.stripSerialPortsConfig.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.stripSerialPortsConfig.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stripSerialPortsConfig.Name = "stripSerialPortsConfig";
            this.stripSerialPortsConfig.ShowDropDownArrow = false;
            this.stripSerialPortsConfig.Size = new System.Drawing.Size(100, 84);
            this.stripSerialPortsConfig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.stripSerialPortsConfig.Click += new System.EventHandler(this.stripSerialPortsConfig_Click);
            // 
            // stripRunDrive
            // 
            this.stripRunDrive.AutoSize = false;
            this.stripRunDrive.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stripRunDrive.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stripRunDrive.Image = global::AgIO.Properties.Resources.AppIcon64;
            this.stripRunDrive.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.stripRunDrive.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stripRunDrive.Name = "stripRunDrive";
            this.stripRunDrive.ShowDropDownArrow = false;
            this.stripRunDrive.Size = new System.Drawing.Size(100, 84);
            this.stripRunDrive.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.stripRunDrive.Click += new System.EventHandler(this.stripRunDrive_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.AutoSize = false;
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStrip,
            this.loadToolStrip,
            this.wizardToolStrip,
            this.nTRIPToolStrip,
            this.uDPToolStripMenu});
            this.toolStripDropDownButton1.Image = global::AgIO.Properties.Resources.SettingsGear64;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.ShowDropDownArrow = false;
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(90, 84);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // saveToolStrip
            // 
            this.saveToolStrip.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveToolStrip.Image = global::AgIO.Properties.Resources.FileSave;
            this.saveToolStrip.Name = "saveToolStrip";
            this.saveToolStrip.Size = new System.Drawing.Size(228, 70);
            this.saveToolStrip.Text = "Save";
            this.saveToolStrip.Click += new System.EventHandler(this.saveToolStrip_Click);
            // 
            // loadToolStrip
            // 
            this.loadToolStrip.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadToolStrip.Image = global::AgIO.Properties.Resources.FileOpen;
            this.loadToolStrip.Name = "loadToolStrip";
            this.loadToolStrip.Size = new System.Drawing.Size(228, 70);
            this.loadToolStrip.Text = "Load";
            this.loadToolStrip.Click += new System.EventHandler(this.loadToolStrip_Click);
            // 
            // wizardToolStrip
            // 
            this.wizardToolStrip.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wizardToolStrip.Image = global::AgIO.Properties.Resources.SpecialFunctions;
            this.wizardToolStrip.Name = "wizardToolStrip";
            this.wizardToolStrip.Size = new System.Drawing.Size(228, 70);
            this.wizardToolStrip.Text = "Wizard";
            this.wizardToolStrip.Click += new System.EventHandler(this.wizardToolStrip_Click);
            // 
            // nTRIPToolStrip
            // 
            this.nTRIPToolStrip.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nTRIPToolStrip.Image = global::AgIO.Properties.Resources.NtripSettings;
            this.nTRIPToolStrip.Name = "nTRIPToolStrip";
            this.nTRIPToolStrip.Size = new System.Drawing.Size(228, 70);
            this.nTRIPToolStrip.Text = "NTRIP";
            this.nTRIPToolStrip.Click += new System.EventHandler(this.nTRIPToolStrip_Click);
            // 
            // uDPToolStripMenu
            // 
            this.uDPToolStripMenu.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uDPToolStripMenu.Image = global::AgIO.Properties.Resources.UDPConfig;
            this.uDPToolStripMenu.Name = "uDPToolStripMenu";
            this.uDPToolStripMenu.Size = new System.Drawing.Size(228, 70);
            this.uDPToolStripMenu.Text = "UDP";
            this.uDPToolStripMenu.Click += new System.EventHandler(this.uDPToolStripMenu_Click);
            // 
            // FormLoop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(521, 393);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnDeviceManager);
            this.Controls.Add(this.btnRescanPorts);
            this.Controls.Add(this.lblPortList);
            this.Controls.Add(this.lblRAM);
            this.Controls.Add(this.lblCPU);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pbarRAM);
            this.Controls.Add(this.pbarCPU);
            this.Controls.Add(this.btnStartStopNtrip);
            this.Controls.Add(this.lblWatch);
            this.Controls.Add(this.lblNTRIPBytes);
            this.Controls.Add(this.lblCurentLon);
            this.Controls.Add(this.lblBytes);
            this.Controls.Add(this.lblCurrentLat);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.cboxIsTrafficOn);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(526, 340);
            this.Name = "FormLoop";
            this.Text = "AgIO";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLoop_FormClosing);
            this.Load += new System.EventHandler(this.FormLoop_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcRAM)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblToAOG;
        private System.Windows.Forms.Label lblFromAOG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFromGPS;
        private System.Windows.Forms.Label lblToGPS;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblFromUDP;
        private System.Windows.Forms.Label lblToUDP;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblFromSteer;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblToSteer;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblFromModule1;
        private System.Windows.Forms.Label lblToModule1;
        private System.Windows.Forms.CheckBox cboxIsTrafficOn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblWatch;
        private System.Windows.Forms.Button btnStartStopNtrip;
        private System.Windows.Forms.Label lblNTRIPBytes;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripDropDownButton stripSerialPortsConfig;
        private System.Windows.Forms.Label lblBytes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCurentLon;
        private System.Windows.Forms.Label lblCurrentLat;
        private System.Windows.Forms.ToolStripDropDownButton stripRunDrive;
        private System.Diagnostics.PerformanceCounter pcCPU;
        private System.Diagnostics.PerformanceCounter pcRAM;
        private System.Windows.Forms.ProgressBar pbarCPU;
        private System.Windows.Forms.ProgressBar pbarRAM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblCPU;
        private System.Windows.Forms.Label lblRAM;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStrip;
        private System.Windows.Forms.ToolStripMenuItem loadToolStrip;
        private System.Windows.Forms.ToolStripMenuItem wizardToolStrip;
        private System.Windows.Forms.ToolStripMenuItem nTRIPToolStrip;
        private System.Windows.Forms.Label lblFromModule2;
        private System.Windows.Forms.Label lblToModule2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ToolStripDropDownButton stripGPSPortsConfig;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblFromMU;
        private System.Windows.Forms.Label lblToIMU;
        private System.Windows.Forms.ToolStripDropDownButton stripIMUConnect;
        private System.Windows.Forms.ToolStripMenuItem uDPToolStripMenu;
        private System.Windows.Forms.Timer serialSendTimer;
        private System.Windows.Forms.Label lblPortList;
        private System.Windows.Forms.Label lblIMUComm;
        private System.Windows.Forms.Label lblGPS1Comm;
        private System.Windows.Forms.Label lblMod1Comm;
        private System.Windows.Forms.Label lblMod2Comm;
        private System.Windows.Forms.Label lblMod3Comm;
        private System.Windows.Forms.Button btnRescanPorts;
        private System.Windows.Forms.Button btnDeviceManager;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

