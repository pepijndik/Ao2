using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cirkel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            circel c = new circel();
           
            txtOmtrek.Text = c.omtrek(double.Parse(txtStraal.Text)).ToString();
            txtOppervlakte.Text = c.oppervlak(double.Parse(txtStraal.Text)).ToString();
        }
    }
}
