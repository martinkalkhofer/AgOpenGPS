using System;
using System.Linq;
using System.Windows.Forms;

namespace AgIO
{
    public partial class FormCommSetIMU : Form
    {
        //class variables
        private readonly FormLoop mf = null;

        //constructor
        public FormCommSetIMU(Form callingForm)
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
            //check if Arduino port is open or closed and set buttons accordingly
            if (mf.spIMU.IsOpen)
            {
                cboxIMU.Enabled = false;
                btnCloseIMU.Enabled = true;
                btnOpenIMU.Enabled = false;
            }
            else
            {
                cboxIMU.Enabled = true;
                btnCloseIMU.Enabled = false;
                btnOpenIMU.Enabled = true;
            }


            //load the port box with valid port names
            cboxIMU.Items.Clear();
            foreach (string s in System.IO.Ports.SerialPort.GetPortNames())
            {
                cboxIMU.Items.Add(s);
            }

            lblCurrentIMU.Text = mf.spIMU.PortName;
        }

        #region PortSettings 1 //---------------------------------------------------

        private void btnOpenIMU_Click(object sender, EventArgs e)
        {
            mf.OpenIMUPort();
            if (mf.spIMU.IsOpen)
            {
                cboxIMU.Enabled = false;
                btnCloseIMU.Enabled = true;
                btnOpenIMU.Enabled = false;
                lblCurrentIMU.Text = mf.spIMU.PortName;
            }
            else
            {
                cboxIMU.Enabled = true;
                btnCloseIMU.Enabled = false;
                btnOpenIMU.Enabled = true;
            }
        }

        private void btnCloseIMU_Click(object sender, EventArgs e)
        {
            mf.CloseIMUPort();
            if (mf.spIMU.IsOpen)
            {
                cboxIMU.Enabled = false;
                btnCloseIMU.Enabled = true;
                btnOpenIMU.Enabled = false;
            }
            else
            {
                cboxIMU.Enabled = true;
                btnCloseIMU.Enabled = false;
                btnOpenIMU.Enabled = true;
            }
        }

        private void cboxIMU_SelectedIndexChanged(object sender, EventArgs e)
        {
            mf.spIMU.PortName = cboxIMU.Text;
            FormLoop.portNameIMU = cboxIMU.Text;
            lblCurrentIMU.Text = cboxIMU.Text;
        }

        #endregion ----------------------------------------------------------------


        private void btnRescan_Click(object sender, EventArgs e)
        {
            cboxIMU.Items.Clear();
            foreach (string s in System.IO.Ports.SerialPort.GetPortNames()) { cboxIMU.Items.Add(s); }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            //GPS phrase
            tboxReceiveIMU.Text = mf.recvIMUSentence;
        }

        private void btnSerialOK_Click(object sender, EventArgs e)
        {
            //save
            //DialogResult = DialogResult.OK;
            Close();
        }
    } //class
} //namespace