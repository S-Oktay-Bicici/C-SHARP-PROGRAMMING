using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Otomobil oto2 = new Otomobil();
            Otomobil oto1 = new Otomobil("Volvo", 2020);

            oto2.marka = "Nissan";
            oto2.model = 2090;

            Console.WriteLine(oto1.marka);
            Console.WriteLine(oto2.marka);

            Console.ReadLine();
        }
    }
}
