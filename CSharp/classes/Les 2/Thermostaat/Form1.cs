using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thermostaat
{
    public partial class Form1 : Form
    {
        Thermostaat t1;
        Thermostaat t2;
        Thermostaat t3;
        Thermostaat t4;
        public Form1()
        {
            InitializeComponent();
            Graphics g = panel1.CreateGraphics();
             t1 = new Thermostaat(15,g, 50, 10);
             t2 = new Thermostaat(12,g, 150, 10);
             t3 = new Thermostaat(16, g, 250, 40);
            t4 = new Thermostaat(18,g, 60 , 40);


         
        }

        private void num_up_down_ValueChanged(object sender, EventArgs e)
        {

            bool checked1 = radioButton1.Checked;
            bool checked2 = radioButton2.Checked;
            bool checked3 = radioButton3.Checked;
            bool checked4 = radioButton4.Checked;
            if (checked1)
            {
                t1.Waarde = Convert.ToInt32(num_up_down.Value);
                t1.load();
            }
            if (checked2)
            {
                t2.Waarde = Convert.ToInt32(num_up_down.Value);
                t2.load();
            }
            if (checked3) 
            {
                t3.Waarde = Convert.ToInt32(num_up_down.Value);
                t3.load();
            }
            if (checked4)
            {
                t4.Waarde = Convert.ToInt32(num_up_down.Value);
                t4.load();
            }
        }
    }
}
