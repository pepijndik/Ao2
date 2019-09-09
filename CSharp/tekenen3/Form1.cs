using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tekenen3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Btndraw_Click(object sender, EventArgs e)
        {
            panel1.Refresh();

            int straal = int.Parse(txtStaal.Text);
            Pen pen = new Pen(Color.Red);
            SolidBrush sldBrush1 = new SolidBrush(Color.Red);
            Graphics g = panel1.CreateGraphics();
            g.DrawEllipse(pen, 0, 0, straal, straal);

        }

        private void TxtStaal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
