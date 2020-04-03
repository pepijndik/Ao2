using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Spaargeld
{
    class Spaargeld
    {
        /* *Maak een klasse spaargeld. Neem daarin de fields op: x,y, naam, saldo en rekeningnummer.
         * Bouw een getter en setter zodat de afzonderlijke saldo’s worden opgehoogd.
         */
        private float _x;
        private float _y;
        private string _naam;
        private double _saldo;
        private double _rekeningnummer;

        //Construct
        public Spaargeld(string naam, double rekeningnummer, double saldo, float x , float y)
        {
            this._naam = naam;
            this._saldo = saldo;
            this._rekeningnummer = rekeningnummer;
            X = x;
            Y = y;
        }
        //Getters  and setters
        public string Naam
        {
            get { return _naam; }
            set { _naam = value; }
        }

        public float X
        {
            get { return _x; }
            set { _x = value; }
        }
        public float Y
        {
            get { return _y; }
            set { _y = value; }
        }
        public double Saldo
        {
            get { return _saldo; }
            set { _saldo = value; }
        }
        public double Rekeningnummer
        {
            get { return _rekeningnummer; }
            set { _rekeningnummer = value; }
        }
        public  void load(Graphics g)
        {
                
               string text_sp1 = "RekeningHouder: " + Naam + " RekeningNummer: " + Rekeningnummer + " " +
                "    Saldo: " + Saldo;
            using (Font font1 = new Font("Arial", 8, FontStyle.Bold, GraphicsUnit.Point))
            {
                RectangleF rectF1 = new RectangleF(X, Y, 200, 60);
                g.DrawString(text_sp1, font1, Brushes.Blue, rectF1);
                g.DrawRectangle(Pens.Red, Rectangle.Round(rectF1));
            }
        }
       
    }
}
