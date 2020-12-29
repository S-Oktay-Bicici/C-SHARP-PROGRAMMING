using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soyut_Sınıflar
{
    class VejeteryanPizza : PizzaYap
    {
        public override void EkMalzeme()
        {
            Console.WriteLine("Turşu Eklendi.");
            Console.WriteLine("Dere Otu Eklendi.");
        }
    }
}
