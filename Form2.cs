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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        string webhookurl = "none";
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                CSCord.templates cscordTemplates = new CSCord.templates();
                cscordTemplates.fancyHelloWorld(webhookurl);
            }
            catch
            {
                MessageBox.Show("webhook url is either incorrect or theres some other error", "Error");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                CSCord.templates cscordTemplates = new CSCord.templates();
                cscordTemplates.helloworldMessage(webhookurl);
            }
            catch
            {
                MessageBox.Show("webhook url is either incorrect or theres some other error", "Error");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            webhookurl = textBox1.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                CSCord.templates cscordTemplates = new CSCord.templates();
                cscordTemplates.rulesEmbed(webhookurl);
            }
            catch
            {
                MessageBox.Show("webhook url is either incorrect or theres some other error", "Error");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                CSCord.templates cscordTemplates = new CSCord.templates();
                cscordTemplates.informationEmbed(webhookurl, textBox2.Text);
            }
            catch
            {
                MessageBox.Show("webhook url is either incorrect or theres some other error", "Error");
            }
        }
    }
}
