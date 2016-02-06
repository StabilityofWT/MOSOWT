using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace MoSoWT
{
    public partial class Wifi_Server : Form
    {
        public Wifi_Server()
        {
            InitializeComponent();
        }

        private void Listen_Button_Click(object sender, EventArgs e)
        {
            TcpListener server = null;
            try
            {
                Status_textbox.Text = "";
                                               
                Int32 port = Int32.Parse(Port_textbox.Text);
                                
                server = new TcpListener(IPAddress.Any, port);
                                
                server.Start();
                                
                Byte[] bytes = new Byte[256];
                String data = null;
                                
                while (true)
                {
                    Console.WriteLine("Waiting for a connection...");
                                        
                    TcpClient client = server.AcceptTcpClient();

                    Console.WriteLine("Connected!");

                                        
                    data = null;
                                        
                    NetworkStream stream = client.GetStream();

                    int i;

                    while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
                    {
                        data = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
                        Console.WriteLine("Received: {0}", data);

                        data = "Sending OK";

                        byte[] msg = System.Text.Encoding.ASCII.GetBytes(data);

                        stream.Write(msg, 0, msg.Length);
                        Console.WriteLine("Sent: {0}", data);
                    }

                    client.Close();
                }
            }
            catch (SocketException exc)
            {
                Console.WriteLine("SocketException: {0}", exc);
            }
            finally
            {
                server.Stop();
            }

        }
    
    }
}
