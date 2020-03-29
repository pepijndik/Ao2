using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kassakorting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            korting k = new korting();
            MessageBox.Show(k.bereken(double.Parse(txtKorting.Text), double.Parse(txtPrijs.Text)).ToString());
        }
    }
}
