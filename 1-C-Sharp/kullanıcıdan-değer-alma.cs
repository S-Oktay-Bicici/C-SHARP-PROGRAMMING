using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kullanıcıdan_değer_alma
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2, sayi3;

            Console.WriteLine("Lütfen bir sayı giriniz");
            sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lütfen bir sayı daha giriniz");
            sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lütfen bir sayı daha giriniz");
            sayi3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sayı 1 = {0}, Sayı 2 = {1}, Sayı 3 = {2}", sayi1, sayi2, sayi3);
            Console.WriteLine($"Sayı 1 = {sayi1}, Sayı 2 = {sayi2}, Sayı 3 = {sayi3}");


            Console.ReadLine();

        }
    }
}