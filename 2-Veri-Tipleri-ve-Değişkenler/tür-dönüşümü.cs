using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tür_dönüşümü
{
    class Program
    {
        static void Main(string[] args)
        {
            //bilinçli ve bilinçsiz tür dönüşümleri vardır. 
            //Inplicit ve Explicit denir.

            //kapalı bilinçsiz tür dönüşümü
            double d = 12.3;
            Console.WriteLine(d);
            int i = 5;
            d = i;
            Console.WriteLine(d);

            //bilinçli tür dönüşümü
            double a = 12.3;
            Console.WriteLine(a);
            int b = 5;
            b = Convert.ToInt32(a);
            Console.WriteLine(d);

            float f = 100.15f;
            int x1 = (int)f;
            int x2 = Convert.ToInt32(f);

            //parse ile tür dönüşümü
            string strNumber1 = "10";
            string strNumber2 = "10C";
            string strNUmber3 = "10,2";
            int y1 = int.Parse(strNumber1);
            int y2 = int.Parse(strNumber2); //hata vericek
            int y3 = int.Parse(strNUmber3); //hata vericek
            Console.WriteLine(y1);
            Console.WriteLine(y2);
            Console.WriteLine(y3);

            //tryparse ile tür dönüşümü
            int result;
            string strNumber = "10K";
            int.TryParse(strNumber, out result);
            Console.WriteLine(result); //hata vermez yapamadığı için 0 verir result a

            Console.ReadLine();
        }
    }
}
