using AgIO.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgIO
{
    public partial class FormLoop : Form
    {
        public FormLoop()
        {
            InitializeComponent();

            // Add Message Event handler for Form decoupling from client socket thread
            updateRTCM_DataEvent = new UpdateRTCM_Data(OnAddMessage);
        }

        public bool isKeyboardOn = true;

        public double defaultLat = 0, defaultLon = 0;
        public double currentLat = 0, currentLon = 0;

        public double secondsSinceStart, lastSecond;

        //The base directory where Drive will be stored and fields and vehicles branch from
        public string baseDirectory;

        //current directory of Comm storage
        public string commDirectory, commFileName = "";

        private void btnDeviceManager_Click(object sender, EventArgs e)
        {            
            Process.Start("devmgmt.msc");            
        }

        private void btnRescanPorts_Click(object sender, EventArgs e)
        {
            string[] ports = System.IO.Ports.SerialPort.GetPortNames();
            lblPortList.Text= string.Join(", ", ports);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            secondsSinceStart = (DateTime.Now - Process.GetCurrentProcess().StartTime).TotalSeconds;

            pbarCPU.Value = (int)pcCPU.NextValue();
            pbarRAM.Value = (int)pcRAM.NextValue();

            lblCPU.Text = pbarCPU.Value.ToString();
            lblRAM.Text = pbarRAM.Value.ToString();

            traffic.enableCounter++;

            DoTraffic();

            lblCurentLon.Text = currentLon.ToString("N7");
            lblCurrentLat.Text = currentLat.ToString("N7");

            //do all the NTRIP routines
            DoNTRIPSecondRoutine();

            //send back to Drive proof of life
            //every 3 seconds
            if ((secondsSinceStart - lastSecond) > 2)
            {
                lastSecond = secondsSinceStart;

                //Proof of life to Drive
                traffic.AgIOStatus[5] = (byte)(secondsSinceStart);
                SendToLoopBackMessage(traffic.AgIOStatus);

                if (wasIMUConnectedLastRun)
                {
                    if (!spIMU.IsOpen)
                    {
                        byte[] imuClose = new byte[] { 0x80, 0x81, 0x7C, 0xD4, 2, 1, 0, 0xCC };

                        //tell AOG IMU is disconnected
                        SendToLoopBackMessage(imuClose);
                        wasIMUConnectedLastRun = false;
                        lblIMUComm.Text = "---";
                    }
                }

                if (wasGPSConnectedLastRun)
                {
                    if (!spGPS.IsOpen)
                    {
                        wasGPSConnectedLastRun = false;
                        lblGPS1Comm.Text = "---";
                    }
                }

                if (wasModule1ConnectedLastRun)
                {
                    if (!spModule1.IsOpen)
                    {
                        wasModule1ConnectedLastRun = false;
                        lblMod1Comm.Text = "---";
                    }
                }

                if (wasModule2ConnectedLastRun)
                {
                    if (!spModule2.IsOpen)
                    {
                        wasModule2ConnectedLastRun = false;
                        lblMod2Comm.Text = "---";
                    }
                }

                if (wasModule3ConnectedLastRun)
                {
                    if (!spModule3.IsOpen)
                    {
                        wasModule3ConnectedLastRun = false;
                        lblMod3Comm.Text = "---";
                    }
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (spGPS.IsOpen)
            {
                //if (spGPS.BytesToRead < 10) return;
                try
                {
                    string sentence = spGPS.ReadExisting();

                    if (sentence.Length > 0 && sentence.Length < 200)
                    {
                        SendToLoopBackMessage(sentence);
                        traffic.cntrGPSIn += sentence.Length;
                        if (isGPSCommOpen) recvGPSSentence = sentence;
                    }
                }
                catch (Exception)
                {
                }
            }


            if (serList.Count > 0 && isOKtoSendSerial)
            {
                if (serList.Count > 60)
                {
                    serList.Clear();
                    return;
                }
                byte[] data = new byte[serList.Count];
                serList.CopyTo(data);
                serList.Clear();
                if (spModule1.IsOpen) SendModule1Port(data, data.Length);
                if (spModule2.IsOpen) SendModule2Port(data, data.Length);
                if (spModule3.IsOpen) SendModule3Port(data, data.Length);
            }
        }

        //First run
        private void FormLoop_Load(object sender, EventArgs e)
        {

            LoadSettings();

            timer1.Enabled = true;

            string[] ports = System.IO.Ports.SerialPort.GetPortNames();
            lblPortList.Text = string.Join(", ", ports);

        }

        private void FormLoop_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (recvFromLoopBackSocket != null)
            {
                try
                {
                    recvFromLoopBackSocket.Shutdown(SocketShutdown.Both);
                }
                finally { recvFromLoopBackSocket.Close(); }
            }


            if (sendToLoopBackSocket != null)
            {
                try
                {
                    sendToLoopBackSocket.Shutdown(SocketShutdown.Both);
                }
                finally { sendToLoopBackSocket.Close(); }
            }

            if (sendSocket != null)
            {
                try
                {
                    sendSocket.Shutdown(SocketShutdown.Both);
                }
                finally { sendSocket.Close(); }
            }

            if (recvSocket != null)
            {
                try
                {
                    recvSocket.Shutdown(SocketShutdown.Both);
                }
                finally { recvSocket.Close(); }
            }
        }

        public void LoadSettings()
        {
            if (Settings.Default.setF_workingDirectory == "Default")
                baseDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\AgOpenGPS\\";
            else baseDirectory = Settings.Default.setF_workingDirectory + "\\AgOpenGPS\\";

            //get the fields directory, if not exist, create
            commDirectory = baseDirectory + "Comm\\";
            string dir = Path.GetDirectoryName(commDirectory);
            if (!string.IsNullOrEmpty(dir) && !Directory.Exists(dir)) { Directory.CreateDirectory(dir); }

            if (Properties.Settings.Default.setUDP_isOn) LoadUDPNetwork();
            LoadLoopback();

            //set baud and port from last time run
            baudRateGPS = Settings.Default.setPort_baudRateGPS;
            portNameGPS = Settings.Default.setPort_portNameGPS;
            wasGPSConnectedLastRun = Settings.Default.setPort_wasGPSConnected;
            if (wasGPSConnectedLastRun) OpenGPSPort();

            //try and open
            OpenGPSPort();

            //same for IMU port
            portNameIMU = Settings.Default.setPort_portNameIMU;
            wasIMUConnectedLastRun = Settings.Default.setPort_wasIMUConnected;
            if (wasIMUConnectedLastRun) OpenIMUPort();

            //same for Module1 port
            portNameModule1 = Settings.Default.setPort_portNameModule1;
            wasModule1ConnectedLastRun = Settings.Default.setPort_wasModule1Connected;
            if (wasModule1ConnectedLastRun) OpenModule1Port();

            //same for Module2 port
            portNameModule2 = Settings.Default.setPort_portNameModule2;
            wasModule3ConnectedLastRun = Settings.Default.setPort_wasModule2Connected;
            if (wasModule3ConnectedLastRun) OpenModule2Port();

            //same for Module3 port
            portNameModule3 = Settings.Default.setPort_portNameModule3;
            wasModule3ConnectedLastRun = Settings.Default.setPort_wasModule3Connected;
            if (wasModule3ConnectedLastRun) OpenModule3Port();

            this.lblWatch.Text = "Wait GPS";

            //start NTRIP if required
            isNTRIP_RequiredOn = Properties.Settings.Default.setNTRIP_isOn;

            if (isNTRIP_RequiredOn)
            {
                btnStartStopNtrip.Visible = true;
                btnStartStopNtrip.Visible = true;
                lblWatch.Visible = true;
                lblNTRIPBytes.Visible = true;
                lblBytes.Visible = true;
            }
            else
            {
                btnStartStopNtrip.Visible = false;
                btnStartStopNtrip.Visible = false;
                lblWatch.Visible = false;
                lblNTRIPBytes.Visible = false;
                lblBytes.Visible = false;
            }
            btnStartStopNtrip.Text = "Off";
        }

        private void DoTraffic()
        {
            if (traffic.isTrafficOn && traffic.enableCounter < 10001)
            {
                if ((traffic.enableCounter & 1) != 0)
                {

                    lblToAOG.Text = lblFromAOG.Text = lblFromUDP.Text = lblToUDP.Text =
                        lblFromGPS.Text = lblToGPS.Text =
                        lblFromMU.Text = lblToIMU.Text =
                        lblFromSteer.Text = lblToSteer.Text =
                        lblFromModule1.Text = lblToModule1.Text =
                        lblFromModule2.Text = lblToModule2.Text = "-";

                    traffic.cntrPGNToAOG = traffic.cntrPGNFromAOG = traffic.cntrUDPIn = traffic.cntrUDPOut =
                        traffic.cntrGPSIn = traffic.cntrGPSOut = traffic.cntrGPS2In = traffic.cntrGPS2Out =
                         traffic.cntrIMUIn = traffic.cntrIMUOut =
                       traffic.cntrModule3In = traffic.cntrModule3Out =
                        traffic.cntrModule1In = traffic.cntrModule1Out =
                        traffic.cntrModule2Out = traffic.cntrModule2In = 0;
                }

                else
                {
                    lblToAOG.Text = (traffic.cntrPGNToAOG).ToString();
                    lblFromAOG.Text = (traffic.cntrPGNFromAOG).ToString();

                    lblFromUDP.Text = (traffic.cntrUDPIn).ToString();
                    lblToUDP.Text = (traffic.cntrUDPOut).ToString();

                    lblFromGPS.Text = (traffic.cntrGPSIn).ToString();
                    lblToGPS.Text = (traffic.cntrGPSOut).ToString();

                    lblFromSteer.Text = (traffic.cntrModule3In).ToString();
                    lblToSteer.Text = (traffic.cntrModule3Out).ToString();

                    lblFromModule1.Text = (traffic.cntrModule1In).ToString();
                    lblToModule1.Text = (traffic.cntrModule1Out).ToString();

                    lblFromModule2.Text = (traffic.cntrModule2In).ToString();
                    lblToModule2.Text = (traffic.cntrModule2Out).ToString();

                    lblFromMU.Text = (traffic.cntrIMUIn).ToString();
                    lblToIMU.Text = (traffic.cntrIMUOut).ToString();

                    traffic.cntrPGNToAOG = traffic.cntrPGNFromAOG = traffic.cntrUDPIn = traffic.cntrUDPOut =
                        traffic.cntrGPSIn = traffic.cntrGPSOut = traffic.cntrGPS2In = traffic.cntrGPS2Out =
                        traffic.cntrIMUIn = traffic.cntrIMUOut =
                        traffic.cntrModule3In = traffic.cntrModule3Out =
                        traffic.cntrModule1In = traffic.cntrModule1Out =
                        traffic.cntrModule2Out = traffic.cntrModule2In = 0;
                }

                lblCurentLon.Text = currentLon.ToString("N7");
                lblCurrentLat.Text = currentLat.ToString("N7");

                if (traffic.enableCounter == 10000)
                {
                    cboxIsTrafficOn.Checked = false;
                }
            }

        }



    }
}

