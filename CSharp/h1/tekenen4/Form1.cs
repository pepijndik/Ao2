using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tekenen4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            panel1.Refresh();
            //begin
            int x = int.Parse(txtX.Text);
            int y = int.Parse(txtY.Text);
            //Eind
            int xeind = int.Parse(txtXeind.Text);
            int yeind = int.Parse(txtYeind.Text);
            Pen penred = new Pen(Color.Red);
            Graphics g = panel1.CreateGraphics();
            g.DrawLine(penred, x, y, xeind, yeind);
        }
    }
}
