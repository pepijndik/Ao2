using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht5
{
    public partial class Form1 : Form
    {
        bool buttonAvg = true;
        //bool buttonSom = false;
        double gem = 0;
        double som = 0;
        double[] getallenRij = new double[] { 6.0, 4.3, 8.9, 6.7, 8.0 };
        public Form1()
        {
            InitializeComponent();
          
        }

        private void Btnsom_Click(object sender, EventArgs e)
        {
          listBox1.Items.Add("De som is:" + BepaalSom(getallenRij));
        }
        //SOM Functie's 

        private double BepaalSom(double[] getallenRij)
        {
          
                for (int i = 0; i < getallenRij.Length; i++)
                {
                    som += (getallenRij[i]);
                }
                
              
               
            return som;
        }

        //AVG Functie
        private double bepaalGemiddelde(double[] getallenRij)
        {
            ///
            return gem = som / getallenRij.Length;
        }
        //afdrukken getallen
            public void afdrukkenRij()
        {
            for(int i = 0; i< getallenRij.Length; i++)
            {
                listBox1.Items.Add("Het gemiddelde is: " + bepaalGemiddelde(getallenRij));
            }
        }
        //button avg click 
        private void Btnavg_Click(object sender, EventArgs e)
        {
            if (buttonAvg)
            {
                afdrukkenRij();
                buttonAvg = false;
            }
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
