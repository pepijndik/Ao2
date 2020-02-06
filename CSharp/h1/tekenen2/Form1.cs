using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tekenen2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = panel1.CreateGraphics();

            //onderkant huis
            SolidBrush sb_groen = new SolidBrush(Color.Green);
            g.FillRectangle(sb_groen,15,55,50,50);

            //Boven kant
            SolidBrush sb_blauw = new SolidBrush(Color.Blue);
            Point[] points = { new Point(40, 15), new Point(0, 60), new Point(80, 60) };
            g.FillPolygon(sb_blauw, points);
        }
    }
}
