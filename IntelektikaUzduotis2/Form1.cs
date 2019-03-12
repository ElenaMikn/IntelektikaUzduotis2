using LiteDB;
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
        private string connectionString;
        public Form1()
        {
            InitializeComponent();
            status = true;
            //createDB();
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

            int d1Grupe = GetGrupe(rezD1);
            int d2Grupe = GetGrupe(rezD2);
            int d3Grupe = GetGrupe(rezD3);
            string isvada= "Neaisku";
            if ((d1Grupe + d2Grupe + d3Grupe) == 3)
            {
                isvada = "Teigiamas";
                naujas.posible = true;
                elemantai.Add(naujas);
            }
            else if ((d1Grupe + d2Grupe + d3Grupe) == 3)
            {
                isvada = "Neigiamas";
                naujas.posible = false;
                elemantai.Add(naujas);
            }
            rezultatas.Text = "pagal D1: " + GetGrupeString(d1Grupe) + "  D2: " + GetGrupeString(d2Grupe) + " D3: " + GetGrupeString(d3Grupe)+ ". Galutine išvada: "+ isvada;
            

            status = true;
            panel1.Refresh();
           

        }
        private string GetGrupeString(int rez)
        {
            if (rez==1)
            {
                return "Teigiamas";
            }
            if(rez==0)
            {
                return "Neigiamas";
            }
            return "Neaisku";
        }
        private int GetGrupe(double rez)
        {
            if (rez > 0.5)
            {
                return 1;
            }
            if (rez < 0.5)
            {
                return 0;
            }
            return -1;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (status && elemantai!=null)
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
            dataGridView();
           
        }
        private void dataGridView()
        {
            if (elemantai != null)
            {
                dataGridView1.Rows.Clear();
                foreach (Elemantas el in elemantai)
                {
                    dataGridView1.Rows.Add(el.name, el.x1, el.x2, el.posible ? "+" : "-");
                }
            }
        }
        private void InsertIntoLitleDB()
        {
            if (connectionString == "") return;
            
                using (var db = new LiteRepository(connectionString))
                {
                    foreach (Elemantas el in elemantai)
                    {
                        db.Upsert(el);
                    }

                }
            
        }
        private void GetFromLitledb()
        {
            if (connectionString == "") return;
            using (var db = new LiteDatabase(connectionString))
            {
                var collection = db.GetCollection<Elemantas>("Elemantas");
                elemantai = new List<Elemantas>();
                foreach (Elemantas co in collection.FindAll().OrderBy(x => x.name))
                {
                    elemantai.Add(co);

                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string selectedDB = comboBox1.SelectedItem.ToString();
            if (selectedDB != "")
            {
                connectionString = "../../"+selectedDB+".db";
                GetFromLitledb();
            }
            panel1.Refresh();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string selectedDB = comboBox1.SelectedItem.ToString();
            if (selectedDB != "")
            {
                connectionString = "../../" + selectedDB + ".db";
                InsertIntoLitleDB();
            }
        }
        private void createDB()
        {
           elemantai = new List<Elemantas>(); // pirma imtis
           elemantai.Add(new Elemantas("e1", 1, 2, true));
           elemantai.Add(new Elemantas("e2", 3, 4, true));
           elemantai.Add(new Elemantas("e3", 6, 4, true));
           elemantai.Add(new Elemantas("e4", 2, 1, false));
           elemantai.Add(new Elemantas("e5", 4, 1, false));
           elemantai.Add(new Elemantas("e6", 5, 2, false));

            connectionString = "../../Mokymo imtis 1.db";
            InsertIntoLitleDB();

            elemantai = new List<Elemantas>();
            elemantai.Add(new Elemantas("e1", 5, 1, true));
            elemantai.Add(new Elemantas("e2", 3, 3, true));
            elemantai.Add(new Elemantas("e3", 0, 3, true));
            elemantai.Add(new Elemantas("e4", 4, 0, false));
            elemantai.Add(new Elemantas("e5", 2, 0, false));
            elemantai.Add(new Elemantas("e6", 1, 1, false));
            connectionString = "../../Mokymo imtis 2.db";
            InsertIntoLitleDB();

            elemantai = new List<Elemantas>();
            elemantai.Add(new Elemantas("e1", 0, 2, true));
            elemantai.Add(new Elemantas("e2", 2, 0, true));
            elemantai.Add(new Elemantas("e3", 5, 0, true));
            elemantai.Add(new Elemantas("e4", 1, 3, false));
            elemantai.Add(new Elemantas("e5", 3, 3, false));
            elemantai.Add(new Elemantas("e6", 4, 2, false));
            connectionString = "../../Mokymo imtis 3.db";
            InsertIntoLitleDB();

            elemantai = new List<Elemantas>();
            elemantai.Add(new Elemantas("e1", 6, 3, true));
            elemantai.Add(new Elemantas("e2", 4, 1, true));
            elemantai.Add(new Elemantas("e3", 1, 1, true));
            elemantai.Add(new Elemantas("e4", 5, 4, false));
            elemantai.Add(new Elemantas("e5", 3, 4, false));
            elemantai.Add(new Elemantas("e6", 2, 3, false));
            connectionString = "../../Mokymo imtis 4.db";
            InsertIntoLitleDB();
        }

        private void DataGridView1_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {

        }

        private void DataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

        }
    }
}
