namespace AgIO
{
    partial class FormCommSetIMU
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cboxIMU = new System.Windows.Forms.ComboBox();
            this.lblCurrentIMU = new System.Windows.Forms.Label();
            this.btnCloseIMU = new System.Windows.Forms.Button();
            this.tboxReceiveIMU = new System.Windows.Forms.TextBox();
            this.btnOpenIMU = new System.Windows.Forms.Button();
            this.btnSerialOK = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
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
            this.btnRescan.Location = new System.Drawing.Point(12, 183);
            this.btnRescan.Name = "btnRescan";
            this.btnRescan.Size = new System.Drawing.Size(156, 54);
            this.btnRescan.TabIndex = 58;
            this.btnRescan.Text = "Rescan Ports";
            this.btnRescan.UseVisualStyleBackColor = false;
            this.btnRescan.Click += new System.EventHandler(this.btnRescan_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.cboxIMU);
            this.groupBox3.Controls.Add(this.lblCurrentIMU);
            this.groupBox3.Controls.Add(this.btnCloseIMU);
            this.groupBox3.Controls.Add(this.tboxReceiveIMU);
            this.groupBox3.Controls.Add(this.btnOpenIMU);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(511, 153);
            this.groupBox3.TabIndex = 67;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "IMU";
            // 
            // cboxIMU
            // 
            this.cboxIMU.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cboxIMU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxIMU.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.cboxIMU.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cboxIMU.FormattingEnabled = true;
            this.cboxIMU.Location = new System.Drawing.Point(10, 37);
            this.cboxIMU.Name = "cboxIMU";
            this.cboxIMU.Size = new System.Drawing.Size(169, 37);
            this.cboxIMU.TabIndex = 50;
            this.cboxIMU.SelectedIndexChanged += new System.EventHandler(this.cboxIMU_SelectedIndexChanged);
            // 
            // lblCurrentIMU
            // 
            this.lblCurrentIMU.AutoSize = true;
            this.lblCurrentIMU.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentIMU.Location = new System.Drawing.Point(139, 16);
            this.lblCurrentIMU.Name = "lblCurrentIMU";
            this.lblCurrentIMU.Size = new System.Drawing.Size(40, 18);
            this.lblCurrentIMU.TabIndex = 47;
            this.lblCurrentIMU.Text = "Port";
            // 
            // btnCloseIMU
            // 
            this.btnCloseIMU.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCloseIMU.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCloseIMU.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseIMU.Location = new System.Drawing.Point(358, 34);
            this.btnCloseIMU.Name = "btnCloseIMU";
            this.btnCloseIMU.Size = new System.Drawing.Size(138, 40);
            this.btnCloseIMU.TabIndex = 44;
            this.btnCloseIMU.Text = "Disconnect";
            this.btnCloseIMU.UseVisualStyleBackColor = false;
            this.btnCloseIMU.Click += new System.EventHandler(this.btnCloseIMU_Click);
            // 
            // tboxReceiveIMU
            // 
            this.tboxReceiveIMU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tboxReceiveIMU.BackColor = System.Drawing.SystemColors.Window;
            this.tboxReceiveIMU.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.tboxReceiveIMU.Location = new System.Drawing.Point(10, 97);
            this.tboxReceiveIMU.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tboxReceiveIMU.Multiline = true;
            this.tboxReceiveIMU.Name = "tboxReceiveIMU";
            this.tboxReceiveIMU.ReadOnly = true;
            this.tboxReceiveIMU.Size = new System.Drawing.Size(486, 38);
            this.tboxReceiveIMU.TabIndex = 40;
            // 
            // btnOpenIMU
            // 
            this.btnOpenIMU.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnOpenIMU.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnOpenIMU.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenIMU.Location = new System.Drawing.Point(208, 34);
            this.btnOpenIMU.Name = "btnOpenIMU";
            this.btnOpenIMU.Size = new System.Drawing.Size(138, 40);
            this.btnOpenIMU.TabIndex = 45;
            this.btnOpenIMU.Text = "Connect";
            this.btnOpenIMU.UseVisualStyleBackColor = false;
            this.btnOpenIMU.Click += new System.EventHandler(this.btnOpenIMU_Click);
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
            this.btnSerialOK.Location = new System.Drawing.Point(355, 181);
            this.btnSerialOK.Name = "btnSerialOK";
            this.btnSerialOK.Size = new System.Drawing.Size(156, 57);
            this.btnSerialOK.TabIndex = 59;
            this.btnSerialOK.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSerialOK.UseVisualStyleBackColor = true;
            this.btnSerialOK.Click += new System.EventHandler(this.btnSerialOK_Click);
            // 
            // FormCommSetIMU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(529, 250);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnRescan);
            this.Controls.Add(this.btnSerialOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormCommSetIMU";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Connect IMU";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormCommSet_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnRescan;
        private System.Windows.Forms.Button btnSerialOK;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cboxIMU;
        private System.Windows.Forms.Label lblCurrentIMU;
        private System.Windows.Forms.Button btnCloseIMU;
        private System.Windows.Forms.TextBox tboxReceiveIMU;
        private System.Windows.Forms.Button btnOpenIMU;
    }
}