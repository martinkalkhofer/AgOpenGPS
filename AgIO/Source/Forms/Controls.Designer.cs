using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgIO
{

    public partial class FormLoop
    {
        public void TimedMessageBox(int timeout, string s1, string s2)
        {
            var form = new FormTimedMessage(timeout, s1, s2);
            form.Show();
        }

        private void SettingsCommunications()
        {
            using (var form = new FormCommSet(this))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {

                }
            }
            //SendSteerSettingsOutAutoSteerPort();
            //SendArduinoSettingsOutToAutoSteerPort();
        }

        private void SettingsCommunicationGPS()
        {
            isGPSCommOpen = true;
            using (FormCommSetGPS form = new FormCommSetGPS(this))
            {
                DialogResult result = form.ShowDialog();
                if (result == DialogResult.OK)
                {

                }
            }
            isGPSCommOpen = false;
        }

        private void SettingsCommunicationIMU()
        {
            using (FormCommSetIMU form = new FormCommSetIMU(this))
            {
                DialogResult result = form.ShowDialog();
                if (result == DialogResult.OK)
                {

                }
            }
        }

        private void DoNTRIPSecondRoutine()
        {
            //count up the ntrip clock only if everything is alive
            if ( isNTRIP_RequiredOn)
            {
                IncrementNTRIPWatchDog();
            }

            //Have we connection
            if (isNTRIP_RequiredOn && !isNTRIP_Connected && !isNTRIP_Connecting)
            {
                if (!isNTRIP_Starting && ntripCounter > 20)
                {
                    StartNTRIP();
                }
            }

            if (isNTRIP_Connecting)
            {
                if (ntripCounter > 28)
                {
                    TimedMessageBox(2000, "Connection Problem", "Not Connecting To Caster");
                    ReconnectRequest();
                }
                if (clientSocket != null && clientSocket.Connected)
                {
                    //TimedMessageBox(2000, "NTRIP Not Connected", " At the StartNTRIP() ");
                    //ReconnectRequest();
                    //return;
                    SendAuthorization();
                }

            }

            if (isNTRIP_RequiredOn)
            {
                //update byte counter and up counter
                if (ntripCounter > 59) btnStartStopNtrip.Text = (ntripCounter / 60) + " Mins";
                else if (ntripCounter < 60 && ntripCounter > 22) btnStartStopNtrip.Text = ntripCounter + " Secs";
                else btnStartStopNtrip.Text = "In " + (Math.Abs(ntripCounter - 22)) + " secs";

                //pbarNtripMenu.Value = unchecked((byte)(tripBytes * 0.02));
                lblNTRIPBytes.Text = ((tripBytes) * 0.001).ToString("###,###,###") + " kb";

                //watchdog for Ntrip
                if (isNTRIP_Connecting) lblWatch.Text = gStr.gsAuthourizing;
                else
                {
                    if (NTRIP_Watchdog > 10) lblWatch.Text = gStr.gsWaiting;
                    else lblWatch.Text = gStr.gsListening ;
                }

                if (sendGGAInterval > 0 && isNTRIP_Sending)
                {
                    lblWatch.Text = "Send GGA";
                    isNTRIP_Sending = false;
                }
            }
        }

        private void SettingsNTRIP()
        {
            using (var form = new FormNtrip(this))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    if (isNTRIP_Connected)
                    {
                        SettingsShutDownNTRIP();
                    }
                }
                else
                {
                    //Clicked X - No Save
                }
            }
        }

        private void SettingsUDP()
        {
            using (var form = new FormUDP(this))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    //Clicked Save
                    Application.Restart();
                    Environment.Exit(0);
                }
                else
                {
                    //Clicked X - No Save
                }
            }
        }

        private void StartAOG()
        {

            DirectoryInfo di = new DirectoryInfo(Application.StartupPath);
            string strPath = di.ToString();
            try
            {
                strPath += "\\AgOpenGPS.exe";
                Process.Start(strPath);
            }
            catch
            {
                TimedMessageBox(2000, "No File Found", "Can't Find Drive");
            }

        }

        private void cboxIsTrafficOn_CheckedChanged(object sender, EventArgs e)
        {
            traffic.isTrafficOn = cboxIsTrafficOn.Checked;
            if (traffic.isTrafficOn)
            {
                traffic.enableCounter = 0;
            }
        }

        private void btnStartStopNtrip_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.setNTRIP_isOn)
            {
                if (isNTRIP_RequiredOn)
                {
                    ShutDownNTRIP();
                    lblWatch.Text = "Stopped";
                    btnStartStopNtrip.Text = "OffLine";
                    isNTRIP_RequiredOn = false;
                }
                else
                {
                    isNTRIP_RequiredOn = true;
                    lblWatch.Text = "Waiting";
                }
            }
            else
            {
                TimedMessageBox(2000, "Turn on NTRIP", "NTRIP Client Not Set Up");
            }

        }

        private void stripSerialPortsConfig_Click(object sender, EventArgs e)
        {
            SettingsCommunications();
        }

        private void stripRunDrive_Click(object sender, EventArgs e)
        {
            StartAOG();
        }

        private void nTRIPToolStrip_Click(object sender, EventArgs e)
        {
            SettingsNTRIP();
        }

        private void wizardToolStrip_Click(object sender, EventArgs e)
        {

        }

        private void loadToolStrip_Click(object sender, EventArgs e)
        {
            using (FormCommPicker form = new FormCommPicker(this))
            {
                DialogResult result = form.ShowDialog();
                
                if (result == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
        }

        private void stripGPSPortsConfig_Click(object sender, EventArgs e)
        {
            SettingsCommunicationGPS();
        }

        private void stripIMUConnect_Click(object sender, EventArgs e)
        {
            SettingsCommunicationIMU();
        }

        private void uDPToolStripMenu_Click(object sender, EventArgs e)
        {
            SettingsUDP();
        }

        private void saveToolStrip_Click(object sender, EventArgs e)
        {
            using (FormCommSaver form = new FormCommSaver(this))
            {
                DialogResult result = form.ShowDialog();
            }

        }

        public void KeypadToNUD(NumericUpDown sender)
        {
            NumericUpDown nud = (NumericUpDown)sender;
            nud.BackColor = System.Drawing.Color.Red;
            using (var form = new FormNumeric((double)nud.Minimum, (double)nud.Maximum, (double)nud.Value))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    nud.Value = (decimal)form.ReturnValue;
                }
            }
            nud.BackColor = System.Drawing.Color.AliceBlue;
        }

        public void KeyboardToText(TextBox sender)
        {
            TextBox tbox = (TextBox)sender;
            tbox.BackColor = System.Drawing.Color.Red;
            using (var form = new FormKeyboard((string)tbox.Text))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    tbox.Text = (string)form.ReturnString;
                }
            }
            tbox.BackColor = System.Drawing.Color.AliceBlue;
        }

    }
}
