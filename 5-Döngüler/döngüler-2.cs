using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //For Döngüsü
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            //0 dan 100 e kadar olan çift sayıların ekrana yazdırılması
            for (int i = 0; i <= 100; i += 2)
            {
                Console.WriteLine(i);
            }
            //0 dan 100 e kadar olan Tek sayıların ekrana yazdırılması
            for (int i = 1; i <= 100; i += 2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Şifrenizi Belirleyin");
            string sifre = Console.ReadLine();
            Console.WriteLine("Şifrenizi Girin");


            for (string gelenVeri = Console.ReadLine(); sifre != gelenVeri; gelenVeri = Console.ReadLine())
            {
                Console.WriteLine("Şifreniz Yanlış. Lütfen Şifrenizi Doğru Girin");
            }

            Console.WriteLine("Şifreniz Doğru");


            //Soru 1 - 0 dan 500 e kadar 2 ve 3 sayısına tam bölünebilen sayılar

            for (int i = 0; i <= 500; i++)
            {
                if (i % 2 == 0 && i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            //Soru 2 - 0 dan 500 e kadar 5 veya 7 sayısına tam bölünebilen sayılar

            for (int i = 0; i <= 500; i++)
            {
                if (i % 5 == 0 || i % 7 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            //Soru 3 - 0 dan 500 e kadar 5 ve 7 sayısına tam bölünebilen ancak 3 e bölünemeyen sayılar

            for (int i = 0; i <= 500; i++)
            {
                if (i % 5 == 0 && i % 7 == 0 && i % 3 != 0)
                {
                    Console.WriteLine(i);
                }
            }

            //While Döngüsü
            int sayi = 0;
            while (sayi <= 50)
            {
                Console.WriteLine(sayi);
                sayi++;
            }

            //Do While Döngüsü
            string Sifre;
            string Gelen;
            Console.WriteLine("Şifrenizi Belirleyin.");
            Sifre = Console.ReadLine();
            do
            {
                Console.WriteLine("Şifrenizi Girin.");
                Gelen = Console.ReadLine();
            } while (Sifre != Gelen);

            Console.WriteLine("Tebrikler! Şifre Doğru.");

            //break anahtar sözcüğü döngülerin sonlandırılmasında da kullanılır.
            for (int i = 0; i < 10; i++)
            {

                if (i == 5)
                {
                    break;
                }
                Console.WriteLine(i);
            }

            //continue anahtar sözcüğü döngülerin istenilen kısımlarını atlamaya yarar.
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    continue;
                }
                Console.WriteLine(i);
            }

            //GoTo anahtar sözcüğü kodların istenilen bölümlerinin atlanmasını sağlar.
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    goto Git;
                }
                Console.WriteLine(i);
            }
            Git:
            Console.WriteLine("Gidildi.");

            Console.ReadLine();

        }
    }
}
