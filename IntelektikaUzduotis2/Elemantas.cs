using System;
namespace IntelektikaUzduotis2
{
    class Elementas
    {
        public Guid Id { get; set; }
        public string name { get; set; }
        public float x1 { get; set; }
        public float x2 { get; set; }
        public bool posible { get; set; }

        public double d1 { get; set; }
        public double d2 { get; set; }
        public double d3 { get; set; }
        public Elementas() { }
        public Elementas(string name, float x1, float x2, bool posible)
        {
            this.name = name;
            this.x1 = x1;
            this.x2 = x2;
            this.posible = posible;
        }
        //skaiciojame pagal pirma formule
        public double D1(Elementas elementas2)
        {
            this.d1 = Math.Abs(this.x1 - elementas2.x1) + Math.Abs(this.x2 - elementas2.x2);
            return this.d1;
        }
        //skaiciojame pagal antra formule
        public double D2(Elementas elementas2)
        {
            this.d2= Math.Pow(this.x1 - elementas2.x1, 2) + Math.Pow(this.x2 - elementas2.x2, 2);
            return this.d2;
        }
        //skaiciojame pagal tracia formule
        public double D3(Elementas elementas2)
        {
            this.d3= Math.Max(Math.Abs(this.x1 - elementas2.x1), Math.Abs(this.x2 - elementas2.x2));
            return this.d3;
        }
    }
}
