using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Graphics_Reznik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double xmin = double.Parse(textBox1.Text);//-2,4
            double xmax = double.Parse(textBox2.Text);//1
            double step = double.Parse(textBox3.Text);//0,2

            int count = (int)Math.Ceiling(Math.Abs((xmax - xmin) / step) + 1);
            double[] x = new double[count];
            double[] y = new double[count];
            
            for (int i = 0; i < count; i++)
            {
                x[i] = xmin + step * i;
                y[i] = 9 * (x[i] + 15 * Math.Sqrt(Math.Pow(x[i], 3) + Math.Pow(2.5, 3)));
            }
            chart1.ChartAreas[0].AxisX.Minimum = xmin;
            chart1.ChartAreas[0].AxisX.Maximum = xmax;
            chart1.ChartAreas[0].AxisX.MajorGrid.Interval = step;
            chart1.Series[0].Points.DataBindXY(x, y);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
