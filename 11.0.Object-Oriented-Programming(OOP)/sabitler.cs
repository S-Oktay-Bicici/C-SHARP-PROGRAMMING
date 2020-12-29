using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_sabitler
{

    class Sabitler
    {
        public  const  double pi= 3.14;
        public readonly int Asal = 1;
    }
    class Program
    {
        static void Main(string[] args)
        {
            //sabitler static gibi davranır 
            Console.WriteLine(Sabitler.pi);

            Sabitler sabit = new Sabitler();
            Console.WriteLine(sabit.Asal);
        }
    }
}
