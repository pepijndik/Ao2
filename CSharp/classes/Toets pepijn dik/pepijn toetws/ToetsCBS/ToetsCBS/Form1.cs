using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToetsCBS
{
    /*
    * File: Form1
    * Items: listbox
    * Used classes:
    * Auto ,  Personenauto,  vrachtauto
    */
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            Personenauto p = new Personenauto("Renault", "Twingo", 2006, 5);
            //p.ControleLevensDuur();
            Vrachtauto v = new Vrachtauto("Renault", "Highspeedtruck", 2004, 1500);
            // v.ControleLevensDuur();
            lbxVoertuigenoverzicht.Items.Add(p.Show());
            lbxVoertuigenoverzicht.Items.Add(p.ControleLevensDuur());
            lbxVoertuigenoverzicht.Items.Add(v.Show());
            lbxVoertuigenoverzicht.Items.Add(v.ControleLevensDuur());

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void load()
        {
                   }

        private void Form1_Shown(object sender, EventArgs e)
        {
           
        }
    }
}
