using System;
using System.Linq;
using System.Windows.Forms;

namespace AgIO
{
    public partial class FormCommSetGPS : Form
    {
        //class variables
        private readonly FormLoop mf = null;

        //constructor
        public FormCommSetGPS(Form callingForm)
        {
            //get copy of the calling main form
            mf = callingForm as FormLoop;
            InitializeComponent();
            //btnOpenSerial.Text = gStr.gsConnect;
            //btnOpenSerialArduino.Text = gStr.gsConnect;
            //btnOpenSerialAutoSteer.Text = gStr.gsConnect;
            //btnCloseSerial.Text = gStr.gsDisconnect;
            //btnCloseSerialArduino.Text = gStr.gsDisconnect;
            //btnCloseSerialAutoSteer.Text = gStr.gsDisconnect;
            //btnRescan.Text = gStr.gsRescanPorts;

            //label3.Text = gStr.gsToAutoSteer;
            //label6.Text = gStr.gsFromAutoSteer;
            //label2.Text = gStr.gsToMachinePort;
            //label15.Text = gStr.gsFromMachinePort;

            //groupBox1.Text = gStr.gsGPSPort;
            //groupBox3.Text = gStr.gsAutoSteerPort;
            //groupBox2.Text = gStr.gsMachinePort;

            //lblCurrentArduinoPort.Text = gStr.gsPort;
            //lblCurrentPort.Text = gStr.gsPort;
            //lblCurrentAutoSteerPort.Text = gStr.gsPort;
            //lblCurrentBaud.Text = gStr.gsBaud;

        }

        private void FormCommSet_Load(object sender, EventArgs e)
        {
            //check if GPS port is open or closed and set buttons accordingly
            if (mf.spGPS.IsOpen)
            {
                cboxBaud.Enabled = false;
                cboxPort.Enabled = false;
                btnCloseSerial.Enabled = true;
                btnOpenSerial.Enabled = false;
            }
            else
            {
                cboxBaud.Enabled = true;
                cboxPort.Enabled = true;
                btnCloseSerial.Enabled = false;
                btnOpenSerial.Enabled = true;
            }


            if (mf.spGPS2.IsOpen)
            {
                cboxBaud2.Enabled = false;
                cboxPort2.Enabled = false;
                btnCloseSerial2.Enabled = true;
                btnOpenSerial2.Enabled = false;
            }
            else
            {
                cboxBaud2.Enabled = true;
                cboxPort2.Enabled = true;
                btnCloseSerial2.Enabled = false;
                btnOpenSerial2.Enabled = true;
            }


            //load the port box with valid port names
            cboxPort.Items.Clear();
            cboxPort2.Items.Clear();
            foreach (string s in System.IO.Ports.SerialPort.GetPortNames())
            {
                cboxPort.Items.Add(s);
                cboxPort2.Items.Add(s);
            }

            lblCurrentBaud.Text = mf.spGPS.BaudRate.ToString();
            lblCurrentPort.Text = mf.spGPS.PortName;

            lblCurrentBaud2.Text = mf.spGPS2.BaudRate.ToString();
            lblCurrentPort2.Text = mf.spGPS2.PortName;
        }

        #region PortSettings //----------------------------------------------------------------

        //AutoSteer

        // GPS Serial Port
        private void cboxBaud_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            mf.spGPS.BaudRate = Convert.ToInt32(cboxBaud.Text);
            FormLoop.baudRateGPS = Convert.ToInt32(cboxBaud.Text);
        }
        private void cboxBaud2_SelectedIndexChanged(object sender, EventArgs e)
        {
            mf.spGPS2.BaudRate = Convert.ToInt32(cboxBaud2.Text);
            FormLoop.baudRateGPS2 = Convert.ToInt32(cboxBaud2.Text);
        }


        private void cboxPort_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            mf.spGPS.PortName = cboxPort.Text;
            FormLoop.portNameGPS = cboxPort.Text;
        }

        private void cboxPort2_SelectedIndexChanged(object sender, EventArgs e)
        {
            mf.spGPS2.PortName = cboxPort2.Text;
            FormLoop.portNameGPS2 = cboxPort2.Text;
        }


        private void btnOpenSerial_Click(object sender, EventArgs e)
        {

            mf.OpenGPSPort();
            if (mf.spGPS.IsOpen)
            {
                cboxBaud.Enabled = false;
                cboxPort.Enabled = false;
                btnCloseSerial.Enabled = true;
                btnOpenSerial.Enabled = false;
                lblCurrentBaud.Text = mf.spGPS.BaudRate.ToString();
                lblCurrentPort.Text = mf.spGPS.PortName;
            }
            else
            {
                cboxBaud.Enabled = true;
                cboxPort.Enabled = true;
                btnCloseSerial.Enabled = false;
                btnOpenSerial.Enabled = true;
            }
        }
        private void btnOpenSerial2_Click(object sender, EventArgs e)
        {
            mf.OpenGPS2Port();
            if (mf.spGPS2.IsOpen)
            {
                cboxBaud2.Enabled = false;
                cboxPort2.Enabled = false;
                btnCloseSerial2.Enabled = true;
                btnOpenSerial2.Enabled = false;
                lblCurrentBaud2.Text = mf.spGPS.BaudRate.ToString();
                lblCurrentPort2.Text = mf.spGPS.PortName;
            }
            else
            {
                cboxBaud2.Enabled = true;
                cboxPort2.Enabled = true;
                btnCloseSerial2.Enabled = false;
                btnOpenSerial2.Enabled = true;
            }
        }


        private void btnCloseSerial_Click(object sender, EventArgs e)
        {
            mf.CloseGPSPort();
            if (mf.spGPS.IsOpen)
            {
                cboxBaud.Enabled = false;
                cboxPort.Enabled = false;
                btnCloseSerial.Enabled = true;
                btnOpenSerial.Enabled = false;
            }
            else
            {
                cboxBaud.Enabled = true;
                cboxPort.Enabled = true;
                btnCloseSerial.Enabled = false;
                btnOpenSerial.Enabled = true;
            }
        }
        private void btnCloseSerial2_Click(object sender, EventArgs e)
        {
            mf.CloseGPS2Port();
            if (mf.spGPS2.IsOpen)
            {
                cboxBaud2.Enabled = false;
                cboxPort2.Enabled = false;
                btnCloseSerial2.Enabled = true;
                btnOpenSerial2.Enabled = false;
            }
            else
            {
                cboxBaud2.Enabled = true;
                cboxPort2.Enabled = true;
                btnCloseSerial2.Enabled = false;
                btnOpenSerial2.Enabled = true;
            }
        }

        #endregion PortSettings //----------------------------------------------------------------

        private void timer1_Tick(object sender, EventArgs e)
        {
            //GPS phrase
            textBoxRcv.Text = mf.recvGPSSentence;
            textBoxRcv2.Text = mf.recvGPS2Sentence;

        }

        private void btnSerialOK_Click(object sender, EventArgs e)
        {
            //save
            //DialogResult = DialogResult.OK;
            Close();
        }

        private void btnRescan_Click(object sender, EventArgs e)
        {
            cboxPort.Items.Clear();
            cboxPort2.Items.Clear();
            foreach (string s in System.IO.Ports.SerialPort.GetPortNames())
            {
                cboxPort.Items.Add(s);
                cboxPort2.Items.Add(s);
            }
        }

        private void btnClrGPS_Click(object sender, EventArgs e)
        {
            mf.CloseGPSPort();
            FormLoop.portNameGPS = "GPS 1";
            Properties.Settings.Default.setPort_portNameGPS = FormLoop.portNameGPS;
            Properties.Settings.Default.Save();

        }

    } //class
} //namespace
