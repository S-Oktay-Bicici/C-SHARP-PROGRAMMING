using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soyut_Sınıflar
{
    class SucukluPizza : PizzaYap
    {
        public override void EkMalzeme()
        {
            Console.WriteLine("Sucuk Eklendi.");
            Console.WriteLine("Baharat Eklendi.");
        }
    }
}
