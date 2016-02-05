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

namespace MoSoWT
{
    public partial class BL_Monitor_Form : Form
    {
        public BL_Monitor_Form()
        {
            InitializeComponent();
        }
        
        private void BL_start_Click(object sender, EventArgs e)
        {
            NetworkInterface[] infs = NetworkInterface.GetAllNetworkInterfaces();

            BL_monitor_TBox.Text = "";

            foreach (NetworkInterface i in infs)
            {
                if (i.Name.Contains("Bluetooth"))
                {

                    BL_monitor_TBox.Text += "Name: " + i.Name + "\r\n";
                    BL_monitor_TBox.Text += "Type: " + i.NetworkInterfaceType + "\r\n";
                    BL_monitor_TBox.Text += "Speed: " + i.Speed + "\r\n";
                    BL_monitor_TBox.Text += "\r\n";
                }
            }
        }

    }
}
