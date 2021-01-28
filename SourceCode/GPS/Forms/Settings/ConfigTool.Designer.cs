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
        #region Config
        private void tabTConfig_Enter(object sender, EventArgs e)
        {
            if (Properties.Vehicle.Default.setTool_isToolFront)
            {
                rbtnTBT.Checked = false;
                rbtnTrailing.Checked = false;
                rbtnFixedRear.Checked = false;
                rbtnFront.Checked = true;
            }
            else if (Properties.Vehicle.Default.setTool_isToolTBT)
            {
                rbtnTBT.Checked = true;
                rbtnTrailing.Checked = false;
                rbtnFixedRear.Checked = false;
                rbtnFront.Checked = false;
            }
            else if (Properties.Vehicle.Default.setTool_isToolTrailing)
            {
                rbtnTBT.Checked = false;
                rbtnTrailing.Checked = true;
                rbtnFixedRear.Checked = false;
                rbtnFront.Checked = false;
            }
            else if (Properties.Vehicle.Default.setTool_isToolRearFixed)
            {
                rbtnTBT.Checked = false;
                rbtnTrailing.Checked = false;
                rbtnFixedRear.Checked = true;
                rbtnFront.Checked = false;
            }
        }
        private void tabTConfig_Leave(object sender, EventArgs e)
        {
            if (rbtnFront.Checked)
            {
                Properties.Vehicle.Default.setTool_isToolFront = true;
                Properties.Vehicle.Default.setTool_isToolTBT = false;
                Properties.Vehicle.Default.setTool_isToolTrailing = false;
                Properties.Vehicle.Default.setTool_isToolRearFixed = false;
            }
            else if (rbtnTBT.Checked)
            {
                Properties.Vehicle.Default.setTool_isToolFront = false;
                Properties.Vehicle.Default.setTool_isToolTBT = true;
                Properties.Vehicle.Default.setTool_isToolTrailing = true;
                Properties.Vehicle.Default.setTool_isToolRearFixed = false;
            }
            else if (rbtnTrailing.Checked)
            {
                Properties.Vehicle.Default.setTool_isToolFront = false;
                Properties.Vehicle.Default.setTool_isToolTBT = false;
                Properties.Vehicle.Default.setTool_isToolTrailing = true;
                Properties.Vehicle.Default.setTool_isToolRearFixed = false;
            }
            else if (rbtnFixedRear.Checked)
            {
                Properties.Vehicle.Default.setTool_isToolFront = false;
                Properties.Vehicle.Default.setTool_isToolTBT = false;
                Properties.Vehicle.Default.setTool_isToolTrailing = false;
                Properties.Vehicle.Default.setTool_isToolRearFixed = true;
            }

            mf.tool.isToolRearFixed = Properties.Vehicle.Default.setTool_isToolRearFixed;
            mf.tool.isToolTrailing = Properties.Vehicle.Default.setTool_isToolTrailing;
            mf.tool.isToolTBT = Properties.Vehicle.Default.setTool_isToolTBT;
            mf.tool.isToolFrontFixed = Properties.Vehicle.Default.setTool_isToolFront;

            Properties.Vehicle.Default.Save();
        }


        #endregion

        #region  Hitch

        private void tabTHitch_Enter(object sender, EventArgs e)
        {
            if (Properties.Vehicle.Default.setTool_isToolFront)
            {
                nudTrailingHitchLength.Visible = false;
                nudDrawbarLength.Visible = true;
                nudTankHitch.Visible = false;

                nudTrailingHitchLength.Left = 0;
                nudDrawbarLength.Left = 206;
                nudTankHitch.Left = 0;

                picboxToolHitch.Image = Properties.Resources.ToolHitchPageFront1;
            }
            else if (Properties.Vehicle.Default.setTool_isToolTBT)
            {
                nudTrailingHitchLength.Visible = true;
                nudDrawbarLength.Visible = true;
                nudTankHitch.Visible = true;

                nudTrailingHitchLength.Left = 451;
                nudDrawbarLength.Left = 61;
                nudTankHitch.Left = 256;

                picboxToolHitch.Image = Properties.Resources.ToolHitchPageTBT1;
            }
            else if (Properties.Vehicle.Default.setTool_isToolRearFixed)
            {
                nudTrailingHitchLength.Visible = false;
                nudDrawbarLength.Visible = true;
                nudTankHitch.Visible = false;

                nudTrailingHitchLength.Left = 0;
                nudDrawbarLength.Left = 440;
                nudTankHitch.Left = 0;

                picboxToolHitch.Image = Properties.Resources.ToolHitchPageRear1;
            }
            else if (Properties.Vehicle.Default.setTool_isToolTrailing)
            {
                nudTrailingHitchLength.Visible = true;
                nudDrawbarLength.Visible = true;
                nudTankHitch.Visible = false;

                nudTrailingHitchLength.Left = 465;
                nudDrawbarLength.Left = 292;
                nudTankHitch.Left = 0;

                picboxToolHitch.Image = Properties.Resources.ToolHitchPageTrailing1;
            }

            nudDrawbarLength.Value = (decimal)Math.Abs(Properties.Vehicle.Default.setVehicle_hitchLength)*100;
            nudTrailingHitchLength.Value = (decimal)Math.Abs(Properties.Vehicle.Default.setTool_toolTrailingHitchLength) * 100;
            nudTankHitch.Value = (decimal)Math.Abs(Properties.Vehicle.Default.setVehicle_tankTrailingHitchLength) * 100;
        }

        private void tabTHitch_Leave(object sender, EventArgs e)
        {
            Properties.Vehicle.Default.Save();
        }


        private void nudDrawbarLength_Enter(object sender, EventArgs e)
        {
            if (mf.KeypadToNUD((NumericUpDown)sender))
            {
                mf.tool.hitchLength = (double)nudDrawbarLength.Value * 0.01;
                if (!Properties.Vehicle.Default.setTool_isToolFront)
                {
                    mf.tool.hitchLength *= -1;
                }
                Properties.Vehicle.Default.setVehicle_hitchLength = mf.tool.hitchLength;

            }
            btnNext2.Focus();
        }

        private void nudTankHitch_Enter(object sender, EventArgs e)
        {
            if (mf.KeypadToNUD((NumericUpDown)sender))
            {
                mf.tool.toolTankTrailingHitchLength = (double)nudTankHitch.Value * -0.01;
                Properties.Vehicle.Default.setVehicle_tankTrailingHitchLength = mf.tool.toolTankTrailingHitchLength;

            }
            btnNext2.Focus();
        }

        private void nudTrailingHitchLength_Enter(object sender, EventArgs e)
        {
            if (mf.KeypadToNUD((NumericUpDown)sender))
            {
                mf.tool.toolTrailingHitchLength = (double)nudTrailingHitchLength.Value * -0.01;
                Properties.Vehicle.Default.setTool_toolTrailingHitchLength = mf.tool.toolTrailingHitchLength;

            }
            btnNext2.Focus();
        }


        #endregion

        #region Settings

        private void tabTSettings_Enter(object sender, EventArgs e)
        {
            nudLookAhead.Value =    (decimal)Properties.Vehicle.Default.setVehicle_toolLookAheadOn;
            nudLookAheadOff.Value = (decimal)Properties.Vehicle.Default.setVehicle_toolLookAheadOff;
            nudTurnOffDelay.Value = (decimal)Properties.Vehicle.Default.setVehicle_toolOffDelay;
            nudOffset.Value =       (decimal)Properties.Vehicle.Default.setVehicle_toolOffset*100;
            nudOverlap.Value =      (decimal)Properties.Vehicle.Default.setVehicle_toolOverlap*100;
            nudCutoffSpeed.Value =  (decimal)Properties.Vehicle.Default.setVehicle_slowSpeedCutoff;

            btnNext3.Focus();

        }

        private void tabTSettings_Leave(object sender, EventArgs e)
        {

            Properties.Vehicle.Default.setVehicle_toolLookAheadOn = (double)nudLookAhead.Value;
            Properties.Vehicle.Default.setVehicle_toolLookAheadOff = (double)nudLookAheadOff.Value;
            Properties.Vehicle.Default.setVehicle_toolOffDelay = (double)nudTurnOffDelay.Value;
            Properties.Vehicle.Default.setVehicle_toolOffset = (double)nudOffset.Value*0.01;
            Properties.Vehicle.Default.setVehicle_toolOverlap = (double)nudOverlap.Value*0.01;
            Properties.Vehicle.Default.setVehicle_slowSpeedCutoff = (double)nudCutoffSpeed.Value;

            Properties.Vehicle.Default.Save();
        }

        private void nudLookAhead_Enter(object sender, EventArgs e)
        {
            if (mf.KeypadToNUD((NumericUpDown)sender))
            {
                if (nudLookAheadOff.Value > (nudLookAhead.Value * 0.8m))
                {
                    nudLookAheadOff.Value = nudLookAhead.Value * 0.8m;
                }

                mf.tool.lookAheadOnSetting = (double)nudLookAhead.Value;
            }
            btnNext3.Focus();
        }

        private void nudLookAheadOff_Enter(object sender, EventArgs e)
        {
            if (mf.KeypadToNUD((NumericUpDown)sender))
            {
                if (nudLookAheadOff.Value > (nudLookAhead.Value * 0.8m))
                {
                    nudLookAheadOff.Value = nudLookAhead.Value * 0.8m;
                }
                mf.tool.lookAheadOffSetting = (double)nudLookAheadOff.Value;
            }
            btnNext3.Focus();
        }

        private void nudTurnOffDelay_Enter(object sender, EventArgs e)
        {
            if (mf.KeypadToNUD((NumericUpDown)sender))
            {
                if (nudTurnOffDelay.Value > 0)
                {
                    nudLookAheadOff.Value = 0;
                }
                mf.tool.turnOffDelay = (double)nudTurnOffDelay.Value;
                mf.tool.lookAheadOffSetting = (double)nudLookAheadOff.Value;
            }
            btnNext3.Focus();
        }

        private void nudOverlap_Enter(object sender, EventArgs e)
        {
            if (mf.KeypadToNUD((NumericUpDown)sender))
            {
                mf.tool.toolOverlap = (double)nudOverlap.Value * 0.01;
            }
            btnNext3.Focus();
        }

        private void nudOffset_Enter(object sender, EventArgs e)
        {
            if (mf.KeypadToNUD((NumericUpDown)sender))
            {
                mf.tool.toolOffset = (double)nudOffset.Value * 0.01;
            }
            btnNext3.Focus();
        }

        private void nudCutoffSpeed_Enter(object sender, EventArgs e)
        {
            if (mf.KeypadToNUD((NumericUpDown)sender))
            {
                mf.vehicle.slowSpeedCutoff = (double)nudCutoffSpeed.Value;
            }
            btnNext3.Focus();
        }

        #endregion

        #region Sections 



        #endregion

        #region Switch

        private void tabTSwitches_Enter(object sender, EventArgs e)
        {
            chkWorkSwActiveLow.Checked =    Properties.Settings.Default.setF_IsWorkSwitchActiveLow;
            chkEnableWorkSwitch.Checked =   Properties.Settings.Default.setF_IsWorkSwitchEnabled;
            checkWorkSwitchManual.Checked = Properties.Settings.Default.setF_IsWorkSwitchManual;
        }
    

        private void tabTSwitches_Leave(object sender, EventArgs e)
        {
            mf.mc.isWorkSwitchActiveLow = Properties.Settings.Default.setF_IsWorkSwitchActiveLow = chkWorkSwActiveLow.Checked;
            mf.mc.isWorkSwitchEnabled = Properties.Settings.Default.setF_IsWorkSwitchEnabled = chkEnableWorkSwitch.Checked;
            mf.mc.isWorkSwitchManual = Properties.Settings.Default.setF_IsWorkSwitchManual = checkWorkSwitchManual.Checked;

            Properties.Settings.Default.Save();
        }

        #endregion

    }
}
