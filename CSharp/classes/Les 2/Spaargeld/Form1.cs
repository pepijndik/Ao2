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
     
        Spaargeld sp1 = new Spaargeld("Ramon", 34567811, 0, 30 ,10);
        Spaargeld sp2 = new Spaargeld("Klaas", 23092001, 150,250,10);
        Spaargeld sp3 = new Spaargeld("Pepijn", 34567865,10000,30,80);
        Graphics g;
        public Form1()
        {
            InitializeComponent();
         
        }
  
        //Maak alle rekeningen aan ;)
        private void btn_laad_Click(object sender, EventArgs e)
        {
            Graphics g = panel1.CreateGraphics();     
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
