using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_struct
{
    class Program
    {
        static void Main(string[] args)
        {

            Deneme den = new Deneme();
            den.sayi = 10;


            Denemee dene = new Denemee();
            dene.sayi = 20;
        }
    }


    // classlar referans tiplerdir
    //struct değer tiplerdir
    struct Deneme
    {
        public int sayi;
    }

    class Denemee
    {
        public int sayi;
    }
}
