using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_bereken_Click(object sender, EventArgs e)
        {
            auto a = new auto();
            double prijsTekst;
            prijsTekst = Double.Parse(textBox1.Text);
            prijsTekst = a.berekenCatalogusWaarde(prijsTekst);
            MessageBox.Show("" + prijsTekst);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getal g = new getal();
            double getalTekst;
            double dubbel;
            double helft;
            double kwa;
            getalTekst = Double.Parse(textBox1.Text);
            dubbel = g.dubbel(getalTekst);
            helft = g.helft(getalTekst);
            kwa = g.kwadraad(getalTekst);
            lstbox.Items.Add("Methode dubbel " +dubbel);
            lstbox.Items.Add("Methode helft " + helft);
            lstbox.Items.Add("Methode kwa " + kwa);
        }
    }
}
