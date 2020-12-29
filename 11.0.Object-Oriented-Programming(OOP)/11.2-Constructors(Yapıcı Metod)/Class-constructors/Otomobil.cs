using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_constructors
{
    class Otomobil
    {
        public string marka, renk;
        public int model;
        public double fiyat;

        public Otomobil()
        {
        }

        public Otomobil(string marka, int model)
        {
            this.marka = marka;
            this.model = model;
        }
    }
}
