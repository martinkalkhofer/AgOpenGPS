namespace AgOpenGPS
{
    partial class FormConfig
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
            this.panelLeftSideMenu = new System.Windows.Forms.Panel();
            this.panelArduino = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnMachineModule = new System.Windows.Forms.Button();
            this.btnSteerModule = new System.Windows.Forms.Button();
            this.btnArduino = new System.Windows.Forms.Button();
            this.btnUTurn = new System.Windows.Forms.Button();
            this.panelDataSourcesSubMenu = new System.Windows.Forms.Panel();
            this.btnSubRoll = new System.Windows.Forms.Button();
            this.btnSubHeading = new System.Windows.Forms.Button();
            this.btnSubFix = new System.Windows.Forms.Button();
            this.btnDataSources = new System.Windows.Forms.Button();
            this.panelToolSubMenu = new System.Windows.Forms.Panel();
            this.btnSubSwitches = new System.Windows.Forms.Button();
            this.btnSubToolSettings = new System.Windows.Forms.Button();
            this.btnSubSections = new System.Windows.Forms.Button();
            this.btnSubHitch = new System.Windows.Forms.Button();
            this.btnSubToolConfig = new System.Windows.Forms.Button();
            this.btnTool = new System.Windows.Forms.Button();
            this.panelVehicleSubMenu = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSubGuidance = new System.Windows.Forms.Button();
            this.btnSubDimensions = new System.Windows.Forms.Button();
            this.btnSubAntenna = new System.Windows.Forms.Button();
            this.btnSubVehicleConfig = new System.Windows.Forms.Button();
            this.btnVehicle = new System.Windows.Forms.Button();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.tab1 = new System.Windows.Forms.TabControl();
            this.tabSummary = new System.Windows.Forms.TabPage();
            this.btnVehicleSave = new System.Windows.Forms.Button();
            this.btnVehicleLoad = new System.Windows.Forms.Button();
            this.btnVehicleDelete = new System.Windows.Forms.Button();
            this.lvVehicles = new System.Windows.Forms.ListView();
            this.chVehicle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.tboxVehicleNameSave = new System.Windows.Forms.TextBox();
            this.lblCurrentVehicle = new System.Windows.Forms.Label();
            this.btnVehicleSaveAs = new System.Windows.Forms.Button();
            this.lblSumFixType = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.lblSumNumSections = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.lblSumToolWidth = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.lblSumWheelbase = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.tabVConfig = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnHarvester = new System.Windows.Forms.RadioButton();
            this.rbtn4WD = new System.Windows.Forms.RadioButton();
            this.rbtnTractor = new System.Windows.Forms.RadioButton();
            this.tabVAntenna = new System.Windows.Forms.TabPage();
            this.btnNext = new System.Windows.Forms.Button();
            this.nudAntennaHeight = new System.Windows.Forms.NumericUpDown();
            this.nudAntennaPivot = new System.Windows.Forms.NumericUpDown();
            this.nudAntennaOffset = new System.Windows.Forms.NumericUpDown();
            this.pboxAntenna = new System.Windows.Forms.PictureBox();
            this.tabVDimensions = new System.Windows.Forms.TabPage();
            this.label53 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.btnNextDim = new System.Windows.Forms.Button();
            this.nudWheelbase = new System.Windows.Forms.NumericUpDown();
            this.nudMinTurnRadius = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabVGuidance = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.nudLineWidth = new System.Windows.Forms.NumericUpDown();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.cboxAutoSteerAuto = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nudLightbarCmPerPixel = new System.Windows.Forms.NumericUpDown();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.nudSnapDistance = new System.Windows.Forms.NumericUpDown();
            this.tabTConfig = new System.Windows.Forms.TabPage();
            this.gboxAttachment = new System.Windows.Forms.GroupBox();
            this.rbtnTBT = new System.Windows.Forms.RadioButton();
            this.rbtnFixedRear = new System.Windows.Forms.RadioButton();
            this.rbtnFront = new System.Windows.Forms.RadioButton();
            this.rbtnTrailing = new System.Windows.Forms.RadioButton();
            this.tabTHitch = new System.Windows.Forms.TabPage();
            this.btnNext2 = new System.Windows.Forms.Button();
            this.nudTrailingHitchLength = new System.Windows.Forms.NumericUpDown();
            this.nudDrawbarLength = new System.Windows.Forms.NumericUpDown();
            this.nudTankHitch = new System.Windows.Forms.NumericUpDown();
            this.picboxToolHitch = new System.Windows.Forms.PictureBox();
            this.tabTSections = new System.Windows.Forms.TabPage();
            this.btnNext4 = new System.Windows.Forms.Button();
            this.nudCutoffSpeed = new System.Windows.Forms.NumericUpDown();
            this.label42 = new System.Windows.Forms.Label();
            this.lblTurnOffBelowUnits = new System.Windows.Forms.Label();
            this.lblInchesCm = new System.Windows.Forms.Label();
            this.lblDoNotExceed = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.nudDefaultSectionWidth = new System.Windows.Forms.NumericUpDown();
            this.cboxNumSections = new System.Windows.Forms.ComboBox();
            this.lblVehicleToolWidth = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.nudMinApplied = new System.Windows.Forms.NumericUpDown();
            this.label51 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudSection16 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.nudSection15 = new System.Windows.Forms.NumericUpDown();
            this.nudSection14 = new System.Windows.Forms.NumericUpDown();
            this.nudSection13 = new System.Windows.Forms.NumericUpDown();
            this.label32 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.nudSection12 = new System.Windows.Forms.NumericUpDown();
            this.nudSection11 = new System.Windows.Forms.NumericUpDown();
            this.nudSection10 = new System.Windows.Forms.NumericUpDown();
            this.nudSection9 = new System.Windows.Forms.NumericUpDown();
            this.nudSection8 = new System.Windows.Forms.NumericUpDown();
            this.nudSection7 = new System.Windows.Forms.NumericUpDown();
            this.nudSection6 = new System.Windows.Forms.NumericUpDown();
            this.nudSection5 = new System.Windows.Forms.NumericUpDown();
            this.nudSection4 = new System.Windows.Forms.NumericUpDown();
            this.nudSection3 = new System.Windows.Forms.NumericUpDown();
            this.nudSection2 = new System.Windows.Forms.NumericUpDown();
            this.nudSection1 = new System.Windows.Forms.NumericUpDown();
            this.tabTSwitches = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkWorkSwitchManual = new System.Windows.Forms.CheckBox();
            this.chkWorkSwActiveLow = new System.Windows.Forms.CheckBox();
            this.chkEnableWorkSwitch = new System.Windows.Forms.CheckBox();
            this.tabTSettings = new System.Windows.Forms.TabPage();
            this.label69 = new System.Windows.Forms.Label();
            this.nudHydLiftLookAhead = new System.Windows.Forms.NumericUpDown();
            this.btnNext3 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.nudLookAheadOff = new System.Windows.Forms.NumericUpDown();
            this.nudOffset = new System.Windows.Forms.NumericUpDown();
            this.label43 = new System.Windows.Forms.Label();
            this.nudTurnOffDelay = new System.Windows.Forms.NumericUpDown();
            this.label44 = new System.Windows.Forms.Label();
            this.nudLookAhead = new System.Windows.Forms.NumericUpDown();
            this.nudOverlap = new System.Windows.Forms.NumericUpDown();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tabDFix = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.cboxIsRTK = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbtnOGI = new System.Windows.Forms.RadioButton();
            this.rbtnRMC = new System.Windows.Forms.RadioButton();
            this.rbtnGGA = new System.Windows.Forms.RadioButton();
            this.lblSimGGA = new System.Windows.Forms.Label();
            this.tabDHeading = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nudStartSpeed = new System.Windows.Forms.NumericUpDown();
            this.nudMinFixStepDistance = new System.Windows.Forms.NumericUpDown();
            this.lblFusionIMU = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.hsbarFusion = new System.Windows.Forms.HScrollBar();
            this.lblIMUFusion = new System.Windows.Forms.Label();
            this.lblFusion = new System.Windows.Forms.Label();
            this.headingGroupBox = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.rbtnHeadingHDT = new System.Windows.Forms.RadioButton();
            this.rbtnHeadingGPS = new System.Windows.Forms.RadioButton();
            this.rbtnHeadingFix = new System.Windows.Forms.RadioButton();
            this.tabDRoll = new System.Windows.Forms.TabPage();
            this.cboxDataInvertRoll = new System.Windows.Forms.CheckBox();
            this.btnResetIMU = new System.Windows.Forms.Button();
            this.btnRollZero = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnRemoveZeroOffsetPitch = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.btnZeroPitch = new System.Windows.Forms.Button();
            this.btnRemoveZeroOffset = new System.Windows.Forms.Button();
            this.lblRollZeroOffset = new System.Windows.Forms.Label();
            this.btnZeroRoll = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.lblRollFilterPercent = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.hsbarRollFilter = new System.Windows.Forms.HScrollBar();
            this.tabUTurn = new System.Windows.Forms.TabPage();
            this.btnTurnSmoothingUp = new ProXoft.WinForms.RepeatButton();
            this.btnTurnSmoothingDown = new ProXoft.WinForms.RepeatButton();
            this.label59 = new System.Windows.Forms.Label();
            this.lblSmoothing = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnYouTurnWideReturn = new System.Windows.Forms.Button();
            this.btnYouTurnKeyHole = new System.Windows.Forms.Button();
            this.btnYouTurnSemiCircle = new System.Windows.Forms.Button();
            this.btnYouTurnRecord = new System.Windows.Forms.Button();
            this.btnYouTurnCustom = new System.Windows.Forms.Button();
            this.lblTriggerDistance = new System.Windows.Forms.Label();
            this.lblWhenTrig = new System.Windows.Forms.Label();
            this.btnIsUsingDubins = new System.Windows.Forms.Button();
            this.lblDistance = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.btnTriggerDistanceDn = new ProXoft.WinForms.RepeatButton();
            this.btnTriggerDistanceUp = new ProXoft.WinForms.RepeatButton();
            this.btnDistanceUp = new ProXoft.WinForms.RepeatButton();
            this.btnDistanceDn = new ProXoft.WinForms.RepeatButton();
            this.tabASteer = new System.Windows.Forms.TabPage();
            this.chkSteerInvertRelays = new System.Windows.Forms.CheckBox();
            this.label68 = new System.Windows.Forms.Label();
            this.cboxMotorDrive = new System.Windows.Forms.ComboBox();
            this.cboxSteerEnable = new System.Windows.Forms.ComboBox();
            this.label62 = new System.Windows.Forms.Label();
            this.cboxConv = new System.Windows.Forms.ComboBox();
            this.label63 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.nudAckerman = new System.Windows.Forms.NumericUpDown();
            this.label61 = new System.Windows.Forms.Label();
            this.nudMaxCounts = new System.Windows.Forms.NumericUpDown();
            this.chkInvertSteer = new System.Windows.Forms.CheckBox();
            this.cboxEncoder = new System.Windows.Forms.CheckBox();
            this.chkInvertWAS = new System.Windows.Forms.CheckBox();
            this.label55 = new System.Windows.Forms.Label();
            this.btnSendSteerConfigPGN = new System.Windows.Forms.Button();
            this.tabAMachine = new System.Windows.Forms.TabPage();
            this.label67 = new System.Windows.Forms.Label();
            this.cboxMachInvertRelays = new System.Windows.Forms.CheckBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.nudLowerTime = new System.Windows.Forms.NumericUpDown();
            this.nudRaiseTime = new System.Windows.Forms.NumericUpDown();
            this.label65 = new System.Windows.Forms.Label();
            this.cboxIsHydOn = new System.Windows.Forms.CheckBox();
            this.label66 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.btnSendMachinePGN = new System.Windows.Forms.Button();
            this.lblSecTotalWidthMeters = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.lblSecTotalWidthFeet = new System.Windows.Forms.Label();
            this.lblSecTotalWidthInches = new System.Windows.Forms.Label();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnOK = new System.Windows.Forms.Button();
            this.panelLeftSideMenu.SuspendLayout();
            this.panelArduino.SuspendLayout();
            this.panelDataSourcesSubMenu.SuspendLayout();
            this.panelToolSubMenu.SuspendLayout();
            this.panelVehicleSubMenu.SuspendLayout();
            this.panelChildForm.SuspendLayout();
            this.tab1.SuspendLayout();
            this.tabSummary.SuspendLayout();
            this.tabVConfig.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabVAntenna.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAntennaHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAntennaPivot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAntennaOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxAntenna)).BeginInit();
            this.tabVDimensions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWheelbase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinTurnRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabVGuidance.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLineWidth)).BeginInit();
            this.groupBox9.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLightbarCmPerPixel)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSnapDistance)).BeginInit();
            this.tabTConfig.SuspendLayout();
            this.gboxAttachment.SuspendLayout();
            this.tabTHitch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTrailingHitchLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDrawbarLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTankHitch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxToolHitch)).BeginInit();
            this.tabTSections.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCutoffSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDefaultSectionWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinApplied)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSection16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSection15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSection14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSection13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSection12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSection11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSection10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSection9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSection8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSection7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSection6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSection5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSection4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSection3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSection2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSection1)).BeginInit();
            this.tabTSwitches.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabTSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHydLiftLookAhead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLookAheadOff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTurnOffDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLookAhead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOverlap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.tabDFix.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabDHeading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStartSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinFixStepDistance)).BeginInit();
            this.headingGroupBox.SuspendLayout();
            this.tabDRoll.SuspendLayout();
            this.btnRollZero.SuspendLayout();
            this.tabUTurn.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.tabASteer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAckerman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxCounts)).BeginInit();
            this.tabAMachine.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLowerTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRaiseTime)).BeginInit();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeftSideMenu
            // 
            this.panelLeftSideMenu.AutoScroll = true;
            this.panelLeftSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.panelLeftSideMenu.Controls.Add(this.panelArduino);
            this.panelLeftSideMenu.Controls.Add(this.btnArduino);
            this.panelLeftSideMenu.Controls.Add(this.btnUTurn);
            this.panelLeftSideMenu.Controls.Add(this.panelDataSourcesSubMenu);
            this.panelLeftSideMenu.Controls.Add(this.btnDataSources);
            this.panelLeftSideMenu.Controls.Add(this.panelToolSubMenu);
            this.panelLeftSideMenu.Controls.Add(this.btnTool);
            this.panelLeftSideMenu.Controls.Add(this.panelVehicleSubMenu);
            this.panelLeftSideMenu.Controls.Add(this.btnVehicle);
            this.panelLeftSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftSideMenu.Location = new System.Drawing.Point(2, 2);
            this.panelLeftSideMenu.Name = "panelLeftSideMenu";
            this.panelLeftSideMenu.Size = new System.Drawing.Size(201, 708);
            this.panelLeftSideMenu.TabIndex = 110;
            // 
            // panelArduino
            // 
            this.panelArduino.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelArduino.Controls.Add(this.button2);
            this.panelArduino.Controls.Add(this.btn3);
            this.panelArduino.Controls.Add(this.btnMachineModule);
            this.panelArduino.Controls.Add(this.btnSteerModule);
            this.panelArduino.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelArduino.Location = new System.Drawing.Point(0, 535);
            this.panelArduino.Name = "panelArduino";
            this.panelArduino.Size = new System.Drawing.Size(201, 89);
            this.panelArduino.TabIndex = 116;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(64)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Image = global::AgOpenGPS.Properties.Resources.DataSources;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(-9, 186);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(201, 75);
            this.button2.TabIndex = 115;
            this.button2.Text = "Module";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btn3.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn3.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn3.FlatAppearance.BorderSize = 0;
            this.btn3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btn3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn3.Location = new System.Drawing.Point(0, 50);
            this.btn3.Name = "btn3";
            this.btn3.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn3.Size = new System.Drawing.Size(201, 25);
            this.btn3.TabIndex = 0;
            this.btn3.Text = "Btn3";
            this.btn3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn3.UseVisualStyleBackColor = false;
            // 
            // btnMachineModule
            // 
            this.btnMachineModule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnMachineModule.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMachineModule.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnMachineModule.FlatAppearance.BorderSize = 0;
            this.btnMachineModule.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnMachineModule.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnMachineModule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMachineModule.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMachineModule.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMachineModule.Location = new System.Drawing.Point(0, 25);
            this.btnMachineModule.Name = "btnMachineModule";
            this.btnMachineModule.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnMachineModule.Size = new System.Drawing.Size(201, 25);
            this.btnMachineModule.TabIndex = 1;
            this.btnMachineModule.Text = "Machine";
            this.btnMachineModule.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMachineModule.UseVisualStyleBackColor = false;
            this.btnMachineModule.Click += new System.EventHandler(this.btnMachineModule_Click);
            // 
            // btnSteerModule
            // 
            this.btnSteerModule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnSteerModule.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSteerModule.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnSteerModule.FlatAppearance.BorderSize = 0;
            this.btnSteerModule.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnSteerModule.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnSteerModule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSteerModule.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSteerModule.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSteerModule.Location = new System.Drawing.Point(0, 0);
            this.btnSteerModule.Name = "btnSteerModule";
            this.btnSteerModule.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSteerModule.Size = new System.Drawing.Size(201, 25);
            this.btnSteerModule.TabIndex = 2;
            this.btnSteerModule.Text = "Steer";
            this.btnSteerModule.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSteerModule.UseVisualStyleBackColor = false;
            this.btnSteerModule.Click += new System.EventHandler(this.btnSteerModule_Click);
            // 
            // btnArduino
            // 
            this.btnArduino.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(64)))));
            this.btnArduino.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnArduino.FlatAppearance.BorderSize = 0;
            this.btnArduino.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnArduino.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnArduino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArduino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArduino.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnArduino.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnArduino.Location = new System.Drawing.Point(0, 497);
            this.btnArduino.Name = "btnArduino";
            this.btnArduino.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnArduino.Size = new System.Drawing.Size(201, 38);
            this.btnArduino.TabIndex = 115;
            this.btnArduino.Text = "Module";
            this.btnArduino.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnArduino.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnArduino.UseVisualStyleBackColor = false;
            this.btnArduino.Click += new System.EventHandler(this.btnArduino_Click);
            // 
            // btnUTurn
            // 
            this.btnUTurn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(64)))));
            this.btnUTurn.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUTurn.FlatAppearance.BorderSize = 0;
            this.btnUTurn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnUTurn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnUTurn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUTurn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUTurn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUTurn.Location = new System.Drawing.Point(0, 459);
            this.btnUTurn.Name = "btnUTurn";
            this.btnUTurn.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnUTurn.Size = new System.Drawing.Size(201, 38);
            this.btnUTurn.TabIndex = 116;
            this.btnUTurn.Text = "UTurn";
            this.btnUTurn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUTurn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUTurn.UseVisualStyleBackColor = false;
            this.btnUTurn.Click += new System.EventHandler(this.btnUTurn_Click);
            // 
            // panelDataSourcesSubMenu
            // 
            this.panelDataSourcesSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelDataSourcesSubMenu.Controls.Add(this.btnSubRoll);
            this.panelDataSourcesSubMenu.Controls.Add(this.btnSubHeading);
            this.panelDataSourcesSubMenu.Controls.Add(this.btnSubFix);
            this.panelDataSourcesSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDataSourcesSubMenu.Location = new System.Drawing.Point(0, 366);
            this.panelDataSourcesSubMenu.Name = "panelDataSourcesSubMenu";
            this.panelDataSourcesSubMenu.Size = new System.Drawing.Size(201, 93);
            this.panelDataSourcesSubMenu.TabIndex = 7;
            // 
            // btnSubRoll
            // 
            this.btnSubRoll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnSubRoll.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubRoll.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnSubRoll.FlatAppearance.BorderSize = 0;
            this.btnSubRoll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnSubRoll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnSubRoll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubRoll.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubRoll.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSubRoll.Location = new System.Drawing.Point(0, 50);
            this.btnSubRoll.Name = "btnSubRoll";
            this.btnSubRoll.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSubRoll.Size = new System.Drawing.Size(201, 25);
            this.btnSubRoll.TabIndex = 0;
            this.btnSubRoll.Text = "Roll";
            this.btnSubRoll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubRoll.UseVisualStyleBackColor = false;
            this.btnSubRoll.Click += new System.EventHandler(this.btnSubRoll_Click);
            // 
            // btnSubHeading
            // 
            this.btnSubHeading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnSubHeading.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubHeading.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnSubHeading.FlatAppearance.BorderSize = 0;
            this.btnSubHeading.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnSubHeading.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnSubHeading.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubHeading.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubHeading.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSubHeading.Location = new System.Drawing.Point(0, 25);
            this.btnSubHeading.Name = "btnSubHeading";
            this.btnSubHeading.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSubHeading.Size = new System.Drawing.Size(201, 25);
            this.btnSubHeading.TabIndex = 1;
            this.btnSubHeading.Text = "Heading";
            this.btnSubHeading.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubHeading.UseVisualStyleBackColor = false;
            this.btnSubHeading.Click += new System.EventHandler(this.btnSubHeading_Click);
            // 
            // btnSubFix
            // 
            this.btnSubFix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnSubFix.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubFix.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnSubFix.FlatAppearance.BorderSize = 0;
            this.btnSubFix.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnSubFix.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnSubFix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubFix.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubFix.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSubFix.Location = new System.Drawing.Point(0, 0);
            this.btnSubFix.Name = "btnSubFix";
            this.btnSubFix.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSubFix.Size = new System.Drawing.Size(201, 25);
            this.btnSubFix.TabIndex = 2;
            this.btnSubFix.Text = "Fix Source";
            this.btnSubFix.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubFix.UseVisualStyleBackColor = false;
            this.btnSubFix.Click += new System.EventHandler(this.btnSubFix_Click);
            // 
            // btnDataSources
            // 
            this.btnDataSources.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(64)))));
            this.btnDataSources.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDataSources.FlatAppearance.BorderSize = 0;
            this.btnDataSources.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnDataSources.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnDataSources.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDataSources.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDataSources.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDataSources.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDataSources.Location = new System.Drawing.Point(0, 328);
            this.btnDataSources.Name = "btnDataSources";
            this.btnDataSources.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnDataSources.Size = new System.Drawing.Size(201, 38);
            this.btnDataSources.TabIndex = 114;
            this.btnDataSources.Text = "Sources";
            this.btnDataSources.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDataSources.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDataSources.UseVisualStyleBackColor = false;
            this.btnDataSources.Click += new System.EventHandler(this.btnDataSources_Click);
            // 
            // panelToolSubMenu
            // 
            this.panelToolSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelToolSubMenu.Controls.Add(this.btnSubSwitches);
            this.panelToolSubMenu.Controls.Add(this.btnSubToolSettings);
            this.panelToolSubMenu.Controls.Add(this.btnSubSections);
            this.panelToolSubMenu.Controls.Add(this.btnSubHitch);
            this.panelToolSubMenu.Controls.Add(this.btnSubToolConfig);
            this.panelToolSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelToolSubMenu.Location = new System.Drawing.Point(0, 189);
            this.panelToolSubMenu.Name = "panelToolSubMenu";
            this.panelToolSubMenu.Size = new System.Drawing.Size(201, 139);
            this.panelToolSubMenu.TabIndex = 4;
            // 
            // btnSubSwitches
            // 
            this.btnSubSwitches.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnSubSwitches.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubSwitches.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnSubSwitches.FlatAppearance.BorderSize = 0;
            this.btnSubSwitches.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnSubSwitches.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnSubSwitches.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubSwitches.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubSwitches.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSubSwitches.Location = new System.Drawing.Point(0, 100);
            this.btnSubSwitches.Name = "btnSubSwitches";
            this.btnSubSwitches.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSubSwitches.Size = new System.Drawing.Size(201, 25);
            this.btnSubSwitches.TabIndex = 1;
            this.btnSubSwitches.Text = "Switches";
            this.btnSubSwitches.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubSwitches.UseVisualStyleBackColor = false;
            this.btnSubSwitches.Click += new System.EventHandler(this.btnSubSwitches_Click);
            // 
            // btnSubToolSettings
            // 
            this.btnSubToolSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnSubToolSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubToolSettings.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnSubToolSettings.FlatAppearance.BorderSize = 0;
            this.btnSubToolSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnSubToolSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnSubToolSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubToolSettings.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubToolSettings.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSubToolSettings.Location = new System.Drawing.Point(0, 75);
            this.btnSubToolSettings.Name = "btnSubToolSettings";
            this.btnSubToolSettings.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSubToolSettings.Size = new System.Drawing.Size(201, 25);
            this.btnSubToolSettings.TabIndex = 4;
            this.btnSubToolSettings.Text = "Settings";
            this.btnSubToolSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubToolSettings.UseVisualStyleBackColor = false;
            this.btnSubToolSettings.Click += new System.EventHandler(this.btnSubToolSettings_Click);
            // 
            // btnSubSections
            // 
            this.btnSubSections.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnSubSections.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubSections.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnSubSections.FlatAppearance.BorderSize = 0;
            this.btnSubSections.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnSubSections.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnSubSections.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubSections.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubSections.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSubSections.Location = new System.Drawing.Point(0, 50);
            this.btnSubSections.Name = "btnSubSections";
            this.btnSubSections.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSubSections.Size = new System.Drawing.Size(201, 25);
            this.btnSubSections.TabIndex = 0;
            this.btnSubSections.Text = "Sections";
            this.btnSubSections.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubSections.UseVisualStyleBackColor = false;
            this.btnSubSections.Click += new System.EventHandler(this.btnSubSections_Click);
            // 
            // btnSubHitch
            // 
            this.btnSubHitch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnSubHitch.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubHitch.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnSubHitch.FlatAppearance.BorderSize = 0;
            this.btnSubHitch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnSubHitch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnSubHitch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubHitch.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubHitch.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSubHitch.Location = new System.Drawing.Point(0, 25);
            this.btnSubHitch.Name = "btnSubHitch";
            this.btnSubHitch.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSubHitch.Size = new System.Drawing.Size(201, 25);
            this.btnSubHitch.TabIndex = 5;
            this.btnSubHitch.Text = "Hitch";
            this.btnSubHitch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubHitch.UseVisualStyleBackColor = false;
            this.btnSubHitch.Click += new System.EventHandler(this.btnSubHitch_Click);
            // 
            // btnSubToolConfig
            // 
            this.btnSubToolConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnSubToolConfig.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubToolConfig.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnSubToolConfig.FlatAppearance.BorderSize = 0;
            this.btnSubToolConfig.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnSubToolConfig.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnSubToolConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubToolConfig.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubToolConfig.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSubToolConfig.Location = new System.Drawing.Point(0, 0);
            this.btnSubToolConfig.Name = "btnSubToolConfig";
            this.btnSubToolConfig.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSubToolConfig.Size = new System.Drawing.Size(201, 25);
            this.btnSubToolConfig.TabIndex = 6;
            this.btnSubToolConfig.Text = "Configuration";
            this.btnSubToolConfig.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubToolConfig.UseVisualStyleBackColor = false;
            this.btnSubToolConfig.Click += new System.EventHandler(this.btnSubToolType_Click);
            // 
            // btnTool
            // 
            this.btnTool.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnTool.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTool.FlatAppearance.BorderSize = 0;
            this.btnTool.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnTool.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnTool.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTool.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTool.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTool.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTool.Location = new System.Drawing.Point(0, 151);
            this.btnTool.Name = "btnTool";
            this.btnTool.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnTool.Size = new System.Drawing.Size(201, 38);
            this.btnTool.TabIndex = 3;
            this.btnTool.Text = "Tool";
            this.btnTool.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTool.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTool.UseVisualStyleBackColor = false;
            this.btnTool.Click += new System.EventHandler(this.btnTool_Click);
            // 
            // panelVehicleSubMenu
            // 
            this.panelVehicleSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelVehicleSubMenu.Controls.Add(this.button1);
            this.panelVehicleSubMenu.Controls.Add(this.btnSubGuidance);
            this.panelVehicleSubMenu.Controls.Add(this.btnSubDimensions);
            this.panelVehicleSubMenu.Controls.Add(this.btnSubAntenna);
            this.panelVehicleSubMenu.Controls.Add(this.btnSubVehicleConfig);
            this.panelVehicleSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelVehicleSubMenu.Location = new System.Drawing.Point(0, 38);
            this.panelVehicleSubMenu.Name = "panelVehicleSubMenu";
            this.panelVehicleSubMenu.Size = new System.Drawing.Size(201, 113);
            this.panelVehicleSubMenu.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Silver;
            this.button1.Location = new System.Drawing.Point(-36, -370);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(231, 40);
            this.button1.TabIndex = 6;
            this.button1.Text = "Type";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnSubGuidance
            // 
            this.btnSubGuidance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnSubGuidance.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubGuidance.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnSubGuidance.FlatAppearance.BorderSize = 0;
            this.btnSubGuidance.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnSubGuidance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnSubGuidance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubGuidance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubGuidance.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSubGuidance.Location = new System.Drawing.Point(0, 75);
            this.btnSubGuidance.Name = "btnSubGuidance";
            this.btnSubGuidance.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSubGuidance.Size = new System.Drawing.Size(201, 25);
            this.btnSubGuidance.TabIndex = 3;
            this.btnSubGuidance.Text = "Guidance";
            this.btnSubGuidance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubGuidance.UseVisualStyleBackColor = false;
            this.btnSubGuidance.Click += new System.EventHandler(this.btnSubGuidance_Click);
            // 
            // btnSubDimensions
            // 
            this.btnSubDimensions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnSubDimensions.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubDimensions.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnSubDimensions.FlatAppearance.BorderSize = 0;
            this.btnSubDimensions.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnSubDimensions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnSubDimensions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubDimensions.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubDimensions.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSubDimensions.Location = new System.Drawing.Point(0, 50);
            this.btnSubDimensions.Name = "btnSubDimensions";
            this.btnSubDimensions.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSubDimensions.Size = new System.Drawing.Size(201, 25);
            this.btnSubDimensions.TabIndex = 1;
            this.btnSubDimensions.Text = "Dimensions";
            this.btnSubDimensions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubDimensions.UseVisualStyleBackColor = false;
            this.btnSubDimensions.Click += new System.EventHandler(this.btnSubDimensions_Click);
            // 
            // btnSubAntenna
            // 
            this.btnSubAntenna.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnSubAntenna.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubAntenna.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnSubAntenna.FlatAppearance.BorderSize = 0;
            this.btnSubAntenna.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnSubAntenna.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnSubAntenna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubAntenna.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubAntenna.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSubAntenna.Location = new System.Drawing.Point(0, 25);
            this.btnSubAntenna.Name = "btnSubAntenna";
            this.btnSubAntenna.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSubAntenna.Size = new System.Drawing.Size(201, 25);
            this.btnSubAntenna.TabIndex = 2;
            this.btnSubAntenna.Text = "Antenna";
            this.btnSubAntenna.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubAntenna.UseVisualStyleBackColor = false;
            this.btnSubAntenna.Click += new System.EventHandler(this.btnSubAntenna_Click);
            // 
            // btnSubVehicleConfig
            // 
            this.btnSubVehicleConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(56)))));
            this.btnSubVehicleConfig.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubVehicleConfig.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnSubVehicleConfig.FlatAppearance.BorderSize = 0;
            this.btnSubVehicleConfig.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnSubVehicleConfig.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnSubVehicleConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubVehicleConfig.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubVehicleConfig.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSubVehicleConfig.Location = new System.Drawing.Point(0, 0);
            this.btnSubVehicleConfig.Name = "btnSubVehicleConfig";
            this.btnSubVehicleConfig.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSubVehicleConfig.Size = new System.Drawing.Size(201, 25);
            this.btnSubVehicleConfig.TabIndex = 0;
            this.btnSubVehicleConfig.Text = "Configuration";
            this.btnSubVehicleConfig.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubVehicleConfig.UseVisualStyleBackColor = false;
            this.btnSubVehicleConfig.Click += new System.EventHandler(this.btnSubVehicleType_Click);
            // 
            // btnVehicle
            // 
            this.btnVehicle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnVehicle.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVehicle.FlatAppearance.BorderSize = 0;
            this.btnVehicle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnVehicle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVehicle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVehicle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVehicle.Location = new System.Drawing.Point(0, 0);
            this.btnVehicle.Name = "btnVehicle";
            this.btnVehicle.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnVehicle.Size = new System.Drawing.Size(201, 38);
            this.btnVehicle.TabIndex = 113;
            this.btnVehicle.Text = "Vehicle";
            this.btnVehicle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVehicle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVehicle.UseVisualStyleBackColor = false;
            this.btnVehicle.Click += new System.EventHandler(this.btnVehicle_Click);
            // 
            // panelChildForm
            // 
            this.panelChildForm.AutoScroll = true;
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(64)))));
            this.panelChildForm.Controls.Add(this.tab1);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelChildForm.Location = new System.Drawing.Point(203, 2);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(795, 641);
            this.panelChildForm.TabIndex = 111;
            // 
            // tab1
            // 
            this.tab1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tab1.Controls.Add(this.tabSummary);
            this.tab1.Controls.Add(this.tabVConfig);
            this.tab1.Controls.Add(this.tabVAntenna);
            this.tab1.Controls.Add(this.tabVDimensions);
            this.tab1.Controls.Add(this.tabVGuidance);
            this.tab1.Controls.Add(this.tabTConfig);
            this.tab1.Controls.Add(this.tabTHitch);
            this.tab1.Controls.Add(this.tabTSections);
            this.tab1.Controls.Add(this.tabTSwitches);
            this.tab1.Controls.Add(this.tabTSettings);
            this.tab1.Controls.Add(this.tabDFix);
            this.tab1.Controls.Add(this.tabDHeading);
            this.tab1.Controls.Add(this.tabDRoll);
            this.tab1.Controls.Add(this.tabUTurn);
            this.tab1.Controls.Add(this.tabASteer);
            this.tab1.Controls.Add(this.tabAMachine);
            this.tab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab1.ItemSize = new System.Drawing.Size(60, 40);
            this.tab1.Location = new System.Drawing.Point(0, 0);
            this.tab1.Name = "tab1";
            this.tab1.Padding = new System.Drawing.Point(0, 0);
            this.tab1.SelectedIndex = 0;
            this.tab1.Size = new System.Drawing.Size(795, 641);
            this.tab1.TabIndex = 0;
            // 
            // tabSummary
            // 
            this.tabSummary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.tabSummary.Controls.Add(this.btnVehicleSave);
            this.tabSummary.Controls.Add(this.btnVehicleLoad);
            this.tabSummary.Controls.Add(this.btnVehicleDelete);
            this.tabSummary.Controls.Add(this.lvVehicles);
            this.tabSummary.Controls.Add(this.label3);
            this.tabSummary.Controls.Add(this.tboxVehicleNameSave);
            this.tabSummary.Controls.Add(this.lblCurrentVehicle);
            this.tabSummary.Controls.Add(this.btnVehicleSaveAs);
            this.tabSummary.Controls.Add(this.lblSumFixType);
            this.tabSummary.Controls.Add(this.label36);
            this.tabSummary.Controls.Add(this.lblSumNumSections);
            this.tabSummary.Controls.Add(this.label33);
            this.tabSummary.Controls.Add(this.lblSumToolWidth);
            this.tabSummary.Controls.Add(this.label31);
            this.tabSummary.Controls.Add(this.lblSumWheelbase);
            this.tabSummary.Controls.Add(this.label29);
            this.tabSummary.Controls.Add(this.label28);
            this.tabSummary.Controls.Add(this.label27);
            this.tabSummary.Controls.Add(this.label25);
            this.tabSummary.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.tabSummary.Location = new System.Drawing.Point(4, 44);
            this.tabSummary.Name = "tabSummary";
            this.tabSummary.Padding = new System.Windows.Forms.Padding(3);
            this.tabSummary.Size = new System.Drawing.Size(787, 593);
            this.tabSummary.TabIndex = 0;
            this.tabSummary.Text = "Summ";
            // 
            // btnVehicleSave
            // 
            this.btnVehicleSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVehicleSave.BackColor = System.Drawing.Color.Transparent;
            this.btnVehicleSave.FlatAppearance.BorderSize = 0;
            this.btnVehicleSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVehicleSave.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.btnVehicleSave.Image = global::AgOpenGPS.Properties.Resources.VehFileSave;
            this.btnVehicleSave.Location = new System.Drawing.Point(540, 517);
            this.btnVehicleSave.Name = "btnVehicleSave";
            this.btnVehicleSave.Size = new System.Drawing.Size(127, 71);
            this.btnVehicleSave.TabIndex = 457;
            this.btnVehicleSave.UseVisualStyleBackColor = false;
            this.btnVehicleSave.Click += new System.EventHandler(this.btnVehicleSave_Click);
            // 
            // btnVehicleLoad
            // 
            this.btnVehicleLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVehicleLoad.BackColor = System.Drawing.Color.Transparent;
            this.btnVehicleLoad.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnVehicleLoad.FlatAppearance.BorderSize = 0;
            this.btnVehicleLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVehicleLoad.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.btnVehicleLoad.Image = global::AgOpenGPS.Properties.Resources.VehFileLoad;
            this.btnVehicleLoad.Location = new System.Drawing.Point(178, 517);
            this.btnVehicleLoad.Name = "btnVehicleLoad";
            this.btnVehicleLoad.Size = new System.Drawing.Size(81, 71);
            this.btnVehicleLoad.TabIndex = 456;
            this.btnVehicleLoad.Text = "Load";
            this.btnVehicleLoad.UseVisualStyleBackColor = false;
            this.btnVehicleLoad.Click += new System.EventHandler(this.btnVehicleLoad_Click);
            // 
            // btnVehicleDelete
            // 
            this.btnVehicleDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVehicleDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnVehicleDelete.FlatAppearance.BorderSize = 0;
            this.btnVehicleDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVehicleDelete.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.btnVehicleDelete.Image = global::AgOpenGPS.Properties.Resources.VehFileDelete;
            this.btnVehicleDelete.Location = new System.Drawing.Point(19, 517);
            this.btnVehicleDelete.Name = "btnVehicleDelete";
            this.btnVehicleDelete.Size = new System.Drawing.Size(81, 71);
            this.btnVehicleDelete.TabIndex = 455;
            this.btnVehicleDelete.UseVisualStyleBackColor = false;
            this.btnVehicleDelete.Click += new System.EventHandler(this.btnVehicleDelete_Click);
            // 
            // lvVehicles
            // 
            this.lvVehicles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lvVehicles.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lvVehicles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvVehicles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chVehicle});
            this.lvVehicles.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvVehicles.FullRowSelect = true;
            this.lvVehicles.GridLines = true;
            this.lvVehicles.HideSelection = false;
            this.lvVehicles.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.lvVehicles.LabelWrap = false;
            this.lvVehicles.Location = new System.Drawing.Point(19, 364);
            this.lvVehicles.Margin = new System.Windows.Forms.Padding(0);
            this.lvVehicles.MultiSelect = false;
            this.lvVehicles.Name = "lvVehicles";
            this.lvVehicles.Size = new System.Drawing.Size(400, 140);
            this.lvVehicles.TabIndex = 454;
            this.lvVehicles.TileSize = new System.Drawing.Size(300, 35);
            this.lvVehicles.UseCompatibleStateImageBehavior = false;
            this.lvVehicles.View = System.Windows.Forms.View.Tile;
            // 
            // chVehicle
            // 
            this.chVehicle.Text = "Vehicles";
            this.chVehicle.Width = 330;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(467, 437);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 23);
            this.label3.TabIndex = 452;
            this.label3.Text = "Save New Vehicle:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tboxVehicleNameSave
            // 
            this.tboxVehicleNameSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tboxVehicleNameSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tboxVehicleNameSave.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxVehicleNameSave.Location = new System.Drawing.Point(438, 468);
            this.tboxVehicleNameSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tboxVehicleNameSave.Name = "tboxVehicleNameSave";
            this.tboxVehicleNameSave.Size = new System.Drawing.Size(328, 36);
            this.tboxVehicleNameSave.TabIndex = 451;
            // 
            // lblCurrentVehicle
            // 
            this.lblCurrentVehicle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrentVehicle.AutoSize = true;
            this.lblCurrentVehicle.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentVehicle.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.lblCurrentVehicle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCurrentVehicle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCurrentVehicle.Location = new System.Drawing.Point(467, 376);
            this.lblCurrentVehicle.Name = "lblCurrentVehicle";
            this.lblCurrentVehicle.Size = new System.Drawing.Size(138, 23);
            this.lblCurrentVehicle.TabIndex = 450;
            this.lblCurrentVehicle.Text = "Current Vehicle";
            this.lblCurrentVehicle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnVehicleSaveAs
            // 
            this.btnVehicleSaveAs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVehicleSaveAs.BackColor = System.Drawing.Color.Transparent;
            this.btnVehicleSaveAs.FlatAppearance.BorderSize = 0;
            this.btnVehicleSaveAs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVehicleSaveAs.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.btnVehicleSaveAs.Image = global::AgOpenGPS.Properties.Resources.VehFileSaveAs;
            this.btnVehicleSaveAs.Location = new System.Drawing.Point(316, 517);
            this.btnVehicleSaveAs.Name = "btnVehicleSaveAs";
            this.btnVehicleSaveAs.Size = new System.Drawing.Size(127, 71);
            this.btnVehicleSaveAs.TabIndex = 453;
            this.btnVehicleSaveAs.UseVisualStyleBackColor = false;
            this.btnVehicleSaveAs.Click += new System.EventHandler(this.btnVehicleSaveAs_Click);
            // 
            // lblSumFixType
            // 
            this.lblSumFixType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSumFixType.AutoSize = true;
            this.lblSumFixType.BackColor = System.Drawing.Color.Transparent;
            this.lblSumFixType.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumFixType.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSumFixType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSumFixType.Location = new System.Drawing.Point(240, 321);
            this.lblSumFixType.Name = "lblSumFixType";
            this.lblSumFixType.Size = new System.Drawing.Size(45, 19);
            this.lblSumFixType.TabIndex = 449;
            this.lblSumFixType.Text = "Secs";
            this.lblSumFixType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label36
            // 
            this.label36.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label36.AutoSize = true;
            this.label36.BackColor = System.Drawing.Color.Transparent;
            this.label36.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label36.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label36.Location = new System.Drawing.Point(153, 321);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(78, 19);
            this.label36.TabIndex = 448;
            this.label36.Text = "Fix Type";
            this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSumNumSections
            // 
            this.lblSumNumSections.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSumNumSections.AutoSize = true;
            this.lblSumNumSections.BackColor = System.Drawing.Color.Transparent;
            this.lblSumNumSections.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumNumSections.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSumNumSections.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSumNumSections.Location = new System.Drawing.Point(240, 242);
            this.lblSumNumSections.Name = "lblSumNumSections";
            this.lblSumNumSections.Size = new System.Drawing.Size(45, 19);
            this.lblSumNumSections.TabIndex = 447;
            this.lblSumNumSections.Text = "Secs";
            this.lblSumNumSections.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label33
            // 
            this.label33.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label33.AutoSize = true;
            this.label33.BackColor = System.Drawing.Color.Transparent;
            this.label33.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label33.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label33.Location = new System.Drawing.Point(153, 242);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(77, 19);
            this.label33.TabIndex = 446;
            this.label33.Text = "Sections";
            this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSumToolWidth
            // 
            this.lblSumToolWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSumToolWidth.AutoSize = true;
            this.lblSumToolWidth.BackColor = System.Drawing.Color.Transparent;
            this.lblSumToolWidth.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumToolWidth.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSumToolWidth.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSumToolWidth.Location = new System.Drawing.Point(240, 205);
            this.lblSumToolWidth.Name = "lblSumToolWidth";
            this.lblSumToolWidth.Size = new System.Drawing.Size(68, 19);
            this.lblSumToolWidth.TabIndex = 445;
            this.lblSumToolWidth.Text = "TWidth";
            this.lblSumToolWidth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label31
            // 
            this.label31.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.Color.Transparent;
            this.label31.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label31.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label31.Location = new System.Drawing.Point(153, 204);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(57, 19);
            this.label31.TabIndex = 444;
            this.label31.Text = "Width";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSumWheelbase
            // 
            this.lblSumWheelbase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSumWheelbase.AutoSize = true;
            this.lblSumWheelbase.BackColor = System.Drawing.Color.Transparent;
            this.lblSumWheelbase.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumWheelbase.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSumWheelbase.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSumWheelbase.Location = new System.Drawing.Point(257, 98);
            this.lblSumWheelbase.Name = "lblSumWheelbase";
            this.lblSumWheelbase.Size = new System.Drawing.Size(98, 19);
            this.lblSumWheelbase.TabIndex = 443;
            this.lblSumWheelbase.Text = "Wheelbase";
            this.lblSumWheelbase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label29
            // 
            this.label29.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.Transparent;
            this.label29.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label29.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label29.Location = new System.Drawing.Point(153, 99);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(98, 19);
            this.label29.TabIndex = 442;
            this.label29.Text = "Wheelbase";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label28
            // 
            this.label28.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.Color.Transparent;
            this.label28.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label28.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label28.Location = new System.Drawing.Point(1, 321);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(135, 23);
            this.label28.TabIndex = 441;
            this.label28.Text = "Data Sources";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label27
            // 
            this.label27.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label27.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label27.Location = new System.Drawing.Point(84, 200);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(52, 23);
            this.label27.TabIndex = 440;
            this.label27.Text = "Tool";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label25
            // 
            this.label25.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label25.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label25.Location = new System.Drawing.Point(57, 96);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(79, 23);
            this.label25.TabIndex = 439;
            this.label25.Text = "Vehicle";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabVConfig
            // 
            this.tabVConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(42)))));
            this.tabVConfig.Controls.Add(this.groupBox1);
            this.tabVConfig.Location = new System.Drawing.Point(4, 44);
            this.tabVConfig.Name = "tabVConfig";
            this.tabVConfig.Size = new System.Drawing.Size(787, 593);
            this.tabVConfig.TabIndex = 4;
            this.tabVConfig.Text = "vConfig";
            this.tabVConfig.Enter += new System.EventHandler(this.tabVConfig_Enter);
            this.tabVConfig.Leave += new System.EventHandler(this.tabVConfig_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.rbtnHarvester);
            this.groupBox1.Controls.Add(this.rbtn4WD);
            this.groupBox1.Controls.Add(this.rbtnTractor);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(26, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(712, 483);
            this.groupBox1.TabIndex = 112;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vehicle Type";
            // 
            // rbtnHarvester
            // 
            this.rbtnHarvester.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtnHarvester.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rbtnHarvester.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbtnHarvester.FlatAppearance.BorderSize = 0;
            this.rbtnHarvester.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rbtnHarvester.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnHarvester.Image = global::AgOpenGPS.Properties.Resources.vehiclePageHarvester;
            this.rbtnHarvester.Location = new System.Drawing.Point(49, 278);
            this.rbtnHarvester.Name = "rbtnHarvester";
            this.rbtnHarvester.Size = new System.Drawing.Size(276, 166);
            this.rbtnHarvester.TabIndex = 253;
            this.rbtnHarvester.TabStop = true;
            this.rbtnHarvester.UseVisualStyleBackColor = true;
            // 
            // rbtn4WD
            // 
            this.rbtn4WD.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtn4WD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rbtn4WD.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbtn4WD.FlatAppearance.BorderSize = 0;
            this.rbtn4WD.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rbtn4WD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtn4WD.Image = global::AgOpenGPS.Properties.Resources.vehiclePage4WD;
            this.rbtn4WD.Location = new System.Drawing.Point(49, 53);
            this.rbtn4WD.Name = "rbtn4WD";
            this.rbtn4WD.Size = new System.Drawing.Size(299, 171);
            this.rbtn4WD.TabIndex = 252;
            this.rbtn4WD.TabStop = true;
            this.rbtn4WD.UseVisualStyleBackColor = true;
            // 
            // rbtnTractor
            // 
            this.rbtnTractor.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtnTractor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rbtnTractor.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbtnTractor.FlatAppearance.BorderSize = 0;
            this.rbtnTractor.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rbtnTractor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnTractor.Image = global::AgOpenGPS.Properties.Resources.vehiclePageTractor;
            this.rbtnTractor.Location = new System.Drawing.Point(404, 53);
            this.rbtnTractor.Name = "rbtnTractor";
            this.rbtnTractor.Size = new System.Drawing.Size(290, 171);
            this.rbtnTractor.TabIndex = 112;
            this.rbtnTractor.TabStop = true;
            this.rbtnTractor.UseVisualStyleBackColor = true;
            // 
            // tabVAntenna
            // 
            this.tabVAntenna.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(60)))));
            this.tabVAntenna.Controls.Add(this.btnNext);
            this.tabVAntenna.Controls.Add(this.nudAntennaHeight);
            this.tabVAntenna.Controls.Add(this.nudAntennaPivot);
            this.tabVAntenna.Controls.Add(this.nudAntennaOffset);
            this.tabVAntenna.Controls.Add(this.pboxAntenna);
            this.tabVAntenna.Location = new System.Drawing.Point(4, 44);
            this.tabVAntenna.Name = "tabVAntenna";
            this.tabVAntenna.Size = new System.Drawing.Size(787, 593);
            this.tabVAntenna.TabIndex = 12;
            this.tabVAntenna.Text = "vAnt";
            this.tabVAntenna.Enter += new System.EventHandler(this.tabVAntenna_Enter);
            this.tabVAntenna.Leave += new System.EventHandler(this.tabVAntenna_Leave);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Location = new System.Drawing.Point(733, 25);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(31, 28);
            this.btnNext.TabIndex = 0;
            this.btnNext.UseVisualStyleBackColor = false;
            // 
            // nudAntennaHeight
            // 
            this.nudAntennaHeight.BackColor = System.Drawing.Color.AliceBlue;
            this.nudAntennaHeight.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAntennaHeight.InterceptArrowKeys = false;
            this.nudAntennaHeight.Location = new System.Drawing.Point(388, 209);
            this.nudAntennaHeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudAntennaHeight.Name = "nudAntennaHeight";
            this.nudAntennaHeight.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nudAntennaHeight.Size = new System.Drawing.Size(144, 52);
            this.nudAntennaHeight.TabIndex = 3;
            this.nudAntennaHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudAntennaHeight.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nudAntennaHeight.Enter += new System.EventHandler(this.nudAntennaHeight_Enter);
            // 
            // nudAntennaPivot
            // 
            this.nudAntennaPivot.BackColor = System.Drawing.Color.AliceBlue;
            this.nudAntennaPivot.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAntennaPivot.InterceptArrowKeys = false;
            this.nudAntennaPivot.Location = new System.Drawing.Point(122, 44);
            this.nudAntennaPivot.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudAntennaPivot.Name = "nudAntennaPivot";
            this.nudAntennaPivot.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nudAntennaPivot.Size = new System.Drawing.Size(144, 52);
            this.nudAntennaPivot.TabIndex = 1;
            this.nudAntennaPivot.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudAntennaPivot.Value = new decimal(new int[] {
            111,
            0,
            0,
            0});
            this.nudAntennaPivot.Enter += new System.EventHandler(this.nudAntennaPivot_Enter);
            // 
            // nudAntennaOffset
            // 
            this.nudAntennaOffset.BackColor = System.Drawing.Color.AliceBlue;
            this.nudAntennaOffset.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAntennaOffset.InterceptArrowKeys = false;
            this.nudAntennaOffset.Location = new System.Drawing.Point(462, 415);
            this.nudAntennaOffset.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudAntennaOffset.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            -2147483648});
            this.nudAntennaOffset.Name = "nudAntennaOffset";
            this.nudAntennaOffset.Size = new System.Drawing.Size(144, 52);
            this.nudAntennaOffset.TabIndex = 2;
            this.nudAntennaOffset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudAntennaOffset.Enter += new System.EventHandler(this.nudAntennaOffset_Enter);
            // 
            // pboxAntenna
            // 
            this.pboxAntenna.BackgroundImage = global::AgOpenGPS.Properties.Resources.AntennaTractor;
            this.pboxAntenna.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pboxAntenna.Location = new System.Drawing.Point(18, 107);
            this.pboxAntenna.Name = "pboxAntenna";
            this.pboxAntenna.Size = new System.Drawing.Size(514, 446);
            this.pboxAntenna.TabIndex = 48;
            this.pboxAntenna.TabStop = false;
            // 
            // tabVDimensions
            // 
            this.tabVDimensions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(60)))));
            this.tabVDimensions.Controls.Add(this.label53);
            this.tabVDimensions.Controls.Add(this.label23);
            this.tabVDimensions.Controls.Add(this.btnNextDim);
            this.tabVDimensions.Controls.Add(this.nudWheelbase);
            this.tabVDimensions.Controls.Add(this.nudMinTurnRadius);
            this.tabVDimensions.Controls.Add(this.pictureBox1);
            this.tabVDimensions.Location = new System.Drawing.Point(4, 44);
            this.tabVDimensions.Name = "tabVDimensions";
            this.tabVDimensions.Size = new System.Drawing.Size(787, 593);
            this.tabVDimensions.TabIndex = 13;
            this.tabVDimensions.Text = "vDim";
            this.tabVDimensions.Enter += new System.EventHandler(this.tabVDimensions_Enter);
            this.tabVDimensions.Leave += new System.EventHandler(this.tabVDimensions_Leave);
            // 
            // label53
            // 
            this.label53.BackColor = System.Drawing.Color.Transparent;
            this.label53.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.label53.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label53.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label53.Location = new System.Drawing.Point(28, 381);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(155, 67);
            this.label53.TabIndex = 52;
            this.label53.Text = "Wheelbase";
            this.label53.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label23
            // 
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.label23.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label23.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label23.Location = new System.Drawing.Point(506, 427);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(155, 67);
            this.label23.TabIndex = 53;
            this.label23.Text = "Min Turn Radius";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNextDim
            // 
            this.btnNextDim.BackColor = System.Drawing.Color.Transparent;
            this.btnNextDim.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNextDim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextDim.Location = new System.Drawing.Point(746, 6);
            this.btnNextDim.Name = "btnNextDim";
            this.btnNextDim.Size = new System.Drawing.Size(31, 28);
            this.btnNextDim.TabIndex = 0;
            this.btnNextDim.UseVisualStyleBackColor = false;
            // 
            // nudWheelbase
            // 
            this.nudWheelbase.BackColor = System.Drawing.Color.AliceBlue;
            this.nudWheelbase.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudWheelbase.InterceptArrowKeys = false;
            this.nudWheelbase.Location = new System.Drawing.Point(32, 326);
            this.nudWheelbase.Maximum = new decimal(new int[] {
            1999,
            0,
            0,
            0});
            this.nudWheelbase.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudWheelbase.Name = "nudWheelbase";
            this.nudWheelbase.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nudWheelbase.Size = new System.Drawing.Size(152, 52);
            this.nudWheelbase.TabIndex = 52;
            this.nudWheelbase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudWheelbase.Value = new decimal(new int[] {
            499,
            0,
            0,
            0});
            this.nudWheelbase.Enter += new System.EventHandler(this.nudMinTurnRadius_Enter);
            // 
            // nudMinTurnRadius
            // 
            this.nudMinTurnRadius.BackColor = System.Drawing.Color.AliceBlue;
            this.nudMinTurnRadius.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMinTurnRadius.InterceptArrowKeys = false;
            this.nudMinTurnRadius.Location = new System.Drawing.Point(509, 372);
            this.nudMinTurnRadius.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudMinTurnRadius.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudMinTurnRadius.Name = "nudMinTurnRadius";
            this.nudMinTurnRadius.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nudMinTurnRadius.Size = new System.Drawing.Size(152, 52);
            this.nudMinTurnRadius.TabIndex = 49;
            this.nudMinTurnRadius.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudMinTurnRadius.Value = new decimal(new int[] {
            301,
            0,
            0,
            0});
            this.nudMinTurnRadius.Enter += new System.EventHandler(this.nudWheelbase_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AgOpenGPS.Properties.Resources.RadiusWheelBase;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(220, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(441, 415);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // tabVGuidance
            // 
            this.tabVGuidance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.tabVGuidance.Controls.Add(this.groupBox6);
            this.tabVGuidance.Controls.Add(this.groupBox9);
            this.tabVGuidance.Controls.Add(this.groupBox2);
            this.tabVGuidance.Controls.Add(this.groupBox5);
            this.tabVGuidance.Location = new System.Drawing.Point(4, 44);
            this.tabVGuidance.Name = "tabVGuidance";
            this.tabVGuidance.Size = new System.Drawing.Size(787, 593);
            this.tabVGuidance.TabIndex = 14;
            this.tabVGuidance.Text = "vGuid";
            this.tabVGuidance.Enter += new System.EventHandler(this.tabVGuidance_Enter);
            this.tabVGuidance.Leave += new System.EventHandler(this.tabVGuidance_Leave);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.nudLineWidth);
            this.groupBox6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox6.Location = new System.Drawing.Point(435, 100);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(232, 144);
            this.groupBox6.TabIndex = 124;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Guidance Line Width";
            // 
            // nudLineWidth
            // 
            this.nudLineWidth.BackColor = System.Drawing.Color.AliceBlue;
            this.nudLineWidth.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudLineWidth.InterceptArrowKeys = false;
            this.nudLineWidth.Location = new System.Drawing.Point(56, 49);
            this.nudLineWidth.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudLineWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLineWidth.Name = "nudLineWidth";
            this.nudLineWidth.Size = new System.Drawing.Size(110, 52);
            this.nudLineWidth.TabIndex = 0;
            this.nudLineWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudLineWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLineWidth.Enter += new System.EventHandler(this.nudLineWidth_Enter);
            // 
            // groupBox9
            // 
            this.groupBox9.BackColor = System.Drawing.Color.Transparent;
            this.groupBox9.Controls.Add(this.cboxAutoSteerAuto);
            this.groupBox9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox9.Location = new System.Drawing.Point(76, 62);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(232, 182);
            this.groupBox9.TabIndex = 93;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Remote/Manual AutoSteer Button";
            // 
            // cboxAutoSteerAuto
            // 
            this.cboxAutoSteerAuto.Appearance = System.Windows.Forms.Appearance.Button;
            this.cboxAutoSteerAuto.BackColor = System.Drawing.Color.Transparent;
            this.cboxAutoSteerAuto.FlatAppearance.BorderSize = 0;
            this.cboxAutoSteerAuto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboxAutoSteerAuto.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxAutoSteerAuto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cboxAutoSteerAuto.Image = global::AgOpenGPS.Properties.Resources.AutoSteerOn;
            this.cboxAutoSteerAuto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cboxAutoSteerAuto.Location = new System.Drawing.Point(73, 55);
            this.cboxAutoSteerAuto.Name = "cboxAutoSteerAuto";
            this.cboxAutoSteerAuto.Size = new System.Drawing.Size(98, 103);
            this.cboxAutoSteerAuto.TabIndex = 0;
            this.cboxAutoSteerAuto.Text = "Manual";
            this.cboxAutoSteerAuto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cboxAutoSteerAuto.UseVisualStyleBackColor = false;
            this.cboxAutoSteerAuto.CheckedChanged += new System.EventHandler(this.cboxAutoSteerAuto_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nudLightbarCmPerPixel);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Location = new System.Drawing.Point(436, 316);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(232, 144);
            this.groupBox2.TabIndex = 123;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "cm / Lightbar Pixel";
            // 
            // nudLightbarCmPerPixel
            // 
            this.nudLightbarCmPerPixel.BackColor = System.Drawing.Color.AliceBlue;
            this.nudLightbarCmPerPixel.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudLightbarCmPerPixel.InterceptArrowKeys = false;
            this.nudLightbarCmPerPixel.Location = new System.Drawing.Point(55, 53);
            this.nudLightbarCmPerPixel.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudLightbarCmPerPixel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLightbarCmPerPixel.Name = "nudLightbarCmPerPixel";
            this.nudLightbarCmPerPixel.Size = new System.Drawing.Size(110, 52);
            this.nudLightbarCmPerPixel.TabIndex = 0;
            this.nudLightbarCmPerPixel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudLightbarCmPerPixel.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudLightbarCmPerPixel.Enter += new System.EventHandler(this.nudLightbarCmPerPixel_Enter);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.nudSnapDistance);
            this.groupBox5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox5.Location = new System.Drawing.Point(76, 316);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(232, 144);
            this.groupBox5.TabIndex = 90;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "<< >> Snap Distance";
            // 
            // nudSnapDistance
            // 
            this.nudSnapDistance.BackColor = System.Drawing.Color.AliceBlue;
            this.nudSnapDistance.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSnapDistance.InterceptArrowKeys = false;
            this.nudSnapDistance.Location = new System.Drawing.Point(61, 53);
            this.nudSnapDistance.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudSnapDistance.Name = "nudSnapDistance";
            this.nudSnapDistance.Size = new System.Drawing.Size(110, 52);
            this.nudSnapDistance.TabIndex = 0;
            this.nudSnapDistance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudSnapDistance.Value = new decimal(new int[] {
            499,
            0,
            0,
            0});
            this.nudSnapDistance.Enter += new System.EventHandler(this.nudSnapDistance_Enter);
            // 
            // tabTConfig
            // 
            this.tabTConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(60)))));
            this.tabTConfig.Controls.Add(this.gboxAttachment);
            this.tabTConfig.Location = new System.Drawing.Point(4, 44);
            this.tabTConfig.Name = "tabTConfig";
            this.tabTConfig.Size = new System.Drawing.Size(787, 593);
            this.tabTConfig.TabIndex = 11;
            this.tabTConfig.Text = "tConfig";
            this.tabTConfig.Enter += new System.EventHandler(this.tabTConfig_Enter);
            this.tabTConfig.Leave += new System.EventHandler(this.tabTConfig_Leave);
            // 
            // gboxAttachment
            // 
            this.gboxAttachment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gboxAttachment.Controls.Add(this.rbtnTBT);
            this.gboxAttachment.Controls.Add(this.rbtnFixedRear);
            this.gboxAttachment.Controls.Add(this.rbtnFront);
            this.gboxAttachment.Controls.Add(this.rbtnTrailing);
            this.gboxAttachment.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxAttachment.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gboxAttachment.Location = new System.Drawing.Point(45, 57);
            this.gboxAttachment.Name = "gboxAttachment";
            this.gboxAttachment.Size = new System.Drawing.Size(669, 356);
            this.gboxAttachment.TabIndex = 111;
            this.gboxAttachment.TabStop = false;
            this.gboxAttachment.Text = "Attachment Style";
            // 
            // rbtnTBT
            // 
            this.rbtnTBT.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtnTBT.BackColor = System.Drawing.Color.Transparent;
            this.rbtnTBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rbtnTBT.FlatAppearance.BorderSize = 0;
            this.rbtnTBT.FlatAppearance.CheckedBackColor = System.Drawing.Color.Cyan;
            this.rbtnTBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnTBT.Image = global::AgOpenGPS.Properties.Resources.ToolChkTBT;
            this.rbtnTBT.Location = new System.Drawing.Point(348, 48);
            this.rbtnTBT.Name = "rbtnTBT";
            this.rbtnTBT.Size = new System.Drawing.Size(241, 100);
            this.rbtnTBT.TabIndex = 112;
            this.rbtnTBT.UseVisualStyleBackColor = false;
            // 
            // rbtnFixedRear
            // 
            this.rbtnFixedRear.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtnFixedRear.BackColor = System.Drawing.Color.Transparent;
            this.rbtnFixedRear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rbtnFixedRear.FlatAppearance.BorderSize = 0;
            this.rbtnFixedRear.FlatAppearance.CheckedBackColor = System.Drawing.Color.Cyan;
            this.rbtnFixedRear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnFixedRear.Image = global::AgOpenGPS.Properties.Resources.ToolChkRear;
            this.rbtnFixedRear.Location = new System.Drawing.Point(16, 48);
            this.rbtnFixedRear.Name = "rbtnFixedRear";
            this.rbtnFixedRear.Size = new System.Drawing.Size(201, 100);
            this.rbtnFixedRear.TabIndex = 111;
            this.rbtnFixedRear.UseVisualStyleBackColor = false;
            // 
            // rbtnFront
            // 
            this.rbtnFront.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtnFront.BackColor = System.Drawing.Color.Transparent;
            this.rbtnFront.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rbtnFront.FlatAppearance.BorderSize = 0;
            this.rbtnFront.FlatAppearance.CheckedBackColor = System.Drawing.Color.Cyan;
            this.rbtnFront.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnFront.Image = global::AgOpenGPS.Properties.Resources.ToolChkFront;
            this.rbtnFront.Location = new System.Drawing.Point(16, 212);
            this.rbtnFront.Name = "rbtnFront";
            this.rbtnFront.Size = new System.Drawing.Size(201, 100);
            this.rbtnFront.TabIndex = 110;
            this.rbtnFront.UseVisualStyleBackColor = false;
            // 
            // rbtnTrailing
            // 
            this.rbtnTrailing.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtnTrailing.BackColor = System.Drawing.Color.Transparent;
            this.rbtnTrailing.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rbtnTrailing.Checked = true;
            this.rbtnTrailing.FlatAppearance.BorderSize = 0;
            this.rbtnTrailing.FlatAppearance.CheckedBackColor = System.Drawing.Color.Cyan;
            this.rbtnTrailing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnTrailing.Image = global::AgOpenGPS.Properties.Resources.ToolChkTrailing;
            this.rbtnTrailing.Location = new System.Drawing.Point(348, 212);
            this.rbtnTrailing.Name = "rbtnTrailing";
            this.rbtnTrailing.Size = new System.Drawing.Size(241, 100);
            this.rbtnTrailing.TabIndex = 109;
            this.rbtnTrailing.TabStop = true;
            this.rbtnTrailing.UseVisualStyleBackColor = false;
            // 
            // tabTHitch
            // 
            this.tabTHitch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(60)))));
            this.tabTHitch.Controls.Add(this.btnNext2);
            this.tabTHitch.Controls.Add(this.nudTrailingHitchLength);
            this.tabTHitch.Controls.Add(this.nudDrawbarLength);
            this.tabTHitch.Controls.Add(this.nudTankHitch);
            this.tabTHitch.Controls.Add(this.picboxToolHitch);
            this.tabTHitch.Location = new System.Drawing.Point(4, 44);
            this.tabTHitch.Name = "tabTHitch";
            this.tabTHitch.Size = new System.Drawing.Size(787, 593);
            this.tabTHitch.TabIndex = 5;
            this.tabTHitch.Text = "tHitch";
            this.tabTHitch.Enter += new System.EventHandler(this.tabTHitch_Enter);
            this.tabTHitch.Leave += new System.EventHandler(this.tabTHitch_Leave);
            // 
            // btnNext2
            // 
            this.btnNext2.BackColor = System.Drawing.Color.Transparent;
            this.btnNext2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNext2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext2.Location = new System.Drawing.Point(611, 72);
            this.btnNext2.Name = "btnNext2";
            this.btnNext2.Size = new System.Drawing.Size(31, 28);
            this.btnNext2.TabIndex = 0;
            this.btnNext2.UseVisualStyleBackColor = false;
            // 
            // nudTrailingHitchLength
            // 
            this.nudTrailingHitchLength.BackColor = System.Drawing.Color.AliceBlue;
            this.nudTrailingHitchLength.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudTrailingHitchLength.InterceptArrowKeys = false;
            this.nudTrailingHitchLength.Location = new System.Drawing.Point(451, 175);
            this.nudTrailingHitchLength.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudTrailingHitchLength.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudTrailingHitchLength.Name = "nudTrailingHitchLength";
            this.nudTrailingHitchLength.Size = new System.Drawing.Size(150, 52);
            this.nudTrailingHitchLength.TabIndex = 3;
            this.nudTrailingHitchLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudTrailingHitchLength.Value = new decimal(new int[] {
            302,
            0,
            0,
            0});
            this.nudTrailingHitchLength.Enter += new System.EventHandler(this.nudTrailingHitchLength_Enter);
            // 
            // nudDrawbarLength
            // 
            this.nudDrawbarLength.BackColor = System.Drawing.Color.AliceBlue;
            this.nudDrawbarLength.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDrawbarLength.InterceptArrowKeys = false;
            this.nudDrawbarLength.Location = new System.Drawing.Point(61, 175);
            this.nudDrawbarLength.Maximum = new decimal(new int[] {
            1200,
            0,
            0,
            0});
            this.nudDrawbarLength.Name = "nudDrawbarLength";
            this.nudDrawbarLength.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nudDrawbarLength.Size = new System.Drawing.Size(150, 52);
            this.nudDrawbarLength.TabIndex = 1;
            this.nudDrawbarLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudDrawbarLength.Value = new decimal(new int[] {
            51,
            0,
            0,
            0});
            this.nudDrawbarLength.Enter += new System.EventHandler(this.nudDrawbarLength_Enter);
            // 
            // nudTankHitch
            // 
            this.nudTankHitch.BackColor = System.Drawing.Color.AliceBlue;
            this.nudTankHitch.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudTankHitch.InterceptArrowKeys = false;
            this.nudTankHitch.Location = new System.Drawing.Point(256, 175);
            this.nudTankHitch.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudTankHitch.Minimum = new decimal(new int[] {
            75,
            0,
            0,
            0});
            this.nudTankHitch.Name = "nudTankHitch";
            this.nudTankHitch.Size = new System.Drawing.Size(150, 52);
            this.nudTankHitch.TabIndex = 2;
            this.nudTankHitch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudTankHitch.Value = new decimal(new int[] {
            75,
            0,
            0,
            0});
            this.nudTankHitch.Enter += new System.EventHandler(this.nudTankHitch_Enter);
            // 
            // picboxToolHitch
            // 
            this.picboxToolHitch.Image = global::AgOpenGPS.Properties.Resources.ToolHitchPageTBT1;
            this.picboxToolHitch.Location = new System.Drawing.Point(143, 233);
            this.picboxToolHitch.Name = "picboxToolHitch";
            this.picboxToolHitch.Size = new System.Drawing.Size(499, 285);
            this.picboxToolHitch.TabIndex = 0;
            this.picboxToolHitch.TabStop = false;
            // 
            // tabTSections
            // 
            this.tabTSections.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(60)))));
            this.tabTSections.Controls.Add(this.btnNext4);
            this.tabTSections.Controls.Add(this.nudCutoffSpeed);
            this.tabTSections.Controls.Add(this.label42);
            this.tabTSections.Controls.Add(this.lblTurnOffBelowUnits);
            this.tabTSections.Controls.Add(this.lblInchesCm);
            this.tabTSections.Controls.Add(this.lblDoNotExceed);
            this.tabTSections.Controls.Add(this.label49);
            this.tabTSections.Controls.Add(this.nudDefaultSectionWidth);
            this.tabTSections.Controls.Add(this.cboxNumSections);
            this.tabTSections.Controls.Add(this.lblVehicleToolWidth);
            this.tabTSections.Controls.Add(this.label50);
            this.tabTSections.Controls.Add(this.nudMinApplied);
            this.tabTSections.Controls.Add(this.label51);
            this.tabTSections.Controls.Add(this.label1);
            this.tabTSections.Controls.Add(this.nudSection16);
            this.tabTSections.Controls.Add(this.label4);
            this.tabTSections.Controls.Add(this.label19);
            this.tabTSections.Controls.Add(this.label30);
            this.tabTSections.Controls.Add(this.nudSection15);
            this.tabTSections.Controls.Add(this.nudSection14);
            this.tabTSections.Controls.Add(this.nudSection13);
            this.tabTSections.Controls.Add(this.label32);
            this.tabTSections.Controls.Add(this.label34);
            this.tabTSections.Controls.Add(this.label35);
            this.tabTSections.Controls.Add(this.label40);
            this.tabTSections.Controls.Add(this.label39);
            this.tabTSections.Controls.Add(this.label38);
            this.tabTSections.Controls.Add(this.label37);
            this.tabTSections.Controls.Add(this.label41);
            this.tabTSections.Controls.Add(this.label45);
            this.tabTSections.Controls.Add(this.label46);
            this.tabTSections.Controls.Add(this.label47);
            this.tabTSections.Controls.Add(this.label48);
            this.tabTSections.Controls.Add(this.nudSection12);
            this.tabTSections.Controls.Add(this.nudSection11);
            this.tabTSections.Controls.Add(this.nudSection10);
            this.tabTSections.Controls.Add(this.nudSection9);
            this.tabTSections.Controls.Add(this.nudSection8);
            this.tabTSections.Controls.Add(this.nudSection7);
            this.tabTSections.Controls.Add(this.nudSection6);
            this.tabTSections.Controls.Add(this.nudSection5);
            this.tabTSections.Controls.Add(this.nudSection4);
            this.tabTSections.Controls.Add(this.nudSection3);
            this.tabTSections.Controls.Add(this.nudSection2);
            this.tabTSections.Controls.Add(this.nudSection1);
            this.tabTSections.Location = new System.Drawing.Point(4, 44);
            this.tabTSections.Name = "tabTSections";
            this.tabTSections.Size = new System.Drawing.Size(787, 593);
            this.tabTSections.TabIndex = 7;
            this.tabTSections.Text = "tSect";
            this.tabTSections.Enter += new System.EventHandler(this.tabTSections_Enter);
            this.tabTSections.Leave += new System.EventHandler(this.tabTSections_Leave);
            // 
            // btnNext4
            // 
            this.btnNext4.BackColor = System.Drawing.Color.Transparent;
            this.btnNext4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNext4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext4.Location = new System.Drawing.Point(556, 267);
            this.btnNext4.Name = "btnNext4";
            this.btnNext4.Size = new System.Drawing.Size(31, 25);
            this.btnNext4.TabIndex = 0;
            this.btnNext4.UseVisualStyleBackColor = false;
            // 
            // nudCutoffSpeed
            // 
            this.nudCutoffSpeed.BackColor = System.Drawing.Color.AliceBlue;
            this.nudCutoffSpeed.DecimalPlaces = 1;
            this.nudCutoffSpeed.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCutoffSpeed.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudCutoffSpeed.InterceptArrowKeys = false;
            this.nudCutoffSpeed.Location = new System.Drawing.Point(626, 348);
            this.nudCutoffSpeed.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudCutoffSpeed.Name = "nudCutoffSpeed";
            this.nudCutoffSpeed.Size = new System.Drawing.Size(127, 52);
            this.nudCutoffSpeed.TabIndex = 306;
            this.nudCutoffSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudCutoffSpeed.Value = new decimal(new int[] {
            11,
            0,
            0,
            65536});
            this.nudCutoffSpeed.Enter += new System.EventHandler(this.nudCutoffSpeed_Enter);
            // 
            // label42
            // 
            this.label42.BackColor = System.Drawing.Color.Transparent;
            this.label42.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.label42.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label42.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label42.Location = new System.Drawing.Point(621, 295);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(146, 50);
            this.label42.TabIndex = 304;
            this.label42.Text = "Off below";
            this.label42.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblTurnOffBelowUnits
            // 
            this.lblTurnOffBelowUnits.AutoSize = true;
            this.lblTurnOffBelowUnits.BackColor = System.Drawing.Color.Transparent;
            this.lblTurnOffBelowUnits.Font = new System.Drawing.Font("Tahoma", 20.25F);
            this.lblTurnOffBelowUnits.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTurnOffBelowUnits.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTurnOffBelowUnits.Location = new System.Drawing.Point(652, 403);
            this.lblTurnOffBelowUnits.Name = "lblTurnOffBelowUnits";
            this.lblTurnOffBelowUnits.Size = new System.Drawing.Size(82, 33);
            this.lblTurnOffBelowUnits.TabIndex = 305;
            this.lblTurnOffBelowUnits.Text = "Km/H";
            // 
            // lblInchesCm
            // 
            this.lblInchesCm.AutoSize = true;
            this.lblInchesCm.Font = new System.Drawing.Font("Tahoma", 24F);
            this.lblInchesCm.ForeColor = System.Drawing.Color.Red;
            this.lblInchesCm.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblInchesCm.Location = new System.Drawing.Point(22, 546);
            this.lblInchesCm.Name = "lblInchesCm";
            this.lblInchesCm.Size = new System.Drawing.Size(111, 39);
            this.lblInchesCm.TabIndex = 303;
            this.lblInchesCm.Text = "Inches";
            // 
            // lblDoNotExceed
            // 
            this.lblDoNotExceed.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.lblDoNotExceed.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDoNotExceed.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDoNotExceed.Location = new System.Drawing.Point(258, 519);
            this.lblDoNotExceed.Name = "lblDoNotExceed";
            this.lblDoNotExceed.Size = new System.Drawing.Size(262, 52);
            this.lblDoNotExceed.TabIndex = 299;
            this.lblDoNotExceed.Text = "* Do not exceed 1570 *";
            this.lblDoNotExceed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label49
            // 
            this.label49.BackColor = System.Drawing.Color.Transparent;
            this.label49.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.label49.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label49.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label49.Location = new System.Drawing.Point(31, 383);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(131, 61);
            this.label49.TabIndex = 297;
            this.label49.Text = "Section Width";
            this.label49.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // nudDefaultSectionWidth
            // 
            this.nudDefaultSectionWidth.BackColor = System.Drawing.Color.AliceBlue;
            this.nudDefaultSectionWidth.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDefaultSectionWidth.InterceptArrowKeys = false;
            this.nudDefaultSectionWidth.Location = new System.Drawing.Point(46, 451);
            this.nudDefaultSectionWidth.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudDefaultSectionWidth.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudDefaultSectionWidth.Name = "nudDefaultSectionWidth";
            this.nudDefaultSectionWidth.Size = new System.Drawing.Size(87, 52);
            this.nudDefaultSectionWidth.TabIndex = 296;
            this.nudDefaultSectionWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudDefaultSectionWidth.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudDefaultSectionWidth.Enter += new System.EventHandler(this.nudDefaultSectionWidth_Enter);
            // 
            // cboxNumSections
            // 
            this.cboxNumSections.BackColor = System.Drawing.Color.AliceBlue;
            this.cboxNumSections.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxNumSections.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboxNumSections.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxNumSections.FormattingEnabled = true;
            this.cboxNumSections.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16"});
            this.cboxNumSections.Location = new System.Drawing.Point(350, 453);
            this.cboxNumSections.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cboxNumSections.Name = "cboxNumSections";
            this.cboxNumSections.Size = new System.Drawing.Size(74, 50);
            this.cboxNumSections.TabIndex = 295;
            this.cboxNumSections.SelectedIndexChanged += new System.EventHandler(this.cboxNumSections_SelectedIndexChanged);
            // 
            // lblVehicleToolWidth
            // 
            this.lblVehicleToolWidth.AutoSize = true;
            this.lblVehicleToolWidth.Font = new System.Drawing.Font("Tahoma", 24F);
            this.lblVehicleToolWidth.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblVehicleToolWidth.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblVehicleToolWidth.Location = new System.Drawing.Point(442, 459);
            this.lblVehicleToolWidth.Name = "lblVehicleToolWidth";
            this.lblVehicleToolWidth.Size = new System.Drawing.Size(41, 39);
            this.lblVehicleToolWidth.TabIndex = 294;
            this.lblVehicleToolWidth.Text = "II";
            // 
            // label50
            // 
            this.label50.BackColor = System.Drawing.Color.Transparent;
            this.label50.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.label50.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label50.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label50.Location = new System.Drawing.Point(621, 451);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(141, 61);
            this.label50.TabIndex = 293;
            this.label50.Text = "Min UnApplied";
            this.label50.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // nudMinApplied
            // 
            this.nudMinApplied.BackColor = System.Drawing.Color.AliceBlue;
            this.nudMinApplied.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMinApplied.InterceptArrowKeys = false;
            this.nudMinApplied.Location = new System.Drawing.Point(650, 519);
            this.nudMinApplied.Name = "nudMinApplied";
            this.nudMinApplied.Size = new System.Drawing.Size(92, 52);
            this.nudMinApplied.TabIndex = 292;
            this.nudMinApplied.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudMinApplied.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudMinApplied.Enter += new System.EventHandler(this.nudMinApplied_Enter);
            // 
            // label51
            // 
            this.label51.BackColor = System.Drawing.Color.Transparent;
            this.label51.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.label51.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label51.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label51.Location = new System.Drawing.Point(327, 383);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(119, 61);
            this.label51.TabIndex = 291;
            this.label51.Text = "# Of Sections";
            this.label51.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(432, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 25);
            this.label1.TabIndex = 290;
            this.label1.Text = "16";
            // 
            // nudSection16
            // 
            this.nudSection16.BackColor = System.Drawing.Color.AliceBlue;
            this.nudSection16.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSection16.InterceptArrowKeys = false;
            this.nudSection16.Location = new System.Drawing.Point(402, 313);
            this.nudSection16.Maximum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.nudSection16.Name = "nudSection16";
            this.nudSection16.Size = new System.Drawing.Size(100, 46);
            this.nudSection16.TabIndex = 289;
            this.nudSection16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudSection16.Value = new decimal(new int[] {
            92,
            0,
            0,
            0});
            this.nudSection16.Enter += new System.EventHandler(this.NudSection1_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(298, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 25);
            this.label4.TabIndex = 288;
            this.label4.Text = "15";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label19.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label19.Location = new System.Drawing.Point(173, 285);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(38, 25);
            this.label19.TabIndex = 287;
            this.label19.Text = "14";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label30.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label30.Location = new System.Drawing.Point(49, 287);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(38, 25);
            this.label30.TabIndex = 286;
            this.label30.Text = "13";
            // 
            // nudSection15
            // 
            this.nudSection15.BackColor = System.Drawing.Color.AliceBlue;
            this.nudSection15.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSection15.InterceptArrowKeys = false;
            this.nudSection15.Location = new System.Drawing.Point(273, 313);
            this.nudSection15.Maximum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.nudSection15.Name = "nudSection15";
            this.nudSection15.Size = new System.Drawing.Size(100, 46);
            this.nudSection15.TabIndex = 285;
            this.nudSection15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudSection15.Value = new decimal(new int[] {
            92,
            0,
            0,
            0});
            this.nudSection15.Enter += new System.EventHandler(this.NudSection1_Enter);
            // 
            // nudSection14
            // 
            this.nudSection14.BackColor = System.Drawing.Color.AliceBlue;
            this.nudSection14.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSection14.InterceptArrowKeys = false;
            this.nudSection14.Location = new System.Drawing.Point(144, 313);
            this.nudSection14.Maximum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.nudSection14.Name = "nudSection14";
            this.nudSection14.Size = new System.Drawing.Size(100, 46);
            this.nudSection14.TabIndex = 284;
            this.nudSection14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudSection14.Value = new decimal(new int[] {
            92,
            0,
            0,
            0});
            this.nudSection14.Enter += new System.EventHandler(this.NudSection1_Enter);
            // 
            // nudSection13
            // 
            this.nudSection13.BackColor = System.Drawing.Color.AliceBlue;
            this.nudSection13.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSection13.InterceptArrowKeys = false;
            this.nudSection13.Location = new System.Drawing.Point(15, 312);
            this.nudSection13.Maximum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.nudSection13.Name = "nudSection13";
            this.nudSection13.Size = new System.Drawing.Size(100, 46);
            this.nudSection13.TabIndex = 283;
            this.nudSection13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudSection13.Value = new decimal(new int[] {
            92,
            0,
            0,
            0});
            this.nudSection13.Enter += new System.EventHandler(this.NudSection1_Enter);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label32.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label32.Location = new System.Drawing.Point(690, 24);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(25, 25);
            this.label32.TabIndex = 276;
            this.label32.Text = "6";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label34.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label34.Location = new System.Drawing.Point(174, 24);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(25, 25);
            this.label34.TabIndex = 275;
            this.label34.Text = "2";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label35.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label35.Location = new System.Drawing.Point(307, 24);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(25, 25);
            this.label35.TabIndex = 274;
            this.label35.Text = "3";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label40.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label40.Location = new System.Drawing.Point(682, 148);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(38, 25);
            this.label40.TabIndex = 282;
            this.label40.Text = "12";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label39.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label39.Location = new System.Drawing.Point(561, 148);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(38, 25);
            this.label39.TabIndex = 281;
            this.label39.Text = "11";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label38.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label38.Location = new System.Drawing.Point(429, 148);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(38, 25);
            this.label38.TabIndex = 280;
            this.label38.Text = "10";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label37.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label37.Location = new System.Drawing.Point(308, 148);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(25, 25);
            this.label37.TabIndex = 279;
            this.label37.Text = "9";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label41.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label41.Location = new System.Drawing.Point(176, 148);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(25, 25);
            this.label41.TabIndex = 278;
            this.label41.Text = "8";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label45.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label45.Location = new System.Drawing.Point(49, 148);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(25, 25);
            this.label45.TabIndex = 277;
            this.label45.Text = "7";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label46.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label46.Location = new System.Drawing.Point(433, 24);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(25, 25);
            this.label46.TabIndex = 273;
            this.label46.Text = "4";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label47.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label47.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label47.Location = new System.Drawing.Point(562, 24);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(25, 25);
            this.label47.TabIndex = 272;
            this.label47.Text = "5";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label48.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label48.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label48.Location = new System.Drawing.Point(49, 24);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(25, 25);
            this.label48.TabIndex = 271;
            this.label48.Text = "1";
            // 
            // nudSection12
            // 
            this.nudSection12.BackColor = System.Drawing.Color.AliceBlue;
            this.nudSection12.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSection12.InterceptArrowKeys = false;
            this.nudSection12.Location = new System.Drawing.Point(660, 176);
            this.nudSection12.Maximum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.nudSection12.Name = "nudSection12";
            this.nudSection12.Size = new System.Drawing.Size(100, 46);
            this.nudSection12.TabIndex = 270;
            this.nudSection12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudSection12.Value = new decimal(new int[] {
            92,
            0,
            0,
            0});
            this.nudSection12.Enter += new System.EventHandler(this.NudSection1_Enter);
            // 
            // nudSection11
            // 
            this.nudSection11.BackColor = System.Drawing.Color.AliceBlue;
            this.nudSection11.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSection11.InterceptArrowKeys = false;
            this.nudSection11.Location = new System.Drawing.Point(531, 176);
            this.nudSection11.Maximum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.nudSection11.Name = "nudSection11";
            this.nudSection11.Size = new System.Drawing.Size(100, 46);
            this.nudSection11.TabIndex = 269;
            this.nudSection11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudSection11.Value = new decimal(new int[] {
            92,
            0,
            0,
            0});
            this.nudSection11.Enter += new System.EventHandler(this.NudSection1_Enter);
            // 
            // nudSection10
            // 
            this.nudSection10.BackColor = System.Drawing.Color.AliceBlue;
            this.nudSection10.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSection10.InterceptArrowKeys = false;
            this.nudSection10.Location = new System.Drawing.Point(402, 176);
            this.nudSection10.Maximum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.nudSection10.Name = "nudSection10";
            this.nudSection10.Size = new System.Drawing.Size(100, 46);
            this.nudSection10.TabIndex = 268;
            this.nudSection10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudSection10.Value = new decimal(new int[] {
            92,
            0,
            0,
            0});
            this.nudSection10.Enter += new System.EventHandler(this.NudSection1_Enter);
            // 
            // nudSection9
            // 
            this.nudSection9.BackColor = System.Drawing.Color.AliceBlue;
            this.nudSection9.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSection9.InterceptArrowKeys = false;
            this.nudSection9.Location = new System.Drawing.Point(273, 176);
            this.nudSection9.Maximum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.nudSection9.Name = "nudSection9";
            this.nudSection9.Size = new System.Drawing.Size(100, 46);
            this.nudSection9.TabIndex = 267;
            this.nudSection9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudSection9.Value = new decimal(new int[] {
            92,
            0,
            0,
            0});
            this.nudSection9.Enter += new System.EventHandler(this.NudSection1_Enter);
            // 
            // nudSection8
            // 
            this.nudSection8.BackColor = System.Drawing.Color.AliceBlue;
            this.nudSection8.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSection8.InterceptArrowKeys = false;
            this.nudSection8.Location = new System.Drawing.Point(144, 176);
            this.nudSection8.Maximum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.nudSection8.Name = "nudSection8";
            this.nudSection8.Size = new System.Drawing.Size(100, 46);
            this.nudSection8.TabIndex = 266;
            this.nudSection8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudSection8.Value = new decimal(new int[] {
            92,
            0,
            0,
            0});
            this.nudSection8.Enter += new System.EventHandler(this.NudSection1_Enter);
            // 
            // nudSection7
            // 
            this.nudSection7.BackColor = System.Drawing.Color.AliceBlue;
            this.nudSection7.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSection7.InterceptArrowKeys = false;
            this.nudSection7.Location = new System.Drawing.Point(15, 176);
            this.nudSection7.Maximum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.nudSection7.Name = "nudSection7";
            this.nudSection7.Size = new System.Drawing.Size(100, 46);
            this.nudSection7.TabIndex = 265;
            this.nudSection7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudSection7.Value = new decimal(new int[] {
            93,
            0,
            0,
            0});
            this.nudSection7.Enter += new System.EventHandler(this.NudSection1_Enter);
            // 
            // nudSection6
            // 
            this.nudSection6.BackColor = System.Drawing.Color.AliceBlue;
            this.nudSection6.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSection6.InterceptArrowKeys = false;
            this.nudSection6.Location = new System.Drawing.Point(660, 52);
            this.nudSection6.Maximum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.nudSection6.Name = "nudSection6";
            this.nudSection6.Size = new System.Drawing.Size(100, 46);
            this.nudSection6.TabIndex = 264;
            this.nudSection6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudSection6.Value = new decimal(new int[] {
            3888,
            0,
            0,
            0});
            this.nudSection6.Enter += new System.EventHandler(this.NudSection1_Enter);
            // 
            // nudSection5
            // 
            this.nudSection5.BackColor = System.Drawing.Color.AliceBlue;
            this.nudSection5.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSection5.InterceptArrowKeys = false;
            this.nudSection5.Location = new System.Drawing.Point(531, 52);
            this.nudSection5.Maximum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.nudSection5.Name = "nudSection5";
            this.nudSection5.Size = new System.Drawing.Size(100, 46);
            this.nudSection5.TabIndex = 263;
            this.nudSection5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudSection5.Value = new decimal(new int[] {
            95,
            0,
            0,
            0});
            this.nudSection5.Enter += new System.EventHandler(this.NudSection1_Enter);
            // 
            // nudSection4
            // 
            this.nudSection4.BackColor = System.Drawing.Color.AliceBlue;
            this.nudSection4.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSection4.InterceptArrowKeys = false;
            this.nudSection4.Location = new System.Drawing.Point(402, 52);
            this.nudSection4.Maximum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.nudSection4.Name = "nudSection4";
            this.nudSection4.Size = new System.Drawing.Size(100, 46);
            this.nudSection4.TabIndex = 262;
            this.nudSection4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudSection4.Value = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.nudSection4.Enter += new System.EventHandler(this.NudSection1_Enter);
            // 
            // nudSection3
            // 
            this.nudSection3.BackColor = System.Drawing.Color.AliceBlue;
            this.nudSection3.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSection3.InterceptArrowKeys = false;
            this.nudSection3.Location = new System.Drawing.Point(273, 52);
            this.nudSection3.Maximum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.nudSection3.Name = "nudSection3";
            this.nudSection3.Size = new System.Drawing.Size(100, 46);
            this.nudSection3.TabIndex = 261;
            this.nudSection3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudSection3.Value = new decimal(new int[] {
            97,
            0,
            0,
            0});
            this.nudSection3.Enter += new System.EventHandler(this.NudSection1_Enter);
            // 
            // nudSection2
            // 
            this.nudSection2.BackColor = System.Drawing.Color.AliceBlue;
            this.nudSection2.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSection2.InterceptArrowKeys = false;
            this.nudSection2.Location = new System.Drawing.Point(144, 52);
            this.nudSection2.Maximum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.nudSection2.Name = "nudSection2";
            this.nudSection2.Size = new System.Drawing.Size(100, 46);
            this.nudSection2.TabIndex = 260;
            this.nudSection2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudSection2.Value = new decimal(new int[] {
            98,
            0,
            0,
            0});
            this.nudSection2.Enter += new System.EventHandler(this.NudSection1_Enter);
            // 
            // nudSection1
            // 
            this.nudSection1.BackColor = System.Drawing.Color.AliceBlue;
            this.nudSection1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSection1.InterceptArrowKeys = false;
            this.nudSection1.Location = new System.Drawing.Point(15, 52);
            this.nudSection1.Maximum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.nudSection1.Name = "nudSection1";
            this.nudSection1.Size = new System.Drawing.Size(100, 46);
            this.nudSection1.TabIndex = 259;
            this.nudSection1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudSection1.Value = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.nudSection1.Enter += new System.EventHandler(this.NudSection1_Enter);
            // 
            // tabTSwitches
            // 
            this.tabTSwitches.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(60)))));
            this.tabTSwitches.Controls.Add(this.groupBox3);
            this.tabTSwitches.Location = new System.Drawing.Point(4, 44);
            this.tabTSwitches.Name = "tabTSwitches";
            this.tabTSwitches.Size = new System.Drawing.Size(787, 593);
            this.tabTSwitches.TabIndex = 9;
            this.tabTSwitches.Text = "tSwit";
            this.tabTSwitches.Enter += new System.EventHandler(this.tabTSwitches_Enter);
            this.tabTSwitches.Leave += new System.EventHandler(this.tabTSwitches_Leave);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.checkWorkSwitchManual);
            this.groupBox3.Controls.Add(this.chkWorkSwActiveLow);
            this.groupBox3.Controls.Add(this.chkEnableWorkSwitch);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox3.Location = new System.Drawing.Point(61, 113);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(636, 310);
            this.groupBox3.TabIndex = 67;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Work Switch";
            // 
            // checkWorkSwitchManual
            // 
            this.checkWorkSwitchManual.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkWorkSwitchManual.AutoSize = true;
            this.checkWorkSwitchManual.FlatAppearance.CheckedBackColor = System.Drawing.Color.Teal;
            this.checkWorkSwitchManual.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.checkWorkSwitchManual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkWorkSwitchManual.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkWorkSwitchManual.Location = new System.Drawing.Point(46, 234);
            this.checkWorkSwitchManual.Name = "checkWorkSwitchManual";
            this.checkWorkSwitchManual.Size = new System.Drawing.Size(371, 43);
            this.checkWorkSwitchManual.TabIndex = 0;
            this.checkWorkSwitchManual.Text = "Work Switch Controls Manual";
            this.checkWorkSwitchManual.UseVisualStyleBackColor = true;
            // 
            // chkWorkSwActiveLow
            // 
            this.chkWorkSwActiveLow.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkWorkSwActiveLow.AutoSize = true;
            this.chkWorkSwActiveLow.FlatAppearance.CheckedBackColor = System.Drawing.Color.Teal;
            this.chkWorkSwActiveLow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.chkWorkSwActiveLow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkWorkSwActiveLow.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkWorkSwActiveLow.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkWorkSwActiveLow.Location = new System.Drawing.Point(46, 147);
            this.chkWorkSwActiveLow.Name = "chkWorkSwActiveLow";
            this.chkWorkSwActiveLow.Size = new System.Drawing.Size(151, 43);
            this.chkWorkSwActiveLow.TabIndex = 0;
            this.chkWorkSwActiveLow.Text = "Active Low";
            this.chkWorkSwActiveLow.UseVisualStyleBackColor = true;
            // 
            // chkEnableWorkSwitch
            // 
            this.chkEnableWorkSwitch.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkEnableWorkSwitch.AutoSize = true;
            this.chkEnableWorkSwitch.FlatAppearance.CheckedBackColor = System.Drawing.Color.Teal;
            this.chkEnableWorkSwitch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.chkEnableWorkSwitch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkEnableWorkSwitch.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEnableWorkSwitch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkEnableWorkSwitch.Location = new System.Drawing.Point(46, 60);
            this.chkEnableWorkSwitch.Name = "chkEnableWorkSwitch";
            this.chkEnableWorkSwitch.Size = new System.Drawing.Size(259, 43);
            this.chkEnableWorkSwitch.TabIndex = 1;
            this.chkEnableWorkSwitch.Text = "Enable Work Switch";
            this.chkEnableWorkSwitch.UseVisualStyleBackColor = true;
            // 
            // tabTSettings
            // 
            this.tabTSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(60)))));
            this.tabTSettings.Controls.Add(this.label69);
            this.tabTSettings.Controls.Add(this.nudHydLiftLookAhead);
            this.tabTSettings.Controls.Add(this.btnNext3);
            this.tabTSettings.Controls.Add(this.label16);
            this.tabTSettings.Controls.Add(this.nudLookAheadOff);
            this.tabTSettings.Controls.Add(this.nudOffset);
            this.tabTSettings.Controls.Add(this.label43);
            this.tabTSettings.Controls.Add(this.nudTurnOffDelay);
            this.tabTSettings.Controls.Add(this.label44);
            this.tabTSettings.Controls.Add(this.nudLookAhead);
            this.tabTSettings.Controls.Add(this.nudOverlap);
            this.tabTSettings.Controls.Add(this.pictureBox3);
            this.tabTSettings.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tabTSettings.Location = new System.Drawing.Point(4, 44);
            this.tabTSettings.Name = "tabTSettings";
            this.tabTSettings.Size = new System.Drawing.Size(787, 593);
            this.tabTSettings.TabIndex = 10;
            this.tabTSettings.Text = "TSettings";
            this.tabTSettings.Enter += new System.EventHandler(this.tabTSettings_Enter);
            this.tabTSettings.Leave += new System.EventHandler(this.tabTSettings_Leave);
            // 
            // label69
            // 
            this.label69.BackColor = System.Drawing.Color.Transparent;
            this.label69.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.label69.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label69.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label69.Location = new System.Drawing.Point(591, 426);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(151, 53);
            this.label69.TabIndex = 128;
            this.label69.Text = "Hydraulic Lift Look Ahead";
            this.label69.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // nudHydLiftLookAhead
            // 
            this.nudHydLiftLookAhead.BackColor = System.Drawing.Color.AliceBlue;
            this.nudHydLiftLookAhead.DecimalPlaces = 1;
            this.nudHydLiftLookAhead.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudHydLiftLookAhead.InterceptArrowKeys = false;
            this.nudHydLiftLookAhead.Location = new System.Drawing.Point(595, 491);
            this.nudHydLiftLookAhead.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudHydLiftLookAhead.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudHydLiftLookAhead.Name = "nudHydLiftLookAhead";
            this.nudHydLiftLookAhead.Size = new System.Drawing.Size(148, 52);
            this.nudHydLiftLookAhead.TabIndex = 117;
            this.nudHydLiftLookAhead.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudHydLiftLookAhead.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudHydLiftLookAhead.Enter += new System.EventHandler(this.nudHydLiftSecs_Enter);
            // 
            // btnNext3
            // 
            this.btnNext3.BackColor = System.Drawing.Color.Transparent;
            this.btnNext3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNext3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext3.Location = new System.Drawing.Point(728, 8);
            this.btnNext3.Name = "btnNext3";
            this.btnNext3.Size = new System.Drawing.Size(31, 25);
            this.btnNext3.TabIndex = 0;
            this.btnNext3.UseVisualStyleBackColor = false;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.label16.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label16.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label16.Location = new System.Drawing.Point(2, 208);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(151, 53);
            this.label16.TabIndex = 125;
            this.label16.Text = "Turn Off Ahead (Secs)";
            this.label16.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // nudLookAheadOff
            // 
            this.nudLookAheadOff.BackColor = System.Drawing.Color.AliceBlue;
            this.nudLookAheadOff.DecimalPlaces = 1;
            this.nudLookAheadOff.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudLookAheadOff.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudLookAheadOff.InterceptArrowKeys = false;
            this.nudLookAheadOff.Location = new System.Drawing.Point(6, 273);
            this.nudLookAheadOff.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudLookAheadOff.Name = "nudLookAheadOff";
            this.nudLookAheadOff.Size = new System.Drawing.Size(114, 52);
            this.nudLookAheadOff.TabIndex = 124;
            this.nudLookAheadOff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudLookAheadOff.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudLookAheadOff.Enter += new System.EventHandler(this.nudLookAheadOff_Enter);
            // 
            // nudOffset
            // 
            this.nudOffset.BackColor = System.Drawing.Color.AliceBlue;
            this.nudOffset.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudOffset.InterceptArrowKeys = false;
            this.nudOffset.Location = new System.Drawing.Point(367, 435);
            this.nudOffset.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.nudOffset.Minimum = new decimal(new int[] {
            2500,
            0,
            0,
            -2147483648});
            this.nudOffset.Name = "nudOffset";
            this.nudOffset.Size = new System.Drawing.Size(114, 52);
            this.nudOffset.TabIndex = 115;
            this.nudOffset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudOffset.Value = new decimal(new int[] {
            8,
            0,
            0,
            -2147483648});
            this.nudOffset.Enter += new System.EventHandler(this.nudOffset_Enter);
            // 
            // label43
            // 
            this.label43.BackColor = System.Drawing.Color.Transparent;
            this.label43.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.label43.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label43.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label43.Location = new System.Drawing.Point(2, 403);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(151, 53);
            this.label43.TabIndex = 120;
            this.label43.Text = "Turn Off Delay (Secs)";
            this.label43.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // nudTurnOffDelay
            // 
            this.nudTurnOffDelay.BackColor = System.Drawing.Color.AliceBlue;
            this.nudTurnOffDelay.DecimalPlaces = 1;
            this.nudTurnOffDelay.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudTurnOffDelay.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudTurnOffDelay.InterceptArrowKeys = false;
            this.nudTurnOffDelay.Location = new System.Drawing.Point(6, 464);
            this.nudTurnOffDelay.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudTurnOffDelay.Name = "nudTurnOffDelay";
            this.nudTurnOffDelay.Size = new System.Drawing.Size(114, 52);
            this.nudTurnOffDelay.TabIndex = 119;
            this.nudTurnOffDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudTurnOffDelay.Enter += new System.EventHandler(this.nudTurnOffDelay_Enter);
            // 
            // label44
            // 
            this.label44.BackColor = System.Drawing.Color.Transparent;
            this.label44.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.label44.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label44.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label44.Location = new System.Drawing.Point(2, 30);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(151, 53);
            this.label44.TabIndex = 118;
            this.label44.Text = "Turn On Ahead (Secs)";
            this.label44.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // nudLookAhead
            // 
            this.nudLookAhead.BackColor = System.Drawing.Color.AliceBlue;
            this.nudLookAhead.DecimalPlaces = 1;
            this.nudLookAhead.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudLookAhead.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudLookAhead.InterceptArrowKeys = false;
            this.nudLookAhead.Location = new System.Drawing.Point(6, 93);
            this.nudLookAhead.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudLookAhead.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.nudLookAhead.Name = "nudLookAhead";
            this.nudLookAhead.Size = new System.Drawing.Size(114, 52);
            this.nudLookAhead.TabIndex = 117;
            this.nudLookAhead.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudLookAhead.Value = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            this.nudLookAhead.Enter += new System.EventHandler(this.nudLookAhead_Enter);
            // 
            // nudOverlap
            // 
            this.nudOverlap.BackColor = System.Drawing.Color.AliceBlue;
            this.nudOverlap.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudOverlap.InterceptArrowKeys = false;
            this.nudOverlap.Location = new System.Drawing.Point(566, 282);
            this.nudOverlap.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nudOverlap.Minimum = new decimal(new int[] {
            300,
            0,
            0,
            -2147483648});
            this.nudOverlap.Name = "nudOverlap";
            this.nudOverlap.Size = new System.Drawing.Size(114, 52);
            this.nudOverlap.TabIndex = 116;
            this.nudOverlap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudOverlap.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudOverlap.Enter += new System.EventHandler(this.nudOverlap_Enter);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::AgOpenGPS.Properties.Resources.ImplementSettings;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(107, 37);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(660, 534);
            this.pictureBox3.TabIndex = 127;
            this.pictureBox3.TabStop = false;
            // 
            // tabDFix
            // 
            this.tabDFix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(60)))));
            this.tabDFix.Controls.Add(this.label2);
            this.tabDFix.Controls.Add(this.cboxIsRTK);
            this.tabDFix.Controls.Add(this.groupBox4);
            this.tabDFix.Location = new System.Drawing.Point(4, 44);
            this.tabDFix.Name = "tabDFix";
            this.tabDFix.Size = new System.Drawing.Size(787, 593);
            this.tabDFix.TabIndex = 17;
            this.tabDFix.Text = "dFix";
            this.tabDFix.Enter += new System.EventHandler(this.tabDFix_Enter);
            this.tabDFix.Leave += new System.EventHandler(this.tabDFix_Leave);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(540, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 23);
            this.label2.TabIndex = 92;
            this.label2.Text = "Alarm";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboxIsRTK
            // 
            this.cboxIsRTK.Appearance = System.Windows.Forms.Appearance.Button;
            this.cboxIsRTK.FlatAppearance.CheckedBackColor = System.Drawing.Color.Teal;
            this.cboxIsRTK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboxIsRTK.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxIsRTK.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.cboxIsRTK.Location = new System.Drawing.Point(507, 110);
            this.cboxIsRTK.Name = "cboxIsRTK";
            this.cboxIsRTK.Size = new System.Drawing.Size(140, 43);
            this.cboxIsRTK.TabIndex = 91;
            this.cboxIsRTK.Text = "RTK ?";
            this.cboxIsRTK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cboxIsRTK.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbtnOGI);
            this.groupBox4.Controls.Add(this.rbtnRMC);
            this.groupBox4.Controls.Add(this.rbtnGGA);
            this.groupBox4.Controls.Add(this.lblSimGGA);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox4.Location = new System.Drawing.Point(62, 61);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(312, 264);
            this.groupBox4.TabIndex = 72;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Position From";
            // 
            // rbtnOGI
            // 
            this.rbtnOGI.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtnOGI.FlatAppearance.CheckedBackColor = System.Drawing.Color.Teal;
            this.rbtnOGI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnOGI.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnOGI.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.rbtnOGI.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rbtnOGI.Location = new System.Drawing.Point(21, 197);
            this.rbtnOGI.Name = "rbtnOGI";
            this.rbtnOGI.Size = new System.Drawing.Size(140, 43);
            this.rbtnOGI.TabIndex = 71;
            this.rbtnOGI.TabStop = true;
            this.rbtnOGI.Text = "OGI";
            this.rbtnOGI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtnOGI.UseVisualStyleBackColor = true;
            // 
            // rbtnRMC
            // 
            this.rbtnRMC.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtnRMC.FlatAppearance.CheckedBackColor = System.Drawing.Color.Teal;
            this.rbtnRMC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnRMC.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnRMC.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.rbtnRMC.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rbtnRMC.Location = new System.Drawing.Point(21, 122);
            this.rbtnRMC.Name = "rbtnRMC";
            this.rbtnRMC.Size = new System.Drawing.Size(140, 43);
            this.rbtnRMC.TabIndex = 70;
            this.rbtnRMC.TabStop = true;
            this.rbtnRMC.Text = "RMC";
            this.rbtnRMC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtnRMC.UseVisualStyleBackColor = true;
            // 
            // rbtnGGA
            // 
            this.rbtnGGA.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtnGGA.FlatAppearance.CheckedBackColor = System.Drawing.Color.Teal;
            this.rbtnGGA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnGGA.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnGGA.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.rbtnGGA.Location = new System.Drawing.Point(21, 47);
            this.rbtnGGA.Name = "rbtnGGA";
            this.rbtnGGA.Size = new System.Drawing.Size(140, 43);
            this.rbtnGGA.TabIndex = 69;
            this.rbtnGGA.TabStop = true;
            this.rbtnGGA.Text = "GGA";
            this.rbtnGGA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtnGGA.UseVisualStyleBackColor = true;
            this.rbtnGGA.CheckedChanged += new System.EventHandler(this.rbtnGGA_CheckedChanged);
            // 
            // lblSimGGA
            // 
            this.lblSimGGA.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSimGGA.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblSimGGA.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSimGGA.Location = new System.Drawing.Point(167, 47);
            this.lblSimGGA.Name = "lblSimGGA";
            this.lblSimGGA.Size = new System.Drawing.Size(139, 45);
            this.lblSimGGA.TabIndex = 87;
            this.lblSimGGA.Text = "Use GGA For Simulator";
            this.lblSimGGA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabDHeading
            // 
            this.tabDHeading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(60)))));
            this.tabDHeading.Controls.Add(this.button3);
            this.tabDHeading.Controls.Add(this.label15);
            this.tabDHeading.Controls.Add(this.label9);
            this.tabDHeading.Controls.Add(this.label8);
            this.tabDHeading.Controls.Add(this.nudStartSpeed);
            this.tabDHeading.Controls.Add(this.nudMinFixStepDistance);
            this.tabDHeading.Controls.Add(this.lblFusionIMU);
            this.tabDHeading.Controls.Add(this.label6);
            this.tabDHeading.Controls.Add(this.label5);
            this.tabDHeading.Controls.Add(this.label7);
            this.tabDHeading.Controls.Add(this.hsbarFusion);
            this.tabDHeading.Controls.Add(this.lblIMUFusion);
            this.tabDHeading.Controls.Add(this.lblFusion);
            this.tabDHeading.Controls.Add(this.headingGroupBox);
            this.tabDHeading.Location = new System.Drawing.Point(4, 44);
            this.tabDHeading.Name = "tabDHeading";
            this.tabDHeading.Size = new System.Drawing.Size(787, 593);
            this.tabDHeading.TabIndex = 15;
            this.tabDHeading.Text = "dHead";
            this.tabDHeading.Enter += new System.EventHandler(this.tabDHeading_Enter);
            this.tabDHeading.Leave += new System.EventHandler(this.tabDHeading_Leave);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(749, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(31, 28);
            this.button3.TabIndex = 0;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label15.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label15.Location = new System.Drawing.Point(366, 78);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 23);
            this.label15.TabIndex = 307;
            this.label15.Text = "Fix Trigger";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(565, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(165, 23);
            this.label9.TabIndex = 306;
            this.label9.Text = "Start Speed (kmh)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(366, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 23);
            this.label8.TabIndex = 305;
            this.label8.Text = "Distance (m)";
            // 
            // nudStartSpeed
            // 
            this.nudStartSpeed.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.nudStartSpeed.DecimalPlaces = 1;
            this.nudStartSpeed.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudStartSpeed.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nudStartSpeed.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudStartSpeed.InterceptArrowKeys = false;
            this.nudStartSpeed.Location = new System.Drawing.Point(569, 133);
            this.nudStartSpeed.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudStartSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudStartSpeed.Name = "nudStartSpeed";
            this.nudStartSpeed.Size = new System.Drawing.Size(129, 52);
            this.nudStartSpeed.TabIndex = 3;
            this.nudStartSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudStartSpeed.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudStartSpeed.Enter += new System.EventHandler(this.nudStartSpeed_Enter);
            // 
            // nudMinFixStepDistance
            // 
            this.nudMinFixStepDistance.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.nudMinFixStepDistance.DecimalPlaces = 1;
            this.nudMinFixStepDistance.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMinFixStepDistance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nudMinFixStepDistance.Increment = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.nudMinFixStepDistance.InterceptArrowKeys = false;
            this.nudMinFixStepDistance.Location = new System.Drawing.Point(355, 133);
            this.nudMinFixStepDistance.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudMinFixStepDistance.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.nudMinFixStepDistance.Name = "nudMinFixStepDistance";
            this.nudMinFixStepDistance.Size = new System.Drawing.Size(129, 52);
            this.nudMinFixStepDistance.TabIndex = 2;
            this.nudMinFixStepDistance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudMinFixStepDistance.Value = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            this.nudMinFixStepDistance.Enter += new System.EventHandler(this.nudMinFixStepDistance_Enter);
            // 
            // lblFusionIMU
            // 
            this.lblFusionIMU.AutoSize = true;
            this.lblFusionIMU.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFusionIMU.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFusionIMU.Location = new System.Drawing.Point(72, 447);
            this.lblFusionIMU.Name = "lblFusionIMU";
            this.lblFusionIMU.Size = new System.Drawing.Size(91, 39);
            this.lblFusionIMU.TabIndex = 302;
            this.lblFusionIMU.Text = "-888";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(227, 495);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 23);
            this.label6.TabIndex = 301;
            this.label6.Text = "Default 25";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(119, 416);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 23);
            this.label5.TabIndex = 300;
            this.label5.Text = "IMU <";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(379, 416);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 23);
            this.label7.TabIndex = 299;
            this.label7.Text = "> GPS";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hsbarFusion
            // 
            this.hsbarFusion.LargeChange = 1;
            this.hsbarFusion.Location = new System.Drawing.Point(169, 446);
            this.hsbarFusion.Maximum = 50;
            this.hsbarFusion.Minimum = 5;
            this.hsbarFusion.Name = "hsbarFusion";
            this.hsbarFusion.Size = new System.Drawing.Size(235, 43);
            this.hsbarFusion.TabIndex = 1;
            this.hsbarFusion.Value = 25;
            this.hsbarFusion.ValueChanged += new System.EventHandler(this.hsbarFusion_ValueChanged);
            // 
            // lblIMUFusion
            // 
            this.lblIMUFusion.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIMUFusion.ForeColor = System.Drawing.SystemColors.Control;
            this.lblIMUFusion.Location = new System.Drawing.Point(230, 416);
            this.lblIMUFusion.Name = "lblIMUFusion";
            this.lblIMUFusion.Size = new System.Drawing.Size(109, 23);
            this.lblIMUFusion.TabIndex = 297;
            this.lblIMUFusion.Text = "IMU GPS Fusion";
            this.lblIMUFusion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFusion
            // 
            this.lblFusion.AutoSize = true;
            this.lblFusion.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFusion.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFusion.Location = new System.Drawing.Point(409, 447);
            this.lblFusion.Name = "lblFusion";
            this.lblFusion.Size = new System.Drawing.Size(91, 39);
            this.lblFusion.TabIndex = 298;
            this.lblFusion.Text = "-888";
            // 
            // headingGroupBox
            // 
            this.headingGroupBox.Controls.Add(this.label13);
            this.headingGroupBox.Controls.Add(this.label12);
            this.headingGroupBox.Controls.Add(this.label11);
            this.headingGroupBox.Controls.Add(this.rbtnHeadingHDT);
            this.headingGroupBox.Controls.Add(this.rbtnHeadingGPS);
            this.headingGroupBox.Controls.Add(this.rbtnHeadingFix);
            this.headingGroupBox.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headingGroupBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.headingGroupBox.Location = new System.Drawing.Point(22, 43);
            this.headingGroupBox.Name = "headingGroupBox";
            this.headingGroupBox.Size = new System.Drawing.Size(250, 288);
            this.headingGroupBox.TabIndex = 85;
            this.headingGroupBox.TabStop = false;
            this.headingGroupBox.Text = "GPS Heading From";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label13.Location = new System.Drawing.Point(149, 219);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 43);
            this.label13.TabIndex = 88;
            this.label13.Text = "Dual\r\nAntenna";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label12.Location = new System.Drawing.Point(149, 136);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 43);
            this.label12.TabIndex = 87;
            this.label12.Text = "From VTG \r\n    or RMC ";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(149, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 43);
            this.label11.TabIndex = 86;
            this.label11.Text = "Fix to Fix";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rbtnHeadingHDT
            // 
            this.rbtnHeadingHDT.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtnHeadingHDT.FlatAppearance.CheckedBackColor = System.Drawing.Color.Teal;
            this.rbtnHeadingHDT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnHeadingHDT.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnHeadingHDT.Location = new System.Drawing.Point(23, 219);
            this.rbtnHeadingHDT.Name = "rbtnHeadingHDT";
            this.rbtnHeadingHDT.Size = new System.Drawing.Size(117, 43);
            this.rbtnHeadingHDT.TabIndex = 2;
            this.rbtnHeadingHDT.Text = "Dual";
            this.rbtnHeadingHDT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtnHeadingHDT.UseVisualStyleBackColor = true;
            // 
            // rbtnHeadingGPS
            // 
            this.rbtnHeadingGPS.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtnHeadingGPS.FlatAppearance.CheckedBackColor = System.Drawing.Color.Teal;
            this.rbtnHeadingGPS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnHeadingGPS.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnHeadingGPS.Location = new System.Drawing.Point(23, 137);
            this.rbtnHeadingGPS.Name = "rbtnHeadingGPS";
            this.rbtnHeadingGPS.Size = new System.Drawing.Size(117, 43);
            this.rbtnHeadingGPS.TabIndex = 1;
            this.rbtnHeadingGPS.Text = "GPS";
            this.rbtnHeadingGPS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtnHeadingGPS.UseVisualStyleBackColor = true;
            // 
            // rbtnHeadingFix
            // 
            this.rbtnHeadingFix.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtnHeadingFix.FlatAppearance.CheckedBackColor = System.Drawing.Color.Teal;
            this.rbtnHeadingFix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnHeadingFix.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnHeadingFix.Location = new System.Drawing.Point(23, 55);
            this.rbtnHeadingFix.Name = "rbtnHeadingFix";
            this.rbtnHeadingFix.Size = new System.Drawing.Size(117, 43);
            this.rbtnHeadingFix.TabIndex = 0;
            this.rbtnHeadingFix.Text = "Fix";
            this.rbtnHeadingFix.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtnHeadingFix.UseVisualStyleBackColor = true;
            this.rbtnHeadingFix.CheckedChanged += new System.EventHandler(this.rbtnHeadingFix_CheckedChanged);
            // 
            // tabDRoll
            // 
            this.tabDRoll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(60)))));
            this.tabDRoll.Controls.Add(this.cboxDataInvertRoll);
            this.tabDRoll.Controls.Add(this.btnResetIMU);
            this.tabDRoll.Controls.Add(this.btnRollZero);
            this.tabDRoll.Controls.Add(this.label24);
            this.tabDRoll.Controls.Add(this.label26);
            this.tabDRoll.Controls.Add(this.lblRollFilterPercent);
            this.tabDRoll.Controls.Add(this.label18);
            this.tabDRoll.Controls.Add(this.hsbarRollFilter);
            this.tabDRoll.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tabDRoll.Location = new System.Drawing.Point(4, 44);
            this.tabDRoll.Name = "tabDRoll";
            this.tabDRoll.Size = new System.Drawing.Size(787, 593);
            this.tabDRoll.TabIndex = 16;
            this.tabDRoll.Text = "dRoll";
            this.tabDRoll.Enter += new System.EventHandler(this.tabDRoll_Enter);
            this.tabDRoll.Leave += new System.EventHandler(this.tabDRoll_Leave);
            // 
            // cboxDataInvertRoll
            // 
            this.cboxDataInvertRoll.Appearance = System.Windows.Forms.Appearance.Button;
            this.cboxDataInvertRoll.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.cboxDataInvertRoll.FlatAppearance.CheckedBackColor = System.Drawing.Color.Teal;
            this.cboxDataInvertRoll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboxDataInvertRoll.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxDataInvertRoll.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cboxDataInvertRoll.Location = new System.Drawing.Point(474, 209);
            this.cboxDataInvertRoll.Name = "cboxDataInvertRoll";
            this.cboxDataInvertRoll.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cboxDataInvertRoll.Size = new System.Drawing.Size(192, 70);
            this.cboxDataInvertRoll.TabIndex = 452;
            this.cboxDataInvertRoll.Text = "Invert Roll";
            this.cboxDataInvertRoll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cboxDataInvertRoll.UseVisualStyleBackColor = true;
            // 
            // btnResetIMU
            // 
            this.btnResetIMU.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.btnResetIMU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetIMU.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetIMU.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnResetIMU.Location = new System.Drawing.Point(519, 69);
            this.btnResetIMU.Name = "btnResetIMU";
            this.btnResetIMU.Size = new System.Drawing.Size(103, 48);
            this.btnResetIMU.TabIndex = 85;
            this.btnResetIMU.Text = "Reset IMU";
            this.btnResetIMU.UseVisualStyleBackColor = true;
            this.btnResetIMU.Click += new System.EventHandler(this.btnResetIMU_Click);
            // 
            // btnRollZero
            // 
            this.btnRollZero.Controls.Add(this.label10);
            this.btnRollZero.Controls.Add(this.btnRemoveZeroOffsetPitch);
            this.btnRollZero.Controls.Add(this.label14);
            this.btnRollZero.Controls.Add(this.btnZeroPitch);
            this.btnRollZero.Controls.Add(this.btnRemoveZeroOffset);
            this.btnRollZero.Controls.Add(this.lblRollZeroOffset);
            this.btnRollZero.Controls.Add(this.btnZeroRoll);
            this.btnRollZero.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRollZero.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRollZero.Location = new System.Drawing.Point(39, 52);
            this.btnRollZero.Name = "btnRollZero";
            this.btnRollZero.Size = new System.Drawing.Size(314, 227);
            this.btnRollZero.TabIndex = 349;
            this.btnRollZero.TabStop = false;
            this.btnRollZero.Text = "Roll Zero";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(204, 293);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 16);
            this.label10.TabIndex = 84;
            this.label10.Text = "Pitch";
            // 
            // btnRemoveZeroOffsetPitch
            // 
            this.btnRemoveZeroOffsetPitch.Enabled = false;
            this.btnRemoveZeroOffsetPitch.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveZeroOffsetPitch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnRemoveZeroOffsetPitch.Location = new System.Drawing.Point(12, 242);
            this.btnRemoveZeroOffsetPitch.Name = "btnRemoveZeroOffsetPitch";
            this.btnRemoveZeroOffsetPitch.Size = new System.Drawing.Size(79, 48);
            this.btnRemoveZeroOffsetPitch.TabIndex = 79;
            this.btnRemoveZeroOffsetPitch.Text = "Remove Offset";
            this.btnRemoveZeroOffsetPitch.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 20.25F);
            this.label14.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label14.Location = new System.Drawing.Point(99, 251);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 33);
            this.label14.TabIndex = 78;
            this.label14.Text = "--";
            // 
            // btnZeroPitch
            // 
            this.btnZeroPitch.Enabled = false;
            this.btnZeroPitch.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZeroPitch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnZeroPitch.Location = new System.Drawing.Point(207, 242);
            this.btnZeroPitch.Name = "btnZeroPitch";
            this.btnZeroPitch.Size = new System.Drawing.Size(103, 48);
            this.btnZeroPitch.TabIndex = 77;
            this.btnZeroPitch.Text = "> 0 <";
            this.btnZeroPitch.UseVisualStyleBackColor = true;
            // 
            // btnRemoveZeroOffset
            // 
            this.btnRemoveZeroOffset.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRemoveZeroOffset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveZeroOffset.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveZeroOffset.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnRemoveZeroOffset.Location = new System.Drawing.Point(28, 53);
            this.btnRemoveZeroOffset.Name = "btnRemoveZeroOffset";
            this.btnRemoveZeroOffset.Size = new System.Drawing.Size(103, 49);
            this.btnRemoveZeroOffset.TabIndex = 76;
            this.btnRemoveZeroOffset.Text = "Remove Offset";
            this.btnRemoveZeroOffset.UseVisualStyleBackColor = true;
            this.btnRemoveZeroOffset.Click += new System.EventHandler(this.btnRemoveZeroOffset_Click);
            // 
            // lblRollZeroOffset
            // 
            this.lblRollZeroOffset.AutoSize = true;
            this.lblRollZeroOffset.Font = new System.Drawing.Font("Tahoma", 20.25F);
            this.lblRollZeroOffset.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblRollZeroOffset.Location = new System.Drawing.Point(149, 151);
            this.lblRollZeroOffset.Name = "lblRollZeroOffset";
            this.lblRollZeroOffset.Size = new System.Drawing.Size(100, 33);
            this.lblRollZeroOffset.TabIndex = 75;
            this.lblRollZeroOffset.Text = "label11";
            // 
            // btnZeroRoll
            // 
            this.btnZeroRoll.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.btnZeroRoll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZeroRoll.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZeroRoll.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnZeroRoll.Location = new System.Drawing.Point(28, 142);
            this.btnZeroRoll.Name = "btnZeroRoll";
            this.btnZeroRoll.Size = new System.Drawing.Size(103, 48);
            this.btnZeroRoll.TabIndex = 73;
            this.btnZeroRoll.Text = "> 0 <";
            this.btnZeroRoll.UseVisualStyleBackColor = true;
            this.btnZeroRoll.Click += new System.EventHandler(this.btnZeroRoll_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label24.Location = new System.Drawing.Point(35, 374);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(45, 23);
            this.label24.TabIndex = 347;
            this.label24.Text = "Less";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label26.Location = new System.Drawing.Point(322, 374);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(52, 23);
            this.label26.TabIndex = 346;
            this.label26.Text = "More";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRollFilterPercent
            // 
            this.lblRollFilterPercent.AutoSize = true;
            this.lblRollFilterPercent.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRollFilterPercent.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblRollFilterPercent.Location = new System.Drawing.Point(169, 451);
            this.lblRollFilterPercent.Name = "lblRollFilterPercent";
            this.lblRollFilterPercent.Size = new System.Drawing.Size(95, 39);
            this.lblRollFilterPercent.TabIndex = 344;
            this.lblRollFilterPercent.Text = "65%";
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label18.Location = new System.Drawing.Point(153, 345);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(122, 52);
            this.label18.TabIndex = 345;
            this.label18.Text = "Roll Filter";
            this.label18.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // hsbarRollFilter
            // 
            this.hsbarRollFilter.LargeChange = 1;
            this.hsbarRollFilter.Location = new System.Drawing.Point(39, 400);
            this.hsbarRollFilter.Maximum = 98;
            this.hsbarRollFilter.Minimum = 2;
            this.hsbarRollFilter.Name = "hsbarRollFilter";
            this.hsbarRollFilter.Size = new System.Drawing.Size(335, 43);
            this.hsbarRollFilter.TabIndex = 343;
            this.hsbarRollFilter.Value = 5;
            this.hsbarRollFilter.ValueChanged += new System.EventHandler(this.hsbarRollFilter_ValueChanged);
            // 
            // tabUTurn
            // 
            this.tabUTurn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.tabUTurn.Controls.Add(this.btnTurnSmoothingUp);
            this.tabUTurn.Controls.Add(this.btnTurnSmoothingDown);
            this.tabUTurn.Controls.Add(this.label59);
            this.tabUTurn.Controls.Add(this.lblSmoothing);
            this.tabUTurn.Controls.Add(this.label57);
            this.tabUTurn.Controls.Add(this.label58);
            this.tabUTurn.Controls.Add(this.groupBox7);
            this.tabUTurn.Controls.Add(this.lblTriggerDistance);
            this.tabUTurn.Controls.Add(this.lblWhenTrig);
            this.tabUTurn.Controls.Add(this.btnIsUsingDubins);
            this.tabUTurn.Controls.Add(this.lblDistance);
            this.tabUTurn.Controls.Add(this.label54);
            this.tabUTurn.Controls.Add(this.btnTriggerDistanceDn);
            this.tabUTurn.Controls.Add(this.btnTriggerDistanceUp);
            this.tabUTurn.Controls.Add(this.btnDistanceUp);
            this.tabUTurn.Controls.Add(this.btnDistanceDn);
            this.tabUTurn.Location = new System.Drawing.Point(4, 44);
            this.tabUTurn.Name = "tabUTurn";
            this.tabUTurn.Size = new System.Drawing.Size(787, 593);
            this.tabUTurn.TabIndex = 18;
            this.tabUTurn.Text = "uTurn";
            this.tabUTurn.Enter += new System.EventHandler(this.tabUTurn_Enter);
            this.tabUTurn.Leave += new System.EventHandler(this.tabUTurn_Leave);
            // 
            // btnTurnSmoothingUp
            // 
            this.btnTurnSmoothingUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTurnSmoothingUp.FlatAppearance.BorderSize = 0;
            this.btnTurnSmoothingUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTurnSmoothingUp.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTurnSmoothingUp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTurnSmoothingUp.Image = global::AgOpenGPS.Properties.Resources.UpArrow64;
            this.btnTurnSmoothingUp.Location = new System.Drawing.Point(628, 474);
            this.btnTurnSmoothingUp.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnTurnSmoothingUp.Name = "btnTurnSmoothingUp";
            this.btnTurnSmoothingUp.Size = new System.Drawing.Size(59, 69);
            this.btnTurnSmoothingUp.TabIndex = 466;
            this.btnTurnSmoothingUp.UseVisualStyleBackColor = true;
            this.btnTurnSmoothingUp.Click += new System.EventHandler(this.btnTurnSmoothingUp_Click);
            // 
            // btnTurnSmoothingDown
            // 
            this.btnTurnSmoothingDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTurnSmoothingDown.FlatAppearance.BorderSize = 0;
            this.btnTurnSmoothingDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTurnSmoothingDown.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTurnSmoothingDown.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTurnSmoothingDown.Image = global::AgOpenGPS.Properties.Resources.DnArrow64;
            this.btnTurnSmoothingDown.Location = new System.Drawing.Point(535, 474);
            this.btnTurnSmoothingDown.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnTurnSmoothingDown.Name = "btnTurnSmoothingDown";
            this.btnTurnSmoothingDown.Size = new System.Drawing.Size(59, 69);
            this.btnTurnSmoothingDown.TabIndex = 465;
            this.btnTurnSmoothingDown.UseVisualStyleBackColor = true;
            this.btnTurnSmoothingDown.Click += new System.EventHandler(this.btnTurnSmoothingDown_Click);
            // 
            // label59
            // 
            this.label59.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label59.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label59.Location = new System.Drawing.Point(496, 364);
            this.label59.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(229, 52);
            this.label59.TabIndex = 467;
            this.label59.Text = "UTurn Smoothing";
            this.label59.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblSmoothing
            // 
            this.lblSmoothing.AutoSize = true;
            this.lblSmoothing.BackColor = System.Drawing.Color.Transparent;
            this.lblSmoothing.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSmoothing.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSmoothing.Location = new System.Drawing.Point(564, 418);
            this.lblSmoothing.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSmoothing.Name = "lblSmoothing";
            this.lblSmoothing.Size = new System.Drawing.Size(95, 45);
            this.lblSmoothing.TabIndex = 464;
            this.lblSmoothing.Text = "XXX";
            // 
            // label57
            // 
            this.label57.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label57.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label57.Location = new System.Drawing.Point(231, 278);
            this.label57.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(210, 45);
            this.label57.TabIndex = 459;
            this.label57.Text = "Dubins or Pattern";
            this.label57.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label58
            // 
            this.label58.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label58.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label58.Location = new System.Drawing.Point(73, 364);
            this.label58.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(182, 52);
            this.label58.TabIndex = 463;
            this.label58.Text = "UTurn Distance";
            this.label58.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnYouTurnWideReturn);
            this.groupBox7.Controls.Add(this.btnYouTurnKeyHole);
            this.groupBox7.Controls.Add(this.btnYouTurnSemiCircle);
            this.groupBox7.Controls.Add(this.btnYouTurnRecord);
            this.groupBox7.Controls.Add(this.btnYouTurnCustom);
            this.groupBox7.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox7.Location = new System.Drawing.Point(49, 79);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox7.Size = new System.Drawing.Size(628, 140);
            this.groupBox7.TabIndex = 454;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Turn Patterns";
            // 
            // btnYouTurnWideReturn
            // 
            this.btnYouTurnWideReturn.BackColor = System.Drawing.Color.Transparent;
            this.btnYouTurnWideReturn.FlatAppearance.BorderSize = 0;
            this.btnYouTurnWideReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYouTurnWideReturn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYouTurnWideReturn.Image = global::AgOpenGPS.Properties.Resources.WideReturn;
            this.btnYouTurnWideReturn.Location = new System.Drawing.Point(271, 39);
            this.btnYouTurnWideReturn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnYouTurnWideReturn.Name = "btnYouTurnWideReturn";
            this.btnYouTurnWideReturn.Size = new System.Drawing.Size(83, 84);
            this.btnYouTurnWideReturn.TabIndex = 149;
            this.btnYouTurnWideReturn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnYouTurnWideReturn.UseVisualStyleBackColor = false;
            this.btnYouTurnWideReturn.Click += new System.EventHandler(this.btnYouTurnWideReturn_Click);
            // 
            // btnYouTurnKeyHole
            // 
            this.btnYouTurnKeyHole.BackColor = System.Drawing.Color.Transparent;
            this.btnYouTurnKeyHole.FlatAppearance.BorderSize = 0;
            this.btnYouTurnKeyHole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYouTurnKeyHole.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYouTurnKeyHole.Image = global::AgOpenGPS.Properties.Resources.KeyHole;
            this.btnYouTurnKeyHole.Location = new System.Drawing.Point(35, 40);
            this.btnYouTurnKeyHole.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnYouTurnKeyHole.Name = "btnYouTurnKeyHole";
            this.btnYouTurnKeyHole.Size = new System.Drawing.Size(83, 84);
            this.btnYouTurnKeyHole.TabIndex = 7;
            this.btnYouTurnKeyHole.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnYouTurnKeyHole.UseVisualStyleBackColor = false;
            this.btnYouTurnKeyHole.Click += new System.EventHandler(this.btnYouTurnKeyHole_Click);
            // 
            // btnYouTurnSemiCircle
            // 
            this.btnYouTurnSemiCircle.BackColor = System.Drawing.Color.Transparent;
            this.btnYouTurnSemiCircle.FlatAppearance.BorderSize = 0;
            this.btnYouTurnSemiCircle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYouTurnSemiCircle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYouTurnSemiCircle.Image = global::AgOpenGPS.Properties.Resources.SemiCircle;
            this.btnYouTurnSemiCircle.Location = new System.Drawing.Point(153, 39);
            this.btnYouTurnSemiCircle.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnYouTurnSemiCircle.Name = "btnYouTurnSemiCircle";
            this.btnYouTurnSemiCircle.Size = new System.Drawing.Size(83, 84);
            this.btnYouTurnSemiCircle.TabIndex = 9;
            this.btnYouTurnSemiCircle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnYouTurnSemiCircle.UseVisualStyleBackColor = false;
            this.btnYouTurnSemiCircle.Click += new System.EventHandler(this.btnYouTurnSemiCircle_Click);
            // 
            // btnYouTurnRecord
            // 
            this.btnYouTurnRecord.BackColor = System.Drawing.Color.Transparent;
            this.btnYouTurnRecord.FlatAppearance.BorderSize = 0;
            this.btnYouTurnRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYouTurnRecord.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYouTurnRecord.Image = global::AgOpenGPS.Properties.Resources.BoundaryRecord;
            this.btnYouTurnRecord.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnYouTurnRecord.Location = new System.Drawing.Point(506, 39);
            this.btnYouTurnRecord.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnYouTurnRecord.Name = "btnYouTurnRecord";
            this.btnYouTurnRecord.Size = new System.Drawing.Size(83, 84);
            this.btnYouTurnRecord.TabIndex = 10;
            this.btnYouTurnRecord.Text = "Record";
            this.btnYouTurnRecord.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnYouTurnRecord.UseVisualStyleBackColor = false;
            this.btnYouTurnRecord.Click += new System.EventHandler(this.btnYouTurnRecord_Click);
            // 
            // btnYouTurnCustom
            // 
            this.btnYouTurnCustom.BackColor = System.Drawing.Color.Transparent;
            this.btnYouTurnCustom.FlatAppearance.BorderSize = 0;
            this.btnYouTurnCustom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYouTurnCustom.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYouTurnCustom.Image = global::AgOpenGPS.Properties.Resources.Custom;
            this.btnYouTurnCustom.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnYouTurnCustom.Location = new System.Drawing.Point(406, 39);
            this.btnYouTurnCustom.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnYouTurnCustom.Name = "btnYouTurnCustom";
            this.btnYouTurnCustom.Size = new System.Drawing.Size(83, 84);
            this.btnYouTurnCustom.TabIndex = 8;
            this.btnYouTurnCustom.Text = "Custom";
            this.btnYouTurnCustom.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnYouTurnCustom.UseVisualStyleBackColor = false;
            this.btnYouTurnCustom.Click += new System.EventHandler(this.btnYouTurnCustom_Click);
            // 
            // lblTriggerDistance
            // 
            this.lblTriggerDistance.AutoSize = true;
            this.lblTriggerDistance.BackColor = System.Drawing.Color.Transparent;
            this.lblTriggerDistance.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTriggerDistance.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTriggerDistance.Location = new System.Drawing.Point(121, 418);
            this.lblTriggerDistance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTriggerDistance.Name = "lblTriggerDistance";
            this.lblTriggerDistance.Size = new System.Drawing.Size(95, 45);
            this.lblTriggerDistance.TabIndex = 462;
            this.lblTriggerDistance.Text = "XXX";
            // 
            // lblWhenTrig
            // 
            this.lblWhenTrig.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhenTrig.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblWhenTrig.Location = new System.Drawing.Point(270, 364);
            this.lblWhenTrig.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWhenTrig.Name = "lblWhenTrig";
            this.lblWhenTrig.Size = new System.Drawing.Size(229, 52);
            this.lblWhenTrig.TabIndex = 458;
            this.lblWhenTrig.Text = "UTurn Length";
            this.lblWhenTrig.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnIsUsingDubins
            // 
            this.btnIsUsingDubins.BackColor = System.Drawing.Color.PaleGreen;
            this.btnIsUsingDubins.FlatAppearance.BorderSize = 0;
            this.btnIsUsingDubins.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIsUsingDubins.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIsUsingDubins.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnIsUsingDubins.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnIsUsingDubins.Location = new System.Drawing.Point(136, 258);
            this.btnIsUsingDubins.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnIsUsingDubins.Name = "btnIsUsingDubins";
            this.btnIsUsingDubins.Size = new System.Drawing.Size(91, 84);
            this.btnIsUsingDubins.TabIndex = 453;
            this.btnIsUsingDubins.Text = "Dubins";
            this.btnIsUsingDubins.UseVisualStyleBackColor = false;
            this.btnIsUsingDubins.Click += new System.EventHandler(this.btnIsUsingDubins_Click);
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.BackColor = System.Drawing.Color.Transparent;
            this.lblDistance.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistance.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDistance.Location = new System.Drawing.Point(338, 418);
            this.lblDistance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(95, 45);
            this.lblDistance.TabIndex = 455;
            this.lblDistance.Text = "XXX";
            // 
            // label54
            // 
            this.label54.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label54.AutoSize = true;
            this.label54.BackColor = System.Drawing.Color.Transparent;
            this.label54.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label54.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label54.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label54.Location = new System.Drawing.Point(6, -16);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(59, 19);
            this.label54.TabIndex = 449;
            this.label54.Text = "UTurn";
            this.label54.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTriggerDistanceDn
            // 
            this.btnTriggerDistanceDn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTriggerDistanceDn.FlatAppearance.BorderSize = 0;
            this.btnTriggerDistanceDn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTriggerDistanceDn.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTriggerDistanceDn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTriggerDistanceDn.Image = global::AgOpenGPS.Properties.Resources.DnArrow64;
            this.btnTriggerDistanceDn.Location = new System.Drawing.Point(96, 474);
            this.btnTriggerDistanceDn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnTriggerDistanceDn.Name = "btnTriggerDistanceDn";
            this.btnTriggerDistanceDn.Size = new System.Drawing.Size(59, 69);
            this.btnTriggerDistanceDn.TabIndex = 460;
            this.btnTriggerDistanceDn.UseVisualStyleBackColor = true;
            this.btnTriggerDistanceDn.Click += new System.EventHandler(this.btnTriggerDistanceDn_Click);
            // 
            // btnTriggerDistanceUp
            // 
            this.btnTriggerDistanceUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTriggerDistanceUp.FlatAppearance.BorderSize = 0;
            this.btnTriggerDistanceUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTriggerDistanceUp.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTriggerDistanceUp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTriggerDistanceUp.Image = global::AgOpenGPS.Properties.Resources.UpArrow64;
            this.btnTriggerDistanceUp.Location = new System.Drawing.Point(186, 474);
            this.btnTriggerDistanceUp.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnTriggerDistanceUp.Name = "btnTriggerDistanceUp";
            this.btnTriggerDistanceUp.Size = new System.Drawing.Size(59, 69);
            this.btnTriggerDistanceUp.TabIndex = 461;
            this.btnTriggerDistanceUp.UseVisualStyleBackColor = true;
            this.btnTriggerDistanceUp.Click += new System.EventHandler(this.btnTriggerDistanceUp_Click);
            // 
            // btnDistanceUp
            // 
            this.btnDistanceUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDistanceUp.FlatAppearance.BorderSize = 0;
            this.btnDistanceUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDistanceUp.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDistanceUp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDistanceUp.Image = global::AgOpenGPS.Properties.Resources.UpArrow64;
            this.btnDistanceUp.Location = new System.Drawing.Point(402, 474);
            this.btnDistanceUp.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDistanceUp.Name = "btnDistanceUp";
            this.btnDistanceUp.Size = new System.Drawing.Size(59, 69);
            this.btnDistanceUp.TabIndex = 457;
            this.btnDistanceUp.UseVisualStyleBackColor = true;
            this.btnDistanceUp.Click += new System.EventHandler(this.btnDistanceUp_Click);
            // 
            // btnDistanceDn
            // 
            this.btnDistanceDn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDistanceDn.FlatAppearance.BorderSize = 0;
            this.btnDistanceDn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDistanceDn.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDistanceDn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDistanceDn.Image = global::AgOpenGPS.Properties.Resources.DnArrow64;
            this.btnDistanceDn.Location = new System.Drawing.Point(309, 474);
            this.btnDistanceDn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDistanceDn.Name = "btnDistanceDn";
            this.btnDistanceDn.Size = new System.Drawing.Size(59, 69);
            this.btnDistanceDn.TabIndex = 456;
            this.btnDistanceDn.UseVisualStyleBackColor = true;
            this.btnDistanceDn.Click += new System.EventHandler(this.btnDistanceDn_Click);
            // 
            // tabASteer
            // 
            this.tabASteer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.tabASteer.Controls.Add(this.chkSteerInvertRelays);
            this.tabASteer.Controls.Add(this.label68);
            this.tabASteer.Controls.Add(this.cboxMotorDrive);
            this.tabASteer.Controls.Add(this.cboxSteerEnable);
            this.tabASteer.Controls.Add(this.label62);
            this.tabASteer.Controls.Add(this.cboxConv);
            this.tabASteer.Controls.Add(this.label63);
            this.tabASteer.Controls.Add(this.label64);
            this.tabASteer.Controls.Add(this.label60);
            this.tabASteer.Controls.Add(this.nudAckerman);
            this.tabASteer.Controls.Add(this.label61);
            this.tabASteer.Controls.Add(this.nudMaxCounts);
            this.tabASteer.Controls.Add(this.chkInvertSteer);
            this.tabASteer.Controls.Add(this.cboxEncoder);
            this.tabASteer.Controls.Add(this.chkInvertWAS);
            this.tabASteer.Controls.Add(this.label55);
            this.tabASteer.Controls.Add(this.btnSendSteerConfigPGN);
            this.tabASteer.Location = new System.Drawing.Point(4, 44);
            this.tabASteer.Name = "tabASteer";
            this.tabASteer.Size = new System.Drawing.Size(787, 593);
            this.tabASteer.TabIndex = 19;
            this.tabASteer.Text = "aSteer";
            this.tabASteer.Enter += new System.EventHandler(this.tabASteer_Enter);
            this.tabASteer.Leave += new System.EventHandler(this.tabASteer_Leave);
            // 
            // chkSteerInvertRelays
            // 
            this.chkSteerInvertRelays.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkSteerInvertRelays.FlatAppearance.CheckedBackColor = System.Drawing.Color.Teal;
            this.chkSteerInvertRelays.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkSteerInvertRelays.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSteerInvertRelays.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.chkSteerInvertRelays.Location = new System.Drawing.Point(32, 244);
            this.chkSteerInvertRelays.Name = "chkSteerInvertRelays";
            this.chkSteerInvertRelays.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkSteerInvertRelays.Size = new System.Drawing.Size(192, 70);
            this.chkSteerInvertRelays.TabIndex = 467;
            this.chkSteerInvertRelays.Text = "Invert Relays";
            this.chkSteerInvertRelays.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkSteerInvertRelays.UseVisualStyleBackColor = true;
            // 
            // label68
            // 
            this.label68.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label68.BackColor = System.Drawing.Color.Transparent;
            this.label68.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.label68.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label68.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label68.Location = new System.Drawing.Point(463, 504);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(172, 62);
            this.label68.TabIndex = 466;
            this.label68.Text = "Send +  Save";
            this.label68.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboxMotorDrive
            // 
            this.cboxMotorDrive.BackColor = System.Drawing.Color.AliceBlue;
            this.cboxMotorDrive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxMotorDrive.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboxMotorDrive.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxMotorDrive.FormattingEnabled = true;
            this.cboxMotorDrive.Items.AddRange(new object[] {
            "Cytron",
            "IBT2"});
            this.cboxMotorDrive.Location = new System.Drawing.Point(292, 79);
            this.cboxMotorDrive.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cboxMotorDrive.Name = "cboxMotorDrive";
            this.cboxMotorDrive.Size = new System.Drawing.Size(217, 37);
            this.cboxMotorDrive.TabIndex = 459;
            // 
            // cboxSteerEnable
            // 
            this.cboxSteerEnable.BackColor = System.Drawing.Color.AliceBlue;
            this.cboxSteerEnable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxSteerEnable.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboxSteerEnable.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxSteerEnable.FormattingEnabled = true;
            this.cboxSteerEnable.Items.AddRange(new object[] {
            "Button",
            "Switch"});
            this.cboxSteerEnable.Location = new System.Drawing.Point(293, 277);
            this.cboxSteerEnable.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cboxSteerEnable.Name = "cboxSteerEnable";
            this.cboxSteerEnable.Size = new System.Drawing.Size(217, 37);
            this.cboxSteerEnable.TabIndex = 462;
            // 
            // label62
            // 
            this.label62.BackColor = System.Drawing.Color.Transparent;
            this.label62.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.label62.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label62.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label62.Location = new System.Drawing.Point(291, 244);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(221, 29);
            this.label62.TabIndex = 463;
            this.label62.Text = "Steer Enable";
            this.label62.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // cboxConv
            // 
            this.cboxConv.BackColor = System.Drawing.Color.AliceBlue;
            this.cboxConv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxConv.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboxConv.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxConv.FormattingEnabled = true;
            this.cboxConv.Items.AddRange(new object[] {
            "Single",
            "Differential"});
            this.cboxConv.Location = new System.Drawing.Point(292, 177);
            this.cboxConv.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cboxConv.Name = "cboxConv";
            this.cboxConv.Size = new System.Drawing.Size(217, 37);
            this.cboxConv.TabIndex = 464;
            // 
            // label63
            // 
            this.label63.BackColor = System.Drawing.Color.Transparent;
            this.label63.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.label63.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label63.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label63.Location = new System.Drawing.Point(288, 48);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(221, 29);
            this.label63.TabIndex = 460;
            this.label63.Text = "Motor Driver";
            this.label63.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label64
            // 
            this.label64.BackColor = System.Drawing.Color.Transparent;
            this.label64.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.label64.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label64.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label64.Location = new System.Drawing.Point(287, 145);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(221, 29);
            this.label64.TabIndex = 461;
            this.label64.Text = "A2D Convertor";
            this.label64.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label60
            // 
            this.label60.BackColor = System.Drawing.Color.Transparent;
            this.label60.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.label60.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label60.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label60.Location = new System.Drawing.Point(582, 185);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(174, 65);
            this.label60.TabIndex = 458;
            this.label60.Text = "Ackerman %";
            this.label60.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // nudAckerman
            // 
            this.nudAckerman.BackColor = System.Drawing.Color.AliceBlue;
            this.nudAckerman.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAckerman.InterceptArrowKeys = false;
            this.nudAckerman.Location = new System.Drawing.Point(606, 265);
            this.nudAckerman.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudAckerman.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudAckerman.Name = "nudAckerman";
            this.nudAckerman.Size = new System.Drawing.Size(123, 52);
            this.nudAckerman.TabIndex = 457;
            this.nudAckerman.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudAckerman.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudAckerman.Enter += new System.EventHandler(this.nudAckerman_Enter);
            // 
            // label61
            // 
            this.label61.BackColor = System.Drawing.Color.Transparent;
            this.label61.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.label61.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label61.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label61.Location = new System.Drawing.Point(261, 404);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(216, 29);
            this.label61.TabIndex = 456;
            this.label61.Text = "Turn Sensor";
            this.label61.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // nudMaxCounts
            // 
            this.nudMaxCounts.BackColor = System.Drawing.Color.AliceBlue;
            this.nudMaxCounts.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMaxCounts.InterceptArrowKeys = false;
            this.nudMaxCounts.Location = new System.Drawing.Point(294, 439);
            this.nudMaxCounts.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudMaxCounts.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMaxCounts.Name = "nudMaxCounts";
            this.nudMaxCounts.Size = new System.Drawing.Size(165, 52);
            this.nudMaxCounts.TabIndex = 455;
            this.nudMaxCounts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudMaxCounts.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nudMaxCounts.Enter += new System.EventHandler(this.nudMaxCounts_Enter);
            // 
            // chkInvertSteer
            // 
            this.chkInvertSteer.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkInvertSteer.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.chkInvertSteer.FlatAppearance.CheckedBackColor = System.Drawing.Color.Teal;
            this.chkInvertSteer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkInvertSteer.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkInvertSteer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.chkInvertSteer.Location = new System.Drawing.Point(32, 144);
            this.chkInvertSteer.Name = "chkInvertSteer";
            this.chkInvertSteer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkInvertSteer.Size = new System.Drawing.Size(192, 70);
            this.chkInvertSteer.TabIndex = 451;
            this.chkInvertSteer.Text = "Invert Steer Motor";
            this.chkInvertSteer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkInvertSteer.UseVisualStyleBackColor = true;
            // 
            // cboxEncoder
            // 
            this.cboxEncoder.Appearance = System.Windows.Forms.Appearance.Button;
            this.cboxEncoder.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.cboxEncoder.FlatAppearance.CheckedBackColor = System.Drawing.Color.Teal;
            this.cboxEncoder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboxEncoder.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxEncoder.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cboxEncoder.Location = new System.Drawing.Point(32, 421);
            this.cboxEncoder.Name = "cboxEncoder";
            this.cboxEncoder.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cboxEncoder.Size = new System.Drawing.Size(192, 70);
            this.cboxEncoder.TabIndex = 453;
            this.cboxEncoder.Text = "Turn Sensor";
            this.cboxEncoder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cboxEncoder.UseVisualStyleBackColor = true;
            // 
            // chkInvertWAS
            // 
            this.chkInvertWAS.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkInvertWAS.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.chkInvertWAS.FlatAppearance.CheckedBackColor = System.Drawing.Color.Teal;
            this.chkInvertWAS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkInvertWAS.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkInvertWAS.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.chkInvertWAS.Location = new System.Drawing.Point(32, 46);
            this.chkInvertWAS.Name = "chkInvertWAS";
            this.chkInvertWAS.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkInvertWAS.Size = new System.Drawing.Size(192, 70);
            this.chkInvertWAS.TabIndex = 450;
            this.chkInvertWAS.Text = "Invert WAS\r\nline 2";
            this.chkInvertWAS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkInvertWAS.UseVisualStyleBackColor = true;
            // 
            // label55
            // 
            this.label55.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label55.AutoSize = true;
            this.label55.BackColor = System.Drawing.Color.Transparent;
            this.label55.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label55.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label55.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label55.Location = new System.Drawing.Point(635, 19);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(117, 19);
            this.label55.TabIndex = 449;
            this.label55.Text = "Steer Module";
            this.label55.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSendSteerConfigPGN
            // 
            this.btnSendSteerConfigPGN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendSteerConfigPGN.BackColor = System.Drawing.Color.Transparent;
            this.btnSendSteerConfigPGN.FlatAppearance.BorderSize = 0;
            this.btnSendSteerConfigPGN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendSteerConfigPGN.Image = global::AgOpenGPS.Properties.Resources.ToolAcceptChange;
            this.btnSendSteerConfigPGN.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSendSteerConfigPGN.Location = new System.Drawing.Point(619, 504);
            this.btnSendSteerConfigPGN.Name = "btnSendSteerConfigPGN";
            this.btnSendSteerConfigPGN.Size = new System.Drawing.Size(133, 62);
            this.btnSendSteerConfigPGN.TabIndex = 465;
            this.btnSendSteerConfigPGN.UseVisualStyleBackColor = false;
            this.btnSendSteerConfigPGN.Click += new System.EventHandler(this.btnSendToSteerArduino_Click);
            // 
            // tabAMachine
            // 
            this.tabAMachine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.tabAMachine.Controls.Add(this.label67);
            this.tabAMachine.Controls.Add(this.cboxMachInvertRelays);
            this.tabAMachine.Controls.Add(this.groupBox8);
            this.tabAMachine.Controls.Add(this.label56);
            this.tabAMachine.Controls.Add(this.btnSendMachinePGN);
            this.tabAMachine.Location = new System.Drawing.Point(4, 44);
            this.tabAMachine.Name = "tabAMachine";
            this.tabAMachine.Size = new System.Drawing.Size(787, 593);
            this.tabAMachine.TabIndex = 20;
            this.tabAMachine.Text = "aMach";
            this.tabAMachine.Enter += new System.EventHandler(this.tabAMachine_Enter);
            this.tabAMachine.Leave += new System.EventHandler(this.tabAMachine_Leave);
            // 
            // label67
            // 
            this.label67.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label67.BackColor = System.Drawing.Color.Transparent;
            this.label67.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.label67.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label67.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label67.Location = new System.Drawing.Point(465, 507);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(172, 37);
            this.label67.TabIndex = 455;
            this.label67.Text = "Send + Save";
            this.label67.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboxMachInvertRelays
            // 
            this.cboxMachInvertRelays.Appearance = System.Windows.Forms.Appearance.Button;
            this.cboxMachInvertRelays.FlatAppearance.CheckedBackColor = System.Drawing.Color.PaleGreen;
            this.cboxMachInvertRelays.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboxMachInvertRelays.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxMachInvertRelays.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cboxMachInvertRelays.Location = new System.Drawing.Point(459, 100);
            this.cboxMachInvertRelays.Name = "cboxMachInvertRelays";
            this.cboxMachInvertRelays.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cboxMachInvertRelays.Size = new System.Drawing.Size(192, 70);
            this.cboxMachInvertRelays.TabIndex = 453;
            this.cboxMachInvertRelays.Text = "Invert Relays";
            this.cboxMachInvertRelays.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cboxMachInvertRelays.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.nudLowerTime);
            this.groupBox8.Controls.Add(this.nudRaiseTime);
            this.groupBox8.Controls.Add(this.label65);
            this.groupBox8.Controls.Add(this.cboxIsHydOn);
            this.groupBox8.Controls.Add(this.label66);
            this.groupBox8.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox8.Location = new System.Drawing.Point(74, 84);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(321, 360);
            this.groupBox8.TabIndex = 451;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Hydraulic Tool Lift";
            // 
            // nudLowerTime
            // 
            this.nudLowerTime.BackColor = System.Drawing.Color.AliceBlue;
            this.nudLowerTime.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudLowerTime.InterceptArrowKeys = false;
            this.nudLowerTime.Location = new System.Drawing.Point(74, 288);
            this.nudLowerTime.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudLowerTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLowerTime.Name = "nudLowerTime";
            this.nudLowerTime.Size = new System.Drawing.Size(114, 52);
            this.nudLowerTime.TabIndex = 271;
            this.nudLowerTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudLowerTime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLowerTime.Enter += new System.EventHandler(this.nudLowerTime_Enter);
            // 
            // nudRaiseTime
            // 
            this.nudRaiseTime.BackColor = System.Drawing.Color.AliceBlue;
            this.nudRaiseTime.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudRaiseTime.InterceptArrowKeys = false;
            this.nudRaiseTime.Location = new System.Drawing.Point(74, 176);
            this.nudRaiseTime.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudRaiseTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRaiseTime.Name = "nudRaiseTime";
            this.nudRaiseTime.Size = new System.Drawing.Size(114, 52);
            this.nudRaiseTime.TabIndex = 269;
            this.nudRaiseTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudRaiseTime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRaiseTime.Enter += new System.EventHandler(this.nudRaiseTime_Enter);
            // 
            // label65
            // 
            this.label65.BackColor = System.Drawing.Color.Transparent;
            this.label65.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.label65.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label65.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label65.Location = new System.Drawing.Point(13, 106);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(235, 54);
            this.label65.TabIndex = 270;
            this.label65.Text = "Raise Time (secs)";
            this.label65.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // cboxIsHydOn
            // 
            this.cboxIsHydOn.Appearance = System.Windows.Forms.Appearance.Button;
            this.cboxIsHydOn.BackColor = System.Drawing.Color.Transparent;
            this.cboxIsHydOn.FlatAppearance.CheckedBackColor = System.Drawing.Color.PaleGreen;
            this.cboxIsHydOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboxIsHydOn.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxIsHydOn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cboxIsHydOn.Location = new System.Drawing.Point(55, 50);
            this.cboxIsHydOn.Name = "cboxIsHydOn";
            this.cboxIsHydOn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cboxIsHydOn.Size = new System.Drawing.Size(165, 52);
            this.cboxIsHydOn.TabIndex = 273;
            this.cboxIsHydOn.Text = "Enable";
            this.cboxIsHydOn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cboxIsHydOn.UseVisualStyleBackColor = false;
            // 
            // label66
            // 
            this.label66.BackColor = System.Drawing.Color.Transparent;
            this.label66.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.label66.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label66.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label66.Location = new System.Drawing.Point(18, 231);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(235, 54);
            this.label66.TabIndex = 272;
            this.label66.Text = "Lower Time (secs)";
            this.label66.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label56
            // 
            this.label56.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label56.AutoSize = true;
            this.label56.BackColor = System.Drawing.Color.Transparent;
            this.label56.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label56.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label56.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label56.Location = new System.Drawing.Point(338, 19);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(140, 19);
            this.label56.TabIndex = 450;
            this.label56.Text = "Machine Module";
            this.label56.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSendMachinePGN
            // 
            this.btnSendMachinePGN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendMachinePGN.BackColor = System.Drawing.Color.Transparent;
            this.btnSendMachinePGN.FlatAppearance.BorderSize = 0;
            this.btnSendMachinePGN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendMachinePGN.Image = global::AgOpenGPS.Properties.Resources.ToolAcceptChange;
            this.btnSendMachinePGN.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSendMachinePGN.Location = new System.Drawing.Point(620, 491);
            this.btnSendMachinePGN.Name = "btnSendMachinePGN";
            this.btnSendMachinePGN.Size = new System.Drawing.Size(133, 62);
            this.btnSendMachinePGN.TabIndex = 454;
            this.btnSendMachinePGN.UseVisualStyleBackColor = false;
            this.btnSendMachinePGN.Click += new System.EventHandler(this.btnSendMachinePGN_Click);
            // 
            // lblSecTotalWidthMeters
            // 
            this.lblSecTotalWidthMeters.AutoSize = true;
            this.lblSecTotalWidthMeters.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecTotalWidthMeters.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSecTotalWidthMeters.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSecTotalWidthMeters.Location = new System.Drawing.Point(594, 33);
            this.lblSecTotalWidthMeters.Name = "lblSecTotalWidthMeters";
            this.lblSecTotalWidthMeters.Size = new System.Drawing.Size(32, 25);
            this.lblSecTotalWidthMeters.TabIndex = 302;
            this.lblSecTotalWidthMeters.Text = "II";
            // 
            // label52
            // 
            this.label52.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label52.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label52.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label52.Location = new System.Drawing.Point(475, 5);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(180, 25);
            this.label52.TabIndex = 301;
            this.label52.Text = "Tool Width:";
            this.label52.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSecTotalWidthFeet
            // 
            this.lblSecTotalWidthFeet.AutoSize = true;
            this.lblSecTotalWidthFeet.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecTotalWidthFeet.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSecTotalWidthFeet.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSecTotalWidthFeet.Location = new System.Drawing.Point(564, 33);
            this.lblSecTotalWidthFeet.Name = "lblSecTotalWidthFeet";
            this.lblSecTotalWidthFeet.Size = new System.Drawing.Size(36, 25);
            this.lblSecTotalWidthFeet.TabIndex = 298;
            this.lblSecTotalWidthFeet.Text = "FF";
            // 
            // lblSecTotalWidthInches
            // 
            this.lblSecTotalWidthInches.AutoSize = true;
            this.lblSecTotalWidthInches.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecTotalWidthInches.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSecTotalWidthInches.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSecTotalWidthInches.Location = new System.Drawing.Point(623, 33);
            this.lblSecTotalWidthInches.Name = "lblSecTotalWidthInches";
            this.lblSecTotalWidthInches.Size = new System.Drawing.Size(32, 25);
            this.lblSecTotalWidthInches.TabIndex = 300;
            this.lblSecTotalWidthInches.Text = "II";
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(60)))));
            this.panelBottom.Controls.Add(this.label52);
            this.panelBottom.Controls.Add(this.lblSecTotalWidthInches);
            this.panelBottom.Controls.Add(this.lblSecTotalWidthFeet);
            this.panelBottom.Controls.Add(this.btnOK);
            this.panelBottom.Controls.Add(this.lblSecTotalWidthMeters);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(203, 642);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(795, 68);
            this.panelBottom.TabIndex = 112;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOK.FlatAppearance.BorderSize = 0;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOK.Image = global::AgOpenGPS.Properties.Resources.OK64;
            this.btnOK.Location = new System.Drawing.Point(710, 9);
            this.btnOK.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(80, 53);
            this.btnOK.TabIndex = 452;
            this.btnOK.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // FormConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(1000, 712);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelLeftSideMenu);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1000, 740);
            this.Name = "FormConfig";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.ShowInTaskbar = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormConfig_FormClosing);
            this.Load += new System.EventHandler(this.FormConfig_Load);
            this.panelLeftSideMenu.ResumeLayout(false);
            this.panelArduino.ResumeLayout(false);
            this.panelDataSourcesSubMenu.ResumeLayout(false);
            this.panelToolSubMenu.ResumeLayout(false);
            this.panelVehicleSubMenu.ResumeLayout(false);
            this.panelChildForm.ResumeLayout(false);
            this.tab1.ResumeLayout(false);
            this.tabSummary.ResumeLayout(false);
            this.tabSummary.PerformLayout();
            this.tabVConfig.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tabVAntenna.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudAntennaHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAntennaPivot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAntennaOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxAntenna)).EndInit();
            this.tabVDimensions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudWheelbase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinTurnRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabVGuidance.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudLineWidth)).EndInit();
            this.groupBox9.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudLightbarCmPerPixel)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudSnapDistance)).EndInit();
            this.tabTConfig.ResumeLayout(false);
            this.gboxAttachment.ResumeLayout(false);
            this.tabTHitch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudTrailingHitchLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDrawbarLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTankHitch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxToolHitch)).EndInit();
            this.tabTSections.ResumeLayout(false);
            this.tabTSections.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCutoffSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDefaultSectionWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinApplied)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSection16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSection15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSection14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSection13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSection12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSection11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSection10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSection9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSection8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSection7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSection6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSection5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSection4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSection3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSection2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSection1)).EndInit();
            this.tabTSwitches.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabTSettings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudHydLiftLookAhead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLookAheadOff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTurnOffDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLookAhead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOverlap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.tabDFix.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.tabDHeading.ResumeLayout(false);
            this.tabDHeading.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStartSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinFixStepDistance)).EndInit();
            this.headingGroupBox.ResumeLayout(false);
            this.tabDRoll.ResumeLayout(false);
            this.tabDRoll.PerformLayout();
            this.btnRollZero.ResumeLayout(false);
            this.btnRollZero.PerformLayout();
            this.tabUTurn.ResumeLayout(false);
            this.tabUTurn.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.tabASteer.ResumeLayout(false);
            this.tabASteer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAckerman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxCounts)).EndInit();
            this.tabAMachine.ResumeLayout(false);
            this.tabAMachine.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudLowerTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRaiseTime)).EndInit();
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelLeftSideMenu;
        private System.Windows.Forms.Panel panelDataSourcesSubMenu;
        private System.Windows.Forms.Button btnSubFix;
        private System.Windows.Forms.Button btnSubHeading;
        private System.Windows.Forms.Button btnSubRoll;
        private System.Windows.Forms.Panel panelToolSubMenu;
        private System.Windows.Forms.Button btnSubSwitches;
        private System.Windows.Forms.Button btnSubSections;
        private System.Windows.Forms.Button btnTool;
        private System.Windows.Forms.Panel panelVehicleSubMenu;
        private System.Windows.Forms.Button btnSubGuidance;
        private System.Windows.Forms.Button btnSubAntenna;
        private System.Windows.Forms.Button btnSubDimensions;
        private System.Windows.Forms.Button btnSubVehicleConfig;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.TabControl tab1;
        private System.Windows.Forms.TabPage tabSummary;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.TabPage tabVConfig;
        private System.Windows.Forms.TabPage tabTHitch;
        private System.Windows.Forms.TabPage tabTSections;
        private System.Windows.Forms.TabPage tabTSwitches;
        private System.Windows.Forms.TabPage tabTSettings;
        private System.Windows.Forms.TabPage tabTConfig;
        private System.Windows.Forms.TabPage tabVAntenna;
        private System.Windows.Forms.TabPage tabVDimensions;
        private System.Windows.Forms.TabPage tabVGuidance;
        private System.Windows.Forms.TabPage tabDHeading;
        private System.Windows.Forms.TabPage tabDRoll;
        private System.Windows.Forms.TabPage tabDFix;
        private System.Windows.Forms.Button btnVehicle;
        private System.Windows.Forms.Button btnDataSources;
        private System.Windows.Forms.Button btnSubHitch;
        private System.Windows.Forms.Button btnSubToolSettings;
        private System.Windows.Forms.Button btnSubToolConfig;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbtnOGI;
        private System.Windows.Forms.RadioButton rbtnRMC;
        private System.Windows.Forms.RadioButton rbtnGGA;
        private System.Windows.Forms.Label lblSimGGA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cboxIsRTK;
        private System.Windows.Forms.GroupBox headingGroupBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton rbtnHeadingHDT;
        private System.Windows.Forms.RadioButton rbtnHeadingGPS;
        private System.Windows.Forms.RadioButton rbtnHeadingFix;
        private System.Windows.Forms.Label lblFusionIMU;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.HScrollBar hsbarFusion;
        private System.Windows.Forms.Label lblIMUFusion;
        private System.Windows.Forms.Label lblFusion;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudStartSpeed;
        private System.Windows.Forms.NumericUpDown nudMinFixStepDistance;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label lblRollFilterPercent;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.HScrollBar hsbarRollFilter;
        private System.Windows.Forms.RadioButton rbtnTBT;
        private System.Windows.Forms.RadioButton rbtnFixedRear;
        private System.Windows.Forms.RadioButton rbtnFront;
        private System.Windows.Forms.RadioButton rbtnTrailing;
        private System.Windows.Forms.NumericUpDown nudAntennaHeight;
        private System.Windows.Forms.NumericUpDown nudAntennaPivot;
        private System.Windows.Forms.NumericUpDown nudAntennaOffset;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.CheckBox cboxAutoSteerAuto;
        private System.Windows.Forms.PictureBox pboxAntenna;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnHarvester;
        private System.Windows.Forms.RadioButton rbtn4WD;
        private System.Windows.Forms.RadioButton rbtnTractor;
        private System.Windows.Forms.Label lblSumWheelbase;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label lblSumNumSections;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label lblSumToolWidth;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label lblSumFixType;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.PictureBox picboxToolHitch;
        private System.Windows.Forms.NumericUpDown nudTrailingHitchLength;
        private System.Windows.Forms.NumericUpDown nudDrawbarLength;
        private System.Windows.Forms.NumericUpDown nudTankHitch;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkWorkSwitchManual;
        private System.Windows.Forms.CheckBox chkWorkSwActiveLow;
        private System.Windows.Forms.CheckBox chkEnableWorkSwitch;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown nudLookAheadOff;
        private System.Windows.Forms.NumericUpDown nudOffset;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.NumericUpDown nudTurnOffDelay;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.NumericUpDown nudLookAhead;
        private System.Windows.Forms.NumericUpDown nudOverlap;
        private System.Windows.Forms.Button btnVehicleSave;
        private System.Windows.Forms.Button btnVehicleLoad;
        private System.Windows.Forms.Button btnVehicleDelete;
        private System.Windows.Forms.ListView lvVehicles;
        private System.Windows.Forms.ColumnHeader chVehicle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tboxVehicleNameSave;
        private System.Windows.Forms.Label lblCurrentVehicle;
        private System.Windows.Forms.Button btnVehicleSaveAs;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.NumericUpDown nudLineWidth;
        private System.Windows.Forms.NumericUpDown nudLightbarCmPerPixel;
        private System.Windows.Forms.NumericUpDown nudSnapDistance;
        private System.Windows.Forms.GroupBox gboxAttachment;
        private System.Windows.Forms.Button btnNext2;
        private System.Windows.Forms.Button btnNext3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudSection16;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.NumericUpDown nudSection15;
        private System.Windows.Forms.NumericUpDown nudSection14;
        private System.Windows.Forms.NumericUpDown nudSection13;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.NumericUpDown nudSection12;
        private System.Windows.Forms.NumericUpDown nudSection11;
        private System.Windows.Forms.NumericUpDown nudSection10;
        private System.Windows.Forms.NumericUpDown nudSection9;
        private System.Windows.Forms.NumericUpDown nudSection8;
        private System.Windows.Forms.NumericUpDown nudSection7;
        private System.Windows.Forms.NumericUpDown nudSection6;
        private System.Windows.Forms.NumericUpDown nudSection5;
        private System.Windows.Forms.NumericUpDown nudSection4;
        private System.Windows.Forms.NumericUpDown nudSection3;
        private System.Windows.Forms.NumericUpDown nudSection2;
        private System.Windows.Forms.NumericUpDown nudSection1;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.NumericUpDown nudDefaultSectionWidth;
        private System.Windows.Forms.ComboBox cboxNumSections;
        private System.Windows.Forms.Label lblVehicleToolWidth;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.NumericUpDown nudMinApplied;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label lblSecTotalWidthMeters;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label lblSecTotalWidthFeet;
        private System.Windows.Forms.Label lblSecTotalWidthInches;
        private System.Windows.Forms.Label lblDoNotExceed;
        private System.Windows.Forms.Label lblInchesCm;
        private System.Windows.Forms.NumericUpDown nudCutoffSpeed;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label lblTurnOffBelowUnits;
        private System.Windows.Forms.Button btnNext4;
        private System.Windows.Forms.GroupBox btnRollZero;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnRemoveZeroOffsetPitch;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnZeroPitch;
        private System.Windows.Forms.Button btnRemoveZeroOffset;
        private System.Windows.Forms.Label lblRollZeroOffset;
        private System.Windows.Forms.Button btnZeroRoll;
        private System.Windows.Forms.Button btnResetIMU;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.NumericUpDown nudMinTurnRadius;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.NumericUpDown nudWheelbase;
        private System.Windows.Forms.Button btnNextDim;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnUTurn;
        private System.Windows.Forms.Button btnArduino;
        private System.Windows.Forms.Panel panelArduino;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnMachineModule;
        private System.Windows.Forms.Button btnSteerModule;
        private System.Windows.Forms.TabPage tabUTurn;
        private System.Windows.Forms.TabPage tabASteer;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.TabPage tabAMachine;
        private System.Windows.Forms.Label label56;
        private ProXoft.WinForms.RepeatButton btnTriggerDistanceDn;
        private ProXoft.WinForms.RepeatButton btnTriggerDistanceUp;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label58;
        private ProXoft.WinForms.RepeatButton btnDistanceUp;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnYouTurnWideReturn;
        private System.Windows.Forms.Button btnYouTurnKeyHole;
        private System.Windows.Forms.Button btnYouTurnSemiCircle;
        private System.Windows.Forms.Button btnYouTurnRecord;
        private System.Windows.Forms.Button btnYouTurnCustom;
        private System.Windows.Forms.Label lblTriggerDistance;
        private ProXoft.WinForms.RepeatButton btnDistanceDn;
        private System.Windows.Forms.Label lblWhenTrig;
        private System.Windows.Forms.Button btnIsUsingDubins;
        private System.Windows.Forms.Label lblDistance;
        private ProXoft.WinForms.RepeatButton btnTurnSmoothingUp;
        private ProXoft.WinForms.RepeatButton btnTurnSmoothingDown;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Label lblSmoothing;
        private System.Windows.Forms.CheckBox chkInvertSteer;
        private System.Windows.Forms.CheckBox cboxEncoder;
        private System.Windows.Forms.CheckBox chkInvertWAS;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.NumericUpDown nudAckerman;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.NumericUpDown nudMaxCounts;
        private System.Windows.Forms.ComboBox cboxMotorDrive;
        private System.Windows.Forms.ComboBox cboxSteerEnable;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.ComboBox cboxConv;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.NumericUpDown nudLowerTime;
        private System.Windows.Forms.NumericUpDown nudRaiseTime;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.CheckBox cboxIsHydOn;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.CheckBox cboxMachInvertRelays;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.Button btnSendSteerConfigPGN;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.Button btnSendMachinePGN;
        private System.Windows.Forms.CheckBox chkSteerInvertRelays;
        private System.Windows.Forms.CheckBox cboxDataInvertRoll;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.NumericUpDown nudHydLiftLookAhead;
    }
}