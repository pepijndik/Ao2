using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rechthoek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_bereken_Click(object sender, EventArgs e)
        {
            //create new object Rechthoek
            rechthoek r = new rechthoek(double.Parse(txt_breedte.Text), double.Parse(txt_lengte.Text));
            txt_Omtrek.Text = r.om().ToString();
            txt_Oppervlak.Text = r.opp().ToString();
         
        }
    }
}
