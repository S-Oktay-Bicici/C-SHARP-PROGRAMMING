using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Ekle();
            Cıkar();
            Duzenle();

            Toplama(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
            Cıkarma(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("Sonuc: "+Carpma(4,6));

            Console.WriteLine(ArrayToplam(new int[]{5,56,7,2}));

            Console.WriteLine(ArrayParamsToplam(5, 56, 7, 2 ));

            //parametreleri sırasının dışında kullanma
            Toplama(say2:40,say1:10);

            ReturnAnahtarı(115);

            Console.ReadLine();
        }

        //geriye değer döndürmeyen 
        static void Ekle()
        {
            Console.WriteLine("Ekleme yapıldı.");
        }

        static void Cıkar()
        {
            Console.WriteLine("Çıkarma yapıldı.");
        }

        static void Duzenle()
        {
            Console.WriteLine("Duzenleme yapıldı.");
        }


        //geriye değer döndürmeyen parametre alan 
        static void Toplama(int say1, int say2)
        {
            Console.WriteLine($"say1+say2");
        }

        static void Cıkarma(int say1, int say2 = 50)
        {
            Console.WriteLine($"say1+say2");
        }

        //geriye değer döndüren parametrea alan 
        static int Carpma(int say1, int say2)
        {
            return (say1 * say2);
        }

        //arraay tipi ile çalışma
        static int ArrayToplam(int[] sayilar)
        {
            int toplam = 0;
            foreach (var say in sayilar)
            {
                toplam += say;
            }

            return toplam;
        }

        //array params kullanımı
        static int ArrayParamsToplam(params int[] sayilar)
        {
            int toplam = 0;
            foreach (var say in sayilar)
            {
                toplam += say;
            }

            return toplam;
        }

        //void metotda return kullanımı
        static void ReturnAnahtarı(int saya)
        {
            for (int i = 0; i < saya; i++)
            {
                if (i == 9)
                {
                    return;
                }
                Console.WriteLine(i);
            }
        }
    }
}
