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

        private void btnCalcu_Click(object sender, EventArgs e)
        {
           double lengt;
            double breedte;
            lengt = Double.Parse(txtLengte.Text);
            breedte = double.Parse(txtBreedte.Text);
            Rechthoek r = new Rechthoek();
            txtOmtrek.Text = r.omtrek(lengt, breedte).ToString();
            txtOppervlak.Text = r.oppervalk(lengt, breedte).ToString();
        }
    }
}
