using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] getallenRij = new int[] { 2, 4, 6, 8, 10 };
        //Listbox Afdrukken
        private void afdrukkenRij(int[] getallenRij)
        {
            lstBox.Items.Clear();
            for (int i = 0; i < getallenRij.Length; i++)
            {
                lstBox.Items.Add(getallenRij[i]);
            }
        }

        //Laag naar hoog
        private void Btn1_Click(object sender, EventArgs e)
        {

            Array.Reverse(getallenRij);
            afdrukkenRij(getallenRij);
        }
        //button Hoog naar laag
        private void Btn2_Click(object sender, EventArgs e)
        {
            Array.Sort(getallenRij);
            afdrukkenRij(getallenRij);

        }
       
      

        private void LstBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
