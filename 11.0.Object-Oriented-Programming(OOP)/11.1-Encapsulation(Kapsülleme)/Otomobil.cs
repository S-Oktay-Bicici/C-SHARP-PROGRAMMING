using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class Otomobil
    {
        private string marka, renk;
        private int model;
        private double fiyat;

        public string Marka { get => marka; set => marka = value; }
        public string Renk { get => renk; set => renk = value; }
        public int Model { get => model; set => model = value; }
        public double Fiyat { get => fiyat; set => fiyat = value; }

        public void goster()
        {
            Console.WriteLine("Marka:  " + Marka +
                              "\nModel: " + Model +
                              "\nRenk: " + Renk +
                              "\nFiyat: " + Fiyat);
        }
    }
}
