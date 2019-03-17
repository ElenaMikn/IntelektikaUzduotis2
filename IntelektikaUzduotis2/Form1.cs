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
        private int pointSize = 4;
        private List<Elementas> elementai;
        Elementas naujas;
        private string connectionString;
        public Form1()
        {
            InitializeComponent();
            panel1.Refresh();
//             createDB();
        }

        private void buttonSkaiciuoti_Click(object sender, EventArgs e)
        {
            float x1;
            float.TryParse(inputX1.Text, out x1);

            float x2;
            float.TryParse(inputX2.Text, out x2);

            int k;
            int.TryParse(inputK.Text, out k);

            if (x1 < 0 || x2 < 0 || k < 0)
            {
                MessageBox.Show("Blogai suvesti duomenis");
            }

            naujas = new Elementas("naujas", x1, x2, false);
            //lyginame naujai sukurta elementa su turimais, gautus atstumus saugome senuose elementuose
            foreach (Elementas el in elementai)
            {
                el.D1(naujas);
                el.D2(naujas);
                el.D3(naujas);
            }
            //Elementus surusiuojam (pagal skirtingus gautus atstumus), paimame k elemetu,
            List<Elementas> d1Elementai = elementai.OrderBy(t => t.d1).Take(k).ToList();
            List<Elementas> d2Elementai = elementai.OrderBy(t => t.d2).Take(k).ToList();
            List<Elementas> d3Elementai = elementai.OrderBy(t => t.d3).Take(k).ToList();

            //skaiciuojam vidurkius gautu listu
            double averageD1 = d1Elementai.Average(t => t.posible ? 1 : 0);
            double averageD2 = d2Elementai.Average(t => t.posible ? 1 : 0);
            double averageD3 = d3Elementai.Average(t => t.posible ? 1 : 0);

            //gauname grupe pagal gauta vidurki
            int d1Grupe = GetGrupe(averageD1);
            int d2Grupe = GetGrupe(averageD2);
            int d3Grupe = GetGrupe(averageD3);

            string isvada = "Neaisku";
            if ((d1Grupe + d2Grupe + d3Grupe) == 3)
            {
                isvada = "Teigiamas";
                naujas.posible = true;
                elementai.Add(naujas);
            }
            else if ((d1Grupe + d2Grupe + d3Grupe) == 0)
            {
                isvada = "Neigiamas";
                naujas.posible = false;
                elementai.Add(naujas);
            }

            rezultatas.Text = "pagal D1: " + GetGrupeString(d1Grupe) + "  D2: " + GetGrupeString(d2Grupe) + " D3: " + GetGrupeString(d3Grupe) + ". Galutine išvada: " + isvada;
            panel1.Refresh();
        }
        //gauname grupes pavadinimą
        private string GetGrupeString(int rez)
        {
            if (rez == 1)
            {
                return "Teigiamas";
            }
            if (rez == 0)
            {
                return "Neigiamas";
            }
            return "Neaisku";
        }
        //apskaiciuojame grupe
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
        //perpaisome taskus
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (elementai != null)
            {
                Graphics g = e.Graphics;
                foreach (Elementas el in elementai)
                {
                    g.FillRectangle(el.posible ? Brushes.Red : Brushes.Blue, (el.x1 * 50), 500 - (el.x2 * 50), pointSize, pointSize);
                }
                if (naujas != null)
                {
                    g.FillRectangle(Brushes.Green, (naujas.x1 * 50), 500 - (naujas.x2 * 50), pointSize, pointSize);
                }
                g.Dispose();
            }
            dataGridView();

        }
        //užpildome duomenų lentele
        private void dataGridView()
        {
            if (elementai != null)
            {
                dataGridView1.Rows.Clear();
                foreach (Elementas el in elementai)
                {
                    dataGridView1.Rows.Add(el.name, el.x1, el.x2, el.posible ? "+" : "-");
                }
            }
        }

        //irasome duomenis i LitleDB
        private void InsertIntoLitleDB()
        {
            if (connectionString == "") return;

            using (var db = new LiteRepository(connectionString))
            {
                foreach (Elementas el in elementai)
                {
                    db.Upsert(el);
                }

            }

        }
        //skaitome duomenis is LitleDB
        private void GetFromLitledb()
        {
            if (connectionString == "") return;
            using (var db = new LiteDatabase(connectionString))
            {
                var collection = db.GetCollection<Elementas>("Elementas");
                elementai = new List<Elementas>();
                foreach (Elementas co in collection.FindAll().OrderBy(x => x.name))
                {
                    elementai.Add(co);

                }
            }
        }
        // pasirenkame iskur skaitysim duomenis ir kviečia duomenu uzkrivimą
        private void buttonUzkrautiDuomenis_Click(object sender, EventArgs e)
        {
            string selectedDB = comboBox1.SelectedItem.ToString();
            if (selectedDB != "")
            {
                connectionString = "../../" + selectedDB + ".db";
                GetFromLitledb();
            }
            panel1.Refresh();
        }
        //pasirenkame kur saugosime duomenis ir iskviecia duomenu irasima
        private void buttonIssaugotiDuomenis_Click(object sender, EventArgs e)
        {
            string selectedDB = comboBox1.SelectedItem.ToString();
            if (selectedDB != "")
            {
                connectionString = "../../" + selectedDB + ".db";
                InsertIntoLitleDB();
            }
        }
        //viena karta naudojama funkcija uzpildyti buomeu baza
        private void createDB()
        {
            elementai = new List<Elementas>(); // pirma imtis
            elementai.Add(new Elementas("e1", 1, 2, true));
            elementai.Add(new Elementas("e2", 3, 4, true));
            elementai.Add(new Elementas("e3", 6, 4, true));
            elementai.Add(new Elementas("e4", 2, 1, false));
            elementai.Add(new Elementas("e5", 4, 1, false));
            elementai.Add(new Elementas("e6", 5, 2, false));

            connectionString = "../../Mokymo imtis 1.db";
            InsertIntoLitleDB();

            elementai = new List<Elementas>();
            elementai.Add(new Elementas("e1", 5, 1, true));
            elementai.Add(new Elementas("e2", 3, 3, true));
            elementai.Add(new Elementas("e3", 0, 3, true));
            elementai.Add(new Elementas("e4", 4, 0, false));
            elementai.Add(new Elementas("e5", 2, 0, false));
            elementai.Add(new Elementas("e6", 1, 1, false));
            connectionString = "../../Mokymo imtis 2.db";
            InsertIntoLitleDB();

            elementai = new List<Elementas>();
            elementai.Add(new Elementas("e1", 0, 2, true));
            elementai.Add(new Elementas("e2", 2, 0, true));
            elementai.Add(new Elementas("e3", 5, 0, true));
            elementai.Add(new Elementas("e4", 1, 3, false));
            elementai.Add(new Elementas("e5", 3, 3, false));
            elementai.Add(new Elementas("e6", 4, 2, false));
            connectionString = "../../Mokymo imtis 3.db";
            InsertIntoLitleDB();

            elementai = new List<Elementas>();
            elementai.Add(new Elementas("e1", 6, 3, true));
            elementai.Add(new Elementas("e2", 4, 1, true));
            elementai.Add(new Elementas("e3", 1, 1, true));
            elementai.Add(new Elementas("e4", 5, 4, false));
            elementai.Add(new Elementas("e5", 3, 4, false));
            elementai.Add(new Elementas("e6", 2, 3, false));
            connectionString = "../../Mokymo imtis 4.db";
            InsertIntoLitleDB();
        }
        // kai pakeičia duomeni arba atnaujiname arba pritedam nauja elementa i sarasa
        private void DataGridView1_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            var ro = ((DataGridView)sender).Rows[e.RowIndex];
            if (ro.Cells[0].Value != null && ro.Cells[1].Value != null && ro.Cells[2].Value != null && ro.Cells[3].Value != null)
            {
                if (ro.Cells[0].Value.ToString() != "" && ro.Cells[1].Value.ToString() != "" && ro.Cells[2].Value.ToString() != "" && ro.Cells[3].Value.ToString() != "")
                {
                    if (elementai.Count > e.RowIndex)
                    {
                        elementai[e.RowIndex].name = ro.Cells[0].EditedFormattedValue.ToString();
                        elementai[e.RowIndex].x1 = float.Parse(ro.Cells[1].EditedFormattedValue.ToString());
                        elementai[e.RowIndex].x2 = float.Parse(ro.Cells[2].EditedFormattedValue.ToString());
                        elementai[e.RowIndex].posible = ro.Cells[3].EditedFormattedValue.ToString() == "+" ? true : false;
                    }
                    else
                    {
                        Elementas el = new Elementas(ro.Cells[0].Value.ToString(), float.Parse(ro.Cells[1].Value.ToString()), float.Parse(ro.Cells[2].Value.ToString()), ro.Cells[3].Value.ToString() == "+" ? true : false);
                        elementai.Add(el);
                    }
                }
            }
        }
    }
}
