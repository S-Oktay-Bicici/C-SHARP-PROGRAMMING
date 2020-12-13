using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_döngü_örneği
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Şifrenizi belirleyin");
            string sifre = Console.ReadLine();
            Console.Write("Şifrenizi giriniz:");

            for (string gelenveri = Console.ReadLine(); sifre != gelenveri; gelenveri = Console.ReadLine())
            {
                Console.WriteLine("Şifrenizi yanlış girdiniz. Lütfen doğru şifreyi girniz:");
            }
            Console.WriteLine("Şifreniz doğru.");

            Console.WriteLine("-------------------------------------------------------");

            //2 ve 3 sayısına tam bölünebilen sayılar (0-500)
            for (int i = 0; i <= 500; i++)
            {
                if(i % 2 == 0 && i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("------------------");

            //5 veya 7 sayıslarına tam bölünen sayılar (0-500)
            for (int i = 0; i <= 500; i++)
            {
                if (i % 5 == 0 || i % 7 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("----------------------------------------");

            //5 ve 7 sayısına tam bölünen 3 e bölünemeyen sayılar (0-500)
            for (int i = 0; i <= 500; i++)
            {
                if (i % 5 == 0 && i % 7 == 0 && i % 3 != 0)
                {
                    Console.WriteLine(i);
                }
            }


            Console.ReadLine();


        }
    }
}
