﻿using System;
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

        #region Vehicle Save---------------------------------------------
        private void btnVehicleSave_Click(object sender, EventArgs e)
        {
            if (tboxVehicleNameSave.Text.Trim().Length > 0)
            {
                //SettingsIO.Export(mf.vehiclesDirectory + tboxVehicleNameSave.Text.Trim() + ".XML");
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
                    //SettingsIO.Export(mf.vehiclesDirectory + lvVehicles.SelectedItems[0].SubItems[0].Text + ".XML");
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
                    //SettingsIO.Import("Vehicle", mf.vehiclesDirectory + lvVehicles.SelectedItems[0].SubItems[0].Text + ".XML");

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
                Properties.Vehicle.Default.setVehicle_vehicleType = 0;
            }
            if (rbtn4WD.Checked)
            {
                mf.vehicle.vehicleType = 2;
                Properties.Vehicle.Default.setVehicle_vehicleType = 0;
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
        }

        #endregion

        #region Antenna Enter/Leave
        private void tabVAntenna_Enter(object sender, EventArgs e)
        {
            nudAntennaHeight.Value = (decimal)Properties.Vehicle.Default.setVehicle_antennaHeight*100;

            nudAntennaPivot.Value = (decimal)Math.Abs(Properties.Vehicle.Default.setVehicle_antennaPivot)*100;

            nudAntennaOffset.Value = (decimal)Properties.Vehicle.Default.setVehicle_antennaOffset*100;

            btnNext.Focus();
        }

        private void tabVAntenna_Leave(object sender, EventArgs e)
        {

            Properties.Vehicle.Default.setVehicle_antennaHeight = (double)nudAntennaHeight.Value * 0.01;


            Properties.Vehicle.Default.setVehicle_antennaPivot = (double)nudAntennaPivot.Value * 0.01;


            Properties.Vehicle.Default.setVehicle_antennaOffset = (double)nudAntennaOffset.Value * 0.01;


            Properties.Vehicle.Default.Save();
        }

        private void nudAntennaPivot_Enter(object sender, EventArgs e)
        {
            if (mf.KeypadToNUD((NumericUpDown)sender))
            {
                mf.vehicle.antennaPivot = (double)nudAntennaHeight.Value * 0.01;
            }
            btnNext.Focus();
        }

        private void nudAntennaOffset_Enter(object sender, EventArgs e)
        {
            if (mf.KeypadToNUD((NumericUpDown)sender))
            {
                mf.vehicle.antennaOffset = (double)nudAntennaHeight.Value * 0.01;
            }
            btnNext.Focus();
        }

        private void nudAntennaHeight_Enter(object sender, EventArgs e)
        {
            if (mf.KeypadToNUD((NumericUpDown)sender))
            {
                mf.vehicle.antennaHeight = (double)nudAntennaHeight.Value * 0.01;
            }
            btnNext.Focus();
        }

        #endregion

        #region Vehicle Dimensions
        private void tabVDimensions_Enter(object sender, EventArgs e)
        {
            nudMinTurnRadius.Value = (decimal)Properties.Vehicle.Default.setVehicle_minTurningRadius * 100;
            nudWheelbase.Value = (decimal)Math.Abs(Properties.Vehicle.Default.setVehicle_wheelbase) * 100; ;

        }

        private void tabVDimensions_Leave(object sender, EventArgs e)
        {
            Properties.Vehicle.Default.setVehicle_minTurningRadius = (double)nudMinTurnRadius.Value * 0.01;
            Properties.Vehicle.Default.setVehicle_wheelbase = (double)nudWheelbase.Value * 0.01;

            Properties.Vehicle.Default.Save();
        }

        private void nudMinTurnRadius_Enter(object sender, EventArgs e)
        {
            if (mf.KeypadToNUD((NumericUpDown)sender))
            {
                mf.vehicle.minTurningRadius = (double)nudMinTurnRadius.Value * 0.01;
            }
            btnNextDim.Focus();

        }

        private void nudWheelbase_Enter(object sender, EventArgs e)
        {
            if (mf.KeypadToNUD((NumericUpDown)sender))
            {
                mf.vehicle.wheelbase = (double)nudWheelbase.Value * 0.01;
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
