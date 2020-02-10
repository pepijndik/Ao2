using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IngebouwdeFunctieSplit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            txtSpatie.Text = "";
           String text = txtinvoer.Text;
        
            string[]  words = text.Split('a');

            foreach (var word in words)
            {
                txtSpatie.Text += word;
           
            }
        }
    }
}
