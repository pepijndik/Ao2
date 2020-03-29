using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lijndikte
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = panel1.CreateGraphics();
            panel1.Controls.Clear();
            circel c = new circel();
            c.LijnDikte = int.Parse(txt_dikte.Text);
            Pen pen = new Pen(Color.Black, c.LijnDikte);
            g.DrawEllipse(pen, 0, 0, 10, 10);

        }
    }
}
