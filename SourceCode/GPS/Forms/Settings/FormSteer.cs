using System;
using System.Drawing;
using System.Windows.Forms;

namespace AgOpenGPS
{
    public partial class FormSteer : Form
    {
        private readonly FormGPS mf = null;

        bool toSend = false;

        //Form stuff
        public FormSteer(Form callingForm)
        {
            mf = callingForm as FormGPS;
            InitializeComponent();

            this.btnFreeDrive.Text = gStr.gsDrive;
            //this.tabGain.Text = gStr.gsGain;
            //this.label22.Text = gStr.gsOutputGain;
            this.label41.Text = gStr.gsMinimumPWMDrive;
            this.label7.Text = gStr.gsProportionalGain;
            //label1.Text = gStr.gsChooseType;

            //this.tabSteer.Text = gStr.gsSteer;
            this.label25.Text = gStr.gsCountsPerDegree;
            //this.label45.Text = gStr.gsMaxIntegralValue;
            this.label19.Text = gStr.gsMaxSteerAngleInDegrees;
            //this.label33.Text = gStr.gsIntegralGain;
            this.label10.Text = gStr.gsWheelAngleSensorZero;

            //this.tabLook.Text = "Pure P";
            this.label2.Text = gStr.gsUTurnLookAheadMultiplier;
            this.label37.Text = gStr.gsLookAheadInSeconds;
            this.label4.Text = gStr.gsLookAheadOfflineMultiplier;
            this.label6.Text = gStr.gsMinLookAheadInMeters;

            //this.tabStan.Text = "Stanley";
            //this.btnChart.Text = gStr.gsSteerChart;
            this.label3.Text = gStr.gsAgressiveness;
            this.label5.Text = gStr.gsOvershootReduction;
            this.Text = gStr.gsAutoSteerConfiguration;
        }

        private void FormSteer_Load(object sender, EventArgs e)
        {
            hsbarWasOffset.Value = Properties.Settings.Default.setAS_wasOffset;
            hsbarCountsPerDegree.Value = Properties.Settings.Default.setAS_countsPerDegree;
            lblCountsPerDegree.Text = hsbarCountsPerDegree.Value.ToString();
            lblSteerAngleSensorZero.Text = ((double)(hsbarWasOffset.Value) / (double)(hsbarCountsPerDegree.Value * 4)).ToString("N2");

            hsbarMinPWM.Value = Properties.Settings.Default.setAS_minSteerPWM;
            lblMinPWM.Text = hsbarMinPWM.Value.ToString();

            hsbarProportionalGain.Value = Properties.Settings.Default.setAS_Kp;
            lblProportionalGain.Text = hsbarProportionalGain.Value.ToString();

            //hsbarOutputGain.Value = Properties.Settings.Default.setAS_Ko;
            //lblOutputGain.Text = hsbarOutputGain.Value.ToString();

            hsbarLowSteerPWM.ValueChanged -= hsbarLowSteerPWM_ValueChanged;
            hsbarHighSteerPWM.ValueChanged -= hsbarMinPWM_ValueChanged;

            hsbarLowSteerPWM.Value = Properties.Settings.Default.setAS_lowSteerPWM;
            lblLowSteerPWM.Text = (mf.p_FC.steerSettings[mf.p_FC.lowPWM]).ToString();

            hsbarHighSteerPWM.Value = Properties.Settings.Default.setAS_highSteerPWM;
            lblHighSteerPWM.Text = hsbarHighSteerPWM.Value.ToString();

            hsbarLowSteerPWM.ValueChanged += hsbarLowSteerPWM_ValueChanged;
            hsbarHighSteerPWM.ValueChanged += hsbarMinPWM_ValueChanged;


            mf.vehicle.maxSteerAngle = Properties.Vehicle.Default.setVehicle_maxSteerAngle;
            hsbarMaxSteerAngle.Value = (Int16)mf.vehicle.maxSteerAngle;
            lblMaxSteerAngle.Text = hsbarMaxSteerAngle.Value.ToString();

            mf.vehicle.goalPointLookAheadSeconds = Properties.Vehicle.Default.setVehicle_goalPointLookAhead;
            hsbarLookAhead.Value = (Int16)(mf.vehicle.goalPointLookAheadSeconds * 10);
            lblLookAhead.Text = mf.vehicle.goalPointLookAheadSeconds.ToString();

            mf.vehicle.goalPointLookAheadMinimumDistance = Properties.Vehicle.Default.setVehicle_lookAheadMinimum;
            hsbarLookAheadMin.Value = (Int16)(mf.vehicle.goalPointLookAheadMinimumDistance * 10);
            lblLookAheadMinimum.Text = mf.vehicle.goalPointLookAheadMinimumDistance.ToString();

            mf.vehicle.goalPointDistanceMultiplier = Properties.Vehicle.Default.setVehicle_lookAheadDistanceFromLine;
            hsbarDistanceFromLine.Value = (Int16)(mf.vehicle.goalPointDistanceMultiplier * 10);
            lblDistanceFromLine.Text = (mf.vehicle.goalPointDistanceMultiplier + 1).ToString();

            hsbarLookAheadUturnMult.Value = (Int16)(mf.vehicle.goalPointLookAheadUturnMult * 10);
            lblLookAheadUturnMult.Text = mf.vehicle.goalPointLookAheadUturnMult.ToString();

            mf.vehicle.stanleyDistanceErrorGain = Properties.Vehicle.Default.stanleyDistanceErrorGain;
            hsbarStanleyGain.Value = (Int16)(mf.vehicle.stanleyDistanceErrorGain * 10);
            lblStanleyGain.Text = mf.vehicle.stanleyDistanceErrorGain.ToString();

            mf.vehicle.stanleyHeadingErrorGain = Properties.Vehicle.Default.stanleyHeadingErrorGain;
            hsbarHeadingErrorGain.Value = (Int16)(mf.vehicle.stanleyHeadingErrorGain * 10);
            lblHeadingErrorGain.Text = mf.vehicle.stanleyHeadingErrorGain.ToString();

            hsbarIntegral.Value = (int)(Properties.Vehicle.Default.stanleyIntegralGainAB * 100);
            lblIntegralPercent.Text = ((int)(mf.vehicle.stanleyIntegralGainAB * 100)).ToString();

            nudIntDistance.Value = (int)(Properties.Vehicle.Default.stanleyIntegralDistanceAwayTriggerAB * 100);

            //make sure free drive is off
            btnFreeDrive.BackColor = Color.Red;
            mf.vehicle.ast.isInFreeDriveMode = false;
            btnSteerAngleDown.Enabled = false;
            btnSteerAngleUp.Enabled = false;
            //hSBarFreeDrive.Value = 0;
            mf.vehicle.ast.driveFreeSteerAngle = 0;

            if (mf.isStanleyUsed)
            {
                hsbarLookAhead.Enabled = false;
                hsbarDistanceFromLine.Enabled = false;
                hsbarLookAheadMin.Enabled = false;
                hsbarLookAheadUturnMult.Enabled = false;
                btnStanley.Text = "Stanley";
            }
            else
            {
                btnStanley.Text = "Pure P";

                hsbarLookAhead.Enabled = true;
                hsbarDistanceFromLine.Enabled = true;
                hsbarLookAheadMin.Enabled = true;
                hsbarLookAheadUturnMult.Enabled = true;
            }

            toSend = false;

        }

        private void FormSteer_FormClosing(object sender, FormClosingEventArgs e)
        {
            mf.vehicle.ast.isInFreeDriveMode = false;

            Properties.Vehicle.Default.setVehicle_goalPointLookAhead = mf.vehicle.goalPointLookAheadSeconds;
            Properties.Vehicle.Default.stanleyHeadingErrorGain = mf.vehicle.stanleyHeadingErrorGain;
            Properties.Vehicle.Default.stanleyDistanceErrorGain = mf.vehicle.stanleyDistanceErrorGain;
            Properties.Vehicle.Default.stanleyIntegralGainAB = mf.vehicle.stanleyIntegralGainAB;
            Properties.Vehicle.Default.setVehicle_goalPointLookAheadUturnMult = mf.vehicle.goalPointLookAheadUturnMult;
            Properties.Vehicle.Default.setVehicle_lookAheadDistanceFromLine = mf.vehicle.goalPointDistanceMultiplier;
            Properties.Vehicle.Default.setVehicle_lookAheadMinimum = mf.vehicle.goalPointLookAheadMinimumDistance;
            Properties.Vehicle.Default.setVehicle_maxSteerAngle = mf.vehicle.maxSteerAngle;

            Properties.Settings.Default.Save();
            Properties.Vehicle.Default.Save();
        }

        //Stanley Page tab
        private void hsbarStanleyGain_ValueChanged(object sender, EventArgs e)
        {
            mf.vehicle.stanleyDistanceErrorGain = hsbarStanleyGain.Value * 0.1;
            lblStanleyGain.Text = mf.vehicle.stanleyDistanceErrorGain.ToString();
        }

        private void hsbarHeadingErrorGain_ValueChanged(object sender, EventArgs e)
        {
            mf.vehicle.stanleyHeadingErrorGain = hsbarHeadingErrorGain.Value * 0.1;
            lblHeadingErrorGain.Text = mf.vehicle.stanleyHeadingErrorGain.ToString();
        }

        private void hsbarIntegral_ValueChanged(object sender, EventArgs e)
        {
            mf.vehicle.stanleyIntegralGainAB = (double)hsbarIntegral.Value * 0.01;
            lblIntegralPercent.Text = hsbarIntegral.Value.ToString();
        }

        //Scrollbars
        private void hsbarLookAhead_ValueChanged(object sender, EventArgs e)
        {
            mf.vehicle.goalPointLookAheadSeconds = hsbarLookAhead.Value * 0.1;
            lblLookAhead.Text = mf.vehicle.goalPointLookAheadSeconds.ToString();
            //mf.AutoSteerSettingsOutToPort();
        }

        private void hsbarLookAheadUturnMult_ValueChanged(object sender, EventArgs e)
        {
            mf.vehicle.goalPointLookAheadUturnMult = hsbarLookAheadUturnMult.Value * 0.1;
            lblLookAheadUturnMult.Text = mf.vehicle.goalPointLookAheadUturnMult.ToString();
        }

        private void hsbarDistanceFromLine_ValueChanged(object sender, EventArgs e)
        {
            mf.vehicle.goalPointDistanceMultiplier = hsbarDistanceFromLine.Value * 0.1;
            lblDistanceFromLine.Text = (mf.vehicle.goalPointDistanceMultiplier + 1).ToString();
        }

        private void hsbarLookAheadMin_ValueChanged(object sender, EventArgs e)
        {
            mf.vehicle.goalPointLookAheadMinimumDistance = hsbarLookAheadMin.Value * 0.1;
            lblLookAheadMinimum.Text = mf.vehicle.goalPointLookAheadMinimumDistance.ToString();
        }

        private void hsbarCountsPerDegree_ValueChanged(object sender, EventArgs e)
        {
            mf.p_FC.steerSettings[mf.p_FC.countsPerDegree] = unchecked((byte)hsbarCountsPerDegree.Value);
            lblCountsPerDegree.Text = (mf.p_FC.steerSettings[mf.p_FC.countsPerDegree]).ToString();
            lblSteerAngleSensorZero.Text = ((double)(hsbarWasOffset.Value) / (double)(hsbarCountsPerDegree.Value * 4)).ToString("N2");
            toSend = true;
        }

        private void hsbarMaxSteerAngle_ValueChanged(object sender, EventArgs e)
        {
            mf.vehicle.maxSteerAngle = hsbarMaxSteerAngle.Value;
            lblMaxSteerAngle.Text = hsbarMaxSteerAngle.Value.ToString();
        }

        private void hsbarSteerAngleSensorZero_ValueChanged(object sender, EventArgs e)
        {
            lblSteerAngleSensorZero.Text = ((double)(hsbarWasOffset.Value) / (double)(hsbarCountsPerDegree.Value * 4)).ToString("N2");
            mf.p_FC.steerSettings[mf.p_FC.wasOffsetHi] = unchecked((byte)(hsbarWasOffset.Value >> 8));
            mf.p_FC.steerSettings[mf.p_FC.wasOffsetLo] = unchecked((byte)(hsbarWasOffset.Value));
            toSend = true;
        }

        //Stanley Parameters

        private void hsbarMinPWM_ValueChanged(object sender, EventArgs e)
        {
            mf.p_FC.steerSettings[mf.p_FC.minPWM] = unchecked((byte)hsbarMinPWM.Value);
            lblMinPWM.Text = (mf.p_FC.steerSettings[mf.p_FC.minPWM]).ToString();
            toSend = true;
        }

        private void hsbarProportionalGain_ValueChanged(object sender, EventArgs e)
        {
            mf.p_FC.steerSettings[mf.p_FC.gainProportional] = unchecked((byte)hsbarProportionalGain.Value);
            lblProportionalGain.Text = (mf.p_FC.steerSettings[mf.p_FC.gainProportional]).ToString();
            toSend = true;
        }

        private void hsbarLowSteerPWM_ValueChanged(object sender, EventArgs e)
        {
            if (hsbarLowSteerPWM.Value > hsbarHighSteerPWM.Value) hsbarHighSteerPWM.Value = hsbarLowSteerPWM.Value;
            mf.p_FC.steerSettings[mf.p_FC.lowPWM] = unchecked((byte)hsbarLowSteerPWM.Value);
            lblLowSteerPWM.Text = (mf.p_FC.steerSettings[mf.p_FC.lowPWM]).ToString();
            toSend = true;
        }

        private void hsbarHighSteerPWM_ValueChanged(object sender, EventArgs e)
        {
            if (hsbarLowSteerPWM.Value > hsbarHighSteerPWM.Value) hsbarLowSteerPWM.Value = hsbarHighSteerPWM.Value;
            mf.p_FC.steerSettings[mf.p_FC.highPWM] = unchecked((byte)hsbarHighSteerPWM.Value);
            lblHighSteerPWM.Text = (mf.p_FC.steerSettings[mf.p_FC.highPWM]).ToString();
            toSend = true;
        }

        private void btnFreeDrive_Click(object sender, EventArgs e)
        {
            if (mf.vehicle.ast.isInFreeDriveMode)
            {
                //turn OFF free drive mode
                btnFreeDrive.BackColor = Color.Red;
                mf.vehicle.ast.isInFreeDriveMode = false;
                btnSteerAngleDown.Enabled = false;
                btnSteerAngleUp.Enabled = false;
                //hSBarFreeDrive.Value = 0;
                mf.vehicle.ast.driveFreeSteerAngle = 0;
            }
            else
            {
                //turn ON free drive mode
                btnFreeDrive.BackColor = Color.LimeGreen;
                mf.vehicle.ast.isInFreeDriveMode = true;
                btnSteerAngleDown.Enabled = true;
                btnSteerAngleUp.Enabled = true;
                //hSBarFreeDrive.Value = 0;
                mf.vehicle.ast.driveFreeSteerAngle = 0;
                lblSteerAngle.Text = "0";
            }
        }

        private void btnFreeDriveZero_Click(object sender, EventArgs e)
        {
            if (mf.vehicle.ast.driveFreeSteerAngle == 0)
                mf.vehicle.ast.driveFreeSteerAngle = 5;
            else mf.vehicle.ast.driveFreeSteerAngle = 0;
            //hSBarFreeDrive.Value = mf.ast.driveFreeSteerAngle;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (Height < 600) Height = 650;
            else Height = 400;
        }

        private void btnChart_Click(object sender, EventArgs e)
        {
            mf.steerChartStripMenu.PerformClick();
        }

        private void BtnStanley_Click(object sender, EventArgs e)
        {
            mf.isStanleyUsed = !mf.isStanleyUsed;

            if (mf.isStanleyUsed)
            {
                hsbarLookAhead.Enabled = false;
                hsbarDistanceFromLine.Enabled = false;
                hsbarLookAheadMin.Enabled = false;
                hsbarLookAheadUturnMult.Enabled = false;
                btnStanley.Text = "Stanley";
            }
            else
            {
                btnStanley.Text = "Pure P";

                hsbarLookAhead.Enabled = true;
                hsbarDistanceFromLine.Enabled = true;
                hsbarLookAheadMin.Enabled = true;
                hsbarLookAheadUturnMult.Enabled = true;
            }

            Properties.Vehicle.Default.setVehicle_isStanleyUsed = mf.isStanleyUsed;
            Properties.Vehicle.Default.Save();
        }

        int counter = 0;
        private void Timer1_Tick(object sender, EventArgs e)
        {
            lblSteerAngle.Text = mf.SetSteerAngle;
            lblSteerAngleActual.Text = mf.mc.actualSteerAngleDisp.ToString("N1") + "\u00B0";

            double err = (mf.mc.actualSteerAngleDisp * 0.01 - mf.guidanceLineSteerAngle * 0.01);
            lblError.Text = Math.Abs(err).ToString("N1") + "\u00B0";
            if (err > 0) lblError.ForeColor = Color.OrangeRed;
            else lblError.ForeColor = Color.LightGreen;
            
            lblPWMDisplay.Text = mf.mc.pwmDisplay.ToString();

            counter++;
            if (toSend && counter > 6)
            {
                Properties.Settings.Default.setAS_countsPerDegree = mf.p_FC.steerSettings[mf.p_FC.countsPerDegree];
                Properties.Settings.Default.setAS_highSteerPWM = mf.p_FC.steerSettings[mf.p_FC.highPWM];
                Properties.Settings.Default.setAS_lowSteerPWM = mf.p_FC.steerSettings[mf.p_FC.lowPWM];
                Properties.Settings.Default.setAS_Kp = mf.p_FC.steerSettings[mf.p_FC.gainProportional];
                Properties.Settings.Default.setAS_minSteerPWM = mf.p_FC.steerSettings[mf.p_FC.minPWM];
                Properties.Settings.Default.setAS_wasOffset = hsbarWasOffset.Value;

                Properties.Settings.Default.Save();
                Properties.Vehicle.Default.Save();

                mf.SendPgnToLoop(mf.p_FC.steerSettings);
                toSend = false;
                counter = 0;
            }

            if (hsbarMinPWM.Value > hsbarLowSteerPWM.Value) lblMinPWM.ForeColor = Color.OrangeRed;
            else lblMinPWM.ForeColor = SystemColors.ButtonFace;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            Properties.Vehicle.Default.Save();
            mf.SendPgnToLoop(mf.p_FC.steerSettings);
        }

        private void btnSteerAngleUp_MouseDown(object sender, MouseEventArgs e)
        {
            mf.vehicle.ast.driveFreeSteerAngle++;
            if (mf.vehicle.ast.driveFreeSteerAngle > 40) mf.vehicle.ast.driveFreeSteerAngle = 40;
        }

        private void btnSteerAngleDown_MouseDown(object sender, MouseEventArgs e)
        {
            mf.vehicle.ast.driveFreeSteerAngle--;
            if (mf.vehicle.ast.driveFreeSteerAngle < -40) mf.vehicle.ast.driveFreeSteerAngle = -40;
        }

        private void nudIntDistance_Enter(object sender, EventArgs e)
        {
            if (mf.KeypadToNUD((NumericUpDown)sender))
            {
                mf.vehicle.stanleyIntegralDistanceAwayTriggerAB = ((double)nudIntDistance.Value)*0.01;
                Properties.Vehicle.Default.stanleyIntegralDistanceAwayTriggerAB = mf.vehicle.stanleyIntegralDistanceAwayTriggerAB;
            }
        }
    }
}
