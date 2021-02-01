//Please, if you use this, share the improvements

using System.IO.Ports;
using System;
using System.Windows.Forms;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Collections.Generic;
using System.Collections;

namespace AgIO
{
    public partial class FormLoop
    {
        //B5,62,7F,PGN_ID,Length
        private int totalHeaderByteCount = 5;

        public static string portNameGPS = "COM GPS";
        public static int baudRateGPS = 4800;

        public static string portNameGPS2 = "COM GPS2";
        public static int baudRateGPS2 = 4800;

        public static string portNameIMU = "COM IMU";
        public static int baudRateIMU = 38400;

        public static string portNameModule1 = "COM Mod1";
        public static int baudRateModule1 = 38400;

        public static string portNameModule2 = "COM Mod2";
        public static int baudRateModule2 = 38400;

        public static string portNameModule3 = "COM Mod3";
        public static int baudRateModule3 = 38400;

        //used to decide to autoconnect section arduino this run
        public string recvGPSSentence = "GPS";
        public string recvGPS2Sentence = "GPS2";
        public string recvIMUSentence = "IMU";
        public string recvModule1Sentence = "Module 1";
        public string recvModule2Sentence = "Module 2";
        public string recvModule3Sentence = "Module 3";

        public bool isGPSCommOpen = false;

        public byte checksumSent = 0;
        public byte checksumRecd = 0;

        //used to decide to autoconnect autosteer arduino this run
        public bool wasGPSConnectedLastRun = false;
        public bool wasModule3ConnectedLastRun = false;
        public bool wasModule2ConnectedLastRun = false;
        public bool wasModule1ConnectedLastRun = false;
        public bool wasIMUConnectedLastRun = false;

        //serial port gps is connected to
        public SerialPort spGPS = new SerialPort(portNameGPS, baudRateGPS, Parity.None, 8, StopBits.One);

        //serial port gps2 is connected to
        public SerialPort spGPS2 = new SerialPort(portNameGPS2, baudRateGPS2, Parity.None, 8, StopBits.One);

        //serial port Arduino is connected to
        public SerialPort spIMU = new SerialPort(portNameIMU, baudRateIMU, Parity.None, 8, StopBits.One);

        //serial port Arduino is connected to
        public SerialPort spModule1 = new SerialPort(portNameModule1, baudRateModule1, Parity.None, 8, StopBits.One);

        //serial port Arduino is connected to
        public SerialPort spModule2 = new SerialPort(portNameModule2, baudRateModule2, Parity.None, 8, StopBits.One);

        //serial port Ardiuno is connected to
        public SerialPort spModule3 = new SerialPort(portNameModule3, baudRateModule3, Parity.None, 8, StopBits.One);

        //lists for parsing incoming bytes
        private List<byte> pgnModule1 = new List<byte>();
        private List<byte> pgnModule2 = new List<byte>();
        private List<byte> pgnModule3 = new List<byte>();
        private List<byte> pgnIMU = new List<byte>();

        #region IMUSerialPort //--------------------------------------------------------------------
        private void ReceiveIMUPort(byte[] Data)
        {
            traffic.cntrIMUIn += Data.Length;
            SendToLoopBackMessage(Data);
        }

        //Send machine info out to machine board
        public void SendIMUPort(byte[] items, int numItems)
        {
            //Tell Arduino to turn section on or off accordingly
            if (spIMU.IsOpen)
            {
                try
                {
                    spIMU.Write(items, 0, numItems);
                    traffic.cntrIMUOut += items.Length;
                }
                catch (Exception)
                {
                    CloseIMUPort();
                }
            }
        }

        //open the Arduino serial port
        public void OpenIMUPort()
        {
            if (!spIMU.IsOpen)
            {
                spIMU.PortName = portNameIMU;
                spIMU.BaudRate = baudRateIMU;
                spIMU.DataReceived += sp_DataReceivedIMU;
                spIMU.DtrEnable = true;
                spIMU.RtsEnable = true;
            }

            try { spIMU.Open(); }
            catch (Exception e)
            {
                //WriteErrorLog("Opening Machine Port" + e.ToString());

                MessageBox.Show(e.Message + "\n\r" + "\n\r" + "Go to Settings -> COM Ports to Fix", "No Arduino Port Active");


                Properties.Settings.Default.setPort_wasIMUConnected = false;
                Properties.Settings.Default.Save();
                wasIMUConnectedLastRun = false;
            }

            if (spIMU.IsOpen)
            {
                //short delay for the use of mega2560, it is working in debugmode with breakpoint
                System.Threading.Thread.Sleep(500); // 500 was not enough

                spIMU.DiscardOutBuffer();
                spIMU.DiscardInBuffer();

                Properties.Settings.Default.setPort_portNameIMU = portNameIMU;
                Properties.Settings.Default.setPort_wasIMUConnected = true;
                Properties.Settings.Default.Save();
                wasIMUConnectedLastRun = true;
                lblIMUComm.Text = portNameIMU;
            }
        }

        //close the machine port
        public void CloseIMUPort()
        {
            if (spIMU.IsOpen)
            {
                spIMU.DataReceived -= sp_DataReceivedIMU;
                try
                {
                    spIMU.Close();
                    byte[] imuClose = new byte[] { 0x80, 0x81, 0x7C, 0xD4, 2, 1, 0, 0xCC };

                    //tell AOG IMU is disconnected
                    SendToLoopBackMessage(imuClose);
                }

                catch (Exception e)
                {
                    //WriteErrorLog("Closing Machine Serial Port" + e.ToString());
                    MessageBox.Show(e.Message, "Connection already terminated??");
                }

                Properties.Settings.Default.setPort_wasIMUConnected = false;
                Properties.Settings.Default.Save();

                spIMU.Dispose();
                wasIMUConnectedLastRun = false;
            }

            else
            {
                byte[] imuClose = new byte[] { 0x80, 0x81, 0x7C, 0xD4, 2, 1, 0, 0xCC };

                //tell AOG IMU is disconnected
                SendToLoopBackMessage(imuClose);
                wasIMUConnectedLastRun = false;
            }

            wasIMUConnectedLastRun = false;
            lblIMUComm.Text = "---";
        }

        private void sp_DataReceivedIMU(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            if (spIMU.IsOpen)
            {
                try
                {
                    if (spIMU.BytesToRead > 100) 
                        spIMU.DiscardInBuffer();

                    byte a; int length;

                    // intial read
                    int b = spIMU.ReadByte();

                    //no more data
                    if (b == -1) return;

                    //first byte in stream
                    a = ((byte)b);

                    do
                    {
                        switch (pgnIMU.Count)
                        {
                            case 0: //find 0x80
                                {
                                    if (a == 128) pgnIMU.Add(a);
                                    else pgnIMU.Clear();
                                    break;
                                }

                            case 1:  //find 0x81   
                                {
                                    if (a == 129) pgnIMU.Add(a);
                                    else
                                    {
                                        if (a == 181)
                                        {
                                            pgnIMU.Clear();
                                            pgnIMU.Add(a);
                                        }
                                        else pgnIMU.Clear();
                                    }
                                    break;
                                }

                            case 2: //Source Address (7F)
                                {
                                    if (a < 128 && a > 120) pgnIMU.Add(a);
                                    else pgnIMU.Clear();
                                    break;
                                }

                            case 3: //PGN ID
                                {
                                    pgnIMU.Add(a);
                                    break;
                                }

                            case 4: //Num of data bytes
                                {
                                    pgnIMU.Add(a);
                                    break;
                                }

                            default: //Data load and Checksum
                                {
                                    if (pgnIMU.Count > 4)
                                    {
                                        length = pgnIMU[4] + totalHeaderByteCount;
                                        if ((pgnIMU.Count) < length)
                                        {
                                            pgnIMU.Add(a);
                                            break;
                                        }
                                        else
                                        {
                                            //crc
                                            int CK_A = 0;
                                            for (int i = 2; i < length; i++)
                                            {
                                                CK_A = CK_A + pgnIMU[i];
                                            }

                                            //if checksum matches finish and update main thread
                                            if (a == (byte)(CK_A))
                                            {
                                                pgnIMU.Add((byte)(CK_A));

                                                byte[] arr;
                                                arr = pgnIMU.ToArray();
                                                this.BeginInvoke(new LineReceivedEventHandlerIMU(ReceiveIMUPort), arr);
                                            }

                                            //clear out the current pgn
                                            pgnIMU.Clear();
                                            return;
                                        }
                                    }
                                    break;
                                }
                        }

                        //get the next byte if there is one
                        b = spIMU.ReadByte();
                        if (b == -1) return;
                        a = (byte)b;

                    } while (b > -1); //out of bytes - leave
                }
                catch (Exception)
                {
                    pgnIMU.Clear();
                }
            }
        }

        //the delegate for thread
        private delegate void LineReceivedEventHandlerIMU(byte[] Data);

        #endregion ----------------------------------------------------------------

        #region Module1SerialPort //--------------------------------------------------------------------
        private void ReceiveModule1Port(byte[] Data)
        {
            SendToLoopBackMessage(Data);
            traffic.cntrModule1In += Data.Length;
            //lblCnt.Text = "";

            //for (int i = 4; i<Data.Length; i++)
            //{
            //    lblCnt.Text += Data[i].ToString() + ",";
            //}
            //System.Text.Encoding.UTF8.GetString(buf);
        }

        //Send machine info out to machine board
        public void SendModule1Port(byte[] items, int numItems)
        {
            //Tell Arduino to turn section on or off accordingly
            if (spModule1.IsOpen)
            {
                try
                {
                    spModule1.Write(items, 0, numItems);
                    traffic.cntrModule1Out += items.Length;
                    //rtxtStatus.Text += BitConverter.ToString(items) + "\r\n";
                }
                catch (Exception)
                {
                    CloseModule1Port();
                }
            }
        }

        //open the Arduino serial port
        public void OpenModule1Port()
        {
            if (!spModule1.IsOpen)
            {
                spModule1.PortName = portNameModule1;
                spModule1.BaudRate = baudRateModule1;
                spModule1.DataReceived += sp_DataReceivedModule1;
                spModule1.DtrEnable = true;
                spModule1.RtsEnable = true;
            }

            try
            {
                spModule1.Open();
                //short delay for the use of mega2560, it is working in debugmode with breakpoint
                System.Threading.Thread.Sleep(1000); // 500 was not enough

            }
            catch (Exception e)
            {
                //WriteErrorLog("Opening Machine Port" + e.ToString());

                MessageBox.Show(e.Message + "\n\r" + "\n\r" + "Go to Settings -> COM Ports to Fix", "No Arduino Port Active");


                Properties.Settings.Default.setPort_wasModule1Connected = false;
                Properties.Settings.Default.Save();
            }

            if (spModule1.IsOpen)
            {
                spModule1.DiscardOutBuffer();
                spModule1.DiscardInBuffer();

                Properties.Settings.Default.setPort_portNameModule1 = portNameModule1;
                Properties.Settings.Default.setPort_wasModule1Connected = true;
                Properties.Settings.Default.Save();

                wasModule1ConnectedLastRun = true;
                lblMod1Comm.Text = portNameModule1;
            }
        }

        //close the machine port
        public void CloseModule1Port()
        {
            if (spModule1.IsOpen)
            {
                spModule1.DataReceived -= sp_DataReceivedModule1;
                try { spModule1.Close(); }
                catch (Exception e)
                {
                    //WriteErrorLog("Closing Machine Serial Port" + e.ToString());
                    MessageBox.Show(e.Message, "Connection already terminated??");
                }

                Properties.Settings.Default.setPort_wasModule1Connected = false;
                Properties.Settings.Default.Save();

                spModule1.Dispose();
            }

            wasModule1ConnectedLastRun = false;
            lblMod1Comm.Text = "---";
        }

        private void sp_DataReceivedModule1(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            if (spModule1.IsOpen)
            {
                try
                {
                    //too many bytes?
                    if (spModule1.BytesToRead > 100) spModule1.DiscardInBuffer();

                    byte a; int cntr=0;

                    // intial read
                    int b = spModule1.ReadByte();

                    //no more data
                    if (b == -1) return;

                    //first byte in stream
                    a = ((byte)b);

                    do
                    {
                        cntr++;
                        switch (pgnModule1.Count)
                        {
                            case 0: //find 0x80
                                {
                                    if (a == 128) pgnModule1.Add(a);
                                    else pgnModule1.Clear();
                                    break;
                                }

                            case 1:  //find 0x81   
                                {
                                    if (a == 129) pgnModule1.Add(a);
                                    else
                                    {
                                        if (a == 181)
                                        {
                                            pgnModule1.Clear();
                                            pgnModule1.Add(a);
                                        }
                                        else pgnModule1.Clear();
                                    }
                                    break;
                                }

                            case 2: //Source Address (7F)
                                {
                                    if (a < 128 && a > 120) pgnModule1.Add(a);
                                    else pgnModule1.Clear();
                                    break;
                                }

                            case 3: //PGN ID
                                {
                                    pgnModule1.Add(a);
                                    break;
                                }

                            case 4: //Num of data bytes
                                {
                                    pgnModule1.Add(a);
                                    break;
                                }

                            default: //Data load and Checksum
                                {
                                    if (pgnModule1.Count > 4)
                                    {
                                        int length = pgnModule1[4] + totalHeaderByteCount;
                                        if ((pgnModule1.Count) < length)
                                        {
                                            pgnModule1.Add(a);
                                            break;
                                        }
                                        else
                                        {
                                            //crc
                                            int CK_A = 0;
                                            for (int i = 2; i < length; i++)
                                            {
                                                CK_A = CK_A + pgnModule1[i];
                                            }

                                            //if checksum matches finish and update main thread
                                            if (a == (byte)(CK_A))
                                            {
                                                pgnModule1.Add((byte)(CK_A));

                                                byte[] arr;
                                                arr = pgnModule1.ToArray();
                                                this.BeginInvoke(new LineReceivedEventHandlerModule1(ReceiveModule1Port), arr);
                                            }

                                            //clear out the current pgn
                                            pgnModule1.Clear();
                                            return;
                                        }
                                    }

                                    break;
                                }
                        }

                        //get the next byte if there is one
                        if (cntr > 18) 
                            return;
                        b = spModule1.ReadByte();
                        if (b == -1) return;
                        a = (byte)b;

                    } while (b > -1); //out of bytes - leave
                }
                catch (Exception)
                {
                    pgnModule1.Clear();
                }
            }
        }

        //the delegate for thread
        private delegate void LineReceivedEventHandlerModule1(byte[] Data);

        #endregion ----------------------------------------------------------------

        #region Module2SerialPort //------------------------------------------------

        private void ReceiveModule2Port(byte[] Data)
        {
            try
            {
                traffic.cntrModule2In += Data.Length;
                SendToLoopBackMessage(Data);
            }
            catch { }

        }

        //Send machine info out to machine board
        public void SendModule2Port(byte[] items, int numItems)
        {
            if (spModule2.IsOpen)
            {
                try
                {
                    spModule2.Write(items, 0, numItems);
                    traffic.cntrModule2Out += items.Length;
                }
                catch (Exception)
                {
                    CloseModule2Port();
                }
            }
        }

        //open the Arduino serial port
        public void OpenModule2Port()
        {
            if (!spModule2.IsOpen)
            {
                spModule2.PortName = portNameModule2;
                spModule2.BaudRate = baudRateModule2;
                spModule2.DataReceived += sp_DataReceivedModule2;
                spModule2.DtrEnable = true;
                spModule2.RtsEnable = true;
            }

            try
            {
                spModule2.Open();
                //short delay for the use of mega2560, it is working in debugmode with breakpoint
                System.Threading.Thread.Sleep(1000); // 500 was not enough

            }
            catch (Exception e)
            {
                //WriteErrorLog("Opening Machine Port" + e.ToString());

                MessageBox.Show(e.Message + "\n\r" + "\n\r" + "Go to Settings -> COM Ports to Fix", "No Arduino Port Active");


                Properties.Settings.Default.setPort_wasModule2Connected = false;
                Properties.Settings.Default.Save();
            }

            if (spModule2.IsOpen)
            {
                spModule2.DiscardOutBuffer();
                spModule2.DiscardInBuffer();

                Properties.Settings.Default.setPort_portNameModule2 = portNameModule2;
                Properties.Settings.Default.setPort_wasModule2Connected = true;
                Properties.Settings.Default.Save();

                wasModule2ConnectedLastRun = true;
                lblMod2Comm.Text = portNameModule2;
            }
        }

        //close the machine port
        public void CloseModule2Port()
        {
            if (spModule2.IsOpen)
            {
                spModule2.DataReceived -= sp_DataReceivedModule2;
                try { spModule2.Close(); }
                catch (Exception e)
                {
                    //WriteErrorLog("Closing Machine Serial Port" + e.ToString());
                    MessageBox.Show(e.Message, "Connection already terminated??");
                }

                Properties.Settings.Default.setPort_wasModule2Connected = false;
                Properties.Settings.Default.Save();

                spModule2.Dispose();
            }

            wasModule2ConnectedLastRun = false;
            lblMod2Comm.Text = "---";
        }

        private void sp_DataReceivedModule2(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            if (spModule2.IsOpen)
            {
                try
                {
                    if (spModule2.BytesToRead > 100) spModule2.DiscardInBuffer();

                    byte a; int length;

                    // intial read
                    int b = spModule2.ReadByte();

                    //no more data
                    if (b == -1) return;

                    //first byte in stream
                    a = ((byte)b);

                    do
                    {
                        switch (pgnModule2.Count)
                        {
                            case 0: //find 0x80
                                {
                                    if (a == 128) pgnModule2.Add(a);
                                    else pgnModule2.Clear();
                                    break;
                                }

                            case 1:  //find 0x81   
                                {
                                    if (a == 129) pgnModule2.Add(a);
                                    else
                                    {
                                        if (a == 181)
                                        {
                                            pgnModule2.Clear();
                                            pgnModule2.Add(a);
                                        }
                                        else pgnModule2.Clear();
                                    }
                                    break;
                                }

                            case 2: //Source Address (7F)
                                {
                                    if (a < 128 && a > 120) pgnModule2.Add(a);
                                    else pgnModule2.Clear();
                                    break;
                                }

                            case 3: //PGN ID
                                {
                                    pgnModule2.Add(a);
                                    break;
                                }

                            case 4: //Num of data bytes
                                {
                                    pgnModule2.Add(a);
                                    break;
                                }

                            default: //Data load and Checksum
                                {
                                    if (pgnModule2.Count > 4)
                                    {
                                        length = pgnModule2[4] + totalHeaderByteCount;
                                        if ((pgnModule2.Count) < length)
                                        {
                                            pgnModule2.Add(a);
                                            break;
                                        }
                                        else
                                        {
                                            //crc
                                            int CK_A = 0;
                                            for (int i = 2; i < length; i++)
                                            {
                                                CK_A = CK_A + pgnModule2[i];
                                            }

                                            //if checksum matches finish and update main thread
                                            if (a == (byte)(CK_A))
                                            {
                                                pgnModule2.Add((byte)(CK_A));

                                                byte[] arr;
                                                arr = pgnModule2.ToArray();
                                                this.BeginInvoke(new LineReceivedEventHandlerModule2(ReceiveModule2Port), arr);
                                            }

                                            //clear out the current pgn
                                            pgnModule2.Clear();
                                            return;
                                        }
                                    }

                                    break;
                                }
                        }

                        //get the next byte if there is one
                        b = spModule2.ReadByte();
                        if (b == -1) return;
                        a = (byte)b;

                    } while (b > -1); //out of bytes - leave
                }
                catch (Exception)
                {
                    pgnModule2.Clear();
                }
            }        
        }

        //the delegate for thread
        private delegate void LineReceivedEventHandlerModule2(byte[] Data);
        #endregion --------------------------------------------------------------------

        #region Module3SerialPort // --------------------------------------------------------------------
        private void ReceiveModule3Port(byte[] Data)
        {
            try
            {
                SendToLoopBackMessage(Data);
                traffic.cntrModule3In += Data.Length;
            }
            catch { }
        }

        public void SendModule3Port(byte[] items, int numItems)
        {
            if (spModule3.IsOpen)
            {
                try
                {
                    spModule3.Write(items, 0, numItems);
                    traffic.cntrModule3Out += items.Length;
                }
                catch (Exception)
                {
                    CloseModule3Port();
                }
            }
        }

        //open the Arduino serial port
        public void OpenModule3Port()
        {
            if (!spModule3.IsOpen)
            {
                spModule3.PortName = portNameModule3;
                spModule3.BaudRate = baudRateModule3;
                spModule3.DataReceived += sp_DataReceiveModule3;
                spModule3.DtrEnable = true;
                spModule3.RtsEnable = true;
            }

            try
            {
                spModule3.Open();
                //short delay for the use of mega2560, it is working in debugmode with breakpoint
                System.Threading.Thread.Sleep(1000); // 500 was not enough

            }
            catch (Exception e)
            {
                //WriteErrorLog("Opening Steer Port" + e.ToString());

                MessageBox.Show(e.Message + "\n\r" + "\n\r" + "Go to Settings -> COM Ports to Fix", "No AutoSteer Port Active");

                Properties.Settings.Default.setPort_wasModule3Connected = false;
                Properties.Settings.Default.Save();
            }

            if (spModule3.IsOpen)
            {
                spModule3.DiscardOutBuffer();
                spModule3.DiscardInBuffer();

                //update port status label

                Properties.Settings.Default.setPort_portNameModule3 = portNameModule3;
                Properties.Settings.Default.setPort_wasModule3Connected = true;
                Properties.Settings.Default.Save();

                wasModule3ConnectedLastRun = true;
                lblMod3Comm.Text = portNameModule3;
            }
        }

        public void CloseModule3Port()
        {
            if (spModule3.IsOpen)
            {
                spModule3.DataReceived -= sp_DataReceiveModule3;
                try { spModule3.Close(); }
                catch (Exception e)
                {
                    //WriteErrorLog("Closing steer Port" + e.ToString());
                    MessageBox.Show(e.Message, "Connection already terminated??");
                }

                Properties.Settings.Default.setPort_wasModule3Connected = false;
                Properties.Settings.Default.Save();

                spModule3.Dispose();
            }

            wasModule3ConnectedLastRun = false;
            lblMod3Comm.Text = "---";

        }

        //called by the module delegate every time a chunk is rec'd
        private void sp_DataReceiveModule3(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            if (spModule3.IsOpen)
            {
                try
                {
                    if (spModule3.BytesToRead > 100) spModule3.DiscardInBuffer();

                    byte a; int length;

                    // intial read
                    int b = spModule3.ReadByte();

                    //no more data
                    if (b == -1) return;

                    //first byte in stream
                    a = ((byte)b);

                    do
                    {
                        switch (pgnModule3.Count)
                        {
                            case 0: //find 0x80
                                {
                                    if (a == 128) pgnModule3.Add(a);
                                    else pgnModule3.Clear();
                                    break;
                                }

                            case 1:  //find 0x81   
                                {
                                    if (a == 129) pgnModule3.Add(a);
                                    else
                                    {
                                        if (a == 181)
                                        {
                                            pgnModule3.Clear();
                                            pgnModule3.Add(a);
                                        }
                                        else pgnModule3.Clear();
                                    }
                                    break;
                                }

                            case 2: //Source Address (7F)
                                {
                                    if (a < 128 && a > 120) pgnModule3.Add(a);
                                    else pgnModule3.Clear();
                                    break;
                                }

                            case 3: //PGN ID
                                {
                                    pgnModule3.Add(a);
                                    break;
                                }

                            case 4: //Num of data bytes
                                {
                                    pgnModule3.Add(a);
                                    break;
                                }

                            default: //Data load and Checksum
                                {
                                    if (pgnModule3.Count > 4)
                                    {
                                        length = pgnModule3[4] + totalHeaderByteCount;
                                        if ((pgnModule3.Count) < length)
                                        {
                                            pgnModule3.Add(a);
                                            break;
                                        }
                                        else
                                        {
                                            //crc
                                            int CK_A = 0;
                                            for (int i = 2; i < length; i++)
                                            {
                                                CK_A = CK_A + pgnModule3[i];
                                            }

                                            //if checksum matches finish and update main thread
                                            if (a == (byte)(CK_A))
                                            {
                                                pgnModule3.Add((byte)(CK_A));

                                                byte[] arr;
                                                arr = pgnModule3.ToArray();
                                                this.BeginInvoke(new LineReceivedEventHandlerModule3(ReceiveModule3Port), arr);
                                            }

                                            //clear out the current pgn
                                            pgnModule3.Clear();
                                            return;
                                        }
                                    }

                                    break;
                                }
                        }

                        //get the next byte if there is one
                        b = spModule3.ReadByte();
                        if (b == -1) return;
                        a = (byte)b;

                    } while (b > -1); //out of bytes - leave
                }
                catch (Exception)
                {
                    pgnModule3.Clear();
                }
            }
        }

        //the delegate for thread
        private delegate void LineReceivedEventHandlerModule3(byte[] Data);

        #endregion

        #region GPS SerialPort --------------------------------------------------------------------------

        public void SendGPSPort(byte[] data)
        {
            try
            {
                if (spGPS.IsOpen)
                {
                    spGPS.Write(data, 0, data.Length);
                    traffic.cntrGPSOut += data.Length;
                }
            }
            catch (Exception)
            {
            }

        }
        public void OpenGPSPort()
        {

            if (spGPS.IsOpen)
            {
                //close it first
                CloseGPSPort();
            }


            if (!spGPS.IsOpen)
            {
                spGPS.PortName = portNameGPS;
                spGPS.BaudRate = baudRateGPS;
                //spGPS.DataReceived += sp_DataReceivedGPS;
                spGPS.WriteTimeout = 1000;
            }

            try { spGPS.Open(); }
            catch (Exception)
            {
            }

            if (spGPS.IsOpen)
            {
                //discard any stuff in the buffers
                spGPS.DiscardOutBuffer();
                spGPS.DiscardInBuffer();

                Properties.Settings.Default.setPort_portNameGPS = portNameGPS;
                Properties.Settings.Default.setPort_baudRateGPS = baudRateGPS;
                Properties.Settings.Default.Save();
                lblGPS1Comm.Text = portNameGPS;
                wasGPSConnectedLastRun = true;
            }
        }
        public void CloseGPSPort()
        {
            //if (sp.IsOpen)
            {
                //spGPS.DataReceived -= sp_DataReceivedGPS;
                try { spGPS.Close(); }
                catch (Exception e)
                {
                    //WriteErrorLog("Closing GPS Port" + e.ToString());
                    MessageBox.Show(e.Message, "Connection already terminated?");
                }

                //update port status labels
                //stripPortGPS.Text = " * * " + baudRateGPS.ToString();
                //stripPortGPS.ForeColor = Color.ForestGreen;
                //stripOnlineGPS.Value = 1;
                spGPS.Dispose();
            }
            lblGPS1Comm.Text = "---";
            wasGPSConnectedLastRun = false;

        }

        //called by the GPS delegate every time a chunk is rec'd
        //private void ReceiveGPSPort(string sentence)
        //{
        //    SendToLoopBackMessage(sentence);
        //    traffic.cntrGPSIn += sentence.Length;
        //    recvGPSSentence = sentence;
        //}

        //serial port receive in its own thread
        //private void sp_DataReceivedGPS(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        //{
        //    //System.Threading.Thread.Sleep(10); // 500 was not enough

        //    if (spGPS.IsOpen)
        //    {
        //        //if (spGPS.BytesToRead < 10) return;
        //        try
        //        {
        //            string sentence = spGPS.ReadExisting();
        //            this.BeginInvoke(new LineReceivedEventHandlerGPS(ReceiveGPSPort), sentence);
        //        }
        //        catch (Exception)
        //        {
        //        }
        //    }
        //}

        //private delegate void LineReceivedEventHandlerGPS(string sentence);

        #endregion SerialPortGPS

        #region GPS2 SerialPort //--------------------------------------------------------------------------

        //called by the GPS2 delegate every time a chunk is rec'd
        private void ReceiveGPS2Port(string sentence)
        {
            SendToLoopBackMessage(sentence);
            traffic.cntrGPS2In += sentence.Length;
            recvGPS2Sentence = sentence;

        }
        public void SendGPS2Port(byte[] data)
        {
            try
            {
                if (spGPS2.IsOpen)
                {
                    spGPS2.Write(data, 0, data.Length);
                    traffic.cntrGPS2Out += data.Length;
                }
            }
            catch (Exception)
            {
            }

        }
        public void OpenGPS2Port()
        {
            //close it first
            CloseGPS2Port();

            //if (spGPS2.IsOpen)
            //{
            //    //simulatorOnToolStripMenuItem.Checked = false;
            //    //panelSim.Visible = false;
            //    //timerSim.Enabled = false;

            //    //Settings.Default.setMenu_isSimulatorOn = simulatorOnToolStripMenuItem.Checked;
            //    //Settings.Default.Save();
            //}


            if (!spGPS2.IsOpen)
            {
                spGPS2.PortName = portNameGPS2;
                spGPS2.BaudRate = baudRateGPS2;
                spGPS2.DataReceived += sp_DataReceivedGPS2;
                spGPS2.WriteTimeout = 1000;
            }

            try { spGPS2.Open(); }
            catch (Exception)
            {
            }

            if (spGPS2.IsOpen)
            {
                //discard any stuff in the buffers
                spGPS2.DiscardOutBuffer();
                spGPS2.DiscardInBuffer();

                Properties.Settings.Default.setPort_portNameGPS2 = portNameGPS2;
                Properties.Settings.Default.setPort_baudRateGPS2 = baudRateGPS2;
                Properties.Settings.Default.Save();
            }
        }
        public void CloseGPS2Port()
        {
            //if (sp.IsOpen)
            {
                spGPS2.DataReceived -= sp_DataReceivedGPS2;
                try { spGPS2.Close(); }
                catch (Exception e)
                {
                    //WriteErrorLog("Closing GPS2 Port" + e.ToString());
                    MessageBox.Show(e.Message, "Connection already terminated?");
                }

                //update port status labels
                //stripPortGPS2.Text = " * * " + baudRateGPS2.ToString();
                //stripPortGPS2.ForeColor = Color.ForestGreen;
                //stripOnlineGPS2.Value = 1;
                spGPS2.Dispose();
            }
        }

        //serial port receive in its own thread
        private void sp_DataReceivedGPS2(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            if (spGPS2.IsOpen)
            {
                try
                {
                    string sentence = spGPS2.ReadLine();
                    this.BeginInvoke(new LineReceivedEventHandlerGPS2(ReceiveGPS2Port), sentence);
                }
                catch (Exception)
                {
                }
            }
        }

        private delegate void LineReceivedEventHandlerGPS2(string sentence);

        #endregion //--------------------------------------------------------

        public void FileSaveComm(string FileName)
        {
            commFileName = Path.GetFileNameWithoutExtension(FileName);
            Properties.Settings.Default.setComm_commName = commFileName;
            Properties.Settings.Default.Save();

            using (StreamWriter writer = new StreamWriter(FileName))
            {
                writer.WriteLine("Version," + Application.ProductVersion.ToString(CultureInfo.InvariantCulture));

                writer.WriteLine("Culture," + Properties.Settings.Default.setF_culture.ToString(CultureInfo.InvariantCulture));
                
                writer.WriteLine("Empty," + "10");
                writer.WriteLine("Empty," + "10");
                writer.WriteLine("Empty," + "10");

                writer.WriteLine("IsNtripCasterIP," + Properties.Settings.Default.setNTRIP_casterIP.ToString(CultureInfo.InvariantCulture));
                writer.WriteLine("IsNtripCasterPort," + Properties.Settings.Default.setNTRIP_casterPort.ToString(CultureInfo.InvariantCulture));
                writer.WriteLine("IsNtripCasterURL," + Properties.Settings.Default.setNTRIP_casterURL.ToString(CultureInfo.InvariantCulture));
                writer.WriteLine("IsNtripGGAManual," + Properties.Settings.Default.setNTRIP_isGGAManual.ToString(CultureInfo.InvariantCulture));
                writer.WriteLine("IsNtripOn," + Properties.Settings.Default.setNTRIP_isOn.ToString(CultureInfo.InvariantCulture));
                writer.WriteLine("IsNtripTCP," + Properties.Settings.Default.setNTRIP_isTCP.ToString(CultureInfo.InvariantCulture));
                writer.WriteLine("IsNtripManualLat," + Properties.Settings.Default.setNTRIP_manualLat.ToString(CultureInfo.InvariantCulture));
                writer.WriteLine("IsNtripManualLon," + Properties.Settings.Default.setNTRIP_manualLon.ToString(CultureInfo.InvariantCulture));
                writer.WriteLine("IsNtripMount," + Properties.Settings.Default.setNTRIP_mount.ToString(CultureInfo.InvariantCulture));
                writer.WriteLine("IsNtripGGAInterval," + Properties.Settings.Default.setNTRIP_sendGGAInterval.ToString(CultureInfo.InvariantCulture));
                writer.WriteLine("IsNtripSendToUDPPort," + Properties.Settings.Default.setNTRIP_sendToUDPPort.ToString(CultureInfo.InvariantCulture));
                writer.WriteLine("IsNtripUserName," + Properties.Settings.Default.setNTRIP_userName.ToString(CultureInfo.InvariantCulture));
                writer.WriteLine("IsNtripUserPassword," + Properties.Settings.Default.setNTRIP_userPassword.ToString(CultureInfo.InvariantCulture));

                writer.WriteLine("IsUDPOn," + Properties.Settings.Default.setUDP_isOn.ToString(CultureInfo.InvariantCulture));
                writer.WriteLine("GPSSimLatitude," + Properties.Settings.Default.setGPS_SimLatitude.ToString(CultureInfo.InvariantCulture));
                writer.WriteLine("GPSSimLongitude" + "," + Properties.Settings.Default.setGPS_SimLongitude.ToString(CultureInfo.InvariantCulture));


                writer.WriteLine("Empty," + "10");
                writer.WriteLine("Empty," + "10");
                writer.WriteLine("Empty," + "10");
                writer.WriteLine("Empty," + "10");
            }

            //little show to say saved and where
            var form = new FormTimedMessage(3000, "Saved in ", commDirectory);
            form.Show();

        }

        public DialogResult FileOpenComm(string fileName)
        {
            //make sure the file if fully valid and vehicle matches sections
            using (StreamReader reader = new StreamReader(fileName))
            {
                try
                {
                    string line;
                    Properties.Settings.Default.setComm_commName = fileName;
                    string[] words;
                    line = reader.ReadLine(); words = line.Split(',');


                    string vers = words[1].Replace('.', '0');
                    int fileVersion = int.Parse(vers, CultureInfo.InvariantCulture);

                    string assemblyVersion = Application.ProductVersion.ToString(CultureInfo.InvariantCulture);
                    assemblyVersion = assemblyVersion.Replace('.', '0');
                    int appVersion = int.Parse(assemblyVersion, CultureInfo.InvariantCulture);

                    appVersion /= 100;
                    fileVersion /= 100;

                    if (fileVersion < appVersion)
                    {
                        var form = new FormTimedMessage(5000, "File Error", "Must be Version " + Application.ProductVersion.ToString(CultureInfo.InvariantCulture) + " or higher");
                        form.Show();
                        return DialogResult.Abort;
                    }

                    else
                    {
                        line = reader.ReadLine(); words = line.Split(',');
                        Properties.Settings.Default.setF_culture = (words[1]);

                        line = reader.ReadLine();
                        line = reader.ReadLine();
                        line = reader.ReadLine();

                        line = reader.ReadLine(); words = line.Split(',');
                        Properties.Settings.Default.setNTRIP_casterIP = words[1];
                        line = reader.ReadLine(); words = line.Split(',');
                        Properties.Settings.Default.setNTRIP_casterPort = int.Parse(words[1], CultureInfo.InvariantCulture);
                        line = reader.ReadLine(); words = line.Split(',');
                        Properties.Settings.Default.setNTRIP_casterURL = words[1];

                        line = reader.ReadLine(); words = line.Split(',');
                        Properties.Settings.Default.setNTRIP_isGGAManual = bool.Parse(words[1]);
                        line = reader.ReadLine(); words = line.Split(',');
                        Properties.Settings.Default.setNTRIP_isOn = bool.Parse(words[1]);
                        line = reader.ReadLine(); words = line.Split(',');
                        Properties.Settings.Default.setNTRIP_isTCP = bool.Parse(words[1]);
                        line = reader.ReadLine(); words = line.Split(',');
                        Properties.Settings.Default.setNTRIP_manualLat = double.Parse(words[1], CultureInfo.InvariantCulture);
                        line = reader.ReadLine(); words = line.Split(',');
                        Properties.Settings.Default.setNTRIP_manualLon = double.Parse(words[1], CultureInfo.InvariantCulture);

                        line = reader.ReadLine(); words = line.Split(',');
                        Properties.Settings.Default.setNTRIP_mount = (words[1]);
                        line = reader.ReadLine(); words = line.Split(',');
                        Properties.Settings.Default.setNTRIP_sendGGAInterval = int.Parse(words[1], CultureInfo.InvariantCulture);
                        line = reader.ReadLine(); words = line.Split(',');
                        Properties.Settings.Default.setNTRIP_sendToUDPPort = int.Parse(words[1], CultureInfo.InvariantCulture);
                        line = reader.ReadLine(); words = line.Split(',');
                        Properties.Settings.Default.setNTRIP_userName = (words[1]);
                        line = reader.ReadLine(); words = line.Split(',');
                        Properties.Settings.Default.setNTRIP_userPassword = (words[1]);

                        line = reader.ReadLine(); words = line.Split(',');
                        Properties.Settings.Default.setUDP_isOn = bool.Parse(words[1]);
                        line = reader.ReadLine(); words = line.Split(',');
                        Properties.Settings.Default.setGPS_SimLatitude = double.Parse(words[1], CultureInfo.InvariantCulture);
                        line = reader.ReadLine(); words = line.Split(',');
                        Properties.Settings.Default.setGPS_SimLongitude = double.Parse(words[1], CultureInfo.InvariantCulture);

                        line = reader.ReadLine();
                        line = reader.ReadLine();
                        line = reader.ReadLine();
                        line = reader.ReadLine();

                        //fill in the current variables with restored data
                        commFileName = Path.GetFileNameWithoutExtension(fileName);
                        Properties.Settings.Default.setComm_commName = commFileName;

                        Properties.Settings.Default.Save();
                    }

                    return DialogResult.OK;
                }
                catch (Exception) //FormatException e || IndexOutOfRangeException e2)
                {
                    //WriteErrorLog("Open Vehicle" + e.ToString());

                    //comm is corrupt, reload with all default information
                    Properties.Settings.Default.Reset();
                    Properties.Settings.Default.Save();
                    MessageBox.Show("Shit", "Comm load", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    //Application.Exit();
                    return DialogResult.Cancel;
                }
            }
        }//end of open file

    }//end class
}//end namespace