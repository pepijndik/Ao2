using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Thermostaat
{
    /* 
     * *Schrijf een classe Thermostaat die de huidige temperatuur uitleest in een apart formulier. 
     * Deze waarde kan afzonderlijk worden ingesteld. 
     * Vervolgens maak je 4 instanties aan van een thermostaat die afzonderlijk zijn te regelen. 
     * Gebruik hiervoor een getter en een setter.
     * De huidige temperatuur is dan toevallig de temperatuur die je hebt ingevoerd. 
     * Verder kunnen de knoppen van elke thermostaat afzonderlijk worden bediend.
     * 1 thermostaat voor het woongedeelte
     * 1 thermostaat voor de douche.
     * 1 thermostaat voor de grootste slaapkamer
     * 1 thermostaat voor de zolder.

 */
    class Thermostaat
    {

        private   int _waarde;
        private Graphics _g;
        private int _x;
        private int _y;
     
        public int Waarde
        {
            get { return _waarde; }
            set { _waarde = value; }
        }

        public int X
        {
            get { return _x; }
            set { _x = value; }
        }

        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }



        public Graphics G
        {
            get { return _g; }
            set { _g = value; }
        }
        public Thermostaat(int Waarde, Graphics g, int x, int y)
        {
            this._waarde = Waarde;
            this._g = g;
            X = x;
            Y = y;
        }

       public void load()
        {
            // Create pen.
            Pen blackPen = new Pen(Color.Black, 3);

            using (Font font1 = new Font("Arial", 8, FontStyle.Bold, GraphicsUnit.Point))
            {

                StringFormat stringFormat = new StringFormat();
                stringFormat.Alignment = StringAlignment.Center;
                stringFormat.LineAlignment = StringAlignment.Center;

                Rectangle rect = new Rectangle(X, Y, 50, 50);
                G.DrawString("Temp: " + Waarde, font1, Brushes.Blue, rect, stringFormat);
                // Create rectangle for ellipse.
             

                // Draw ellipse to screen.
                G.DrawEllipse(blackPen, rect);
            }
        }
    }
}
