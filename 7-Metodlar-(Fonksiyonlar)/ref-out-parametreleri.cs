using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ref_out_parametreleri
{
    class Program
    {
        static void Main(string[] args)
        {
            int aa = 10;

            Console.WriteLine("Par' a girmeden önce: " + aa);
            Par(aa);
            Console.WriteLine("Par' a girdikten sonra: " + aa);

            Console.WriteLine("----------------------------");

            Console.WriteLine("ParRef' a girmeden önce: " + aa);
            ParRef(ref aa);
            Console.WriteLine("ParRef' a girdikten sonra: " + aa);

            Console.WriteLine("----------------------------");

            Console.WriteLine("ParOut' a girmeden önce: " + aa);
            ParOut(out aa);
            Console.WriteLine("ParOut' a girdikten sonra: " + aa);

            Console.ReadLine();
        }

        static void Par(int x)
        {
            x = x * 2;
        }

        //referansını alır ve değişikliği gerçekleştirir
        static void ParRef(ref int x)
        {
            x = x * 2;
        }

        static void ParOut(out int y)
        {
            y = 2;
        }
    }
}
