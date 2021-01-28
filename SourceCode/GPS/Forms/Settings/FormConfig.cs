//Please, if you use this, share the improvements

using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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
            //nudHydLiftSecs.Controls[0].Enabled = false;
        }

        private void FormConfig_Load(object sender, EventArgs e)
        {
            UpdateSummary();
        }

    }
}
