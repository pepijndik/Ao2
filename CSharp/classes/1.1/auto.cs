using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace _1._1
{
    class auto
    {
        // variabalen van de auto
        private string _naam = "Peugeot 504";
        private int _aantalDeuren = 3;
        // eigenschappen van de auto
        private double _prijs;
        private Color _kleur = Color.Red;
        public double berekenCatalogusWaarde(double prijs)
        {
            return _prijs = Math.Round(prijs * 1.190, 2);
        }
    }
}
