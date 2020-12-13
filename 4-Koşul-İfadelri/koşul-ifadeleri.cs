using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace koşul_ifadeleri
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 250;
            int number2 = 25;

            //if koşulu

            if(number1 == number2)
            {
                Console.WriteLine("Sayılar birbirine eşit.");
            }
            else
            {
                Console.WriteLine("Sayılar birbirine eşit değildir.");
            }

            Console.WriteLine("Notunuzu giriniz: ");
            int not1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Notunuzu giriniz: ");
            int not2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Notunuzu giriniz: ");
            int not3 = Convert.ToInt32(Console.ReadLine());
            int ortalama = (not1 + not2 + not3) / 3;

            if(ortalama < 50)
            {
                Console.WriteLine("Ortalamanız düşük.");
            }
            else if(ortalama >= 50 && ortalama < 70)
            {
                Console.WriteLine("Ortamanız orta seviyede.");
            }
            else if(ortalama >= 70 && ortalama < 85)
            {
                Console.WriteLine("Ortalamanız yüksek seviyede.");
            }
            else
            {
                Console.WriteLine("Ortalamanız en iyi seviyede.");
            }

            //iç içe ifler 

            Console.WriteLine("Maaşınızı giriniz:");
            int maas = Convert.ToInt32(Console.ReadLine());

            if(maas >= 1500)
            {
                Console.WriteLine("Aylık ödeme:");
                int ayliködeme = Convert.ToInt32(Console.ReadLine());
                if(ayliködeme >= 100 && ayliködeme <= 300)
                {
                    Console.WriteLine("10000 Tl kredi verilebilir.");
                }
                else if(ayliködeme >= 301 && ayliködeme <= 1000)
                {
                    Console.WriteLine("50000 TL kredi verilebilir.");
                }
                else if(ayliködeme >= 1001 && ayliködeme <= 10000)
                {
                    Console.WriteLine("100000 TL kredi verilebilir.");
                }
                else if(ayliködeme > 10000)
                {
                    Console.WriteLine("5000000 TL kredi verilebilir.");
                }
            }
            else
            {
                Console.WriteLine("Maaşınız kredi çekmeye uygun değildir.");
            }

            // tek satır if kullanımı 

            int number4 = 148;
            string sonuc;

            sonuc = number4 < 150 ? "Sonuç 150 den küçüktür." : "Sonuç 150 den büyüktür.";
            Console.WriteLine(sonuc);


            //switch case kullanımı

            Console.WriteLine("(1-3) arası bir sayı seçiniz: ");
            int sun = Convert.ToInt32(Console.ReadLine());

            switch (sun)
            {
                case 1:
                    Console.WriteLine("1 numarayı seçtin.");
                    break;
                case 2:
                    Console.WriteLine("2 numarayı seçtin.");
                    break;
                case 3:
                    Console.WriteLine("3 numarayı seçtin.");
                    break;
                default:
                    Console.WriteLine("Yanlış numara girdin.");
                    break;
            }

            // switch case (goto) komutu kullanımı 

            Console.WriteLine("(1-3) arası bir sayı seçiniz: ");
            int sune = Convert.ToInt32(Console.ReadLine());

            switch (sune)
            {
                case 1:
                    Console.WriteLine("1 numarayı seçtin.");
                    goto case 2;//iki seçenek birden seçilmiş oluyor.
                case 2:
                    Console.WriteLine("2 numarayı seçtin.");
                    break;
                case 3:
                    Console.WriteLine("3 numarayı seçtin.");
                    break;
                default:
                    Console.WriteLine("Yanlış numara girdin.");
                    break;
            }
            Console.ReadLine();
        }
    }
}
