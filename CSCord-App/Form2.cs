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
            textBox1.BorderStyle = BorderStyle.None;
            textBox3.BorderStyle = BorderStyle.None;
        }

        private void SpV1PB_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In the next update!", "Feature Unavailible");

        }

        private void embeds1PB_Click(object sender, EventArgs e)
        {
            //Templates2PB.Visible = false;
            NM2PB.Visible = false;
            //embeds2PB.Visible = true;
        }

        private void NormalM1PB_Click(object sender, EventArgs e)
        {
            //Templates2PB.Visible = false;
            NM2PB.Visible = true;
            //embeds2PB.Visible = false;
        }

        private void Templates1PB_Click(object sender, EventArgs e)
        {
            //Templates2PB.Visible = true;
            NM2PB.Visible = false;
            //embeds2PB.Visible = false;
        }

        private void Templates2PB_Click(object sender, EventArgs e)
        {
            MessageBox.Show("We are sad to announce - to meet the deadline for the CSCord app we will need to cut this feature out until the next update. Sorry!", "Feature Unavailible");
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
        private void embeds2PB_Click(object sender, EventArgs e)
        {

        }

        private void SpV1PB_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("In the next update!", "Feature Unavailible");
        }

        private void Templates2PB_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("We are sad to announce - to meet the deadline for the CSCord app we will need to cut this feature out until the next update. Sorry!", "Feature Unavailible");
        }

        private void embeds1PB_Click_1(object sender, EventArgs e)
        {
          //  Form1 frm1 = new Form1();
         
           // frm1.Show();
            this.Close();
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

        private void Templates1PB_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("We are sad to announce - to meet the deadline for the CSCord app we will need to cut this feature out until the next update. Sorry!", "Feature Unavailible");
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            if (textBox1.PasswordChar == Convert.ToChar('\u0000'))
            {

                textBox1.PasswordChar = Convert.ToChar("•");
            }
            else
            {
                textBox1.PasswordChar = '\0';
                //textBox1.PasswordChar = '\0';
            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            CSCord.webhooks cscord = new CSCord.webhooks();
            cscord.message(textBox1.Text, textBox3.Text);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
