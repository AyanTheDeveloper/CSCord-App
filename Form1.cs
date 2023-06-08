using DiscordMessenger;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CSCord_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            try
            {
                WebRequest request = WebRequest.Create("https://raw.githubusercontent.com/AyanTheDeveloper/CSCord/master/versionCheckerValue");
                WebResponse response = request.GetResponse();
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                var responseFromServer = reader.ReadToEnd();
                MessageBox.Show("Updater responded with: " + responseFromServer, "Update Checker");
                int res = Convert.ToInt32(responseFromServer);
                if (res == 2)
                {
                    
                    MessageBox.Show("Thank you for downloading the CSCord app! https://github.com/AyanTheDeveloper/CSCord-App/", "CSCord", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
                if (res != 2)
                {

                    MessageBox.Show("Please download the latest version of the CSCord app or you will not be able to use CSCord! https://github.com/AyanTheDeveloper/CSCord-App/releases", "Update Required", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    this.Close();
                }
                WebRequest request2 = WebRequest.Create("https://raw.githubusercontent.com/AyanTheDeveloper/CSCord-App/master/AppServiceStatus");
                WebResponse response2 = request2.GetResponse();
                Stream dataStream2 = response2.GetResponseStream();
                StreamReader reader2 = new StreamReader(dataStream2);
                var responseFromServer2 = reader2.ReadToEnd();
                MessageBox.Show("Service responded with: " + responseFromServer2, "Server Status");
                if (responseFromServer2=="Maintenence\n")
                {
                    MessageBox.Show("Our service is currently in maintence, in preparation for an update or fix, please join our discord for live updates. https://discord.gg/m86NNb2Rhy", "Service in Maintenence");
                    this.Close();
                }
                else if (responseFromServer2=="Shut Down\n")
                {
                    MessageBox.Show("Service is currently Shut Down, please join our discord for live updates. https://discord.gg/m86NNb2Rhy", "Service Down");
                    this.Close();

                }
            }
            catch
            {
                Exception ex = new Exception();
                MessageBox.Show("No internet! Please check your  internet and try again." + ex, "Internet Checker", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                this.Close();
            }
        }
        string webhookurl = "none";
        string color = "1242520";
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming soon, SPAM FOR EMBEDS!", "Sorry For The Inconvinience!");
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

        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.webhookurl = webhookurl;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            webhookurl = textBox5.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            CSCord.advanced cscordAdvanced = new CSCord.advanced();
            try
            {

            MessageBox.Show("You do not have permission to access this button, because this button literally does not do anything, no joke its just for testing color codes.", "CSCord");
                
            }
            catch
            {

            }
            
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.Show();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("V.0.3 ALPHA: Added a checker to check if our servers our down or in maintenence", "Patch Notes");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox5.PasswordChar = (char)0;
            }
            if (checkBox1.Checked == false)
            {
                textBox5.PasswordChar = Convert.ToChar("*");
            }
        }
    }
}
