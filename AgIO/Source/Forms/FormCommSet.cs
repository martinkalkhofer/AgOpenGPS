using System;
using System.Linq;
using System.Windows.Forms;

namespace AgIO
{
    public partial class FormCommSet : Form
    {
        //class variables
        private readonly FormLoop mf = null;

        //constructor
        public FormCommSet(Form callingForm)
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
            if (mf.spModule1.IsOpen)
            {
                cboxModule1Port.Enabled = false;
                btnCloseSerialModule1.Enabled = true;
                btnOpenSerialModule1.Enabled = false;
            }
            else
            {
                cboxModule1Port.Enabled = true;
                btnCloseSerialModule1.Enabled = false;
                btnOpenSerialModule1.Enabled = true;
            }

            //check if AutoSteer port is open or closed and set buttons accordingly
            if (mf.spModule2.IsOpen)
            {
                cboxModule2Port.Enabled = false;
                btnCloseSerialModule2.Enabled = true;
                btnOpenSerialModule2.Enabled = false;
            }
            else
            {
                cboxModule2Port.Enabled = true;
                btnCloseSerialModule2.Enabled = false;
                btnOpenSerialModule2.Enabled = true;
            }

            if (mf.spModule3.IsOpen)
            {
                cboxModule3Port.Enabled = false;
                btnCloseSerialModule3.Enabled = true;
                btnOpenSerialModule3.Enabled = false;
            }
            else
            {
                cboxModule3Port.Enabled = true;
                btnCloseSerialModule3.Enabled = false;
                btnOpenSerialModule3.Enabled = true;
            }

            //load the port box with valid port names
            cboxModule1Port.Items.Clear();
            cboxModule2Port.Items.Clear();
            cboxModule3Port.Items.Clear();
            foreach (string s in System.IO.Ports.SerialPort.GetPortNames())
            {
                cboxModule1Port.Items.Add(s);
                cboxModule2Port.Items.Add(s);
                cboxModule3Port.Items.Add(s);
            }

            lblCurrentModule1Port.Text = mf.spModule1.PortName;
            lblCurrentModule2Port.Text = mf.spModule2.PortName;
            lblCurrentModule3Port.Text = mf.spModule3.PortName;
        }

        #region PortSettings 1 //---------------------------------------------------

        private void btnOpenSerialModule1_Click(object sender, EventArgs e)
        {
            mf.OpenModule1Port();
            if (mf.spModule1.IsOpen)
            {
                cboxModule1Port.Enabled = false;
                btnCloseSerialModule1.Enabled = true;
                btnOpenSerialModule1.Enabled = false;
                lblCurrentModule1Port.Text = mf.spModule1.PortName;
            }
            else
            {
                cboxModule1Port.Enabled = true;
                btnCloseSerialModule1.Enabled = false;
                btnOpenSerialModule1.Enabled = true;
            }
        }

        private void btnCloseSerialModule1_Click(object sender, EventArgs e)
        {
            mf.CloseModule1Port();
            if (mf.spModule1.IsOpen)
            {
                cboxModule1Port.Enabled = false;
                btnCloseSerialModule1.Enabled = true;
                btnOpenSerialModule1.Enabled = false;
            }
            else
            {
                cboxModule1Port.Enabled = true;
                btnCloseSerialModule1.Enabled = false;
                btnOpenSerialModule1.Enabled = true;
            }
        }

        private void cboxModule1_SelectedIndexChanged(object sender, EventArgs e)
        {
            mf.spModule1.PortName = cboxModule1Port.Text;
            FormLoop.portNameModule1 = cboxModule1Port.Text;
            lblCurrentModule1Port.Text = cboxModule1Port.Text;
        }

        #endregion ----------------------------------------------------------------

        #region PortSettings 2 //----------------------------------------------------------------
        private void cboxModule2Port_SelectedIndexChanged(object sender, EventArgs e)
        {
            mf.spModule2.PortName = cboxModule2Port.Text;
            FormLoop.portNameModule2 = cboxModule2Port.Text;
            lblCurrentModule2Port.Text = cboxModule2Port.Text;
        }

        private void btnOpenSerialModule2_Click(object sender, EventArgs e)
        {
            mf.OpenModule2Port();
            if (mf.spModule2.IsOpen)
            {
                cboxModule2Port.Enabled = false;
                btnCloseSerialModule2.Enabled = true;
                btnOpenSerialModule2.Enabled = false;
                lblCurrentModule2Port.Text = mf.spModule2.PortName;
            }
            else
            {
                cboxModule2Port.Enabled = true;
                btnCloseSerialModule2.Enabled = false;
                btnOpenSerialModule2.Enabled = true;
            }

        }

        private void btnCloseSerialModule2_Click(object sender, EventArgs e)
        {
            mf.CloseModule2Port();
            if (mf.spModule2.IsOpen)
            {
                cboxModule2Port.Enabled = false;
                btnCloseSerialModule2.Enabled = true;
                btnOpenSerialModule2.Enabled = false;
            }
            else
            {
                cboxModule2Port.Enabled = true;
                btnCloseSerialModule2.Enabled = false;
                btnOpenSerialModule2.Enabled = true;
            }
        }
        #endregion ----------------------------------------------------------------

        #region PortSettings 3 //----------------------------------------------------
        private void cboxModule3Port_SelectedIndexChanged(object sender, EventArgs e)
        {
            mf.spModule3.PortName = cboxModule3Port.Text;
            FormLoop.portNameModule3 = cboxModule3Port.Text;
            lblCurrentModule3Port.Text = cboxModule3Port.Text;
        }

        private void btnOpenSerialModule3_Click(object sender, EventArgs e)
        {
            mf.OpenModule3Port();
            if (mf.spModule3.IsOpen)
            {
                cboxModule3Port.Enabled = false;
                btnCloseSerialModule3.Enabled = true;
                btnOpenSerialModule3.Enabled = false;
                lblCurrentModule3Port.Text = mf.spModule3.PortName;
            }
            else
            {
                cboxModule3Port.Enabled = true;
                btnCloseSerialModule3.Enabled = false;
                btnOpenSerialModule3.Enabled = true;
            }
        }

        private void btnCloseSerialModule3_Click(object sender, EventArgs e)
        {
            mf.CloseModule3Port();
            if (mf.spModule3.IsOpen)
            {
                cboxModule3Port.Enabled = false;
                btnCloseSerialModule3.Enabled = true;
                btnOpenSerialModule3.Enabled = false;
            }
            else
            {
                cboxModule3Port.Enabled = true;
                btnCloseSerialModule3.Enabled = false;
                btnOpenSerialModule3.Enabled = true;
            }
        }
        #endregion ----------------------------------------------------------------

        private void btnRescan_Click(object sender, EventArgs e)
        {
            cboxModule3Port.Items.Clear();
            foreach (string s in System.IO.Ports.SerialPort.GetPortNames()) { cboxModule3Port.Items.Add(s); }

            cboxModule1Port.Items.Clear();
            foreach (string s in System.IO.Ports.SerialPort.GetPortNames()) { cboxModule1Port.Items.Add(s); }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            //GPS phrase
            txtBoxRecvModule3.Text = mf.recvModule3Sentence;
            txtBoxRecvModule1.Text = mf.recvModule1Sentence;
        }

        private void btnSerialOK_Click(object sender, EventArgs e)
        {
            //save
            //DialogResult = DialogResult.OK;
            Close();
        }
    } //class
} //namespace