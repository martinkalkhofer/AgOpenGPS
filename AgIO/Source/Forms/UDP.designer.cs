using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgIO
{
    public class CTraffic
    {
        public int cntrPGNFromAOG = 0;
        public int cntrPGNToAOG = 0;
     
        public int cntrUDPOut = 0;
        public int cntrUDPIn = 0;

        public int cntrGPSIn = 0;
        public int cntrGPSOut = 0;

        public int cntrGPS2In = 0;
        public int cntrGPS2Out = 0;

        public int cntrIMUIn = 0;
        public int cntrIMUOut = 0;

        public int cntrModule1In = 0;
        public int cntrModule1Out = 0;

        public int cntrModule2In = 0;
        public int cntrModule2Out = 0;

        public int cntrModule3In = 0;
        public int cntrModule3Out = 0;

        public bool isTrafficOn = true;

        public int enableCounter = 0;

        //0x7FD0
        public byte[] AgIOStatus = new byte[] {0x80,0x81, 0x7E, 0xD2, 2, 0, 0, 0xCC };
    }

    public partial class FormLoop
    {
        // Server socket
        private Socket recvFromLoopBackSocket;
        private Socket sendToLoopBackSocket;

        CTraffic traffic = new CTraffic();

        IPEndPoint epAgOpen;

        // Data stream
        private byte[] buffer = new byte[1024];

        // Status delegate
        private delegate void UpdateStatusDelegate(int port, byte[] msg);
        private UpdateStatusDelegate updateStatusDelegate = null;

        // Send and Recv socket for udp network
        private Socket sendSocket;
        private Socket recvSocket;
        private bool isUDPNetworkConnected;

        //list of bytes to send out serial ports
        private List<byte> serList = new List<byte>();
        private bool isOKtoSendSerial = false;

        //IP address and port of Auto Steer server
        IPAddress epIP = IPAddress.Parse(Properties.Settings.Default.setIP_autoSteerIP);

        // Status delegate
        private delegate void UpdateRecvMessageDelegate(int port, byte[] msg);
        private UpdateRecvMessageDelegate updateRecvMessageDelegate = null;

        //initialize loopback and udp network
        private void LoadUDPNetwork()
        {
            try //udp network
            {
                // Initialise the delegate which updates the message received
                updateRecvMessageDelegate = ReceiveFromUDP;

                // Initialise the socket
                sendSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                recvSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

                sendSocket.EnableBroadcast = true;
                recvSocket.EnableBroadcast = true;

                // Initialise the IPEndPoint for the server and listen on port 9999
                IPEndPoint recv = new IPEndPoint(IPAddress.Any, Properties.Settings.Default.setIP_thisPort);

                // Associate the socket with this IP address and port
                recvSocket.Bind(recv);

                // Initialise the IPEndPoint for the server to send on port 9998
                IPEndPoint server = new IPEndPoint(IPAddress.Any, 9998);
                sendSocket.Bind(server);

                // Initialise the IPEndPoint for the client - async listner client only!
                EndPoint client = new IPEndPoint(IPAddress.Any, 0);

                // Start listening for incoming data
                recvSocket.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None,
                                                ref client, new AsyncCallback(ReceiveDataUDPAsync), recvSocket);
                isUDPNetworkConnected = true;
            }
            catch (Exception e)
            {
                //WriteErrorLog("UDP Server" + e);
                MessageBox.Show("Load Error: " + e.Message, "UDP Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadLoopback()
        { 
            try //loopback
            {
                // Initialise the socket
                sendToLoopBackSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

                sendToLoopBackSocket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
                sendToLoopBackSocket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, true);
                // Initialise the IPEndPoint for the server to send on port 17776
                IPEndPoint sender = new IPEndPoint(IPAddress.Any, 17776);
                sendToLoopBackSocket.Bind(sender);

                //IP address and port of AgOpen
                epAgOpen = new IPEndPoint(IPAddress.Loopback, 15555);

                // Initialise the delegate which updates the status
                updateStatusDelegate = new UpdateStatusDelegate(ReceiveFromLoopBack);

                // Initialise the socket
                recvFromLoopBackSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                recvFromLoopBackSocket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
                EndPoint client = new IPEndPoint(IPAddress.Any, 17777);
                recvFromLoopBackSocket.Bind(client);
                recvFromLoopBackSocket.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref client, new AsyncCallback(ReceiveDataLoopAsync), recvFromLoopBackSocket);

            }
            catch (Exception ex)
            {
                //lblStatus.Text = "Error";
                MessageBox.Show("Load Error: " + ex.Message, "UDP Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //loopback functions
        #region Send And Receive

        public byte[] nmeaHeader = new byte[] { 0x80, 0x81, 0x7F, 0xCF };

        private void SendToLoopBackMessage(string message)
        {
            try
            {
                // Get packet as byte array
                byte[] byteData = Encoding.ASCII.GetBytes(message);

                //if (byteData.Length != 0)
                //{
                //    traffic.cntrPGNToAOG += byteData.Length;

                //    // Send packet to the zero
                //    sendToLoopBackSocket.BeginSendTo(byteData, 0, byteData.Length, SocketFlags.None, epAgOpen,
                //            new AsyncCallback(SendDataLoopAsync), null);
                //}


                byte[] nmeaData = glm.Combine(nmeaHeader, byteData);

                if (nmeaData.Length != 0)
                {
                    traffic.cntrPGNToAOG += nmeaData.Length;

                    // Send packet to the zero
                    sendToLoopBackSocket.BeginSendTo(nmeaData, 0, nmeaData.Length, SocketFlags.None, epAgOpen,
                            new AsyncCallback(SendDataLoopAsync), null);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Send Error: " + ex.Message, "UDP Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SendToLoopBackMessage(byte[] byteData)
        {
            try
            {
                if (byteData.Length != 0)
                {
                    traffic.cntrPGNToAOG += byteData.Length;

                    // Send packet to the zero
                    sendToLoopBackSocket.BeginSendTo(byteData, 0, byteData.Length, SocketFlags.None, epAgOpen, 
                        new AsyncCallback(SendDataLoopAsync), null);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Send Error: " + ex.Message, "UDP Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReceiveFromLoopBack(int port, byte[] data)
        {
            isOKtoSendSerial = false;
            traffic.cntrPGNFromAOG += data.Length;

            //Send out to udp network
            if (isUDPNetworkConnected)  SendUDPMessage(data);

            serList.AddRange(data);
            isOKtoSendSerial = true;

            if (data[0] == 0x80 && data[1] == 0x81)
            {
                switch (data[3])
                {
                    //the lat lon from AOG
                    case 0xD0:
                        {
                            int encAngle = BitConverter.ToInt32(data, 5);
                            currentLat = (encAngle / (0x7FFFFFFF / 90.0));

                            encAngle = BitConverter.ToInt32(data, 9);
                            currentLon = (encAngle / (0x7FFFFFFF / 180.0));

                            break;
                        }
                }
            }

            //lblIncoming.Text = (data[0].ToString() + "," + data[1].ToString()
            //    + "," + data[2].ToString() + "," + data[3].ToString()
            //    + "," + data[4].ToString() + "," + data[5].ToString()
            //    + "," + data[6].ToString() + "," + data[7].ToString()
            //    + "," + data[8].ToString() + "," + data[9].ToString()
            //    + " \r\n");

        }

        public void SendDataLoopAsync(IAsyncResult asyncResult)
        {
            try
            {
                sendToLoopBackSocket.EndSend(asyncResult);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SendData Error: " + ex.Message, "UDP Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private EndPoint epSender = new IPEndPoint(IPAddress.Any, 0);
        private void ReceiveDataLoopAsync(IAsyncResult asyncResult)
        {
            try
            {
                // Initialise the IPEndPoint for the clients

                // Receive all data
                int msgLen = recvFromLoopBackSocket.EndReceiveFrom(asyncResult, ref epSender);

                byte[] localMsg = new byte[msgLen];
                Array.Copy(buffer, localMsg, msgLen);

                // Listen for more connections again...
                recvFromLoopBackSocket.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None,
                    ref epSender, new AsyncCallback(ReceiveDataLoopAsync), recvFromLoopBackSocket);

                //string text = Encoding.ASCII.GetString(localMsg);

                // Update status through a delegate
                int port = ((IPEndPoint)epSender).Port;
                Invoke(updateStatusDelegate, new object[] { port, localMsg });
            }
            catch (Exception)
            {
                //MessageBox.Show("ReceiveData Error: " + ex.Message, "UDP Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        //udp network functions
        public void SendUDPMessage(string message)
        {
            if (isUDPNetworkConnected)
            {
                try
                {
                    IPEndPoint epAutoSteer = new IPEndPoint(epIP, 8888);

                    // Get packet as byte array to send
                    byte[] byteData = Encoding.ASCII.GetBytes(message);
                    if (byteData.Length != 0)
                        sendSocket.BeginSendTo(byteData, 0, byteData.Length, SocketFlags.None,
                            epAutoSteer, new AsyncCallback(SendDataUDPAsync), null);

                    traffic.cntrUDPOut+=byteData.Length;
                }
                catch (Exception)
                {
                    //WriteErrorLog("Sending UDP Message" + e.ToString());
                    //MessageBox.Show("Send Error: " + e.Message, "UDP Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //sends byte array
        public void SendUDPMessage(byte[] byteData)
        {
            if (isUDPNetworkConnected)
            {
                try
                {
                    IPEndPoint epAutoSteer = new IPEndPoint(epIP, 8888);

                    // Send packet to the zero
                    if (byteData.Length != 0)
                        sendSocket.BeginSendTo(byteData, 0, byteData.Length, SocketFlags.None,
                            epAutoSteer, new AsyncCallback(SendDataUDPAsync), null);

                    traffic.cntrUDPOut+=byteData.Length;
                }
                catch (Exception)
                {
                    //WriteErrorLog("Sending UDP Message" + e.ToString());
                    //MessageBox.Show("Send Error: " + e.Message, "UDP Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ReceiveFromUDP(int port, byte[] data)
        {
            SendToLoopBackMessage(data);
            traffic.cntrUDPIn += data.Length;
        }

        private void SendDataUDPAsync(IAsyncResult asyncResult)
        {
            try
            {
                sendSocket.EndSend(asyncResult);
            }
            catch (Exception)
            {
                //WriteErrorLog(" UDP Send Data" + e.ToString());
                //MessageBox.Show("SendData Error: " + e.Message, "UDP Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReceiveDataUDPAsync(IAsyncResult asyncResult)
        {
            try
            {
                // Initialise the IPEndPoint for the client
                EndPoint epSender = new IPEndPoint(IPAddress.Any, 0);

                // Receive all data
                int msgLen = recvSocket.EndReceiveFrom(asyncResult, ref epSender);

                byte[] localMsg = new byte[msgLen];
                Array.Copy(buffer, localMsg, msgLen);

                // Listen for more connections again...
                recvSocket.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epSender,
                    new AsyncCallback(ReceiveDataUDPAsync), recvSocket);

                //string text =  Encoding.ASCII.GetString(localMsg);

                int port = ((IPEndPoint)epSender).Port;
                // Update status through a delegate
                Invoke(updateRecvMessageDelegate, new object[] { port, localMsg });
            }
            catch (Exception)
            {
                //WriteErrorLog("UDP Recv data " + e.ToString());
                //MessageBox.Show("ReceiveData Error: " + e.Message, "UDP Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
