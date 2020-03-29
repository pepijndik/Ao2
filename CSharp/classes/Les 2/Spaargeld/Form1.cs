using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spaargeld
{
    public partial class Form1 : Form
    {
     
        Spaargeld sp1 = new Spaargeld();
        Spaargeld sp2 = new Spaargeld();
        Spaargeld sp3 = new Spaargeld();
        Graphics g;
        public Form1()
        {
            InitializeComponent();
         
        }
  
        //Maak alle rekeningen aan ;)
        private void btn_laad_Click(object sender, EventArgs e)
        {
            Graphics g = panel1.CreateGraphics();

            sp1.Naam = "Ramon";
            sp2.Naam = "Klaas";
            sp3.Naam = "Pepijn";
            sp3.Rekeningnummer = 34567811;
            sp2.Rekeningnummer = 23092001;
            sp1.Rekeningnummer = 34567865;
            sp1.Saldo = 0;
            sp2.Saldo = 150;
            sp3.Saldo = 10000;
       
            sp1.Y = 10;
            sp2.Y = 10;
            sp3.Y = 80;
            sp1.X = 30;
            sp2.X = 250;
            sp3.X = 30;

         
            //Load Rekeningen
            sp1.load(g);
            sp2.load(g);
            sp3.load(g);
        }

       public void clear()
        {
            panel1.Controls.Clear();
        }
        private void btn_storten_Click(object sender, EventArgs e)
        {
            clear();
            Graphics g = panel1.CreateGraphics();

            bool checked1 = radioButton1.Checked;
            bool checked2 = radioButton2.Checked;
            bool checked3 = radioButton3.Checked;
            if (checked1)
            {
                sp1.Saldo += double.Parse(txt_bedrag.Text);

                sp1.load(g);
            }
            if (checked2)
            {
              
                sp2.Saldo += double.Parse(txt_bedrag.Text);
            }
            if (checked3)
            {
                clear();
                sp3.Saldo += double.Parse(txt_bedrag.Text);
            }
        }
    }
}
