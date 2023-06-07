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
                if (res == 1)
                {
                    
                    MessageBox.Show("Thank you for downloading the CSCord app! https://github.com/AyanTheDeveloper/CSCord-App/", "CSCord", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
                if (res != 1)
                {

                    MessageBox.Show("Please download the latest version of the CSCord app or you will not be able to use CSCord! https://github.com/AyanTheDeveloper/CSCord-App/releases", "Update Required", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
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
            try
            {
                CSCord.webhooks cscord = new CSCord.webhooks();
                //int coloR2 = Int16.Parse(textBox8.Text); // returns 100
                cscord.embed(textBox5.Text, textBox9.Text, textBox7.Text, textBox3.Text, textBox2.Text, textBox4.Text, 1242520);
            }
            catch
            {
                MessageBox.Show("webhook url is either incorrect or theres some other error", "Error");
            }
        
            }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (comboBox1.Text=="Green")
            {
                CSCord.webhooks cscord = new CSCord.webhooks();
                //int coloR2 = Int16.Parse(textBox8.Text); // returns 100
                cscord.embed(textBox5.Text, textBox9.Text, textBox7.Text, textBox3.Text, textBox2.Text, textBox4.Text, 1242520);
            }
            if (comboBox1.Text == "Black")
            {
                CSCord.webhooks cscord = new CSCord.webhooks();
                //int coloR2 = Int16.Parse(textBox8.Text); // returns 100
                cscord.embed(textBox5.Text, textBox9.Text, textBox7.Text, textBox3.Text, textBox2.Text, textBox4.Text, 000000);
            }
            if (comboBox1.Text == "Blue")
            {
                CSCord.webhooks cscord = new CSCord.webhooks();
                //int coloR2 = Int16.Parse(textBox8.Text); // returns 100
                cscord.embed(textBox5.Text, textBox9.Text, textBox7.Text, textBox3.Text, textBox2.Text, textBox4.Text, 25500);
            }
            if (comboBox1.Text == "Yellow")
            {
                CSCord.webhooks cscord = new CSCord.webhooks();
                //int coloR2 = Int16.Parse(textBox8.Text); // returns 100
                cscord.embed(textBox5.Text, textBox9.Text, textBox7.Text, textBox3.Text, textBox2.Text, textBox4.Text, 16776960);
              } 
                if (comboBox1.Text == "Purple")
                {
                    CSCord.webhooks cscord = new CSCord.webhooks();
                    //int coloR2 = Int16.Parse(textBox8.Text); // returns 100
                    cscord.embed(textBox5.Text, textBox9.Text, textBox7.Text, textBox3.Text, textBox2.Text, textBox4.Text, 10181046);
                }
            if (comboBox1.Text == "Red")
            {
                CSCord.webhooks cscord = new CSCord.webhooks();
                //int coloR2 = Int16.Parse(textBox8.Text); // returns 100
                cscord.embed(textBox5.Text, textBox9.Text, textBox7.Text, textBox3.Text, textBox2.Text, textBox4.Text, 15548997);
            }

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
            if (comboBox1.Text == "Green")
            {
                textBox1.Text = "!";
            }
            if (comboBox1.Text == string.Empty)
            {
                MessageBox.Show("Please enter in a color!", "Error");
            }
            if (comboBox1.Text == string.Empty)
            {
                MessageBox.Show("Please enter in a color!", "Error");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            CSCord.webhooks cscord = new CSCord.webhooks();
            try
            {

                MessageBox.Show("You do not have permission to access this button, because this button literally does not do anything, no joke its just for testing color codes.", "CSCord");

            }
            catch
            {
                
             }
        }
    }
}
