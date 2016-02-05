using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoSoWT
{
    public partial class GUI : Form
    {
        public GUI()
        {
            InitializeComponent();
        }

        private Form Wifi_Monitor;
        private Form BL_Monitor;

        private void WiFi_Button_Click(object sender, EventArgs e)
        {
            WiFi_Monitor_Button.Enabled = false;
            Wifi_Monitor = new Wifi_Monitor();
            Wifi_Monitor.FormClosing += Wifi_Monitor_FormClosing;
            Wifi_Monitor.Show();
        }

        private void Wifi_Monitor_FormClosing(object sender, FormClosingEventArgs e)
        {
            WiFi_Monitor_Button.Enabled = true;
        }

        private void BL_Button_Click(object sender, EventArgs e)
        {
            BL_Monitor_Button.Enabled = false;
            BL_Monitor = new BL_Monitor();
            BL_Monitor.FormClosing += BL_Monitor_FormClosing;
            BL_Monitor.Show();
        }

        private void BL_Monitor_FormClosing(object sender, FormClosingEventArgs e)
        {
            BL_Monitor_Button.Enabled = true;
        }
    }
}
