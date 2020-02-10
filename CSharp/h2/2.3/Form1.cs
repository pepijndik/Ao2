using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2._3
{
    public partial class Form1 : Form
    {
        public Form1()  
        {
            InitializeComponent();
        }
        String[] Studenten = new String[] { "Pepijn", "Samir", "bob", "Thijs", "Mohammed" };
        private void BtnShow_Click(object sender, EventArgs e)
        {
            lstbox.Items.Clear();
            for (int i = 0; i < Studenten.Length; i++)
            {
                lstbox.Items.Add(Studenten[i]);
            }
        }
    }
}
