using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSCordEmbedsHelper;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CSCord_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          
            textBox1.BorderStyle = BorderStyle.None;
             textBox2.BorderStyle = BorderStyle.None;
               textBox3.BorderStyle = BorderStyle.None;
                 textBox4.BorderStyle = BorderStyle.None;
                  textBox5.BorderStyle = BorderStyle.None;
                    textBox6.BorderStyle = BorderStyle.None;
                      textBox7.BorderStyle = BorderStyle.None;
                        textBox8.BorderStyle = BorderStyle.None;
                         textBox9.BorderStyle = BorderStyle.None;

        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;      // WS_EX_COMPOSITED
                return handleParam;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Process.Start("python.exe", Environment.CurrentDirectory + @"\CSCordCredits.exe");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void userControl1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            //hider1.Visible = true;
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            CSCord.webhooks webhooks = new CSCord.webhooks();
            // webhooks.embed(textBox1.Text, "", "1st Ever Message From The New CSCord App", textBox2.Text, textBox3.Text, textBox4.Text, 0);
            try
            {
                if (comboBox1.Text == string.Empty)
                {
                    MessageBox.Show("Please select a color!");
                }

                if (comboBox1.Text == "Green")
                {
                    new DiscordMessage()
                           .SetUsername(textBox5.Text)
                           .SetAvatar(textBox8.Text)
                           .AddEmbed()
                             .SetTimestamp(DateTime.Now)
                             .SetTitle(textBox2.Text)
                             .SetDescription(textBox3.Text)
                             .SetFooter(textBox4.Text + " | Made with https://bit.ly/official-cscord")
                             .SetImage(textBox6.Text)
                             .SetThumbnail(textBox7.Text)
                             .SetAuthor(textBox9.Text)
                             .SetColor(1242520)
                             .Build()
                             .SendMessage(textBox1.Text);
                }
                if (comboBox1.Text == "Black")
                {
                    new DiscordMessage()
                            .SetUsername(textBox5.Text)
                            .SetAvatar(textBox8.Text)
                            .AddEmbed()
                              .SetTimestamp(DateTime.Now)
                              .SetTitle(textBox2.Text)
                              .SetDescription(textBox3.Text)
                              .SetFooter(textBox4.Text + " | Made with https://bit.ly/official-cscord")
                              .SetImage(textBox6.Text)
                              .SetThumbnail(textBox7.Text)
                              .SetAuthor(textBox9.Text)
                              .SetColor(000000)
                              .Build()
                              .SendMessage(textBox1.Text);
                }
                if (comboBox1.Text == "Blue")
                {
                    new DiscordMessage()
                           .SetUsername(textBox5.Text)
                           .SetAvatar(textBox8.Text)
                           .AddEmbed()
                             .SetTimestamp(DateTime.Now)
                             .SetTitle(textBox2.Text)
                             .SetDescription(textBox3.Text)
                             .SetFooter(textBox4.Text + " | Made with https://bit.ly/official-cscord")
                             .SetImage(textBox6.Text)
                             .SetThumbnail(textBox7.Text)
                             .SetAuthor(textBox9.Text)
                             .SetColor(25500)
                             .Build()
                             .SendMessage(textBox1.Text);
         
                }
                if (comboBox1.Text == "Yellow")
                {
                    new DiscordMessage()
                           .SetUsername(textBox5.Text)
                           .SetAvatar(textBox8.Text)
                           .AddEmbed()
                             .SetTimestamp(DateTime.Now)
                             .SetTitle(textBox2.Text)
                             .SetDescription(textBox3.Text)
                             .SetFooter(textBox4.Text + " | Made with https://bit.ly/official-cscord")
                             .SetImage(textBox6.Text)
                             .SetThumbnail(textBox7.Text)
                             .SetAuthor(textBox9.Text)
                             .SetColor(16776960)
                             .Build()
                             .SendMessage(textBox1.Text);

                }
                if (comboBox1.Text == "Purple")
                {

                    new DiscordMessage()
                .SetUsername(textBox5.Text)
                .SetAvatar(textBox8.Text)
                .AddEmbed()
                  .SetTimestamp(DateTime.Now)
                  .SetTitle(textBox2.Text)
                  .SetDescription(textBox3.Text)
                  .SetFooter(textBox4.Text + " | Made with https://bit.ly/official-cscord")
                  .SetImage(textBox6.Text)
                  .SetThumbnail(textBox7.Text)
                  .SetAuthor(textBox9.Text)
                  .SetColor(10181046)
                  .Build()
                   .SendMessage(textBox1.Text);
                               
                }
                if (comboBox1.Text == "Red")
                {
        new DiscordMessage()
                            .SetUsername(textBox5.Text)
                            .SetAvatar(textBox8.Text)
                            .AddEmbed()
                              .SetTimestamp(DateTime.Now)
                              .SetTitle(textBox2.Text)
                              .SetDescription(textBox3.Text)
                              .SetFooter(textBox4.Text + " | Made with https://bit.ly/official-cscord")
                              .SetImage(textBox6.Text)
                              .SetThumbnail(textBox7.Text)
                              .SetAuthor(textBox9.Text)
                              .SetColor(15548997)
                              .Build()
                              .SendMessage(textBox1.Text);
                }
            }
            catch
            {
                MessageBox.Show("There was an error, make sure you fill the required fields.");
            }
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //hider1.Visible = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //hider1.Visible = true;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //hider1.Visible = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {

        }

        private void NormalM1PB_Click(object sender, EventArgs e)
        {
            Templates2PB.Visible = false;
            NM2PB.Visible = true;
            embeds2PB.Visible = false;
        }

        private void SpV1PB_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In the next update!", "Feature Unavailible");
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            Templates2PB.Visible = false;
            NM2PB.Visible = false;
            embeds2PB.Visible = true;
        }

        private void Templates1PB_Click(object sender, EventArgs e)
        {
            Templates2PB.Visible = true;
            NM2PB.Visible = false;
            embeds2PB.Visible = false;
        }

        private void DTB1_Click(object sender, EventArgs e)
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
        string color = "none";

        private void SpV1PB_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("In the next update!", "Feature Unavailible");
            
        }

        private void embeds1PB_Click(object sender, EventArgs e)
        {
            Templates2PB.Visible = false;
            NM2PB.Visible = false;
            embeds2PB.Visible = true;
        }

        private void NormalM1PB_Click_1(object sender, EventArgs e)
        {
            Templates2PB.Visible = false;
            NM2PB.Visible = true;
            embeds2PB.Visible = false;
        }

        private void Templates1PB_Click_1(object sender, EventArgs e)
        {
            Templates2PB.Visible = true;
            NM2PB.Visible = false;
            embeds2PB.Visible = false;
        }

        private void Templates2PB_Click(object sender, EventArgs e)
        {
             MessageBox.Show("We are sad to announce - to meet the deadline for the CSCord app we will need to cut this feature out until the next update. Sorry!", "Feature Unavailible");
        }

        private void SpV1PB_Click_2(object sender, EventArgs e)
        {
            MessageBox.Show("In the next update!", "Feature Unavailible");
        }

        private void DTB1_Click_1(object sender, EventArgs e)
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

        private void pictureBox23_Click(object sender, EventArgs e)
        {
       //     CSCordErrorHelper.ErrorHelper CSCordErrorHelper1 = new CSCordErrorHelper.ErrorHelper();
     //       CSCordErrorHelper1.ShowMb();
            //thats all.
            ;
        }

        private void pictureBox46_Click(object sender, EventArgs e)
        {
            color = "Black";
            comboBox1.Text = color;
        }

        private void pictureBox33_Click(object sender, EventArgs e)
        {
            color = "Blue";
            comboBox1.Text = color;
        }

        private void pictureBox42_Click(object sender, EventArgs e)
        {
            color = "Red";
            comboBox1.Text = color;
        }

        private void pictureBox43_Click(object sender, EventArgs e)
        {
            color = "Green";
            comboBox1.Text = color;
        }

        private void pictureBox44_Click(object sender, EventArgs e)
        {
            color = "Yellow";
            comboBox1.Text = color;
        }

        private void pictureBox45_Click(object sender, EventArgs e)
        {
            color = "Purple";
            comboBox1.Text = color;
        }
    }
}

