namespace AgOpenGPS
{
    partial class FormSteer
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
            this.btnFreeDrive = new System.Windows.Forms.Button();
            this.hsbarHighSteerPWM = new System.Windows.Forms.HScrollBar();
            this.hsbarMinPWM = new System.Windows.Forms.HScrollBar();
            this.hsbarProportionalGain = new System.Windows.Forms.HScrollBar();
            this.label45 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.hsbarLowSteerPWM = new System.Windows.Forms.HScrollBar();
            this.label7 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.lblMinPWM = new System.Windows.Forms.Label();
            this.lblHighSteerPWM = new System.Windows.Forms.Label();
            this.lblLowSteerPWM = new System.Windows.Forms.Label();
            this.lblProportionalGain = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.hsbarCountsPerDegree = new System.Windows.Forms.HScrollBar();
            this.label19 = new System.Windows.Forms.Label();
            this.hsbarMaxSteerAngle = new System.Windows.Forms.HScrollBar();
            this.label10 = new System.Windows.Forms.Label();
            this.hsbarWasOffset = new System.Windows.Forms.HScrollBar();
            this.lblCountsPerDegree = new System.Windows.Forms.Label();
            this.lblMaxSteerAngle = new System.Windows.Forms.Label();
            this.lblSteerAngleSensorZero = new System.Windows.Forms.Label();
            this.hsbarLookAheadUturnMult = new System.Windows.Forms.HScrollBar();
            this.label2 = new System.Windows.Forms.Label();
            this.hsbarLookAheadMin = new System.Windows.Forms.HScrollBar();
            this.hsbarDistanceFromLine = new System.Windows.Forms.HScrollBar();
            this.hsbarLookAhead = new System.Windows.Forms.HScrollBar();
            this.label37 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblLookAheadUturnMult = new System.Windows.Forms.Label();
            this.lblLookAhead = new System.Windows.Forms.Label();
            this.lblLookAheadMinimum = new System.Windows.Forms.Label();
            this.lblDistanceFromLine = new System.Windows.Forms.Label();
            this.btnStanley = new System.Windows.Forms.Button();
            this.hsbarHeadingErrorGain = new System.Windows.Forms.HScrollBar();
            this.lblStanleyGain = new System.Windows.Forms.Label();
            this.hsbarStanleyGain = new System.Windows.Forms.HScrollBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblHeadingErrorGain = new System.Windows.Forms.Label();
            this.hsbarIntegral = new System.Windows.Forms.HScrollBar();
            this.label15 = new System.Windows.Forms.Label();
            this.lblIntegralPercent = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblSteerAngle = new System.Windows.Forms.Label();
            this.lblRecd = new System.Windows.Forms.Label();
            this.lblSent = new System.Windows.Forms.Label();
            this.lblSteerAngleActual = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.btnFreeDriveZero = new System.Windows.Forms.Button();
            this.btnSteerAngleDown = new ProXoft.WinForms.RepeatButton();
            this.btnSteerAngleUp = new ProXoft.WinForms.RepeatButton();
            this.lblPWMDisplay = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.nudIntDistance = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label22 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabGain = new System.Windows.Forms.TabPage();
            this.tabSteer = new System.Windows.Forms.TabPage();
            this.tabStan = new System.Windows.Forms.TabPage();
            this.tabInt = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.nudIntDistance)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabGain.SuspendLayout();
            this.tabSteer.SuspendLayout();
            this.tabStan.SuspendLayout();
            this.tabInt.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFreeDrive
            // 
            this.btnFreeDrive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFreeDrive.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFreeDrive.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFreeDrive.Location = new System.Drawing.Point(4, 32);
            this.btnFreeDrive.Name = "btnFreeDrive";
            this.btnFreeDrive.Size = new System.Drawing.Size(69, 45);
            this.btnFreeDrive.TabIndex = 228;
            this.btnFreeDrive.Text = "Drive";
            this.btnFreeDrive.UseVisualStyleBackColor = true;
            this.btnFreeDrive.Click += new System.EventHandler(this.btnFreeDrive_Click);
            // 
            // hsbarHighSteerPWM
            // 
            this.hsbarHighSteerPWM.LargeChange = 2;
            this.hsbarHighSteerPWM.Location = new System.Drawing.Point(78, 102);
            this.hsbarHighSteerPWM.Maximum = 255;
            this.hsbarHighSteerPWM.Minimum = 1;
            this.hsbarHighSteerPWM.Name = "hsbarHighSteerPWM";
            this.hsbarHighSteerPWM.Size = new System.Drawing.Size(254, 30);
            this.hsbarHighSteerPWM.TabIndex = 274;
            this.hsbarHighSteerPWM.Value = 50;
            this.hsbarHighSteerPWM.ValueChanged += new System.EventHandler(this.hsbarHighSteerPWM_ValueChanged);
            // 
            // hsbarMinPWM
            // 
            this.hsbarMinPWM.LargeChange = 1;
            this.hsbarMinPWM.Location = new System.Drawing.Point(78, 234);
            this.hsbarMinPWM.Name = "hsbarMinPWM";
            this.hsbarMinPWM.Size = new System.Drawing.Size(254, 30);
            this.hsbarMinPWM.TabIndex = 284;
            this.hsbarMinPWM.Value = 10;
            this.hsbarMinPWM.ValueChanged += new System.EventHandler(this.hsbarMinPWM_ValueChanged);
            // 
            // hsbarProportionalGain
            // 
            this.hsbarProportionalGain.LargeChange = 1;
            this.hsbarProportionalGain.Location = new System.Drawing.Point(78, 36);
            this.hsbarProportionalGain.Maximum = 200;
            this.hsbarProportionalGain.Name = "hsbarProportionalGain";
            this.hsbarProportionalGain.Size = new System.Drawing.Size(254, 30);
            this.hsbarProportionalGain.TabIndex = 254;
            this.hsbarProportionalGain.Value = 4;
            this.hsbarProportionalGain.ValueChanged += new System.EventHandler(this.hsbarProportionalGain_ValueChanged);
            // 
            // label45
            // 
            this.label45.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label45.Location = new System.Drawing.Point(78, 70);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(222, 30);
            this.label45.TabIndex = 275;
            this.label45.Text = "High Max PWM";
            this.label45.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label41
            // 
            this.label41.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label41.Location = new System.Drawing.Point(78, 203);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(222, 30);
            this.label41.TabIndex = 285;
            this.label41.Text = "Minimum PWM Drive";
            this.label41.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hsbarLowSteerPWM
            // 
            this.hsbarLowSteerPWM.LargeChange = 1;
            this.hsbarLowSteerPWM.Location = new System.Drawing.Point(78, 168);
            this.hsbarLowSteerPWM.Maximum = 255;
            this.hsbarLowSteerPWM.Minimum = 1;
            this.hsbarLowSteerPWM.Name = "hsbarLowSteerPWM";
            this.hsbarLowSteerPWM.Size = new System.Drawing.Size(254, 30);
            this.hsbarLowSteerPWM.TabIndex = 269;
            this.hsbarLowSteerPWM.Value = 1;
            this.hsbarLowSteerPWM.ValueChanged += new System.EventHandler(this.hsbarLowSteerPWM_ValueChanged);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(78, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(222, 30);
            this.label7.TabIndex = 255;
            this.label7.Text = "Proportional Gain";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label33
            // 
            this.label33.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label33.Location = new System.Drawing.Point(78, 135);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(222, 30);
            this.label33.TabIndex = 270;
            this.label33.Text = "Low Max PWM";
            this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMinPWM
            // 
            this.lblMinPWM.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinPWM.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblMinPWM.Location = new System.Drawing.Point(7, 231);
            this.lblMinPWM.Name = "lblMinPWM";
            this.lblMinPWM.Size = new System.Drawing.Size(72, 35);
            this.lblMinPWM.TabIndex = 288;
            this.lblMinPWM.Text = "888";
            this.lblMinPWM.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHighSteerPWM
            // 
            this.lblHighSteerPWM.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighSteerPWM.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblHighSteerPWM.Location = new System.Drawing.Point(7, 100);
            this.lblHighSteerPWM.Name = "lblHighSteerPWM";
            this.lblHighSteerPWM.Size = new System.Drawing.Size(72, 35);
            this.lblHighSteerPWM.TabIndex = 278;
            this.lblHighSteerPWM.Text = "888";
            this.lblHighSteerPWM.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLowSteerPWM
            // 
            this.lblLowSteerPWM.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLowSteerPWM.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLowSteerPWM.Location = new System.Drawing.Point(7, 165);
            this.lblLowSteerPWM.Name = "lblLowSteerPWM";
            this.lblLowSteerPWM.Size = new System.Drawing.Size(72, 35);
            this.lblLowSteerPWM.TabIndex = 273;
            this.lblLowSteerPWM.Text = "888";
            this.lblLowSteerPWM.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblProportionalGain
            // 
            this.lblProportionalGain.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProportionalGain.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblProportionalGain.Location = new System.Drawing.Point(7, 33);
            this.lblProportionalGain.Name = "lblProportionalGain";
            this.lblProportionalGain.Size = new System.Drawing.Size(72, 35);
            this.lblProportionalGain.TabIndex = 258;
            this.lblProportionalGain.Text = "888";
            this.lblProportionalGain.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label25
            // 
            this.label25.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label25.Location = new System.Drawing.Point(87, 99);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(222, 30);
            this.label25.TabIndex = 305;
            this.label25.Text = "Counts per Degree";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hsbarCountsPerDegree
            // 
            this.hsbarCountsPerDegree.LargeChange = 1;
            this.hsbarCountsPerDegree.Location = new System.Drawing.Point(82, 132);
            this.hsbarCountsPerDegree.Maximum = 255;
            this.hsbarCountsPerDegree.Minimum = 1;
            this.hsbarCountsPerDegree.Name = "hsbarCountsPerDegree";
            this.hsbarCountsPerDegree.Size = new System.Drawing.Size(262, 30);
            this.hsbarCountsPerDegree.TabIndex = 304;
            this.hsbarCountsPerDegree.Value = 20;
            this.hsbarCountsPerDegree.ValueChanged += new System.EventHandler(this.hsbarCountsPerDegree_ValueChanged);
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label19.Location = new System.Drawing.Point(87, 180);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(222, 30);
            this.label19.TabIndex = 300;
            this.label19.Text = "Max Steer Angle ";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hsbarMaxSteerAngle
            // 
            this.hsbarMaxSteerAngle.LargeChange = 1;
            this.hsbarMaxSteerAngle.Location = new System.Drawing.Point(82, 213);
            this.hsbarMaxSteerAngle.Maximum = 80;
            this.hsbarMaxSteerAngle.Minimum = 10;
            this.hsbarMaxSteerAngle.Name = "hsbarMaxSteerAngle";
            this.hsbarMaxSteerAngle.Size = new System.Drawing.Size(262, 30);
            this.hsbarMaxSteerAngle.TabIndex = 299;
            this.hsbarMaxSteerAngle.Value = 10;
            this.hsbarMaxSteerAngle.ValueChanged += new System.EventHandler(this.hsbarMaxSteerAngle_ValueChanged);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(82, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(222, 30);
            this.label10.TabIndex = 295;
            this.label10.Text = "Wheel Angle Sensor Zero";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hsbarWasOffset
            // 
            this.hsbarWasOffset.LargeChange = 20;
            this.hsbarWasOffset.Location = new System.Drawing.Point(82, 51);
            this.hsbarWasOffset.Maximum = 4000;
            this.hsbarWasOffset.Minimum = -4000;
            this.hsbarWasOffset.Name = "hsbarWasOffset";
            this.hsbarWasOffset.Size = new System.Drawing.Size(262, 30);
            this.hsbarWasOffset.SmallChange = 2;
            this.hsbarWasOffset.TabIndex = 294;
            this.hsbarWasOffset.ValueChanged += new System.EventHandler(this.hsbarSteerAngleSensorZero_ValueChanged);
            // 
            // lblCountsPerDegree
            // 
            this.lblCountsPerDegree.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountsPerDegree.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCountsPerDegree.Location = new System.Drawing.Point(9, 127);
            this.lblCountsPerDegree.Name = "lblCountsPerDegree";
            this.lblCountsPerDegree.Size = new System.Drawing.Size(72, 35);
            this.lblCountsPerDegree.TabIndex = 308;
            this.lblCountsPerDegree.Text = "888";
            this.lblCountsPerDegree.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMaxSteerAngle
            // 
            this.lblMaxSteerAngle.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxSteerAngle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblMaxSteerAngle.Location = new System.Drawing.Point(8, 208);
            this.lblMaxSteerAngle.Name = "lblMaxSteerAngle";
            this.lblMaxSteerAngle.Size = new System.Drawing.Size(72, 35);
            this.lblMaxSteerAngle.TabIndex = 303;
            this.lblMaxSteerAngle.Text = "888";
            this.lblMaxSteerAngle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSteerAngleSensorZero
            // 
            this.lblSteerAngleSensorZero.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSteerAngleSensorZero.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSteerAngleSensorZero.Location = new System.Drawing.Point(3, 46);
            this.lblSteerAngleSensorZero.Name = "lblSteerAngleSensorZero";
            this.lblSteerAngleSensorZero.Size = new System.Drawing.Size(83, 35);
            this.lblSteerAngleSensorZero.TabIndex = 298;
            this.lblSteerAngleSensorZero.Text = "-5.88";
            this.lblSteerAngleSensorZero.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // hsbarLookAheadUturnMult
            // 
            this.hsbarLookAheadUturnMult.LargeChange = 1;
            this.hsbarLookAheadUturnMult.Location = new System.Drawing.Point(81, 246);
            this.hsbarLookAheadUturnMult.Maximum = 10;
            this.hsbarLookAheadUturnMult.Minimum = 1;
            this.hsbarLookAheadUturnMult.Name = "hsbarLookAheadUturnMult";
            this.hsbarLookAheadUturnMult.Size = new System.Drawing.Size(260, 30);
            this.hsbarLookAheadUturnMult.TabIndex = 298;
            this.hsbarLookAheadUturnMult.Value = 4;
            this.hsbarLookAheadUturnMult.ValueChanged += new System.EventHandler(this.hsbarLookAheadUturnMult_ValueChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(100, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 30);
            this.label2.TabIndex = 297;
            this.label2.Text = "UTurn Look Ahead (Multiplier)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // hsbarLookAheadMin
            // 
            this.hsbarLookAheadMin.LargeChange = 1;
            this.hsbarLookAheadMin.Location = new System.Drawing.Point(81, 175);
            this.hsbarLookAheadMin.Maximum = 50;
            this.hsbarLookAheadMin.Minimum = 2;
            this.hsbarLookAheadMin.Name = "hsbarLookAheadMin";
            this.hsbarLookAheadMin.Size = new System.Drawing.Size(260, 30);
            this.hsbarLookAheadMin.TabIndex = 272;
            this.hsbarLookAheadMin.Value = 10;
            this.hsbarLookAheadMin.ValueChanged += new System.EventHandler(this.hsbarLookAheadMin_ValueChanged);
            // 
            // hsbarDistanceFromLine
            // 
            this.hsbarDistanceFromLine.LargeChange = 1;
            this.hsbarDistanceFromLine.Location = new System.Drawing.Point(81, 104);
            this.hsbarDistanceFromLine.Maximum = 30;
            this.hsbarDistanceFromLine.Name = "hsbarDistanceFromLine";
            this.hsbarDistanceFromLine.Size = new System.Drawing.Size(260, 30);
            this.hsbarDistanceFromLine.TabIndex = 269;
            this.hsbarDistanceFromLine.Value = 10;
            this.hsbarDistanceFromLine.ValueChanged += new System.EventHandler(this.hsbarDistanceFromLine_ValueChanged);
            // 
            // hsbarLookAhead
            // 
            this.hsbarLookAhead.LargeChange = 1;
            this.hsbarLookAhead.Location = new System.Drawing.Point(81, 33);
            this.hsbarLookAhead.Maximum = 60;
            this.hsbarLookAhead.Minimum = 5;
            this.hsbarLookAhead.Name = "hsbarLookAhead";
            this.hsbarLookAhead.Size = new System.Drawing.Size(260, 30);
            this.hsbarLookAhead.TabIndex = 289;
            this.hsbarLookAhead.Value = 25;
            this.hsbarLookAhead.ValueChanged += new System.EventHandler(this.hsbarLookAhead_ValueChanged);
            // 
            // label37
            // 
            this.label37.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label37.Location = new System.Drawing.Point(100, 3);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(222, 30);
            this.label37.TabIndex = 290;
            this.label37.Text = "Look Ahead (Seconds)";
            this.label37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(100, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 30);
            this.label4.TabIndex = 273;
            this.label4.Text = "Look Ahead Offline Multiplier";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(100, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(222, 28);
            this.label6.TabIndex = 270;
            this.label6.Text = "Min Look Ahead (Meters)";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLookAheadUturnMult
            // 
            this.lblLookAheadUturnMult.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLookAheadUturnMult.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLookAheadUturnMult.Location = new System.Drawing.Point(8, 241);
            this.lblLookAheadUturnMult.Name = "lblLookAheadUturnMult";
            this.lblLookAheadUturnMult.Size = new System.Drawing.Size(72, 35);
            this.lblLookAheadUturnMult.TabIndex = 299;
            this.lblLookAheadUturnMult.Text = "888";
            this.lblLookAheadUturnMult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLookAhead
            // 
            this.lblLookAhead.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLookAhead.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLookAhead.Location = new System.Drawing.Point(10, 31);
            this.lblLookAhead.Name = "lblLookAhead";
            this.lblLookAhead.Size = new System.Drawing.Size(72, 35);
            this.lblLookAhead.TabIndex = 293;
            this.lblLookAhead.Text = "888";
            this.lblLookAhead.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLookAheadMinimum
            // 
            this.lblLookAheadMinimum.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLookAheadMinimum.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLookAheadMinimum.Location = new System.Drawing.Point(10, 170);
            this.lblLookAheadMinimum.Name = "lblLookAheadMinimum";
            this.lblLookAheadMinimum.Size = new System.Drawing.Size(72, 35);
            this.lblLookAheadMinimum.TabIndex = 274;
            this.lblLookAheadMinimum.Text = "888";
            this.lblLookAheadMinimum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDistanceFromLine
            // 
            this.lblDistanceFromLine.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistanceFromLine.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDistanceFromLine.Location = new System.Drawing.Point(10, 99);
            this.lblDistanceFromLine.Name = "lblDistanceFromLine";
            this.lblDistanceFromLine.Size = new System.Drawing.Size(72, 35);
            this.lblDistanceFromLine.TabIndex = 271;
            this.lblDistanceFromLine.Text = "888";
            this.lblDistanceFromLine.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnStanley
            // 
            this.btnStanley.BackColor = System.Drawing.Color.Transparent;
            this.btnStanley.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.btnStanley.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnStanley.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnStanley.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStanley.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStanley.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnStanley.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnStanley.Location = new System.Drawing.Point(27, 243);
            this.btnStanley.Name = "btnStanley";
            this.btnStanley.Size = new System.Drawing.Size(101, 47);
            this.btnStanley.TabIndex = 302;
            this.btnStanley.Text = "Stanley";
            this.btnStanley.UseVisualStyleBackColor = false;
            this.btnStanley.Click += new System.EventHandler(this.BtnStanley_Click);
            // 
            // hsbarHeadingErrorGain
            // 
            this.hsbarHeadingErrorGain.LargeChange = 1;
            this.hsbarHeadingErrorGain.Location = new System.Drawing.Point(81, 102);
            this.hsbarHeadingErrorGain.Maximum = 10;
            this.hsbarHeadingErrorGain.Minimum = 1;
            this.hsbarHeadingErrorGain.Name = "hsbarHeadingErrorGain";
            this.hsbarHeadingErrorGain.Size = new System.Drawing.Size(259, 30);
            this.hsbarHeadingErrorGain.TabIndex = 294;
            this.hsbarHeadingErrorGain.Value = 5;
            this.hsbarHeadingErrorGain.ValueChanged += new System.EventHandler(this.hsbarHeadingErrorGain_ValueChanged);
            // 
            // lblStanleyGain
            // 
            this.lblStanleyGain.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStanleyGain.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblStanleyGain.Location = new System.Drawing.Point(10, 31);
            this.lblStanleyGain.Name = "lblStanleyGain";
            this.lblStanleyGain.Size = new System.Drawing.Size(72, 35);
            this.lblStanleyGain.TabIndex = 299;
            this.lblStanleyGain.Text = "888";
            this.lblStanleyGain.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // hsbarStanleyGain
            // 
            this.hsbarStanleyGain.LargeChange = 1;
            this.hsbarStanleyGain.Location = new System.Drawing.Point(81, 33);
            this.hsbarStanleyGain.Maximum = 30;
            this.hsbarStanleyGain.Minimum = 1;
            this.hsbarStanleyGain.Name = "hsbarStanleyGain";
            this.hsbarStanleyGain.Size = new System.Drawing.Size(259, 30);
            this.hsbarStanleyGain.TabIndex = 297;
            this.hsbarStanleyGain.Value = 10;
            this.hsbarStanleyGain.ValueChanged += new System.EventHandler(this.hsbarStanleyGain_ValueChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(97, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 30);
            this.label3.TabIndex = 298;
            this.label3.Text = "Agressiveness";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(97, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(222, 30);
            this.label5.TabIndex = 296;
            this.label5.Text = "Heading";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHeadingErrorGain
            // 
            this.lblHeadingErrorGain.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeadingErrorGain.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblHeadingErrorGain.Location = new System.Drawing.Point(10, 95);
            this.lblHeadingErrorGain.Name = "lblHeadingErrorGain";
            this.lblHeadingErrorGain.Size = new System.Drawing.Size(72, 35);
            this.lblHeadingErrorGain.TabIndex = 295;
            this.lblHeadingErrorGain.Text = "888";
            this.lblHeadingErrorGain.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // hsbarIntegral
            // 
            this.hsbarIntegral.LargeChange = 1;
            this.hsbarIntegral.Location = new System.Drawing.Point(81, 171);
            this.hsbarIntegral.Name = "hsbarIntegral";
            this.hsbarIntegral.Size = new System.Drawing.Size(259, 30);
            this.hsbarIntegral.TabIndex = 297;
            this.hsbarIntegral.Value = 5;
            this.hsbarIntegral.ValueChanged += new System.EventHandler(this.hsbarIntegral_ValueChanged);
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label15.Location = new System.Drawing.Point(97, 139);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(222, 30);
            this.label15.TabIndex = 299;
            this.label15.Text = "Integral";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIntegralPercent
            // 
            this.lblIntegralPercent.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntegralPercent.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblIntegralPercent.Location = new System.Drawing.Point(10, 166);
            this.lblIntegralPercent.Name = "lblIntegralPercent";
            this.lblIntegralPercent.Size = new System.Drawing.Size(72, 35);
            this.lblIntegralPercent.TabIndex = 298;
            this.lblIntegralPercent.Text = "888";
            this.lblIntegralPercent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // lblSteerAngle
            // 
            this.lblSteerAngle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSteerAngle.BackColor = System.Drawing.Color.Transparent;
            this.lblSteerAngle.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSteerAngle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSteerAngle.Location = new System.Drawing.Point(172, 5);
            this.lblSteerAngle.Name = "lblSteerAngle";
            this.lblSteerAngle.Size = new System.Drawing.Size(79, 23);
            this.lblSteerAngle.TabIndex = 306;
            this.lblSteerAngle.Text = "-55.5";
            this.lblSteerAngle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRecd
            // 
            this.lblRecd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRecd.AutoSize = true;
            this.lblRecd.BackColor = System.Drawing.Color.Transparent;
            this.lblRecd.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblRecd.Location = new System.Drawing.Point(83, 82);
            this.lblRecd.Name = "lblRecd";
            this.lblRecd.Size = new System.Drawing.Size(32, 16);
            this.lblRecd.TabIndex = 309;
            this.lblRecd.Text = "255";
            this.lblRecd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSent
            // 
            this.lblSent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSent.AutoSize = true;
            this.lblSent.BackColor = System.Drawing.Color.Transparent;
            this.lblSent.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSent.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSent.Location = new System.Drawing.Point(45, 82);
            this.lblSent.Name = "lblSent";
            this.lblSent.Size = new System.Drawing.Size(32, 16);
            this.lblSent.TabIndex = 310;
            this.lblSent.Text = "255";
            this.lblSent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSteerAngleActual
            // 
            this.lblSteerAngleActual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSteerAngleActual.BackColor = System.Drawing.Color.Transparent;
            this.lblSteerAngleActual.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSteerAngleActual.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSteerAngleActual.Location = new System.Drawing.Point(44, 5);
            this.lblSteerAngleActual.Name = "lblSteerAngleActual";
            this.lblSteerAngleActual.Size = new System.Drawing.Size(70, 23);
            this.lblSteerAngleActual.TabIndex = 311;
            this.lblSteerAngleActual.Text = "-55.5";
            this.lblSteerAngleActual.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblError
            // 
            this.lblError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblError.BackColor = System.Drawing.Color.Transparent;
            this.lblError.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblError.Location = new System.Drawing.Point(302, 5);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(70, 23);
            this.lblError.TabIndex = 312;
            this.lblError.Text = "-30.0";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnFreeDriveZero
            // 
            this.btnFreeDriveZero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFreeDriveZero.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFreeDriveZero.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFreeDriveZero.Location = new System.Drawing.Point(295, 31);
            this.btnFreeDriveZero.Name = "btnFreeDriveZero";
            this.btnFreeDriveZero.Size = new System.Drawing.Size(69, 45);
            this.btnFreeDriveZero.TabIndex = 313;
            this.btnFreeDriveZero.Text = ">0<";
            this.btnFreeDriveZero.UseVisualStyleBackColor = true;
            this.btnFreeDriveZero.Click += new System.EventHandler(this.btnFreeDriveZero_Click);
            // 
            // btnSteerAngleDown
            // 
            this.btnSteerAngleDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSteerAngleDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSteerAngleDown.FlatAppearance.BorderSize = 0;
            this.btnSteerAngleDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSteerAngleDown.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSteerAngleDown.Image = global::AgOpenGPS.Properties.Resources.ArrowLeft;
            this.btnSteerAngleDown.Location = new System.Drawing.Point(101, 31);
            this.btnSteerAngleDown.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSteerAngleDown.Name = "btnSteerAngleDown";
            this.btnSteerAngleDown.Size = new System.Drawing.Size(69, 45);
            this.btnSteerAngleDown.TabIndex = 314;
            this.btnSteerAngleDown.UseVisualStyleBackColor = true;
            this.btnSteerAngleDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnSteerAngleDown_MouseDown);
            // 
            // btnSteerAngleUp
            // 
            this.btnSteerAngleUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSteerAngleUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSteerAngleUp.FlatAppearance.BorderSize = 0;
            this.btnSteerAngleUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSteerAngleUp.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSteerAngleUp.Image = global::AgOpenGPS.Properties.Resources.ArrowRight;
            this.btnSteerAngleUp.Location = new System.Drawing.Point(198, 31);
            this.btnSteerAngleUp.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSteerAngleUp.Name = "btnSteerAngleUp";
            this.btnSteerAngleUp.Size = new System.Drawing.Size(69, 45);
            this.btnSteerAngleUp.TabIndex = 315;
            this.btnSteerAngleUp.UseVisualStyleBackColor = true;
            this.btnSteerAngleUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnSteerAngleUp_MouseDown);
            // 
            // lblPWMDisplay
            // 
            this.lblPWMDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPWMDisplay.BackColor = System.Drawing.Color.Transparent;
            this.lblPWMDisplay.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPWMDisplay.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPWMDisplay.Location = new System.Drawing.Point(218, 79);
            this.lblPWMDisplay.Name = "lblPWMDisplay";
            this.lblPWMDisplay.Size = new System.Drawing.Size(64, 23);
            this.lblPWMDisplay.TabIndex = 316;
            this.lblPWMDisplay.Text = "255";
            this.lblPWMDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(8, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 16);
            this.label8.TabIndex = 317;
            this.label8.Text = "Chk:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(160, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 23);
            this.label9.TabIndex = 318;
            this.label9.Text = "PWM:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(4, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 23);
            this.label11.TabIndex = 319;
            this.label11.Text = "Act:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(124, 5);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 23);
            this.label12.TabIndex = 320;
            this.label12.Text = "Set:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label13.Location = new System.Drawing.Point(263, 5);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 23);
            this.label13.TabIndex = 321;
            this.label13.Text = "Err:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label14.Location = new System.Drawing.Point(322, 79);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 16);
            this.label14.TabIndex = 322;
            this.label14.Text = "Or +5";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label16.Location = new System.Drawing.Point(156, 217);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(147, 24);
            this.label16.TabIndex = 340;
            this.label16.Text = "Integral Starts (cm)";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudIntDistance
            // 
            this.nudIntDistance.BackColor = System.Drawing.Color.AliceBlue;
            this.nudIntDistance.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudIntDistance.InterceptArrowKeys = false;
            this.nudIntDistance.Location = new System.Drawing.Point(194, 244);
            this.nudIntDistance.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudIntDistance.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudIntDistance.Name = "nudIntDistance";
            this.nudIntDistance.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nudIntDistance.Size = new System.Drawing.Size(94, 46);
            this.nudIntDistance.TabIndex = 339;
            this.nudIntDistance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudIntDistance.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nudIntDistance.Enter += new System.EventHandler(this.nudIntDistance_Enter);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.panel1.Controls.Add(this.btnFreeDrive);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.lblRecd);
            this.panel1.Controls.Add(this.lblPWMDisplay);
            this.panel1.Controls.Add(this.lblSent);
            this.panel1.Controls.Add(this.btnSteerAngleDown);
            this.panel1.Controls.Add(this.lblSteerAngle);
            this.panel1.Controls.Add(this.btnSteerAngleUp);
            this.panel1.Controls.Add(this.lblSteerAngleActual);
            this.panel1.Controls.Add(this.btnFreeDriveZero);
            this.panel1.Controls.Add(this.lblError);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(2, 355);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 107);
            this.panel1.TabIndex = 323;
            // 
            // label22
            // 
            this.label22.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label22.Location = new System.Drawing.Point(45, 215);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(66, 25);
            this.label22.TabIndex = 346;
            this.label22.Text = "Mode";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.tabGain);
            this.tabControl1.Controls.Add(this.tabSteer);
            this.tabControl1.Controls.Add(this.tabStan);
            this.tabControl1.Controls.Add(this.tabInt);
            this.tabControl1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(89, 48);
            this.tabControl1.Location = new System.Drawing.Point(2, 1);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(368, 351);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 347;
            // 
            // tabGain
            // 
            this.tabGain.AutoScroll = true;
            this.tabGain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.tabGain.Controls.Add(this.hsbarMinPWM);
            this.tabGain.Controls.Add(this.hsbarLowSteerPWM);
            this.tabGain.Controls.Add(this.label45);
            this.tabGain.Controls.Add(this.label41);
            this.tabGain.Controls.Add(this.hsbarProportionalGain);
            this.tabGain.Controls.Add(this.label7);
            this.tabGain.Controls.Add(this.label33);
            this.tabGain.Controls.Add(this.lblLowSteerPWM);
            this.tabGain.Controls.Add(this.lblProportionalGain);
            this.tabGain.Controls.Add(this.lblHighSteerPWM);
            this.tabGain.Controls.Add(this.lblMinPWM);
            this.tabGain.Controls.Add(this.hsbarHighSteerPWM);
            this.tabGain.Location = new System.Drawing.Point(4, 52);
            this.tabGain.Name = "tabGain";
            this.tabGain.Size = new System.Drawing.Size(360, 295);
            this.tabGain.TabIndex = 13;
            this.tabGain.Text = "Gain";
            // 
            // tabSteer
            // 
            this.tabSteer.AutoScroll = true;
            this.tabSteer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.tabSteer.Controls.Add(this.label10);
            this.tabSteer.Controls.Add(this.hsbarCountsPerDegree);
            this.tabSteer.Controls.Add(this.hsbarMaxSteerAngle);
            this.tabSteer.Controls.Add(this.lblCountsPerDegree);
            this.tabSteer.Controls.Add(this.hsbarWasOffset);
            this.tabSteer.Controls.Add(this.lblSteerAngleSensorZero);
            this.tabSteer.Controls.Add(this.label25);
            this.tabSteer.Controls.Add(this.label19);
            this.tabSteer.Controls.Add(this.lblMaxSteerAngle);
            this.tabSteer.Location = new System.Drawing.Point(4, 52);
            this.tabSteer.Name = "tabSteer";
            this.tabSteer.Size = new System.Drawing.Size(361, 300);
            this.tabSteer.TabIndex = 5;
            this.tabSteer.Text = "Steer";
            // 
            // tabStan
            // 
            this.tabStan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.tabStan.Controls.Add(this.hsbarIntegral);
            this.tabStan.Controls.Add(this.label22);
            this.tabStan.Controls.Add(this.lblHeadingErrorGain);
            this.tabStan.Controls.Add(this.lblIntegralPercent);
            this.tabStan.Controls.Add(this.lblStanleyGain);
            this.tabStan.Controls.Add(this.btnStanley);
            this.tabStan.Controls.Add(this.label15);
            this.tabStan.Controls.Add(this.label5);
            this.tabStan.Controls.Add(this.label3);
            this.tabStan.Controls.Add(this.hsbarStanleyGain);
            this.tabStan.Controls.Add(this.hsbarHeadingErrorGain);
            this.tabStan.Controls.Add(this.nudIntDistance);
            this.tabStan.Controls.Add(this.label16);
            this.tabStan.Location = new System.Drawing.Point(4, 52);
            this.tabStan.Name = "tabStan";
            this.tabStan.Size = new System.Drawing.Size(361, 300);
            this.tabStan.TabIndex = 15;
            this.tabStan.Text = "Stanley";
            // 
            // tabInt
            // 
            this.tabInt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.tabInt.Controls.Add(this.hsbarLookAheadUturnMult);
            this.tabInt.Controls.Add(this.lblDistanceFromLine);
            this.tabInt.Controls.Add(this.lblLookAheadMinimum);
            this.tabInt.Controls.Add(this.lblLookAhead);
            this.tabInt.Controls.Add(this.lblLookAheadUturnMult);
            this.tabInt.Controls.Add(this.hsbarLookAheadMin);
            this.tabInt.Controls.Add(this.label6);
            this.tabInt.Controls.Add(this.hsbarDistanceFromLine);
            this.tabInt.Controls.Add(this.label4);
            this.tabInt.Controls.Add(this.hsbarLookAhead);
            this.tabInt.Controls.Add(this.label37);
            this.tabInt.Controls.Add(this.label2);
            this.tabInt.Location = new System.Drawing.Point(4, 52);
            this.tabInt.Name = "tabInt";
            this.tabInt.Size = new System.Drawing.Size(361, 300);
            this.tabInt.TabIndex = 16;
            this.tabInt.Text = "PureP";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(2, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(368, 462);
            this.panel2.TabIndex = 348;
            // 
            // FormSteer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(372, 464);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(380, 200);
            this.Name = "FormSteer";
            this.Padding = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Auto Steer Configuration";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSteer_FormClosing);
            this.Load += new System.EventHandler(this.FormSteer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudIntDistance)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabGain.ResumeLayout(false);
            this.tabSteer.ResumeLayout(false);
            this.tabStan.ResumeLayout(false);
            this.tabInt.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnFreeDrive;
        private System.Windows.Forms.Label lblHighSteerPWM;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.HScrollBar hsbarHighSteerPWM;
        private System.Windows.Forms.Label lblLowSteerPWM;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.HScrollBar hsbarLowSteerPWM;
        private System.Windows.Forms.Label lblProportionalGain;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.HScrollBar hsbarProportionalGain;
        private System.Windows.Forms.Label lblLookAhead;
        private System.Windows.Forms.HScrollBar hsbarLookAhead;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label lblMinPWM;
        private System.Windows.Forms.HScrollBar hsbarMinPWM;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label lblCountsPerDegree;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.HScrollBar hsbarCountsPerDegree;
        private System.Windows.Forms.Label lblMaxSteerAngle;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.HScrollBar hsbarMaxSteerAngle;
        private System.Windows.Forms.Label lblSteerAngleSensorZero;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.HScrollBar hsbarWasOffset;
        private System.Windows.Forms.HScrollBar hsbarLookAheadMin;
        private System.Windows.Forms.HScrollBar hsbarDistanceFromLine;
        private System.Windows.Forms.Label lblLookAheadMinimum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDistanceFromLine;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.HScrollBar hsbarLookAheadUturnMult;
        private System.Windows.Forms.Label lblLookAheadUturnMult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.HScrollBar hsbarHeadingErrorGain;
        private System.Windows.Forms.Label lblStanleyGain;
        private System.Windows.Forms.HScrollBar hsbarStanleyGain;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblHeadingErrorGain;
        private System.Windows.Forms.Button btnStanley;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblSteerAngle;
        private System.Windows.Forms.Label lblRecd;
        private System.Windows.Forms.Label lblSent;
        private System.Windows.Forms.Label lblSteerAngleActual;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnFreeDriveZero;
        private ProXoft.WinForms.RepeatButton btnSteerAngleDown;
        private ProXoft.WinForms.RepeatButton btnSteerAngleUp;
        private System.Windows.Forms.Label lblPWMDisplay;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.HScrollBar hsbarIntegral;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblIntegralPercent;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown nudIntDistance;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabGain;
        private System.Windows.Forms.TabPage tabSteer;
        private System.Windows.Forms.TabPage tabStan;
        private System.Windows.Forms.TabPage tabInt;
        private System.Windows.Forms.Panel panel2;
    }
}