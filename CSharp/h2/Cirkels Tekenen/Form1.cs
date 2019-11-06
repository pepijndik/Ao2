using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cirkels_Tekenen
{
    public partial class Form1 : Form
    {

        /*
         * Made by: pepijn dik
         * Versie B 
         * AO2B
        */
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnTeken_Click(object sender, EventArgs e)
        {
            //Geef aan welk panel er getekend moet worden
            Graphics g = panel1.CreateGraphics();
            teken(10, g);
            
        
        }
        //Maak Circles
        public void teken(int aantal,Graphics g) {
   
            panel1.Refresh();
            //Haal X en Y op uit de velden
            int X = int.Parse(txtX.Text);
            int y = int.Parse(txtY.Text);
            int straal = 10;
           
            //Teken 10 circels
            for (int i = 0; i < aantal; i++)
            {
                straal += 10;
        
                //de kleur van de circels
                Pen pen = new Pen(Color.Red);
                g.DrawEllipse(pen, X, y, straal, straal);
            }
        }
        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }
    }
}
