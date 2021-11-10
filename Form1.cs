using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;
using ServiceMtk_P1_20190140101;

namespace ServerConfigForm_P5_101
{
    public partial class Form1 : Form
    {
        private ServiceHost Host;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnOn_Click(object sender, EventArgs e)
        {
            Host = new ServiceHost(typeof(Matematik));

            labelOnOrOff.Text = "Server ON";
            labelKet.Text = " Klik OFF untuk mematikan Server";
            Host.Open();
            btnOn.Enabled = false;
            btnOff.Enabled = true;
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            btnOn.Enabled = true;
            btnOff.Enabled = false;
            Host.Close();
            labelKet.Text = "Klik ON untuk menjalankan Server";
            labelOnOrOff.Text = "Server OFF";
        }
    }
}
