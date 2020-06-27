using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medvedev_08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int imax = 100; // КОММЕНТ ДЛЯ ВТОРОЙ ВЕТКИ
            int t = 2;
            int amp = 50;
            int h = 40;
            int x0 = 20;
            int y0 = 2 * h + amp;
            double[] f = new double[imax * t + 10];

            for (int i = 0; i < imax * t; i++)
            { 
                f[i] = Math.Round(amp * Math.Sin(2 * Math.PI / imax * i)); 
            }

            Graphics g = this.panel1.CreateGraphics();
            g.Clear(Color.White);
            Pen pen = Pens.Blue;

            g.DrawString("График синусоиды", new Font("Arial", 14), Brushes.Red, 0, 0);

            g.DrawLine(new Pen(Brushes.Black, 2), x0, y0, x0 + imax * t, y0);
            g.DrawLine(new Pen(Brushes.Black, 2), x0, y0-amp, x0, y0+amp);
            for (int i = 0; i< imax * t; i++)
            { 
                int f1 = y0 - (int)f[i];
                int f2 = y0 - (int)f[i + 1];
                g.DrawLine(pen, x0 + i, f1, x0 + i + 1, f2);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int imax = 50;
            int t = 7;
            int amp = 10;
            int h = 40;
            int x0 = 60;
            int y0 = 6 * h + amp;
            double[] f = new double[imax * t + 10];

            for (int i = 0; i < imax * t; i++)
            {
                f[i] = Math.Round(amp * ((-1) * Math.Cos( 3 * (Math.PI / 6) / imax * i)) * Math.Exp( (Math.PI / 6) / imax * i));
            }

            Graphics g = this.panel1.CreateGraphics();
            g.Clear(Color.White);
            Pen pen = Pens.Blue;

            g.DrawString("График -cos(3x)*exp(x)", new Font("Arial", 14), Brushes.Red, 0, 0);

            g.DrawLine(new Pen(Brushes.Black, 2), x0, y0, x0 + imax * t, y0);
            g.DrawLine(new Pen(Brushes.Black, 2), x0, y0 - amp, x0, y0 + amp);
            for (int i = 0; i < imax * t; i++)
            {
                int f1 = y0 - (int)f[i];
                int f2 = y0 - (int)f[i + 1];
                g.DrawLine(pen, x0 + i, f1, x0 + i + 1, f2);

            }
        }
    }
}
