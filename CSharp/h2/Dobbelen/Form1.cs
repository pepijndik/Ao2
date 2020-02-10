using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dobbelen
{
    public partial class Form1 : Form
    {
        /*
         * Made by pepijn dik
         * AO2B
         * Versie B

    */
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
           //Activeer Function Dobbel en geef het aantal
            int aantal = int.Parse(txtAantal.Text);
            dobbel(aantal);
        }

        //dobbel functie
        public void dobbel(int aantal)
        {
            //decaleer gem en aantalkeer6
            int aantalkeer6 = 0;
            double gem = 0;

            lstBox.Items.Clear();
            //Gooi de dobbel Random getal tussen 1 en 6 komt er uit
            Random gooi = new Random();
            for (int i = 0; i < aantal; i++)
            { 
                //Uitkomst van de gooi
                int uitkomst = gooi.Next(1, 7);
                //laat uitkomst zien in list box
                lstBox.Items.Add(uitkomst.ToString());

                //als 6 tel 1 bij op
                if (uitkomst == 6 )
                {
                    aantalkeer6++;
                }
                gem += uitkomst;
            }
            //reken gem uit
            gem = gem / aantal;
            

           //print gemiddelde afronden op 2 decimaal
            txtGem.Text = Math.Round(gem, 2).ToString();
             //print uit aantal keer dat 6 gegooid is
            aantal6.Text = aantalkeer6.ToString();
            
        }
    }
}
