using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soyut_Sınıflar
{
    abstract class PizzaYap
    {
        public void StandartMalzemeEkle()
        {
            Console.WriteLine("Hamur Eklendi.");
            Console.WriteLine("Domates Sosu Eklendi.");
            Console.WriteLine("Kaşar Peyniri Eklendi.");
        }
        public abstract void EkMalzeme();
    }
}
