using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelektikaUzduotis2
{
    class Elemantas
    {
        private string name { get; set; }
        public float x1 { get; set; }
        public float x2 { get; set; }
        public bool posible { get; set; }

        public double d1 { get; set; }
        public double d2 { get; set; }
        public double d3 { get; set; }
        public Elemantas(string name, float x1, float x2, bool posible)
        {

            this.name = name;
            this.x1 = x1;
            this.x2 = x2;
            this.posible = posible;
        }
        public double D1(Elemantas elementas2)
        {
            this.d1 = Math.Abs(this.x1 - elementas2.x1) + Math.Abs(this.x2 - elementas2.x2);
            return this.d1;
        }
        public double D2(Elemantas elementas2)
        {
            this.d2= Math.Pow(this.x1 - elementas2.x1, 2) + Math.Pow(this.x2 - elementas2.x2, 2);
            return this.d2;
        }
        public double D3(Elemantas elementas2)
        {
            this.d3= Math.Max(Math.Abs(this.x1 - elementas2.x1), Math.Abs(this.x2 - elementas2.x2));
            return this.d3;
        }
    }
}
