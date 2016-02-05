using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using NativeWifi;
using InTheHand.Net.Sockets;
using InTheHand.Net;
using InTheHand.Net.Bluetooth;
using SharpPcap;
using PacketDotNet;
using System.Threading;
using SharpPcap.WinPcap;


namespace MoSoWT
{
    public partial class Wifi_Monitor : Form
    {
        private WlanClient client = new WlanClient();
        private System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
        
        private static long maxbps = 0;
        private static long maxpps = 0;

        private static long AllRecBytes = 0;
        private static long AllRecTcpUdpPackets = 0;

        private static long AllRecPackets = 0;
        private static long AllSenPackets = 0;


        public Wifi_Monitor()
        {
            InitializeComponent();
        }

        public void InitTimer()
        {            
            timer1.Tick += new EventHandler(wifiInfo);
            timer1.Interval = 100; 
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InitTimer();
            capturing();
        }

        private void wifiInfo(object sender, EventArgs e)
        {
            try
            {
                Output.Text = null;
                string wlan_ssid = ssid_textbox.Text;

                foreach (WlanClient.WlanInterface wlanIface in client.Interfaces)
                {
                    Wlan.WlanBssEntry[] wlanBssEntries = wlanIface.GetNetworkBssList();

                    foreach (Wlan.WlanBssEntry network in wlanBssEntries)
                    {                       
                        String ssid0 = Encoding.ASCII.GetString(network.dot11Ssid.SSID).ToString();
                        String ssid = "";

                        continue;

                        for (int i = 0; i < ssid0.Length; i++)
                        {
                            if (!ssid0[i].Equals('\0'))
                            {
                                ssid += ssid0[i];
                            }
                            else
                            {
                                break;
                            }
                        }

                        if (!wlan_ssid.Equals(ssid))
                        {
                            continue;
                        }

                        int rss = network.rssi;

                        byte[] macAddr = network.dot11Bssid;

                        string tMac = "";

                        for (int i = 0; i < macAddr.Length; i++)
                        {

                            tMac += macAddr[i].ToString("x2").PadLeft(2, '0').ToUpper();
                            if (i != macAddr.Length - 1) tMac += ":";

                        }

                        String rssi = rss.ToString();

                        String speed = (wlanIface.NetworkInterface.Speed / 1000000).ToString();

                        IPv4InterfaceStatistics ipstats = wlanIface.NetworkInterface.GetIPv4Statistics();
                        
                        Output.Text += "SSID: " + ssid + "\r\n";

                        Output.Text += "Signal: " + network.linkQuality + " %.\r\n";

                        Output.Text += "MAC: " + tMac + " .\r\n";

                        Output.Text += "RSSI: " + rssi + " dBm .\r\n";

                        Output.Text += "Speed: " + speed + " Mb/s. \r\n";

                        Output.Text += "Interface state: " + wlanIface.InterfaceState + "\r\n";

                        //
                        AllRecPackets = ipstats.NonUnicastPacketsReceived + ipstats.UnicastPacketsReceived;

                        Output.Text += "Received bytes: " + ipstats.BytesReceived.ToString() + " B. \r\n";

                        Output.Text += "All received packets " + AllRecPackets + " \r\n";
                        
                        Output.Text += "Incoming discarded packets: " + ipstats.IncomingPacketsDiscarded + " \r\n";

                        Output.Text += "Incoming packets with errors: " + ipstats.IncomingPacketsWithErrors + " \r\n";
                        
                        //
                        AllSenPackets = ipstats.NonUnicastPacketsSent + ipstats.UnicastPacketsSent;

                        Output.Text += "Sent bytes: " + ipstats. BytesSent.ToString() + "B. \r\n" ;

                        Output.Text += "All sent packets " + AllSenPackets + " \r\n";

                        Output.Text += "Outgoing discarded packets: " + ipstats.OutgoingPacketsDiscarded + " \r\n";

                        Output.Text += "Outgoing packets with errors: " + ipstats.OutgoingPacketsWithErrors + " \r\n";

                        Output.Text += "\r\n";

                    }

                }

                Output.Text += "\r\n";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void capturing()
        {
            CaptureDeviceList devices = CaptureDeviceList.Instance;
            WinPcapDevice device = null;
            
            CaptBox.Text = "";

            if (devices.Count < 1)
            {
                CaptBox.Text += "No devices found!";
                return;
            }

            foreach (WinPcapDevice dev in devices)
            {
                String devstr = dev.ToString();
                if (devstr.Contains("WiFi")) {
                    device = dev;
                    break;
                }
            }
                        
            device.OnPcapStatistics += new SharpPcap.WinPcap.StatisticsModeEventHandler(getStatistics);

            
            int readTimeoutMilliseconds = 1000;
            device.Open(DeviceMode.Promiscuous, readTimeoutMilliseconds);
                        
            device.Filter = "tcp or udp";
                        
            device.Mode = CaptureMode.Statistics;
            device.StartCapture();

        }

        private static void getPacket(object sender, CaptureEventArgs e)
        {
            DateTime time = e.Packet.Timeval.Date;
            int len = e.Packet.Data.Length;
            

            Console.WriteLine("{0}:{1}:{2},{3} Packet_length = {4}",
            time.Hour, time.Minute, time.Second, time.Millisecond, len);
                                   
        }

        static ulong oldSec = 0;
        static ulong oldUsec = 0;
                       
        private static void getStatistics(object sender, StatisticsModeEventArgs stat)
        {     
            StatisticsModePacket statistics = stat.Statistics;
            
            long delay = (long) ((statistics.Timeval.Seconds - oldSec) *
                1000000 - oldUsec + statistics.Timeval.MicroSeconds);
            
            AllRecBytes += statistics.RecievedBytes;
            long bps = (statistics.RecievedBytes * 8 * 1000000) / delay;

            AllRecTcpUdpPackets += statistics.RecievedPackets;                    
            long pps = (statistics.RecievedPackets * 1000000) / delay;
                        
            string ts = statistics.Timeval.Date.ToLongTimeString();
                        
            if (bps != 0 || pps != 0)
            {
                Console.WriteLine("{0}: bps={1}, pps={2}", ts, bps, pps);
            }

            if (maxbps < bps) maxbps = bps;
            if (maxpps < pps) maxpps = pps;
                        
            oldSec = statistics.Timeval.Seconds;
            oldUsec = statistics.Timeval.MicroSeconds;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            CaptBox.Text = "";

            CaptBox.Text += "All received: " + AllRecBytes + " B \r\n";

            CaptBox.Text += "All received TCP/UDP packets: " + AllRecTcpUdpPackets + " \r\n";
                        
            if (maxbps < 9000)
            {
                long maxBps = maxbps / 8;
                CaptBox.Text += "Max speed: " + maxBps + " B/s \r\n";
            }
            else
            {
                long maxkBps = (maxbps / 8) / 1024;
                CaptBox.Text += "Max speed: " + maxkBps + " kB/s \r\n";
            }
            CaptBox.Text += "Max packets/s speed: " + maxpps + " \r\n";
        }
                
    }
}
