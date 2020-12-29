using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arayüzler
{
    class Program
    {
        static void Main(string[] args)
        {
            EmlakGetir(new Arsa());
            Console.ReadLine();
        
        }

        static void EmlakGetir(IEmlak emlak)
        {
            emlak.Kirala();
        }
    }

}
