using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lijstvannamen
{
    public partial class Form1 : Form
    {

        /*
         * Made by pepijn dik
         * AO2B
         * VERSIE B
         */
        public Form1()
        {
            InitializeComponent();
        }
        //2 arrays
        String[] Studenten = new String[] { "Thomas", "Michiel", "Maria", "Josje" };
        String[] omgekeerde = new string[] {"","","","",""};
        
        private void showStuden(String[] studenten)
        {
            lstBox.Items.Clear();
            lstBoxResultaat.Items.Clear();
            for (int i = 0; i < studenten.Length; i++)
            {
                //voeg woorden toe aan lstbox
                lstBox.Items.Add(studenten[i]);
                String eind = "";
                //haal elk woord uit de array
                String begin = studenten[i];
                //Omgekeerde lus
                for (int getal = begin.Length - 1; getal >= 0; getal--)

                {
                    //zet letters terug
                    eind = eind + begin[getal];

                }

                omgekeerde[i] = eind;
                //print omgekeerd weer uit
                lstBoxResultaat.Items.Add(omgekeerde[i]);
            }
        }
        private void BtnOmkeren_Click(object sender, EventArgs e)
        {
            //voer functie uit
            showStuden(Studenten);
        }


    }
}
