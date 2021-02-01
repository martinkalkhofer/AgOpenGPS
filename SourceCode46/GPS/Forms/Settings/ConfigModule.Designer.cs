using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgOpenGPS
{
    public partial class FormConfig
    {

        #region Module Steer
        private void tabASteer_Enter(object sender, EventArgs e)
        {
            //tabAutoSteer.Text = gStr.gsAutoSteer;
            label1.Text = gStr.gsMotorDriver;
            label3.Text = gStr.gsA2DConvertor;
            label5.Text = gStr.gsSteerEnable;
            label8.Text = gStr.gsMinSpeed;
            chkInvertWAS.Text = gStr.gsInvertWAS;
            chkInvertSteer.Text = gStr.gsInvertSteerDirection;
            cboxEncoder.Text = gStr.gsEncoder;
            label7.Text = gStr.gsEncoderCounts;
            label9.Text = gStr.gsSendToModule;
            groupBox1.Text = gStr.gsHydraulicToolLift;

            nudMaxCounts.Controls[0].Enabled = false;
            nudAckerman.Controls[0].Enabled = false;

            int sett = Properties.Vehicle.Default.setArdSteer_setting0;

            if ((sett & 1) == 0) chkInvertWAS.Checked = false;
            else chkInvertWAS.Checked = true;

            if ((sett & 2) == 0) chkSteerInvertRelays.Checked = false;
            else chkSteerInvertRelays.Checked = true;

            if ((sett & 4) == 0) chkInvertSteer.Checked = false;
            else chkInvertSteer.Checked = true;

            if ((sett & 8) == 0) cboxConv.Text = "Differential";
            else cboxConv.Text = "Single";

            if ((sett & 16) == 0) cboxMotorDrive.Text = "IBT2";
            else cboxMotorDrive.Text = "Cytron";

            if ((sett & 32) == 0) cboxSteerEnable.Text = "Button";
            else cboxSteerEnable.Text = "Switch";

            if ((sett & 64) == 0) cboxEncoder.Checked = false;
            else cboxEncoder.Checked = true;

            nudMaxCounts.Value = (decimal)Properties.Vehicle.Default.setArdSteer_maxPulseCounts;
            nudAckerman.Value = (decimal)Properties.Vehicle.Default.setArdSteer_ackermanFix;
        }

        private void tabASteer_Leave(object sender, EventArgs e)
        {
            SaveSettings();
            Properties.Vehicle.Default.Save();
        }

        private void btnSendToSteerArduino_Click(object sender, EventArgs e)
        {
            SaveSettings();

            mf.TimedMessageBox(1000, gStr.gsAutoSteerPort, gStr.gsModuleConfiguration);
        }
        private void nudAckerman_Enter(object sender, EventArgs e)
        {
            if (mf.KeypadToNUD((NumericUpDown)sender))
            {
            }
            btnSendSteerConfigPGN.Focus();

        }
        private void nudMaxCounts_Enter(object sender, EventArgs e)
        {
            if (mf.KeypadToNUD((NumericUpDown)sender))
            {
            }
            btnSendSteerConfigPGN.Focus();
        }

        private void SaveSettings()
        {

            int set = 1;
            int reset = 2046;
            int sett = 0;

            if (chkInvertWAS.Checked) sett |= set;
            else sett &= reset;

            set <<= 1;
            reset <<= 1;
            reset += 1;
            if (chkSteerInvertRelays.Checked) sett |= set;
            else sett &= reset;

            set <<= 1;
            reset <<= 1;
            reset += 1;
            if (chkInvertSteer.Checked) sett |= set;
            else sett &= reset;

            set <<= 1;
            reset <<= 1;
            reset += 1;
            if (cboxConv.Text == "Single") sett |= set;
            else sett &= reset;

            set <<= 1;
            reset <<= 1;
            reset += 1;
            if (cboxMotorDrive.Text == "Cytron") sett |= set;
            else sett &= reset;

            set <<= 1;
            reset <<= 1;
            reset += 1;
            if (cboxSteerEnable.Text == "Switch") sett |= set;
            else sett &= reset;


            set <<= 1;
            reset <<= 1;
            reset += 1;
            if (cboxEncoder.Checked) sett |= set;
            else sett &= reset;

            //set = (set << 1);
            //reset = (reset << 1);
            //reset = (reset + 1);
            //if ( ) sett |= set;
            //else sett &= reset;

            Properties.Vehicle.Default.setArdSteer_setting0 = (byte)sett;
            Properties.Vehicle.Default.setArdSteer_maxPulseCounts = (byte)nudMaxCounts.Value;
            Properties.Vehicle.Default.setArdSteer_ackermanFix = (byte)nudAckerman.Value;

            Properties.Vehicle.Default.Save();

            mf.p_FB.steerConfig[mf.p_FB.set0] = Properties.Vehicle.Default.setArdSteer_setting0;
            mf.p_FB.steerConfig[mf.p_FB.maxPulse] = Properties.Vehicle.Default.setArdSteer_maxPulseCounts;
            mf.p_FB.steerConfig[mf.p_FB.minSpeed] = 5; //0.5 kmh
            mf.p_FB.steerConfig[mf.p_FB.ackermanFix] = Properties.Vehicle.Default.setArdSteer_ackermanFix;

            mf.SendPgnToLoop(mf.p_FB.steerConfig);
        }



        #endregion


        #region Module MAchine




        private void tabAMachine_Enter(object sender, EventArgs e)
        {
            label10.Text = gStr.gsRaiseTime;
            label11.Text = gStr.gsLowerTime;
            cboxIsHydOn.Text = gStr.gsEnableHydraulics;

            int sett = Properties.Vehicle.Default.setArdMac_setting0;

            if ((sett & 1) == 0) cboxMachInvertRelays.Checked = false;
            else cboxMachInvertRelays.Checked = true;

            if ((sett & 2) == 0) cboxIsHydOn.Checked = false;
            else cboxIsHydOn.Checked = true;

            nudRaiseTime.Value = (decimal)Properties.Vehicle.Default.setArdMac_hydRaiseTime;
            nudLowerTime.Value = (decimal)Properties.Vehicle.Default.setArdMac_hydLowerTime;
        }
        private void tabAMachine_Leave(object sender, EventArgs e)
        {
            //nothing to do
        }

        private void nudRaiseTime_Enter(object sender, EventArgs e)
        {
            if (mf.KeypadToNUD((NumericUpDown)sender))
            {
            }
            btnSendMachinePGN.Focus();
        }

        private void nudLowerTime_Enter(object sender, EventArgs e)
        {
            if (mf.KeypadToNUD((NumericUpDown)sender))
            {
            }
            btnSendMachinePGN.Focus();
        }

        private void SaveSettingsMachine()
        {
            int set = 1;
            int reset = 2046;
            int sett = 0;

            if (cboxMachInvertRelays.Checked) sett |= set;
            else sett &= reset;

            set <<= 1;
            reset <<= 1;
            reset += 1;
            if (cboxIsHydOn.Checked) sett |= set;
            else sett &= reset;



            mf.p_FB.steerConfig[mf.p_FB.set0] = Properties.Vehicle.Default.setArdSteer_setting0;


            Properties.Vehicle.Default.setArdMac_setting0 = (byte)sett;
            Properties.Vehicle.Default.setArdMac_hydRaiseTime = (byte)nudRaiseTime.Value;
            Properties.Vehicle.Default.setArdMac_hydLowerTime = (byte)nudLowerTime.Value;

            mf.p_EE.machineConfig[mf.p_EE.set0] = (byte)sett;
            mf.p_EE.machineConfig[mf.p_EE.raiseTime] = (byte)nudRaiseTime.Value;
            mf.p_EE.machineConfig[mf.p_EE.lowerTime] = (byte)nudLowerTime.Value;

            mf.SendPgnToLoop(mf.p_EE.machineConfig);

        }

        private void btnSendMachinePGN_Click(object sender, EventArgs e)
        {
            SaveSettingsMachine();

            mf.TimedMessageBox(1000, gStr.gsMachinePort, gStr.gsModuleConfiguration);

        }

        #endregion











        #region Uturn Enter-Leave

        private void tabUTurn_Enter(object sender, EventArgs e)
        {
            btnYouTurnCustom.Text = gStr.gsCustom;
            label46.Text = gStr.gsDubins + " " + gStr.gsPattern;
            label1.Text = gStr.gsSkips;
            btnIsUsingDubins.Text = gStr.gsDubins;
            label48.Text = gStr.gsUTurnDistance + " " + gStr.gsFromBounds;
            groupBox1.Text = gStr.gsTurnPatterns;
            lblWhenTrig.Text = gStr.gsUTurnLength;
            btnYouTurnRecord.Text = gStr.gsRecord;

            if (Properties.Settings.Default.setAS_youTurnShape == "KeyHole.txt")
            {
                btnYouTurnKeyHole.BackColor = Color.LimeGreen;
                btnYouTurnSemiCircle.BackColor = System.Drawing.Color.Transparent;
                btnYouTurnCustom.BackColor = System.Drawing.Color.Transparent;
                btnYouTurnWideReturn.BackColor = System.Drawing.Color.Transparent;
            }

            if (Properties.Settings.Default.setAS_youTurnShape == "SemiCircle.txt")
            {
                btnYouTurnKeyHole.BackColor = System.Drawing.Color.Transparent;
                btnYouTurnSemiCircle.BackColor = Color.LimeGreen;
                btnYouTurnCustom.BackColor = System.Drawing.Color.Transparent;
                btnYouTurnWideReturn.BackColor = System.Drawing.Color.Transparent;
            }

            if (Properties.Settings.Default.setAS_youTurnShape == "Custom.txt")
            {
                btnYouTurnKeyHole.BackColor = System.Drawing.Color.Transparent;
                btnYouTurnSemiCircle.BackColor = System.Drawing.Color.Transparent;
                btnYouTurnCustom.BackColor = Color.LimeGreen;
                btnYouTurnWideReturn.BackColor = System.Drawing.Color.Transparent;
            }

            if (Properties.Settings.Default.setAS_youTurnShape == "WideReturn.txt")
            {
                btnYouTurnKeyHole.BackColor = System.Drawing.Color.Transparent;
                btnYouTurnSemiCircle.BackColor = System.Drawing.Color.Transparent;
                btnYouTurnCustom.BackColor = System.Drawing.Color.Transparent;
                btnYouTurnWideReturn.BackColor = Color.LimeGreen;
            }

            lblDistance.Text = mf.yt.youTurnStartOffset.ToString();
            if (mf.yt.isYouTurnBtnOn)
            {
                lblDistance.Text = Math.Abs(mf.yt.youTurnStartOffset).ToString() + " m";
            }
            else
            {
                lblDistance.Text = Math.Abs(mf.yt.youTurnStartOffset).ToString() + " m";
            }

            lblTriggerDistance.Text = mf.yt.triggerDistanceOffset.ToString() + "m";

            //update dubins button
            if (!mf.yt.isUsingDubinsTurn)
            {
                btnIsUsingDubins.Text = gStr.gsPattern;
                btnIsUsingDubins.BackColor = Color.Salmon;
                btnYouTurnCustom.Enabled = true;
                btnYouTurnKeyHole.Enabled = true;
                btnYouTurnRecord.Enabled = true;
                btnYouTurnWideReturn.Enabled = true;
                btnYouTurnSemiCircle.Enabled = true;
            }
            else
            {
                btnIsUsingDubins.Text = gStr.gsDubins;
                btnIsUsingDubins.BackColor = Color.LightGreen;
                btnYouTurnCustom.Enabled = false;
                btnYouTurnKeyHole.Enabled = false;
                btnYouTurnRecord.Enabled = false;
                btnYouTurnWideReturn.Enabled = false;
                btnYouTurnSemiCircle.Enabled = false;
            }

            lblSmoothing.Text = mf.yt.uTurnSmoothing.ToString();
            lblDistance.Text = Math.Abs(mf.yt.youTurnStartOffset).ToString() + " m";
            lblTriggerDistance.Text = mf.yt.triggerDistanceOffset.ToString() + "m";
        }

        private void tabUTurn_Leave(object sender, EventArgs e)
        {
            Properties.Settings.Default.setAS_uTurnSmoothing = mf.yt.uTurnSmoothing;
            Properties.Vehicle.Default.set_youUseDubins = mf.yt.isUsingDubinsTurn;
            Properties.Vehicle.Default.set_youTurnDistance = mf.yt.youTurnStartOffset;
            Properties.Vehicle.Default.set_youTriggerDistance = mf.yt.triggerDistanceOffset;

            Properties.Settings.Default.Save();
            Properties.Vehicle.Default.Save();

            mf.turn.BuildTurnLines();
            mf.yt.ResetCreatedYouTurn();
        }

        #endregion

        #region Uturn controls
        private void btnYouTurnKeyHole_Click(object sender, EventArgs e)
        {
            mf.yt.LoadYouTurnShapeFromFile(@".\Dependencies/YouTurnShapes\KeyHole.txt");
            Properties.Settings.Default.setAS_youTurnShape = "KeyHole.txt";
            btnYouTurnSemiCircle.BackColor = System.Drawing.Color.Transparent;
            btnYouTurnCustom.BackColor = System.Drawing.Color.Transparent;
            btnYouTurnWideReturn.BackColor = System.Drawing.Color.Transparent;
            btnYouTurnKeyHole.BackColor = Color.LimeGreen;
        }
        private void btnYouTurnSemiCircle_Click(object sender, EventArgs e)
        {
            mf.yt.LoadYouTurnShapeFromFile(@".\Dependencies\YouTurnShapes\SemiCircle.txt");
            Properties.Settings.Default.setAS_youTurnShape = "SemiCircle.txt";
            btnYouTurnKeyHole.BackColor = System.Drawing.Color.Transparent;
            btnYouTurnCustom.BackColor = System.Drawing.Color.Transparent;
            btnYouTurnWideReturn.BackColor = System.Drawing.Color.Transparent;
            btnYouTurnSemiCircle.BackColor = Color.LimeGreen;
        }
        private void btnYouTurnWideReturn_Click(object sender, EventArgs e)
        {
            mf.yt.LoadYouTurnShapeFromFile(@".\Dependencies\YouTurnShapes\WideReturn.txt");
            Properties.Settings.Default.setAS_youTurnShape = "WideReturn.txt";
            btnYouTurnKeyHole.BackColor = System.Drawing.Color.Transparent;
            btnYouTurnSemiCircle.BackColor = System.Drawing.Color.Transparent;
            btnYouTurnCustom.BackColor = System.Drawing.Color.Transparent;
            btnYouTurnWideReturn.BackColor = Color.LimeGreen;
        }
        private void btnYouTurnCustom_Click(object sender, EventArgs e)
        {
            mf.yt.LoadYouTurnShapeFromFile(@".\Dependencies\YouTurnShapes\Custom.txt");
            Properties.Settings.Default.setAS_youTurnShape = "Custom.txt";
            btnYouTurnKeyHole.BackColor = System.Drawing.Color.Transparent;
            btnYouTurnSemiCircle.BackColor = System.Drawing.Color.Transparent;
            btnYouTurnWideReturn.BackColor = System.Drawing.Color.Transparent;
            btnYouTurnCustom.BackColor = Color.LimeGreen;
        }
        private void btnIsUsingDubins_Click(object sender, EventArgs e)
        {
            if (mf.yt.isUsingDubinsTurn)
            {
                mf.yt.isUsingDubinsTurn = false;
                btnIsUsingDubins.Text = gStr.gsPattern;
                btnIsUsingDubins.BackColor = Color.Salmon;
                btnYouTurnCustom.Enabled = true;
                btnYouTurnKeyHole.Enabled = true;
                btnYouTurnRecord.Enabled = true;
                btnYouTurnWideReturn.Enabled = true;
                btnYouTurnSemiCircle.Enabled = true;
            }
            else
            {
                mf.yt.isUsingDubinsTurn = true;
                btnIsUsingDubins.Text = gStr.gsDubins;
                btnIsUsingDubins.BackColor = Color.LightGreen;
                btnYouTurnCustom.Enabled = false;
                btnYouTurnKeyHole.Enabled = false;
                btnYouTurnRecord.Enabled = false;
                btnYouTurnWideReturn.Enabled = false;
                btnYouTurnSemiCircle.Enabled = false;
            }
        }
        private void btnTriggerDistanceDn_Click(object sender, EventArgs e)
        {
            mf.yt.triggerDistanceOffset--;
            if (mf.yt.triggerDistanceOffset < 0) mf.yt.triggerDistanceOffset = 0;
            lblTriggerDistance.Text = mf.yt.triggerDistanceOffset.ToString() + "m";
        }

        private void btnTriggerDistanceUp_Click(object sender, EventArgs e)
        {
            if (mf.yt.triggerDistanceOffset++ > 50) mf.yt.triggerDistanceOffset = 50;
            lblTriggerDistance.Text = mf.yt.triggerDistanceOffset.ToString() + "m";
        }

        private void btnDistanceDn_Click(object sender, EventArgs e)
        {
            if (mf.yt.youTurnStartOffset-- < 4) mf.yt.youTurnStartOffset = 3;
            lblDistance.Text = Math.Abs(mf.yt.youTurnStartOffset).ToString() + " m";
        }

        private void btnDistanceUp_Click(object sender, EventArgs e)
        {
            if (mf.yt.youTurnStartOffset++ > 49) mf.yt.youTurnStartOffset = 50;
            lblDistance.Text = Math.Abs(mf.yt.youTurnStartOffset).ToString() + " m";
        }
        private void btnTurnSmoothingDown_Click(object sender, EventArgs e)
        {
            mf.yt.uTurnSmoothing -= 2;
            if (mf.yt.uTurnSmoothing < 4) mf.yt.uTurnSmoothing = 4;
            lblSmoothing.Text = mf.yt.uTurnSmoothing.ToString();
        }

        private void btnTurnSmoothingUp_Click(object sender, EventArgs e)
        {
            mf.yt.uTurnSmoothing += 2;
            if (mf.yt.uTurnSmoothing > 18) mf.yt.uTurnSmoothing = 18;
            lblSmoothing.Text = mf.yt.uTurnSmoothing.ToString();
        }
        private void btnYouTurnRecord_Click(object sender, EventArgs e)
        {
            if (mf.ABLine.isABLineSet)
            {
                Properties.Settings.Default.setAS_uTurnSmoothing = mf.yt.uTurnSmoothing;
                Properties.Vehicle.Default.set_youUseDubins = mf.yt.isUsingDubinsTurn;
                Properties.Vehicle.Default.set_youTurnDistance = mf.yt.youTurnStartOffset;
                Properties.Vehicle.Default.set_youTriggerDistance = mf.yt.triggerDistanceOffset;

                Properties.Settings.Default.Save();
                Properties.Vehicle.Default.Save();

                var form = new FormYouTurnRecord(mf);
                form.Show();
                Close();
            }
            else { mf.TimedMessageBox(3000, "No AB Lines", "Start AB Line Guidance"); }
        }

        #endregion

    }
}
