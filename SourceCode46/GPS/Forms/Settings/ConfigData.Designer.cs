using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgOpenGPS
{
    public partial class FormConfig
    {

        #region Data Sources Save ----------------------------------------------------------
        #endregion

        #region Fix

        private void tabDFix_Enter(object sender, EventArgs e)
        {
            //Fix
            if (Properties.Settings.Default.setGPS_fixFromWhichSentence == "GGA") rbtnGGA.Checked = true;
            else if (Properties.Settings.Default.setGPS_fixFromWhichSentence == "RMC") rbtnRMC.Checked = true;
            else if (Properties.Settings.Default.setGPS_fixFromWhichSentence == "OGI") rbtnOGI.Checked = true;
        }

        private void tabDFix_Leave(object sender, EventArgs e)
        {

            Properties.Settings.Default.setGPS_isRTK = cboxIsRTK.Checked;
            mf.isRTK = cboxIsRTK.Checked;

            Properties.Settings.Default.Save();
        }

        private void rbtnGGA_CheckedChanged(object sender, EventArgs e)
        {
            var checkedButton = groupBox4.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            Properties.Settings.Default.setGPS_fixFromWhichSentence = checkedButton.Text;
            mf.pn.fixFrom = checkedButton.Text;
        }

        #endregion


        #region Heading
        private void tabDHeading_Enter(object sender, EventArgs e)
        {
            //heading
            if (Properties.Settings.Default.setGPS_headingFromWhichSource == "Fix") rbtnHeadingFix.Checked = true;
            else if (Properties.Settings.Default.setGPS_headingFromWhichSource == "GPS") rbtnHeadingGPS.Checked = true;
            else if (Properties.Settings.Default.setGPS_headingFromWhichSource == "Dual") rbtnHeadingHDT.Checked = true;

            cboxIsRTK.Checked = Properties.Settings.Default.setGPS_isRTK;
            nudMinFixStepDistance.Value = (decimal)Properties.Settings.Default.setF_minFixStep;
            nudStartSpeed.Value = (decimal)Properties.Vehicle.Default.setVehicle_startSpeed;

            hsbarFusion.Value = (int)(Properties.Settings.Default.setIMU_fusionWeight * 100);
            lblFusion.Text = (hsbarFusion.Value).ToString();
            lblFusionIMU.Text = (50 - hsbarFusion.Value).ToString();

            hsbarFusion.Focus();
        }

        private void tabDHeading_Leave(object sender, EventArgs e)
        {
            Properties.Settings.Default.setIMU_fusionWeight = (double)hsbarFusion.Value * 0.01;
            Properties.Settings.Default.setF_minFixStep = (double)nudMinFixStepDistance.Value;
            Properties.Vehicle.Default.setVehicle_startSpeed = (double)nudStartSpeed.Value;

            Properties.Settings.Default.Save();
            Properties.Vehicle.Default.Save();
        }

        private void rbtnHeadingFix_CheckedChanged(object sender, EventArgs e)
        {
            var checkedButton = headingGroupBox.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            Properties.Settings.Default.setGPS_headingFromWhichSource = checkedButton.Text;
            mf.headingFromSource = checkedButton.Text;
        }

        private void hsbarFusion_ValueChanged(object sender, EventArgs e)
        {
            lblFusion.Text = (hsbarFusion.Value).ToString();
            lblFusionIMU.Text = (50 - hsbarFusion.Value).ToString();
        }

        private void nudMinFixStepDistance_Enter(object sender, EventArgs e)
        {
            if (mf.KeypadToNUD((NumericUpDown)sender))
            {
            }
            hsbarFusion.Focus();
        }

        private void nudStartSpeed_Enter(object sender, EventArgs e)
        {
            if (mf.KeypadToNUD((NumericUpDown)sender))
            {
            }
            hsbarFusion.Focus();
        }

        #endregion


        #region Roll

        private void tabDRoll_Enter(object sender, EventArgs e)
        {
            //Roll
            lblRollZeroOffset.Text = ((double)Properties.Settings.Default.setIMU_rollZero).ToString("N2");
            hsbarRollFilter.Value = (int)(Properties.Settings.Default.setIMU_rollFilter * 100);
            cboxDataInvertRoll.Checked = Properties.Settings.Default.setIMU_invertRoll;
        }

        private void tabDRoll_Leave(object sender, EventArgs e)
        {
            Properties.Settings.Default.setIMU_rollFilter = (double)hsbarRollFilter.Value * 0.01;
            Properties.Settings.Default.setIMU_rollZero = mf.ahrs.rollZero;
            Properties.Settings.Default.setIMU_invertRoll = cboxDataInvertRoll.Checked;

            mf.ahrs.rollFilter = Properties.Settings.Default.setIMU_rollFilter;
            mf.ahrs.fusionWeight = Properties.Settings.Default.setIMU_fusionWeight;
            mf.ahrs.isRollInvert = Properties.Settings.Default.setIMU_invertRoll;

            Properties.Settings.Default.Save();
        }

        private void hsbarRollFilter_ValueChanged(object sender, EventArgs e)
        {
            lblRollFilterPercent.Text = hsbarRollFilter.Value.ToString();
        }

        private void btnZeroRoll_Click(object sender, EventArgs e)
        {
            if (mf.ahrs.imuRoll != 88888)
            {
                mf.ahrs.imuRoll += mf.ahrs.rollZero;
                mf.ahrs.rollZero = mf.ahrs.imuRoll;
                lblRollZeroOffset.Text = (mf.ahrs.rollZero).ToString("N2");
            }
            else
            {
                lblRollZeroOffset.Text = "***";
            }
        }

        private void btnRemoveZeroOffset_Click(object sender, EventArgs e)
        {
            mf.ahrs.rollZero = 0;
            lblRollZeroOffset.Text = "0.00";
        }
         
        private void btnResetIMU_Click(object sender, EventArgs e)
        {
            mf.ahrs.imuHeading = 99999;
            mf.ahrs.imuRoll = 88888;
        }

        #endregion 
    }
}
