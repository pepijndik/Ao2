using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tekenen1
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

            //Draw Circel 
            SolidBrush sb_rood = new SolidBrush(Color.Red);
            g.FillEllipse(sb_rood, 100, 70,100,100);

            //Draw rectangle

            g.FillRectangle(sb_rood, 165, 130, 35,250);
        }
        
    }
}
