using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace opdracht5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnOmdraaien_Click(object sender, EventArgs e)
        {
            String eind = "";
            String begin = txtBegin.Text;
            for (int i = begin.Length - 1; i >= 0; i--)

            {

                eind = eind + begin[i];

            }
           
            txtOmgedraaid.Text = eind;
        }
      
    }
}
