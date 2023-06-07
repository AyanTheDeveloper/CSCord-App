using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiscordMessenger;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CSCord_App
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            { 
                if(comboBox1.Text==string.Empty)
                {
                    MessageBox.Show("Please select a color!");
                }

            if (comboBox1.Text == "Green")
            {
                
                new DiscordMessage()
                       .SetUsername(textBox6.Text)
                       .SetAvatar(textBox1.Text)
                       .AddEmbed()
                         .SetTimestamp(DateTime.Now)
                         .SetTitle(textBox3.Text)
                         .SetDescription(textBox2.Text)
                         .SetFooter(textBox4.Text + " | Made with https://bit.ly/official-cscord")
                         .SetImage(textBox5.Text)
                         .SetThumbnail(textBox8.Text)
                         .SetAuthor(textBox9.Text)
                         .SetColor(1242520)
                         .Build()
                         .SendMessage(textBox7.Text);
            }
            if (comboBox1.Text == "Black")
            {
                new DiscordMessage()
                        .SetUsername(textBox6.Text)
                        .SetAvatar(textBox1.Text)
                        .AddEmbed()
                          .SetTimestamp(DateTime.Now)
                          .SetTitle(textBox3.Text)
                          .SetDescription(textBox2.Text)
                          .SetFooter(textBox4.Text + " | Made with https://bit.ly/official-cscord")
                          .SetImage(textBox5.Text)
                          .SetThumbnail(textBox8.Text)
                          .SetAuthor(textBox9.Text)
                          .SetColor(000000)
                          .Build()
                          .SendMessage(textBox7.Text);
            }
            if (comboBox1.Text == "Blue")
            {
                new DiscordMessage()
                        .SetUsername(textBox6.Text)
                        .SetAvatar(textBox1.Text)
                        .AddEmbed()
                          .SetTimestamp(DateTime.Now)
                          .SetTitle(textBox3.Text)
                          .SetDescription(textBox2.Text)
                          .SetFooter(textBox4.Text + " | Made with https://bit.ly/official-cscord")
                          .SetImage(textBox5.Text)
                          .SetThumbnail(textBox8.Text)
                          .SetAuthor(textBox9.Text)
                          .SetColor(25500)
                          .Build()
                          .SendMessage(textBox7.Text);
            }
            if (comboBox1.Text == "Yellow")
            {
                new DiscordMessage()
                         .SetUsername(textBox6.Text)
                         .SetAvatar(textBox1.Text)
                         .AddEmbed()
                           .SetTimestamp(DateTime.Now)
                           .SetTitle(textBox3.Text)
                           .SetDescription(textBox2.Text)
                           .SetFooter(textBox4.Text + " | Made with https://bit.ly/official-cscord")
                           .SetImage(textBox5.Text)
                           .SetThumbnail(textBox8.Text)
                           .SetAuthor(textBox9.Text)
                           .SetColor(16776960)
                           .Build()
                           .SendMessage(textBox7.Text);
            }
            if (comboBox1.Text == "Purple")
            {
                new DiscordMessage()
                         .SetUsername(textBox6.Text)
                         .SetAvatar(textBox1.Text)
                         .AddEmbed()
                           .SetTimestamp(DateTime.Now)
                           .SetTitle(textBox3.Text)
                           .SetDescription(textBox2.Text)
                           .SetFooter(textBox4.Text + " | Made with https://bit.ly/official-cscord")
                           .SetImage(textBox5.Text)
                           .SetThumbnail(textBox8.Text)
                           .SetAuthor(textBox9.Text)
                           .SetColor(10181046)
                           .Build()
                           .SendMessage(textBox7.Text);
            }
                if (comboBox1.Text == "Red")
                {
                    new DiscordMessage()
                           .SetUsername(textBox6.Text)
                           .SetAvatar(textBox1.Text)
                           .AddEmbed()
                             .SetTimestamp(DateTime.Now)
                             .SetTitle(textBox3.Text)
                             .SetDescription(textBox2.Text)
                             .SetFooter(textBox4.Text + " | Made with https://bit.ly/official-cscord")
                             .SetImage(textBox5.Text)
                             .SetThumbnail(textBox8.Text)
                             .SetAuthor(textBox9.Text)
                             .SetColor(15548997)
                             .Build()
                             .SendMessage(textBox7.Text);
                }
            }
            catch
            {
                MessageBox.Show("There was an error, make sure you fill the required fields.");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked==true)
            {
                textBox7.PasswordChar = (char)0; 
            }
            if (checkBox1.Checked==false)
            {
                textBox7.PasswordChar = Convert.ToChar("*");
            }
        }
    }
}
