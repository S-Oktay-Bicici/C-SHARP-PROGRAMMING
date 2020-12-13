using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabitler
{
    class Program
    {
        const double yeniPi = 4;
        static void Main(string[] args)
        {
            const double pi = 3.14;

            double alan, cevre, yaricap;
            string yariCapGirilen;
            Console.WriteLine("Dairenin Yarı Çapı: ");
            yariCapGirilen = Console.ReadLine();
            yaricap = Convert.ToDouble(yariCapGirilen);

            cevre = 2 * pi * yaricap;
            alan = pi * Math.Pow(yaricap, 2);
            Console.WriteLine("Dairenin Alanı: {0}", alan);
            Console.WriteLine("Dairenin çevesi: {0}",cevre);

            Console.ReadLine();

        }
    }
}
