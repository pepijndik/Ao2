using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_excute_Click(object sender, EventArgs e)
        {
            bmi b = new bmi(double.Parse(txt_lengte.Text), double.Parse(txt_gewicht.Text));
            txt_bmi.Text = b.bereken().ToString();
            txt_cat.Text = b.check();
            
        }
    }
}
