namespace AgIO
{
    partial class FormCommSetGPS
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnRescan = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClrGPS = new System.Windows.Forms.Button();
            this.cboxPort = new System.Windows.Forms.ComboBox();
            this.cboxBaud = new System.Windows.Forms.ComboBox();
            this.lblCurrentPort = new System.Windows.Forms.Label();
            this.lblCurrentBaud = new System.Windows.Forms.Label();
            this.btnCloseSerial = new System.Windows.Forms.Button();
            this.textBoxRcv = new System.Windows.Forms.TextBox();
            this.btnOpenSerial = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboxPort2 = new System.Windows.Forms.ComboBox();
            this.cboxBaud2 = new System.Windows.Forms.ComboBox();
            this.lblCurrentPort2 = new System.Windows.Forms.Label();
            this.lblCurrentBaud2 = new System.Windows.Forms.Label();
            this.btnCloseSerial2 = new System.Windows.Forms.Button();
            this.textBoxRcv2 = new System.Windows.Forms.TextBox();
            this.btnOpenSerial2 = new System.Windows.Forms.Button();
            this.btnSerialOK = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnRescan
            // 
            this.btnRescan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRescan.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnRescan.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRescan.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRescan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRescan.Location = new System.Drawing.Point(353, 318);
            this.btnRescan.Name = "btnRescan";
            this.btnRescan.Size = new System.Drawing.Size(156, 63);
            this.btnRescan.TabIndex = 58;
            this.btnRescan.Text = "Rescan Ports";
            this.btnRescan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRescan.UseVisualStyleBackColor = false;
            this.btnRescan.Click += new System.EventHandler(this.btnRescan_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.btnClrGPS);
            this.groupBox1.Controls.Add(this.cboxPort);
            this.groupBox1.Controls.Add(this.cboxBaud);
            this.groupBox1.Controls.Add(this.lblCurrentPort);
            this.groupBox1.Controls.Add(this.lblCurrentBaud);
            this.groupBox1.Controls.Add(this.btnCloseSerial);
            this.groupBox1.Controls.Add(this.textBoxRcv);
            this.groupBox1.Controls.Add(this.btnOpenSerial);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(767, 151);
            this.groupBox1.TabIndex = 64;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GPS Port 1";
            // 
            // btnClrGPS
            // 
            this.btnClrGPS.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnClrGPS.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnClrGPS.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClrGPS.Location = new System.Drawing.Point(357, 37);
            this.btnClrGPS.Name = "btnClrGPS";
            this.btnClrGPS.Size = new System.Drawing.Size(57, 40);
            this.btnClrGPS.TabIndex = 51;
            this.btnClrGPS.Text = "CLR";
            this.btnClrGPS.UseVisualStyleBackColor = false;
            this.btnClrGPS.Click += new System.EventHandler(this.btnClrGPS_Click);
            // 
            // cboxPort
            // 
            this.cboxPort.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cboxPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxPort.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.cboxPort.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cboxPort.FormattingEnabled = true;
            this.cboxPort.Location = new System.Drawing.Point(10, 37);
            this.cboxPort.Name = "cboxPort";
            this.cboxPort.Size = new System.Drawing.Size(169, 37);
            this.cboxPort.TabIndex = 50;
            this.cboxPort.SelectedIndexChanged += new System.EventHandler(this.cboxPort_SelectedIndexChanged_1);
            // 
            // cboxBaud
            // 
            this.cboxBaud.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cboxBaud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxBaud.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.cboxBaud.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cboxBaud.FormattingEnabled = true;
            this.cboxBaud.Items.AddRange(new object[] {
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.cboxBaud.Location = new System.Drawing.Point(198, 37);
            this.cboxBaud.Name = "cboxBaud";
            this.cboxBaud.Size = new System.Drawing.Size(127, 37);
            this.cboxBaud.TabIndex = 49;
            this.cboxBaud.SelectedIndexChanged += new System.EventHandler(this.cboxBaud_SelectedIndexChanged_1);
            // 
            // lblCurrentPort
            // 
            this.lblCurrentPort.AutoSize = true;
            this.lblCurrentPort.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentPort.Location = new System.Drawing.Point(139, 16);
            this.lblCurrentPort.Name = "lblCurrentPort";
            this.lblCurrentPort.Size = new System.Drawing.Size(40, 18);
            this.lblCurrentPort.TabIndex = 47;
            this.lblCurrentPort.Text = "Port";
            // 
            // lblCurrentBaud
            // 
            this.lblCurrentBaud.AutoSize = true;
            this.lblCurrentBaud.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentBaud.Location = new System.Drawing.Point(280, 16);
            this.lblCurrentBaud.Name = "lblCurrentBaud";
            this.lblCurrentBaud.Size = new System.Drawing.Size(45, 18);
            this.lblCurrentBaud.TabIndex = 46;
            this.lblCurrentBaud.Text = "Baud";
            // 
            // btnCloseSerial
            // 
            this.btnCloseSerial.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCloseSerial.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCloseSerial.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseSerial.Location = new System.Drawing.Point(608, 35);
            this.btnCloseSerial.Name = "btnCloseSerial";
            this.btnCloseSerial.Size = new System.Drawing.Size(138, 40);
            this.btnCloseSerial.TabIndex = 44;
            this.btnCloseSerial.Text = "Disconnect";
            this.btnCloseSerial.UseVisualStyleBackColor = false;
            this.btnCloseSerial.Click += new System.EventHandler(this.btnCloseSerial_Click);
            // 
            // textBoxRcv
            // 
            this.textBoxRcv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRcv.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxRcv.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.textBoxRcv.Location = new System.Drawing.Point(7, 85);
            this.textBoxRcv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxRcv.Multiline = true;
            this.textBoxRcv.Name = "textBoxRcv";
            this.textBoxRcv.ReadOnly = true;
            this.textBoxRcv.Size = new System.Drawing.Size(736, 58);
            this.textBoxRcv.TabIndex = 40;
            // 
            // btnOpenSerial
            // 
            this.btnOpenSerial.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnOpenSerial.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnOpenSerial.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenSerial.Location = new System.Drawing.Point(458, 35);
            this.btnOpenSerial.Name = "btnOpenSerial";
            this.btnOpenSerial.Size = new System.Drawing.Size(138, 40);
            this.btnOpenSerial.TabIndex = 45;
            this.btnOpenSerial.Text = "Connect";
            this.btnOpenSerial.UseVisualStyleBackColor = false;
            this.btnOpenSerial.Click += new System.EventHandler(this.btnOpenSerial_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.cboxPort2);
            this.groupBox2.Controls.Add(this.cboxBaud2);
            this.groupBox2.Controls.Add(this.lblCurrentPort2);
            this.groupBox2.Controls.Add(this.lblCurrentBaud2);
            this.groupBox2.Controls.Add(this.btnCloseSerial2);
            this.groupBox2.Controls.Add(this.textBoxRcv2);
            this.groupBox2.Controls.Add(this.btnOpenSerial2);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(12, 177);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(767, 120);
            this.groupBox2.TabIndex = 65;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "GPS Port 2";
            // 
            // cboxPort2
            // 
            this.cboxPort2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cboxPort2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxPort2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.cboxPort2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cboxPort2.FormattingEnabled = true;
            this.cboxPort2.Location = new System.Drawing.Point(10, 37);
            this.cboxPort2.Name = "cboxPort2";
            this.cboxPort2.Size = new System.Drawing.Size(169, 37);
            this.cboxPort2.TabIndex = 50;
            this.cboxPort2.SelectedIndexChanged += new System.EventHandler(this.cboxPort2_SelectedIndexChanged);
            // 
            // cboxBaud2
            // 
            this.cboxBaud2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cboxBaud2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxBaud2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.cboxBaud2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cboxBaud2.FormattingEnabled = true;
            this.cboxBaud2.Items.AddRange(new object[] {
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.cboxBaud2.Location = new System.Drawing.Point(198, 37);
            this.cboxBaud2.Name = "cboxBaud2";
            this.cboxBaud2.Size = new System.Drawing.Size(127, 37);
            this.cboxBaud2.TabIndex = 49;
            this.cboxBaud2.SelectedIndexChanged += new System.EventHandler(this.cboxBaud2_SelectedIndexChanged);
            // 
            // lblCurrentPort2
            // 
            this.lblCurrentPort2.AutoSize = true;
            this.lblCurrentPort2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentPort2.Location = new System.Drawing.Point(139, 16);
            this.lblCurrentPort2.Name = "lblCurrentPort2";
            this.lblCurrentPort2.Size = new System.Drawing.Size(40, 18);
            this.lblCurrentPort2.TabIndex = 47;
            this.lblCurrentPort2.Text = "Port";
            // 
            // lblCurrentBaud2
            // 
            this.lblCurrentBaud2.AutoSize = true;
            this.lblCurrentBaud2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentBaud2.Location = new System.Drawing.Point(280, 16);
            this.lblCurrentBaud2.Name = "lblCurrentBaud2";
            this.lblCurrentBaud2.Size = new System.Drawing.Size(45, 18);
            this.lblCurrentBaud2.TabIndex = 46;
            this.lblCurrentBaud2.Text = "Baud";
            // 
            // btnCloseSerial2
            // 
            this.btnCloseSerial2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCloseSerial2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCloseSerial2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseSerial2.Location = new System.Drawing.Point(608, 35);
            this.btnCloseSerial2.Name = "btnCloseSerial2";
            this.btnCloseSerial2.Size = new System.Drawing.Size(138, 40);
            this.btnCloseSerial2.TabIndex = 44;
            this.btnCloseSerial2.Text = "Disconnect";
            this.btnCloseSerial2.UseVisualStyleBackColor = false;
            this.btnCloseSerial2.Click += new System.EventHandler(this.btnCloseSerial2_Click);
            // 
            // textBoxRcv2
            // 
            this.textBoxRcv2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRcv2.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxRcv2.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.textBoxRcv2.Location = new System.Drawing.Point(11, 81);
            this.textBoxRcv2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxRcv2.Multiline = true;
            this.textBoxRcv2.Name = "textBoxRcv2";
            this.textBoxRcv2.ReadOnly = true;
            this.textBoxRcv2.Size = new System.Drawing.Size(736, 31);
            this.textBoxRcv2.TabIndex = 40;
            // 
            // btnOpenSerial2
            // 
            this.btnOpenSerial2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnOpenSerial2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnOpenSerial2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenSerial2.Location = new System.Drawing.Point(458, 35);
            this.btnOpenSerial2.Name = "btnOpenSerial2";
            this.btnOpenSerial2.Size = new System.Drawing.Size(138, 40);
            this.btnOpenSerial2.TabIndex = 45;
            this.btnOpenSerial2.Text = "Connect";
            this.btnOpenSerial2.UseVisualStyleBackColor = false;
            this.btnOpenSerial2.Click += new System.EventHandler(this.btnOpenSerial2_Click);
            // 
            // btnSerialOK
            // 
            this.btnSerialOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSerialOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSerialOK.FlatAppearance.BorderSize = 0;
            this.btnSerialOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSerialOK.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnSerialOK.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSerialOK.Image = global::AgIO.Properties.Resources.OK64;
            this.btnSerialOK.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSerialOK.Location = new System.Drawing.Point(619, 318);
            this.btnSerialOK.Name = "btnSerialOK";
            this.btnSerialOK.Size = new System.Drawing.Size(156, 63);
            this.btnSerialOK.TabIndex = 59;
            this.btnSerialOK.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSerialOK.UseVisualStyleBackColor = true;
            this.btnSerialOK.Click += new System.EventHandler(this.btnSerialOK_Click);
            // 
            // FormCommSetGPS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(791, 393);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnRescan);
            this.Controls.Add(this.btnSerialOK);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormCommSetGPS";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Connect GPS";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormCommSet_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnRescan;
        private System.Windows.Forms.Button btnSerialOK;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCurrentPort;
        private System.Windows.Forms.Label lblCurrentBaud;
        private System.Windows.Forms.Button btnCloseSerial;
        private System.Windows.Forms.TextBox textBoxRcv;
        private System.Windows.Forms.Button btnOpenSerial;
        private System.Windows.Forms.ComboBox cboxBaud;
        private System.Windows.Forms.ComboBox cboxPort;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cboxPort2;
        private System.Windows.Forms.ComboBox cboxBaud2;
        private System.Windows.Forms.Label lblCurrentPort2;
        private System.Windows.Forms.Label lblCurrentBaud2;
        private System.Windows.Forms.Button btnCloseSerial2;
        private System.Windows.Forms.TextBox textBoxRcv2;
        private System.Windows.Forms.Button btnOpenSerial2;
        private System.Windows.Forms.Button btnClrGPS;
    }
}