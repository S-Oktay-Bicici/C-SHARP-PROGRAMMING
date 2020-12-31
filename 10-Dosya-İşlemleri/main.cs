using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dosya_işlemleri
{
    class Program
    {
        static void Main(string[] args)
        {
            DosyaIslemleri dosya = new DosyaIslemleri();
            /*
            Console.WriteLine(dosya.DosyaKontorol("C:\\Users\\49163\\Pictures\\deneme.txt"));

            Console.WriteLine(dosya.DosyaOku("C:\\Users\\49163\\Pictures\\deneme.txt"));

            string[] array = dosya.DosyaOkuArray("C:\\Users\\49163\\Pictures\\deneme.txt");
            foreach(var satir in array)
            {
                Console.WriteLine(satir);
            }*/

            // dosya.DosyaOkuStream("C:\\Users\\49163\\Pictures\\deneme.txt");


            // dosya.BosDosyaOlustur("C:\\Users\\49163\\Pictures\\oldumu.txt");

            //dosya.DosyayaYaz("C:\\Users\\49163\\Pictures\\oldumu.txt", "Bu bir deneme dosyasıdır");

            // dosya.DosyayaYazArray("C:\\Users\\49163\\Pictures\\oldumu.txt", new[] { "Sadık", "Oktay", "Biçici" });

            string[] array = { "Sadık", "Oktay", "Biçici" };
            dosya.dosyayaYazStream("C:\\Users\\49163\\Pictures\\oldumu.txt", array);

            Console.WriteLine(dosya.DosyaOzellikOKu("C:\\Users\\49163\\Pictures\\oldumu.txt", FileAttributes.Hidden));

            dosya.DosyaOzellikDegistir("C:\\Users\\49163\\Pictures\\oldumu.txt", FileAttributes.Hidden);

            Console.ReadLine();
        }
    }
}
