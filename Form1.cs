using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSCord_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string webhookurl = "none";
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                CSCord.webhooks cscord = new CSCord.webhooks();
                cscord.Spam(webhookurl, textBox1.Text);
            }
            catch
            {
                MessageBox.Show("webhook url is either incorrect or theres some other error", "Error");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                CSCord.webhooks cscord = new CSCord.webhooks();
                cscord.message(webhookurl, textBox1.Text);
            }
            catch
            {
                MessageBox.Show("webhook url is either incorrect or theres some other error", "Error");
            }
        }
    }
}
