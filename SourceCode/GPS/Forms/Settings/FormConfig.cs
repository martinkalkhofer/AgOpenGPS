//Please, if you use this, share the improvements

using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace AgOpenGPS
{
    public partial class FormConfig : Form
    {
        //class variables
        private readonly FormGPS mf = null;

        //constructor
        public FormConfig(Form callingForm, int page)
        {
            //get copy of the calling main form
            mf = callingForm as FormGPS;
            InitializeComponent();

            tab1.Appearance = TabAppearance.FlatButtons;
            tab1.ItemSize = new Size(0, 1);
            tab1.SizeMode = TabSizeMode.Fixed;

            HideSubMenu();

            nudTrailingHitchLength.Controls[0].Enabled = false;
            nudDrawbarLength.Controls[0].Enabled = false;
            nudTankHitch.Controls[0].Enabled = false;


            nudLookAhead.Controls[0].Enabled = false;
            nudLookAheadOff.Controls[0].Enabled = false;
            nudTurnOffDelay.Controls[0].Enabled = false;
            nudOffset.Controls[0].Enabled = false;
            nudOverlap.Controls[0].Enabled = false;
            nudCutoffSpeed.Controls[0].Enabled = false;


            nudMinTurnRadius.Controls[0].Enabled = false;
            nudAntennaHeight.Controls[0].Enabled = false;
            nudAntennaOffset.Controls[0].Enabled = false;
            nudAntennaPivot.Controls[0].Enabled = false;
            nudLightbarCmPerPixel.Controls[0].Enabled = false;
            nudMinTurnRadius.Controls[0].Enabled = false;
            nudSnapDistance.Controls[0].Enabled = false;
            nudWheelbase.Controls[0].Enabled = false;
            nudLineWidth.Controls[0].Enabled = false;

            nudMinApplied.Controls[0].Enabled = false;
            nudDefaultSectionWidth.Controls[0].Enabled = false;

            nudSection1.Controls[0].Enabled = false;
            nudSection2.Controls[0].Enabled = false;
            nudSection3.Controls[0].Enabled = false;
            nudSection4.Controls[0].Enabled = false;
            nudSection5.Controls[0].Enabled = false;
            nudSection6.Controls[0].Enabled = false;
            nudSection7.Controls[0].Enabled = false;
            nudSection8.Controls[0].Enabled = false;
            nudSection9.Controls[0].Enabled = false;
            nudSection10.Controls[0].Enabled = false;
            nudSection11.Controls[0].Enabled = false;
            nudSection12.Controls[0].Enabled = false;
            nudSection13.Controls[0].Enabled = false;
            nudSection14.Controls[0].Enabled = false;
            nudSection15.Controls[0].Enabled = false;
            nudSection16.Controls[0].Enabled = false;

            nudMinFixStepDistance.Controls[0].Enabled = false;
            nudStartSpeed.Controls[0].Enabled = false;

            //nudHydLiftSecs.Controls[0].Enabled = false;
        }

        private void FormConfig_Load(object sender, EventArgs e)
        {

            if (mf.isMetric)
            {
                lblInchesCm.Text = gStr.gsCentimeters;
                lblSecTotalWidthFeet.Visible = false;
                lblSecTotalWidthInches.Visible = false;
                lblSecTotalWidthMeters.Visible = true;
                lblDoNotExceed.Text = "* < 5000 cm*";
                maxWidth = 5000;
            }
            else
            {
                lblInchesCm.Text = gStr.gsInches;
                lblSecTotalWidthFeet.Visible = true;
                lblSecTotalWidthInches.Visible = true;
                lblSecTotalWidthMeters.Visible = false;
                lblDoNotExceed.Text = "* < 1968 inches *";
                maxWidth = 1968;
            }

            //update the first child form summary data items
            UpdateSummary();

            //metric or imp on spinners min/maxes
            FixMinMaxSpinners();

            //the pick a saved vehicle box
            UpdateVehicleListView();

            //the tool size in bottom panel
            if (mf.isMetric)
            {
                lblSecTotalWidthMeters.Text = (mf.tool.toolWidth * 100) + " cm";
            }
            else
            {
                double toFeet = mf.tool.toolWidth * 0.08334;
                lblSecTotalWidthFeet.Text = Convert.ToString((int)toFeet) + "'";
                double temp = Math.Round((toFeet - Math.Truncate(toFeet)) * 12, 0);
                lblSecTotalWidthInches.Text = Convert.ToString(temp) + '"';
            }

        }

        private void FormConfig_FormClosing(object sender, FormClosingEventArgs e)
        {
            //reload all the settings from default and user.config
            mf.LoadSettings();
        }

        private void FixMinMaxSpinners()
        {
            if (!mf.isMetric)
            {
                nudTankHitch.Maximum /= 2.54M;
                nudTankHitch.Minimum /= 2.54M;

                nudDrawbarLength.Maximum /= 2.54M;
                nudDrawbarLength.Minimum /= 2.54M;

                nudTrailingHitchLength.Maximum /= 2.54M;
                nudTrailingHitchLength.Minimum /= 2.54M;

                nudSnapDistance.Maximum /= 2.54M;
                nudSnapDistance.Minimum /= 2.54M;

                nudLightbarCmPerPixel.Maximum /= 2.54M;
                nudLightbarCmPerPixel.Minimum /= 2.54M;

                //.Maximum /= 2.54M;
                //.Minimum /= 2.54M;

                //.Maximum /= 2.54M;
                //.Minimum /= 2.54M;

                nudOverlap.Maximum /= 2.54M;
                nudOverlap.Minimum /= 2.54M;

                nudOffset.Maximum /= 2.54M;
                nudOffset.Minimum /= 2.54M;

                nudCutoffSpeed.Maximum /= 1.60934M;
                nudCutoffSpeed.Minimum /= 1.60934M;

                nudDefaultSectionWidth.Maximum /= 2.54M;
                nudDefaultSectionWidth.Minimum /= 2.54M;

                nudSection1.Maximum /= 2.54M;
                nudSection1.Minimum /= 2.54M;
                nudSection2.Maximum /= 2.54M;
                nudSection2.Minimum /= 2.54M;
                nudSection3.Maximum /= 2.54M;
                nudSection3.Minimum /= 2.54M;
                nudSection4.Maximum /= 2.54M;
                nudSection4.Minimum /= 2.54M;
                nudSection5.Maximum /= 2.54M;
                nudSection5.Minimum /= 2.54M;
                nudSection6.Maximum /= 2.54M;
                nudSection6.Minimum /= 2.54M;
                nudSection7.Maximum /= 2.54M;
                nudSection7.Minimum /= 2.54M;
                nudSection8.Maximum /= 2.54M;
                nudSection8.Minimum /= 2.54M;
                nudSection9.Maximum /= 2.54M;
                nudSection9.Minimum /= 2.54M;
                nudSection10.Maximum /= 2.54M;
                nudSection10.Minimum /= 2.54M;
                nudSection11.Maximum /= 2.54M;
                nudSection11.Minimum /= 2.54M;
                nudSection12.Maximum /= 2.54M;
                nudSection12.Minimum /= 2.54M;
                nudSection13.Maximum /= 2.54M;
                nudSection13.Minimum /= 2.54M;
                nudSection14.Maximum /= 2.54M;
                nudSection14.Minimum /= 2.54M;
                nudSection15.Maximum /= 2.54M;
                nudSection15.Minimum /= 2.54M;
                nudSection16.Maximum /= 2.54M;
                nudSection16.Minimum /= 2.54M;

                nudDefaultSectionWidth.Maximum /= 2.54M;
                nudDefaultSectionWidth.Minimum /= 2.54M;

                lblTurnOffBelowUnits.Text = gStr.gsMPH;
                //cutoffMetricImperial = 1.60934;

            }
            else
            {
                lblTurnOffBelowUnits.Text = gStr.gsKMH;
                //cutoffMetricImperial = 1;
            }

        }
    }
}

