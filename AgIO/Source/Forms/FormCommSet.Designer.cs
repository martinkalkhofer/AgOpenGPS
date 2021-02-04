namespace AgIO
{
    partial class FormCommSet
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
            this.btnCloseSerialModule1 = new System.Windows.Forms.Button();
            this.txtBoxRecvModule1 = new System.Windows.Forms.TextBox();
            this.cboxModule1Port = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblCurrentModule1Port = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblCurrentModule3Port = new System.Windows.Forms.Label();
            this.cboxModule3Port = new System.Windows.Forms.ComboBox();
            this.txtBoxRecvModule3 = new System.Windows.Forms.TextBox();
            this.btnCloseSerialModule3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCurrentModule2Port = new System.Windows.Forms.Label();
            this.cboxModule2Port = new System.Windows.Forms.ComboBox();
            this.txtBoxRecvModule2 = new System.Windows.Forms.TextBox();
            this.btnCloseSerialModule2 = new System.Windows.Forms.Button();
            this.btnOpenSerialModule2 = new System.Windows.Forms.Button();
            this.btnOpenSerialModule3 = new System.Windows.Forms.Button();
            this.btnSerialOK = new System.Windows.Forms.Button();
            this.btnOpenSerialModule1 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.btnRescan.FlatAppearance.BorderSize = 0;
            this.btnRescan.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRescan.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRescan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRescan.Location = new System.Drawing.Point(12, 445);
            this.btnRescan.Name = "btnRescan";
            this.btnRescan.Size = new System.Drawing.Size(156, 54);
            this.btnRescan.TabIndex = 58;
            this.btnRescan.Text = "Rescan Ports";
            this.btnRescan.UseVisualStyleBackColor = false;
            this.btnRescan.Click += new System.EventHandler(this.btnRescan_Click);
            // 
            // btnCloseSerialModule1
            // 
            this.btnCloseSerialModule1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCloseSerialModule1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCloseSerialModule1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseSerialModule1.Location = new System.Drawing.Point(336, 36);
            this.btnCloseSerialModule1.Name = "btnCloseSerialModule1";
            this.btnCloseSerialModule1.Size = new System.Drawing.Size(99, 40);
            this.btnCloseSerialModule1.TabIndex = 52;
            this.btnCloseSerialModule1.Text = "Disconnect";
            this.btnCloseSerialModule1.UseVisualStyleBackColor = false;
            this.btnCloseSerialModule1.Click += new System.EventHandler(this.btnCloseSerialModule1_Click);
            // 
            // txtBoxRecvModule1
            // 
            this.txtBoxRecvModule1.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxRecvModule1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txtBoxRecvModule1.Location = new System.Drawing.Point(195, 88);
            this.txtBoxRecvModule1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxRecvModule1.Name = "txtBoxRecvModule1";
            this.txtBoxRecvModule1.ReadOnly = true;
            this.txtBoxRecvModule1.Size = new System.Drawing.Size(240, 27);
            this.txtBoxRecvModule1.TabIndex = 63;
            // 
            // cboxModule1Port
            // 
            this.cboxModule1Port.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxModule1Port.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.cboxModule1Port.FormattingEnabled = true;
            this.cboxModule1Port.Location = new System.Drawing.Point(13, 39);
            this.cboxModule1Port.Name = "cboxModule1Port";
            this.cboxModule1Port.Size = new System.Drawing.Size(121, 37);
            this.cboxModule1Port.TabIndex = 64;
            this.cboxModule1Port.SelectedIndexChanged += new System.EventHandler(this.cboxModule1_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.lblCurrentModule1Port);
            this.groupBox2.Controls.Add(this.cboxModule1Port);
            this.groupBox2.Controls.Add(this.txtBoxRecvModule1);
            this.groupBox2.Controls.Add(this.btnOpenSerialModule1);
            this.groupBox2.Controls.Add(this.btnCloseSerialModule1);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(11, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(449, 126);
            this.groupBox2.TabIndex = 65;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Module 1";
            // 
            // lblCurrentModule1Port
            // 
            this.lblCurrentModule1Port.AutoSize = true;
            this.lblCurrentModule1Port.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentModule1Port.Location = new System.Drawing.Point(94, 81);
            this.lblCurrentModule1Port.Name = "lblCurrentModule1Port";
            this.lblCurrentModule1Port.Size = new System.Drawing.Size(40, 18);
            this.lblCurrentModule1Port.TabIndex = 65;
            this.lblCurrentModule1Port.Text = "Port";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.lblCurrentModule3Port);
            this.groupBox3.Controls.Add(this.cboxModule3Port);
            this.groupBox3.Controls.Add(this.txtBoxRecvModule3);
            this.groupBox3.Controls.Add(this.btnOpenSerialModule3);
            this.groupBox3.Controls.Add(this.btnCloseSerialModule3);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(11, 306);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(449, 126);
            this.groupBox3.TabIndex = 66;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Module 3";
            // 
            // lblCurrentModule3Port
            // 
            this.lblCurrentModule3Port.AutoSize = true;
            this.lblCurrentModule3Port.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentModule3Port.Location = new System.Drawing.Point(94, 85);
            this.lblCurrentModule3Port.Name = "lblCurrentModule3Port";
            this.lblCurrentModule3Port.Size = new System.Drawing.Size(40, 18);
            this.lblCurrentModule3Port.TabIndex = 66;
            this.lblCurrentModule3Port.Text = "Port";
            // 
            // cboxModule3Port
            // 
            this.cboxModule3Port.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboxModule3Port.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxModule3Port.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.cboxModule3Port.FormattingEnabled = true;
            this.cboxModule3Port.Location = new System.Drawing.Point(13, 42);
            this.cboxModule3Port.Name = "cboxModule3Port";
            this.cboxModule3Port.Size = new System.Drawing.Size(121, 37);
            this.cboxModule3Port.TabIndex = 64;
            this.cboxModule3Port.SelectedIndexChanged += new System.EventHandler(this.cboxModule3Port_SelectedIndexChanged);
            // 
            // txtBoxRecvModule3
            // 
            this.txtBoxRecvModule3.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxRecvModule3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txtBoxRecvModule3.Location = new System.Drawing.Point(195, 91);
            this.txtBoxRecvModule3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxRecvModule3.Name = "txtBoxRecvModule3";
            this.txtBoxRecvModule3.ReadOnly = true;
            this.txtBoxRecvModule3.Size = new System.Drawing.Size(240, 27);
            this.txtBoxRecvModule3.TabIndex = 63;
            // 
            // btnCloseSerialModule3
            // 
            this.btnCloseSerialModule3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCloseSerialModule3.FlatAppearance.BorderSize = 0;
            this.btnCloseSerialModule3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCloseSerialModule3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseSerialModule3.Location = new System.Drawing.Point(337, 39);
            this.btnCloseSerialModule3.Name = "btnCloseSerialModule3";
            this.btnCloseSerialModule3.Size = new System.Drawing.Size(99, 40);
            this.btnCloseSerialModule3.TabIndex = 52;
            this.btnCloseSerialModule3.Text = "Disconnect";
            this.btnCloseSerialModule3.UseVisualStyleBackColor = false;
            this.btnCloseSerialModule3.Click += new System.EventHandler(this.btnCloseSerialModule3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.lblCurrentModule2Port);
            this.groupBox1.Controls.Add(this.cboxModule2Port);
            this.groupBox1.Controls.Add(this.txtBoxRecvModule2);
            this.groupBox1.Controls.Add(this.btnOpenSerialModule2);
            this.groupBox1.Controls.Add(this.btnCloseSerialModule2);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(11, 159);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(449, 126);
            this.groupBox1.TabIndex = 66;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Module 2";
            // 
            // lblCurrentModule2Port
            // 
            this.lblCurrentModule2Port.AutoSize = true;
            this.lblCurrentModule2Port.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentModule2Port.Location = new System.Drawing.Point(94, 83);
            this.lblCurrentModule2Port.Name = "lblCurrentModule2Port";
            this.lblCurrentModule2Port.Size = new System.Drawing.Size(40, 18);
            this.lblCurrentModule2Port.TabIndex = 66;
            this.lblCurrentModule2Port.Text = "Port";
            // 
            // cboxModule2Port
            // 
            this.cboxModule2Port.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxModule2Port.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.cboxModule2Port.FormattingEnabled = true;
            this.cboxModule2Port.Location = new System.Drawing.Point(13, 39);
            this.cboxModule2Port.Name = "cboxModule2Port";
            this.cboxModule2Port.Size = new System.Drawing.Size(121, 37);
            this.cboxModule2Port.TabIndex = 64;
            this.cboxModule2Port.SelectedIndexChanged += new System.EventHandler(this.cboxModule2Port_SelectedIndexChanged);
            // 
            // txtBoxRecvModule2
            // 
            this.txtBoxRecvModule2.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxRecvModule2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txtBoxRecvModule2.Location = new System.Drawing.Point(195, 89);
            this.txtBoxRecvModule2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxRecvModule2.Name = "txtBoxRecvModule2";
            this.txtBoxRecvModule2.ReadOnly = true;
            this.txtBoxRecvModule2.Size = new System.Drawing.Size(240, 27);
            this.txtBoxRecvModule2.TabIndex = 63;
            // 
            // btnCloseSerialModule2
            // 
            this.btnCloseSerialModule2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCloseSerialModule2.FlatAppearance.BorderSize = 0;
            this.btnCloseSerialModule2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCloseSerialModule2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseSerialModule2.Location = new System.Drawing.Point(337, 36);
            this.btnCloseSerialModule2.Name = "btnCloseSerialModule2";
            this.btnCloseSerialModule2.Size = new System.Drawing.Size(99, 40);
            this.btnCloseSerialModule2.TabIndex = 52;
            this.btnCloseSerialModule2.Text = "Disconnect";
            this.btnCloseSerialModule2.UseVisualStyleBackColor = false;
            this.btnCloseSerialModule2.Click += new System.EventHandler(this.btnCloseSerialModule2_Click);
            // 
            // btnOpenSerialModule2
            // 
            this.btnOpenSerialModule2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnOpenSerialModule2.FlatAppearance.BorderSize = 0;
            this.btnOpenSerialModule2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnOpenSerialModule2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenSerialModule2.Location = new System.Drawing.Point(195, 36);
            this.btnOpenSerialModule2.Name = "btnOpenSerialModule2";
            this.btnOpenSerialModule2.Size = new System.Drawing.Size(93, 40);
            this.btnOpenSerialModule2.TabIndex = 53;
            this.btnOpenSerialModule2.Text = "Connect";
            this.btnOpenSerialModule2.UseVisualStyleBackColor = false;
            this.btnOpenSerialModule2.Click += new System.EventHandler(this.btnOpenSerialModule2_Click);
            // 
            // btnOpenSerialModule3
            // 
            this.btnOpenSerialModule3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnOpenSerialModule3.FlatAppearance.BorderSize = 0;
            this.btnOpenSerialModule3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnOpenSerialModule3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenSerialModule3.Location = new System.Drawing.Point(195, 39);
            this.btnOpenSerialModule3.Name = "btnOpenSerialModule3";
            this.btnOpenSerialModule3.Size = new System.Drawing.Size(93, 40);
            this.btnOpenSerialModule3.TabIndex = 53;
            this.btnOpenSerialModule3.Text = "Connect";
            this.btnOpenSerialModule3.UseVisualStyleBackColor = false;
            this.btnOpenSerialModule3.Click += new System.EventHandler(this.btnOpenSerialModule3_Click);
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
            this.btnSerialOK.Location = new System.Drawing.Point(303, 443);
            this.btnSerialOK.Name = "btnSerialOK";
            this.btnSerialOK.Size = new System.Drawing.Size(156, 57);
            this.btnSerialOK.TabIndex = 59;
            this.btnSerialOK.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSerialOK.UseVisualStyleBackColor = true;
            this.btnSerialOK.Click += new System.EventHandler(this.btnSerialOK_Click);
            // 
            // btnOpenSerialModule1
            // 
            this.btnOpenSerialModule1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnOpenSerialModule1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnOpenSerialModule1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenSerialModule1.Location = new System.Drawing.Point(195, 36);
            this.btnOpenSerialModule1.Name = "btnOpenSerialModule1";
            this.btnOpenSerialModule1.Size = new System.Drawing.Size(93, 40);
            this.btnOpenSerialModule1.TabIndex = 53;
            this.btnOpenSerialModule1.Text = "Connect";
            this.btnOpenSerialModule1.UseVisualStyleBackColor = false;
            this.btnOpenSerialModule1.Click += new System.EventHandler(this.btnOpenSerialModule1_Click);
            // 
            // FormCommSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(471, 512);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnRescan);
            this.Controls.Add(this.btnSerialOK);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormCommSet";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Connect Modules";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormCommSet_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnRescan;
        private System.Windows.Forms.Button btnSerialOK;
        private System.Windows.Forms.Button btnCloseSerialModule1;
        private System.Windows.Forms.Button btnOpenSerialModule1;
        private System.Windows.Forms.TextBox txtBoxRecvModule1;
        private System.Windows.Forms.ComboBox cboxModule1Port;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cboxModule3Port;
        private System.Windows.Forms.TextBox txtBoxRecvModule3;
        private System.Windows.Forms.Button btnOpenSerialModule3;
        private System.Windows.Forms.Button btnCloseSerialModule3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboxModule2Port;
        private System.Windows.Forms.TextBox txtBoxRecvModule2;
        private System.Windows.Forms.Button btnOpenSerialModule2;
        private System.Windows.Forms.Button btnCloseSerialModule2;
        private System.Windows.Forms.Label lblCurrentModule1Port;
        private System.Windows.Forms.Label lblCurrentModule3Port;
        private System.Windows.Forms.Label lblCurrentModule2Port;
    }
}