using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntelektikaUzduotis2
{
    public partial class Form1 : Form
    {
        public bool status = false;
        private int pointSize = 3;
        private List<Elemantas> elemantai;
        Elemantas naujas;
        public Form1()
        {
            InitializeComponent();
            elemantai = new List<Elemantas>();
            elemantai.Add(new Elemantas("e1", 1, 2, true));
            elemantai.Add(new Elemantas("e3", 3, 4, true));
            elemantai.Add(new Elemantas("e4", 6, 4, true));
            elemantai.Add(new Elemantas("e5", 2, 1, false));
            elemantai.Add(new Elemantas("e6", 4, 1, false));
            elemantai.Add(new Elemantas("e7", 5, 2, false));

            status = true;
            panel1.Refresh();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            float x1;
            float.TryParse(inputX1.Text, out x1);

            float x2;
            float.TryParse(inputX2.Text, out x2);

            int k;
            int.TryParse(inputK.Text, out k);

            naujas = new Elemantas("naujas", x1, x2, false);
            foreach (Elemantas el in elemantai)
            {
                el.D1(naujas);
                el.D2(naujas);
                el.D3(naujas);
            }
            List<Elemantas> d1Elemantai = elemantai.OrderBy(t => t.d1).ToList().Take(k).ToList();
            List<Elemantas> d2Elemantai = elemantai.OrderBy(t => t.d2).ToList().Take(k).ToList();
            List<Elemantas> d3Elemantai = elemantai.OrderBy(t => t.d3).ToList().Take(k).ToList();

            double rezD1 = d1Elemantai.Average(t => t.posible ? 1 : 0);
            double rezD2 = d2Elemantai.Average(t => t.posible ? 1 : 0);
            double rezD3 = d3Elemantai.Average(t => t.posible ? 1 : 0);

            rezultatas.Text = "rezD1: " + rezD1 + "  rezD2 " + rezD2+" rezD3 " + rezD3;

            status = true;
            panel1.Refresh();
           

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (status)
            {
                Graphics g = e.Graphics;
                foreach(Elemantas el in elemantai)
                {
                    g.FillRectangle(el.posible? Brushes.Green: Brushes.Red,(el.x1*50), 500 - (el.x2*50), pointSize, pointSize);
                }
                if (naujas != null)
                {
                    g.FillRectangle(Brushes.Blue,  (naujas.x1 * 50), 500 - (naujas.x2 * 50), pointSize, pointSize);
                }
                g.Dispose();
            }

        }
    }
}
