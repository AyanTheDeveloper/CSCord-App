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
    public partial class Form3 : Form
    {
        Form opener;
        public Form3()
        {
            
            InitializeComponent();
            opener = ParentForm;
        }

        
       
        private void button1_Click(object sender, EventArgs e)
        {
            opener.Close();
            Form1 frm1 = new Form1();
            frm1.Show();
        }
    }
}
