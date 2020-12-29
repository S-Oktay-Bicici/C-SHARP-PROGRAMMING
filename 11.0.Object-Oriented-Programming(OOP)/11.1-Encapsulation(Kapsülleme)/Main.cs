using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class


/*
 Public = her yerden erişilebilir 
 private = sadece tanımlandığı sınıf içerisinden eişilebilir
 ınternal = sadece bulunduğu projede erişilebilir
 protected = sadece tanımlandığı sınıfta yada o sınıfı miras alan sınıflardan erişilebilir
 protected ınternal = sadece tanımlandığı sınıfta ya da o sınıfı miras alan sınıflardan eşirişilebilir 
                      ayrıca tanımlanmanın aynı proje içerisinde olma şartı yoktur protected den farkı budur.
 */


{/*
    class Otomobil
    {
        private string marka,renk;
        private int model;
        private double fiyat;

        public string Marka { get => marka; set => marka = value; }
        public string Renk { get => renk; set => renk = value; }
        public int Model { get => model; set => model = value; }
        public double Fiyat { get => fiyat; set => fiyat = value; }

        public void goster()
        {
            Console.WriteLine("Marka:  "+Marka+
                              "\nModel: "+Model+
                              "\nRenk: "+Renk+
                              "\nFiyat: "+Fiyat);
        }
    }
    */
    class Program
    {
        static void Main(string[] args)
        {
           Otomobil oto1 = new Otomobil();
           oto1.Marka = "Volvo";
           oto1.Model = 2020;
           oto1.Renk = "Gümüş";
           oto1.Fiyat = 990000;

           oto1.goster();

           Console.ReadLine();
        }
    }
}
