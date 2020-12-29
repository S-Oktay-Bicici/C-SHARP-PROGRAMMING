using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soyut_Sınıflar
{
    class Program
    {
        static void Main(string[] args)
        {
            SucukluPizza pizza=new SucukluPizza();
            pizza.StandartMalzemeEkle();
            pizza.EkMalzeme();

            VejeteryanPizza vpizza=new VejeteryanPizza();
            vpizza.StandartMalzemeEkle();
            vpizza.EkMalzeme();
            Console.ReadLine();
        }
    }
}
