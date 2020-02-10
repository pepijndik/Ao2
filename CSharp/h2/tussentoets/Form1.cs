using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tussentoets
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        //Array van kleuren 

        System.Drawing.Color[] kleuren = new Color[] { Color.Yellow, Color.Blue, Color.Red, Color.Green };
        // array plaats 
        int[] plaats = new int[] {80,200,320,460};
  
        //Maak potloden
        public void teken(int aantal, Graphics g)
        {
            for (int i = 0; i < aantal; i++)
            {
                //Convert kleuren naar SolidBrush om te tekenen
                SolidBrush kleur = new SolidBrush(kleuren[i]);

                //Ondeerkant potlood
                g.FillRectangle(kleur, plaats[i], 50, 50, 100);
        
                //Bovenkant 
              
                Point[] points = { new Point(plaats[i] + 20,15), new Point(plaats[i]-40, 60), new Point(plaats[i] + 80, 60)};
                g.FillPolygon(kleur, points);
            }
        }
        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = panel1.CreateGraphics();
            teken(4, g);
        }
    }
}
