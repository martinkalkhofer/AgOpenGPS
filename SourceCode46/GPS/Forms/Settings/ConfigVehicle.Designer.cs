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
        #region summary Page

        #endregion


        #region Vehicle Save---------------------------------------------
        private void btnVehicleSave_Click(object sender, EventArgs e)
        {
            if (tboxVehicleNameSave.Text.Trim().Length > 0)
            {
                SettingsIO.ExportAll(mf.vehiclesDirectory + tboxVehicleNameSave.Text.Trim() + ".XML");
                UpdateVehicleListView();
                tboxVehicleNameSave.Text = "";

            }
        }

        private void btnVehicleSaveAs_Click(object sender, EventArgs e)
        {
            if (lvVehicles.SelectedItems.Count > 0)
            {

                DialogResult result3 = MessageBox.Show(
                    "Overwrite: " + lvVehicles.SelectedItems[0].SubItems[0].Text + ".XML",
                    gStr.gsSaveAndReturn,
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);
                if (result3 == DialogResult.Yes)
                {
                    SettingsIO.ExportAll(mf.vehiclesDirectory + lvVehicles.SelectedItems[0].SubItems[0].Text + ".XML");
                }
                UpdateVehicleListView();
            }
        }

        private void UpdateVehicleListView()
        {
            DirectoryInfo dinfo = new DirectoryInfo(mf.vehiclesDirectory);
            FileInfo[] Files = dinfo.GetFiles("*.XML");

            //load the listbox
            lvVehicles.Items.Clear();
            foreach (FileInfo file in Files)
            {
                lvVehicles.Items.Add(Path.GetFileNameWithoutExtension(file.Name));
            }

            //deselect everything
            lvVehicles.SelectedItems.Clear();
        }

        private void btnVehicleLoad_Click(object sender, EventArgs e)
        {
            if (lvVehicles.SelectedItems.Count > 0)
            {
                DialogResult result3 = MessageBox.Show(
                    "Load: " + lvVehicles.SelectedItems[0].SubItems[0].Text + ".XML",
                    gStr.gsSaveAndReturn,
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);
                if (result3 == DialogResult.Yes)
                {
                    SettingsIO.ImportAll(mf.vehiclesDirectory + lvVehicles.SelectedItems[0].SubItems[0].Text + ".XML");

                    //reset AOG
                    mf.LoadSettings();

                }
                UpdateVehicleListView();
            }
        }

        private void btnVehicleDelete_Click(object sender, EventArgs e)
        {
            if (lvVehicles.SelectedItems.Count > 0)
            {

                DialogResult result3 = MessageBox.Show(
                "Delete: " + lvVehicles.SelectedItems[0].SubItems[0].Text + ".XML",
                gStr.gsSaveAndReturn,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button2);
                if (result3 == DialogResult.Yes)
                {
                    File.Delete(mf.vehiclesDirectory + lvVehicles.SelectedItems[0].SubItems[0].Text + ".XML");
                }
                UpdateVehicleListView();
            }
        }
        #endregion

        #region VConfig Enter/Leave

        private void tabVConfig_Enter(object sender, EventArgs e)
        {
            if (mf.vehicle.vehicleType == 0) rbtnTractor.Checked = true;
            else if (mf.vehicle.vehicleType == 1) rbtnHarvester.Checked = true;
            else if (mf.vehicle.vehicleType == 2) rbtn4WD.Checked = true;
        }

        private void tabVConfig_Leave(object sender, EventArgs e)
        {
            if (rbtnTractor.Checked)
            {
                mf.vehicle.vehicleType = 0;
                Properties.Vehicle.Default.setVehicle_vehicleType = 0;
            }
            if (rbtnHarvester.Checked)
            {
                mf.vehicle.vehicleType = 1;
                Properties.Vehicle.Default.setVehicle_vehicleType = 1;
            }
            if (rbtn4WD.Checked)
            {
                mf.vehicle.vehicleType = 2;
                Properties.Vehicle.Default.setVehicle_vehicleType = 2;
            }

            if (mf.vehicle.vehicleType == 0) //2WD tractor
            {
                Properties.Vehicle.Default.setVehicle_isPivotBehindAntenna = true;
                Properties.Vehicle.Default.setVehicle_isSteerAxleAhead = true;
            }
            if (mf.vehicle.vehicleType == 1) //harvestor
            {
                Properties.Vehicle.Default.setVehicle_isPivotBehindAntenna = true;
                Properties.Vehicle.Default.setVehicle_isSteerAxleAhead = false ;
            }
            if (mf.vehicle.vehicleType == 2) //4WD
            {
                Properties.Vehicle.Default.setVehicle_isPivotBehindAntenna = false;
                Properties.Vehicle.Default.setVehicle_isSteerAxleAhead = true;
            }

            Properties.Vehicle.Default.Save();

            mf.vehicle.isPivotBehindAntenna = Properties.Vehicle.Default.setVehicle_isPivotBehindAntenna;
            mf.vehicle.isSteerAxleAhead = Properties.Vehicle.Default.setVehicle_isSteerAxleAhead;
            mf.vehicle.vehicleType = Properties.Vehicle.Default.setVehicle_vehicleType;




        }

        #endregion

        #region Antenna Enter/Leave
        private void tabVAntenna_Enter(object sender, EventArgs e)
        {
            nudAntennaHeight.Value = (decimal)(Properties.Vehicle.Default.setVehicle_antennaHeight* mf.m2InchOrCm);

            nudAntennaPivot.Value = (decimal)(Math.Abs(Properties.Vehicle.Default.setVehicle_antennaPivot)* mf.m2InchOrCm);

            nudAntennaOffset.Value = (decimal)(Properties.Vehicle.Default.setVehicle_antennaOffset* mf.m2InchOrCm);

            nudWheelbase.Value = (decimal)(Math.Abs(Properties.Vehicle.Default.setVehicle_wheelbase) * mf.m2InchOrCm);

            if (Properties.Vehicle.Default.setVehicle_vehicleType == 0)
                pboxAntenna.Image = Properties.Resources.VehicleAntennaTractor;

            else if (Properties.Vehicle.Default.setVehicle_vehicleType == 1)
                pboxAntenna.Image = Properties.Resources.VehicleAntennaHarvestor;

            else if (Properties.Vehicle.Default.setVehicle_vehicleType == 2)
                pboxAntenna.Image = Properties.Resources.VehicleAntenna4WD;

            btnNext.Focus();
        }

        private void tabVAntenna_Leave(object sender, EventArgs e)
        {

            Properties.Vehicle.Default.setVehicle_antennaHeight = (double)nudAntennaHeight.Value * mf.inchOrCm2m;

            Properties.Vehicle.Default.setVehicle_antennaPivot = (double)nudAntennaPivot.Value * mf.inchOrCm2m;

            Properties.Vehicle.Default.setVehicle_antennaOffset = (double)nudAntennaOffset.Value * mf.inchOrCm2m;

            Properties.Vehicle.Default.setVehicle_wheelbase = (double)nudWheelbase.Value * mf.inchOrCm2m;

            mf.vehicle.antennaHeight = Properties.Vehicle.Default.setVehicle_antennaHeight;
            mf.vehicle.antennaPivot = Properties.Vehicle.Default.setVehicle_antennaPivot;
            mf.vehicle.antennaOffset = Properties.Vehicle.Default.setVehicle_antennaOffset;
            mf.vehicle.wheelbase = Properties.Vehicle.Default.setVehicle_wheelbase;

            Properties.Vehicle.Default.Save();
        }

        private void nudAntennaPivot_Enter(object sender, EventArgs e)
        {
            if (mf.KeypadToNUD((NumericUpDown)sender))
            {
                mf.vehicle.antennaPivot = (double)nudAntennaHeight.Value * mf.inchOrCm2m;
            }
            btnNext.Focus();
        }

        private void nudAntennaOffset_Enter(object sender, EventArgs e)
        {
            if (mf.KeypadToNUD((NumericUpDown)sender))
            {
                mf.vehicle.antennaOffset = (double)nudAntennaHeight.Value * mf.inchOrCm2m;
            }
            btnNext.Focus();
        }

        private void nudAntennaHeight_Enter(object sender, EventArgs e)
        {
            if (mf.KeypadToNUD((NumericUpDown)sender))
            {
                mf.vehicle.antennaHeight = (double)nudAntennaHeight.Value * mf.inchOrCm2m;
            }
            btnNext.Focus();
        }

        private void nudWheelbase_Enter(object sender, EventArgs e)
        {
            if (mf.KeypadToNUD((NumericUpDown)sender))
            {
                mf.vehicle.wheelbase = (double)nudWheelbase.Value * mf.inchOrCm2m;
            }
            btnNextDim.Focus();
        }

        #endregion

        #region Vehicle Dimensions
        private void tabVDimensions_Enter(object sender, EventArgs e)
        {
            nudMinTurnRadius.Value = (decimal)(Properties.Vehicle.Default.setVehicle_minTurningRadius * mf.m2InchOrCm);

        }

        private void tabVDimensions_Leave(object sender, EventArgs e)
        {
            Properties.Vehicle.Default.setVehicle_minTurningRadius = (double)nudMinTurnRadius.Value * mf.inchOrCm2m;

            mf.vehicle.minTurningRadius = Properties.Vehicle.Default.setVehicle_minTurningRadius;

            Properties.Vehicle.Default.Save();
        }

        private void nudMinTurnRadius_Enter(object sender, EventArgs e)
        {
            if (mf.KeypadToNUD((NumericUpDown)sender))
            {
                mf.vehicle.minTurningRadius = (double)nudMinTurnRadius.Value * mf.inchOrCm2m;
            }
            btnNextDim.Focus();
        }

        #endregion

        #region Vehicle Guidance

        private void tabVGuidance_Enter(object sender, EventArgs e)
        {
            nudSnapDistance.Value = Properties.Settings.Default.setAS_snapDistance;
            nudLineWidth.Value = Properties.Settings.Default.setDisplay_lineWidth;
            nudLightbarCmPerPixel.Value = Properties.Settings.Default.setDisplay_lightbarCmPerPixel;
            
            if (Properties.Settings.Default.setAS_isAutoSteerAutoOn)
            {
                cboxAutoSteerAuto.Image = Properties.Resources.AutoSteerOn;
                cboxAutoSteerAuto.Text = "Remote";
            }
            else
            {
                cboxAutoSteerAuto.Image = Properties.Resources.AutoSteerOff;
                cboxAutoSteerAuto.Text = gStr.gsManual;
            }
        }

        private void tabVGuidance_Leave(object sender, EventArgs e)
        {
            Properties.Settings.Default.setAS_snapDistance = (int)nudSnapDistance.Value;
            Properties.Settings.Default.setDisplay_lineWidth = (int)nudLineWidth.Value;
            Properties.Settings.Default.setDisplay_lightbarCmPerPixel = (int)nudLightbarCmPerPixel.Value;
            Properties.Settings.Default.setAS_isAutoSteerAutoOn = cboxAutoSteerAuto.Checked;

            Properties.Settings.Default.Save();
        }

        private void cboxAutoSteerAuto_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxAutoSteerAuto.Checked)
            {
                cboxAutoSteerAuto.Image = Properties.Resources.AutoSteerOn;
                cboxAutoSteerAuto.Text = "Remote";
            }
            else
            {
                cboxAutoSteerAuto.Image = Properties.Resources.AutoSteerOff;
                cboxAutoSteerAuto.Text = gStr.gsManual;
            }
        }

        private void nudSnapDistance_Enter(object sender, EventArgs e)
        {
            if (mf.KeypadToNUD((NumericUpDown)sender))
            {
            }
            cboxAutoSteerAuto.Focus();

        }

        private void nudLightbarCmPerPixel_Enter(object sender, EventArgs e)
        {
            if (mf.KeypadToNUD((NumericUpDown)sender))
            {
                mf.lightbarCmPerPixel = (int)nudLightbarCmPerPixel.Value;
            }
            cboxAutoSteerAuto.Focus();

        }

        private void nudLineWidth_Enter(object sender, EventArgs e)
        {
            if (mf.KeypadToNUD((NumericUpDown)sender))
            {
                mf.ABLine.lineWidth = (int)nudLineWidth.Value;
            }
            cboxAutoSteerAuto.Focus();
        }

        #endregion

    }
}
