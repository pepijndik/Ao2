using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        Random remove = new Random();
        private void Button1_Click(object sender, EventArgs e)
        {
            String[] Studenten = new String[] { "Pepijn", "Samir", "bob", "Thijs", "Mohammed" };
            lstBox.Items.Clear();
            int getal = remove.Next(1, Studenten.Length);
            Studenten[getal] = "======";
            for (int i = 0; i < Studenten.Length; i++)
            {
              
                lstBox.Items.Add(Studenten[i]);
            }
        }
    }
}
