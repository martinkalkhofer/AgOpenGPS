using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace AgOpenGPS
{
    public partial class FormConfig
    {
        private void HideSubMenu()
        {
            panelVehicleSubMenu.Visible = false;
            panelToolSubMenu.Visible = false;
            panelDataSourcesSubMenu.Visible = false;
            panelArduino.Visible = false;

            //default color all main menu buttons
            btnVehicle.BackColor = Color.FromArgb(50, 50, 70);
            btnTool.BackColor = Color.FromArgb(50, 50, 70);
            btnDataSources.BackColor = Color.FromArgb(50, 50, 70);
            btnUTurn.BackColor = Color.FromArgb(50, 50, 70);
            btnArduino.BackColor = Color.FromArgb(50, 50, 70);

        }

        private void ShowSubMenu(Panel subMenu, Button btn)
        {
            tab1.SelectedTab = tabSummary;
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
                btn.BackColor = Color.Teal;
            }
            else
            {
                subMenu.Visible = false;
                btn.BackColor = Color.FromArgb(50, 50, 70);
            }
        }

        #region Top Menu Btns

        private void btnHome_Click(object sender, EventArgs e)
        {
            tab1.SelectedTab = tabSummary;
            HideSubMenu();
            UpdateSummary();
        }

        private void UpdateSummary()
        {
            lblSumWheelbase.Text = Properties.Vehicle.Default.setVehicle_wheelbase.ToString();
            lblSumToolWidth.Text = mf.tool.toolWidth.ToString();
            lblSumNumSections.Text = mf.tool.numOfSections.ToString();

            //lblSumCurrentVehicle.Text = Properties.Settings.Default...........ToString();
            //lblSumCurrentTool.Text = Properties.Tool.Default.toolSettings.toolFileName.ToString();
            //lblSumCurrentDataSource.Text = Properties.DataSource.Default.dataSourceSettings.dataSourceFileName.ToString();
            //lblSumFixType.Text = Properties.DataSource.Default.dataSourceSettings.fixFrom.ToString();
        }

        private void btnTool_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelToolSubMenu, btnTool);
            tab1.SelectedTab = tabSummary;
            UpdateVehicleListView();
            UpdateSummary();

        }

        private void btnDataSources_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelDataSourcesSubMenu, btnDataSources);
            tab1.SelectedTab = tabSummary;
            //lblCurrentData.Text = gStr.gsCurrent + mf.dataSourceFileName;
            UpdateVehicleListView();
            UpdateSummary();
        }

        private void btnVehicle_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelVehicleSubMenu, btnVehicle);
            tab1.SelectedTab = tabSummary;
            lblCurrentVehicle.Text = gStr.gsCurrent + mf.vehicleFileName;
            UpdateVehicleListView();
            UpdateSummary();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUTurn_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            tab1.SelectedTab = tabUTurn;
            btnUTurn.BackColor = Color.Teal;
        }

        private void btnArduino_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelArduino, btnArduino);
            tab1.SelectedTab = tabSummary;

            lblCurrentVehicle.Text = gStr.gsCurrent + mf.vehicleFileName;
            UpdateVehicleListView();
            UpdateSummary();
        }


        #endregion

        #region Vehicle Sub Menu Btns
        private void btnSubVehicleType_Click(object sender, EventArgs e)
        {
            tab1.SelectedTab = tabVConfig;
        }

        private void btnSubDimensions_Click(object sender, EventArgs e)
        {
            tab1.SelectedTab = tabVDimensions;
        }

        private void btnSubAntenna_Click(object sender, EventArgs e)
        {
            tab1.SelectedTab = tabVAntenna;
        }

        private void btnSubGuidance_Click(object sender, EventArgs e)
        {
            tab1.SelectedTab = tabVGuidance;
        }

        #endregion Region

        #region Tool Sub Menu
        private void btnSubToolType_Click(object sender, EventArgs e)
        {
            tab1.SelectedTab = tabTConfig;
        }

        private void btnSubHitch_Click(object sender, EventArgs e)
        {
            tab1.SelectedTab = tabTHitch;
        }

        private void btnSubSections_Click(object sender, EventArgs e)
        {
            tab1.SelectedTab = tabTSections;
        }

        private void btnSubSwitches_Click(object sender, EventArgs e)
        {
            tab1.SelectedTab = tabTSwitches;
        }

        private void btnSubToolSettings_Click(object sender, EventArgs e)
        {
            tab1.SelectedTab = tabTSettings;
        }
        #endregion

        #region SubMenu Data Sources
        private void btnSubRoll_Click(object sender, EventArgs e)
        {
            tab1.SelectedTab = tabDRoll;
        }

        private void btnSubHeading_Click(object sender, EventArgs e)
        {
            tab1.SelectedTab = tabDHeading;

        }

        private void btnSubFix_Click(object sender, EventArgs e)
        {
            tab1.SelectedTab = tabDFix;
        }

        #endregion

        #region Module

        private void btnSteerModule_Click(object sender, EventArgs e)
        {
            tab1.SelectedTab = tabASteer;
        }

        private void btnMachineModule_Click(object sender, EventArgs e)
        {
            tab1.SelectedTab = tabAMachine;
        }


        #endregion

    }
}
