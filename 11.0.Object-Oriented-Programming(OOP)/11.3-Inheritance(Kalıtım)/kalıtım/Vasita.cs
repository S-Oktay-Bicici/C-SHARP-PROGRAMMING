using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_kalıtım
{
    class Vasita
    {
        private string marka, renk;
        private int model;
        private double fiyat;

        public Vasita()
        {
        }

        public void goster()
        {
            Console.WriteLine(marka+" "+model+" "+renk+" "+fiyat);
        }

        public string Marka { get => marka; set => marka = value; }
        public string Renk { get => renk; set => renk = value; }
        public int Model { get => model; set => model = value; }
        public double Fiyat { get => fiyat; set => fiyat = value; }
    }
}
