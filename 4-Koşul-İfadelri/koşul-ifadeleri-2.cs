using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _4_Koşul_İfadeleri
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 150;
            int sayi2 = 200;
            //If Koşulu
            if (sayi1 == sayi2)
            {
                Console.WriteLine("Sayılar birbirine eşit");
            }
            else
            {
                Console.WriteLine("Sayılar birbirine eşit değil");
            }

            //İç İçe İf Kullanımı
            int sayi3 = 150;
            int sayi4 = 200;

            if (sayi3 == 150)
            {
                if (sayi4 == 200)
                {
                    Console.WriteLine("Şartlarınız sağlandı.");
                }
            }
            if (sayi3 == 150 && sayi4 == 200)
            {

                Console.WriteLine("Şartlarınız sağlandı.");
            }

            //Tek Satır If İfadesinin Kullanımı
            //Normal Kullanım
            int sayi5 = 148;
            string sonuc;

            if (sayi5 < 150)
            {
                sonuc = "Sonuç 150 sayısından küçük";
            }
            else
            {
                sonuc = "Sonuç 150 sayısından büyük";
            }

            Console.WriteLine(sonuc);

            //Tek Satırlık Kullanım
            sonuc = sayi5 < 150 ? "Sonuç 150 sayısından küçük" : "Sonuç 150 sayısından büyük";

            Console.WriteLine(sonuc);


            //Switch Case Kullanımı
            int cevap = Convert.ToInt32(Console.ReadLine());

            switch (cevap)
            {
                case 1:
                    Console.WriteLine("1. Seçenek Seçildi.");
                    goto case 2;
                case 2:
                    Console.WriteLine("2. Seçenek Seçildi.");
                    goto case 3;
                case 3:
                    Console.WriteLine("3. Seçenek Seçildi.");
                    break;
                default:
                    Console.WriteLine("3 şarttan hiçbiri seçilmedi.");
                    break;
            }

            Console.ReadLine();
        }
    }
}
