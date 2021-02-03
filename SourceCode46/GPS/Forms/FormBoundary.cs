using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace AgOpenGPS
{
    public partial class FormBoundary : Form
    {
        private readonly FormGPS mf = null;

        private bool Selectedreset = true;

        private double easting, norting, latK, lonK;

        public FormBoundary(Form callingForm)
        {
            mf = callingForm as FormGPS;

            //winform initialization
            InitializeComponent();

            nudBndOffset.Controls[0].Enabled = false;

            this.Text = gStr.gsStartDeleteABoundary;

            //Column Header
            Boundary.Text = gStr.gsBounds;
            Thru.Text = gStr.gsDriveThru;
            Area.Text = gStr.gsArea;

            //btnGo.Text = gStr.gsGo;
            lblOffset.Text = gStr.gsOffset;

            btnDelete.Enabled = false;

        }


        private void FormBoundary_Load(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(610,426);

            btnLeftRight.Image = mf.bnd.isDrawRightSide ? Properties.Resources.BoundaryRight : Properties.Resources.BoundaryLeft;

            //update the list view with real data
            UpdateChart();
            nudBndOffset.Value = (decimal)(mf.tool.toolWidth * 0.5);

            panelMain.Top = 10;
            panelMain.Left = 10;
            panelChoose.Top = 10;
            panelChoose.Left = 10;
            panelDrv.Top = 10;
            panelDrv.Left = 10;
            panelKML.Top = 10;
            panelKML.Left = 10;

            panelMain.Visible = true;
            panelChoose.Visible = false;
            panelDrv.Visible = false;
            panelKML.Visible = false;
        }
        private void UpdateChart()
        {
            int inner = 1;

            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.RowStyles.Clear();

            Font backupfont = new Font(Font.FontFamily, 18F, FontStyle.Bold);

            for (int i = 0; i < mf.bnd.bndArr.Count && i < 4; i++)
            {
                if (mf.bnd.bndArr[i].isSet)
                {
                    //outer inner
                    var a = new Button
                    {
                        Margin = new Padding(6),
                        Size = new Size(150, 40),
                        Name = i.ToString(),
                        TextAlign = ContentAlignment.MiddleCenter,
                        ForeColor = System.Drawing.SystemColors.ButtonFace
                    };
                    a.Click += B_Click;
                    //a.Font = backupfont;
                    //a.FlatStyle = FlatStyle.Flat;
                    //a.FlatAppearance.BorderColor = Color.Cyan;
                    //a.BackColor = Color.Transparent;
                    //a.FlatAppearance.MouseOverBackColor = BackColor;
                    //a.FlatAppearance.MouseDownBackColor = BackColor;


                    //area
                    var b = new Button
                    {
                        Margin = new Padding(6),
                        Size = new System.Drawing.Size(150, 40),
                        Name = i.ToString(),
                        TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                        ForeColor = System.Drawing.SystemColors.ButtonFace
                    };
                    b.Click += B_Click;
                    //b.FlatStyle = FlatStyle.Flat;
                    //b.Font = backupfont;
                    //b.FlatAppearance.BorderColor = BackColor;
                    //b.FlatAppearance.MouseOverBackColor = BackColor;
                    //b.FlatAppearance.MouseDownBackColor = BackColor;

                    //drive thru
                    var d = new Button
                    {
                        Margin = new Padding(6),
                        Size = new System.Drawing.Size(80, 40),
                        Name = i.ToString(),
                        TextAlign = ContentAlignment.MiddleCenter,
                        ForeColor = System.Drawing.SystemColors.ButtonFace
                        //Font = backupfont
                    };
                    d.Click += DriveThru_Click;
                    d.Visible = true;

                    tableLayoutPanel1.Controls.Add(a, 0, i);
                    tableLayoutPanel1.Controls.Add(b, 1, i);
                    tableLayoutPanel1.Controls.Add(d, 2, i);

                    if (i == 0)
                    {
                        //cc.Text = "Outer";
                        mf.bnd.bndArr[i].isDriveThru = false;
                        mf.bnd.bndArr[i].isDriveAround = false;
                        a.Text = string.Format(gStr.gsOuter);
                        //a.Font = backupfont;
                        d.Text = mf.bnd.bndArr[i].isDriveThru ? "--" : "--";
                        d.Enabled = false;
                        d.Anchor = System.Windows.Forms.AnchorStyles.None;
                        a.Anchor = System.Windows.Forms.AnchorStyles.None;
                        b.Anchor = System.Windows.Forms.AnchorStyles.None;
                        //d.BackColor = Color.Transparent;
                    }
                    else
                    {
                        //cc.Text = "Inner";
                        inner += 1;
                        a.Text = string.Format(gStr.gsInner + " {0}", inner);
                        //a.Font = backupfont;
                        d.Text = mf.bnd.bndArr[i].isDriveThru ? "Yes" : "No";
                        d.Anchor = System.Windows.Forms.AnchorStyles.None;
                        a.Anchor = System.Windows.Forms.AnchorStyles.None;
                        b.Anchor = System.Windows.Forms.AnchorStyles.None;
                        //d.BackColor = Color.Transparent;
                    }

                    if (mf.isMetric)
                    {
                        b.Text = Math.Round(mf.bnd.bndArr[i].area * 0.0001, 2).ToString() + " Ha";
                    }
                    else
                    {
                        b.Text = Math.Round(mf.bnd.bndArr[i].area * 0.000247105, 2) + " Ac";
                    }

                    if (Selectedreset == false && i == mf.bnd.boundarySelected)
                    {
                        a.ForeColor = Color.OrangeRed;
                        b.ForeColor = Color.OrangeRed;
                    }
                    else
                    {
                        a.ForeColor = System.Drawing.SystemColors.ButtonFace;
                        b.ForeColor = System.Drawing.SystemColors.ButtonFace;
                    }
                }
            }
        }

        void DriveThru_Click(object sender, EventArgs e)
        {
            if (sender is Button b)
            {
                mf.bnd.bndArr[Convert.ToInt32(b.Name)].isDriveThru = !mf.bnd.bndArr[Convert.ToInt32(b.Name)].isDriveThru;
                UpdateChart();
                mf.turn.BuildTurnLines();
            }
        }

        void DriveAround_Click(object sender, EventArgs e)
        {
            if (sender is Button b)
            {
                mf.bnd.bndArr[Convert.ToInt32(b.Name)].isDriveAround = !mf.bnd.bndArr[Convert.ToInt32(b.Name)].isDriveAround;
                UpdateChart();
            }
        }

        void B_Click(object sender, EventArgs e)
        {
            if (sender is Button b)
            {

                mf.bnd.boundarySelected = Convert.ToInt32(b.Name);

                if (mf.bnd.boundarySelected == 0 && mf.bnd.bndArr.Count > 1)
                {
                    return;
                }

                Selectedreset = false;

                if (mf.bnd.bndArr.Count > mf.bnd.boundarySelected && mf.bnd.bndArr[mf.bnd.boundarySelected].isSet)
                {
                    btnDelete.Enabled = true;
                }
                else
                {
                    btnDelete.Enabled = false;
                    btnDeleteAll.Enabled = false;
                }

            }
            UpdateChart();
        }

        private void btnSerialCancel_Click(object sender, EventArgs e)
        {
            mf.bnd.isOkToAddPoints = false;
        }

        private void btnLeftRight_Click(object sender, EventArgs e)
        {
            mf.bnd.isDrawRightSide = !mf.bnd.isDrawRightSide;
            btnLeftRight.Image = mf.bnd.isDrawRightSide ? Properties.Resources.BoundaryRight : Properties.Resources.BoundaryLeft;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result3 = MessageBox.Show(gStr.gsCompletelyDeleteBoundary,
                gStr.gsDeleteForSure,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            if (result3 == DialogResult.Yes)
            {

                btnDelete.Enabled = false;

                if (mf.bnd.bndArr.Count > mf.bnd.boundarySelected)
                {
                    mf.bnd.bndArr.RemoveAt(mf.bnd.boundarySelected);
                }

                mf.FileSaveBoundary();

                mf.bnd.boundarySelected = -1;
                Selectedreset = true;
                mf.fd.UpdateFieldBoundaryGUIAreas();
                mf.turn.BuildTurnLines();
                UpdateChart();
            }
            else
            {
                mf.TimedMessageBox(1500, gStr.gsNothingDeleted, gStr.gsActionHasBeenCancelled);
            }
        }

        private void ResetAllBoundary()
        {
            mf.bnd.bndArr.Clear();

            mf.FileSaveBoundary();
            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.RowStyles.Clear();

            UpdateChart();
            mf.turn.BuildTurnLines();

            btnDelete.Enabled = false;
        }

        private void btnOpenGoogleEarth_Click(object sender, EventArgs e)
        {
            //save new copy of kml with selected flag and view in GoogleEarth
          
            mf.FileMakeKMLFromCurrentPosition(mf.pn.latitude, mf.pn.longitude);
            System.Diagnostics.Process.Start(mf.fieldsDirectory + mf.currentFieldDirectory + "\\CurrentPosition.KML");
            Close();

        }

        private void nudBndOffset_Enter(object sender, EventArgs e)
        {
            mf.KeypadToNUD((NumericUpDown)sender);
            btnCancelDrive.Focus();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            mf.bnd.createBndOffset = (double)nudBndOffset.Value;
            mf.bnd.isBndBeingMade = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            DialogResult result3 = MessageBox.Show(gStr.gsCompletelyDeleteBoundary,
                gStr.gsDeleteForSure,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            if (result3 == DialogResult.Yes)
            {

                ResetAllBoundary();

                mf.bnd.boundarySelected = -1;
                Selectedreset = true;

                mf.bnd.isOkToAddPoints = false;
                mf.fd.UpdateFieldBoundaryGUIAreas();
            }
            else
            {
                mf.TimedMessageBox(1500, gStr.gsNothingDeleted, gStr.gsActionHasBeenCancelled);
            }

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            mf.bnd.isOkToAddPoints = false;

            panelMain.Visible = true;
            panelChoose.Visible = false;
            panelDrv.Visible = false;
            panelKML.Visible = false;

            this.Size = new System.Drawing.Size(610, 426);

            UpdateChart();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            mf.bnd.boundarySelected = mf.bnd.bndArr.Count;

            Selectedreset = false;

            panelMain.Visible = false;
            panelChoose.Visible = true;
            panelDrv.Visible = false;
            panelKML.Visible = false;

            this.Size = new System.Drawing.Size(270, 426);
        }

        private void btnLoadBoundaryFromGE_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                Selectedreset = true;

                string fileAndDirectory;
                {
                    //create the dialog instance
                    OpenFileDialog ofd = new OpenFileDialog
                    {
                        //set the filter to text KML only
                        Filter = "KML files (*.KML)|*.KML",

                        //the initial directory, fields, for the open dialog
                        InitialDirectory = mf.fieldsDirectory + mf.currentFieldDirectory
                    };

                    //was a file selected
                    if (ofd.ShowDialog() == DialogResult.Cancel) return;
                    else fileAndDirectory = ofd.FileName;
                }

                string coordinates = null;
                int startIndex;
                int i = 0;

                using (System.IO.StreamReader reader = new System.IO.StreamReader(fileAndDirectory))
                {

                    if (button.Name == "btnLoadMultiBoundaryFromGE") ResetAllBoundary();
                    else i = mf.bnd.boundarySelected;

                    try
                    {
                        while (!reader.EndOfStream)
                        {
                            //start to read the file
                            string line = reader.ReadLine();

                            startIndex = line.IndexOf("<coordinates>");

                            if (startIndex != -1)
                            {
                                while (true)
                                {
                                    int endIndex = line.IndexOf("</coordinates>");

                                    if (endIndex == -1)
                                    {
                                        //just add the line
                                        if (startIndex == -1) coordinates += line.Substring(0);
                                        else coordinates += line.Substring(startIndex + 13);
                                    }
                                    else
                                    {
                                        if (startIndex == -1) coordinates += line.Substring(0, endIndex);
                                        else coordinates += line.Substring(startIndex + 13, endIndex - (startIndex + 13));
                                        break;
                                    }
                                    line = reader.ReadLine();
                                    line = line.Trim();
                                    startIndex = -1;
                                }

                                line = coordinates;
                                char[] delimiterChars = { ' ', '\t', '\r', '\n' };
                                string[] numberSets = line.Split(delimiterChars);

                                //at least 3 points
                                if (numberSets.Length > 2)
                                {
                                    mf.bnd.bndArr.Add(new CBoundaryLines());

                                    foreach (var item in numberSets)
                                    {
                                        string[] fix = item.Split(',');
                                        double.TryParse(fix[0], NumberStyles.Float, CultureInfo.InvariantCulture, out lonK);
                                        double.TryParse(fix[1], NumberStyles.Float, CultureInfo.InvariantCulture, out latK);

                                        mf.pn.ConvertWGS84ToLocal(latK, lonK, out norting, out easting);

                                        //add the point to boundary
                                        vec3 bndPt = new vec3(easting, norting, 0);
                                        mf.bnd.bndArr[i].bndLine.Add(bndPt);
                                    }

                                    ////build the boundary, make sure is clockwise for outer counter clockwise for inner
                                    //bool isCW = mf.bnd.bndArr[i].CalculateBoundaryArea();
                                    //if (i == 0 && !isCW)
                                    //{
                                    //    mf.bnd.bndArr[i].ReverseWinding();
                                    //}

                                    ////inner boundaries
                                    //if (i > 0 && isCW)
                                    //{
                                    //    mf.bnd.bndArr[i].ReverseWinding();
                                    //}

                                    //mf.bnd.bndArr[i].FixBoundaryLine(i);
                                    //mf.bnd.bndArr[i].PreCalcBoundaryEarLines();
                                    //mf.bnd.bndArr[i].PreCalcBoundaryLines();
                                    //mf.bnd.bndArr[i].isSet = true;
                                    //mf.fd.UpdateFieldBoundaryGUIAreas();

                                    //fix the points if there are gaps bigger then
                                    mf.bnd.bndArr[i].CalculateBoundaryHeadings();
                                    mf.bnd.bndArr[i].PreCalcBoundaryLines();
                                    mf.bnd.bndArr[i].FixBoundaryLine(i);

                                    //boundary area, pre calcs etc
                                    mf.bnd.bndArr[i].CalculateBoundaryArea();
                                    mf.bnd.bndArr[i].PreCalcBoundaryLines();
                                    mf.bnd.bndArr[i].isSet = true;


                                    coordinates = "";
                                    i++;
                                }
                                else
                                {
                                    mf.TimedMessageBox(2000, gStr.gsErrorreadingKML, gStr.gsChooseBuildDifferentone);
                                }
                                if (button.Name == "btnLoadBoundaryFromGE")
                                {
                                    break;
                                }
                            }
                        }
                        mf.FileSaveBoundary();
                        mf.turn.BuildTurnLines();
                        mf.fd.UpdateFieldBoundaryGUIAreas();
                        UpdateChart();
                    }
                    catch (Exception)
                    {
                        return;
                    }
                }
            }
            mf.bnd.isOkToAddPoints = false;

            panelMain.Visible = true;
            panelChoose.Visible = false;
            panelDrv.Visible = false;
            panelKML.Visible = false;

            this.Size = new System.Drawing.Size(610, 426);

            UpdateChart();

        }

        private void btnDriveOrExt_Click(object sender, EventArgs e)
        {
            panelMain.Visible = false;
            panelChoose.Visible = false;
            panelDrv.Visible = true;
            panelKML.Visible = false;

            lblWidth.Text = mf.tool.toolWidth.ToString();
            btnGo.Focus();
        }

        private void btnGetKML_Click(object sender, EventArgs e)
        {
            panelMain.Visible = false;
            panelChoose.Visible = false;
            panelDrv.Visible = false;
            panelKML.Visible = true;
        }
    }
}
