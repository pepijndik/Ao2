using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      
        private void BtnMAKE_Click(object sender, EventArgs e)
        {
            int getal2 = int.Parse(txtbox1.Text);
            Random toeval = new Random();
            

            for(int i = 0; i < getal2; i++)
            {
                int getal = toeval.Next(1, getal2);
                lstBox.Items.Add(getal);
            }
        }
    }
}
