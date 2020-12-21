using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ref_metodu
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = 5;
            int sayi2 = 5;

            Console.WriteLine("Sayınız metod öncesi: "+sayi2);
            SayiArttir(ref sayi2);
            Console.WriteLine("Sayınız metod sonrası: "+sayi2);
            Console.WriteLine("Sayınız metod sonrası: "+SayiArttir(sayi));

            IsımleriYazdir("oktay","sadık");

            Console.ReadLine();
        }

        static void SayiArttir(ref int sayi3)
        {
            sayi3 += 5;
        }

        static int SayiArttir(int sayi3)
        {
            return sayi3 += 5;
        }

        static void IsımleriYazdir(params string[] isim)
        {
            foreach (string item in isim )
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
