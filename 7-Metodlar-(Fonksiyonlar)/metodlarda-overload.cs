using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodlarda_overloaf
{
    class Program
    {
        static void Main(string[] args)
        {
            Topla(3, 5);
            Topla(3, 5, 6);
        }

        static void Topla(int say1, int say2)
        {
            Console.WriteLine(say1+say2);
        }

        static void Topla(int say1, int say2,int say3)
        {
            Console.WriteLine(say1 + say2 + say3);
        }

    }
}
