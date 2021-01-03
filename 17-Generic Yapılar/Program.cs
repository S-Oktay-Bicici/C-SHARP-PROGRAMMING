using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Yapılar
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Kitap> kitapListesi = new List<Kitap>();
            List<Yazar> yazarListesi = new List<Yazar>();

            //1. Tanımlama Yöntemi
            Kitap kitap1 = new Kitap();
            kitap1.Id = 1;
            kitap1.Adi = "Vadideki Zambak";
            kitap1.Yazari = "Balzac";
            kitap1.SayfaSayisi = 250;
            kitap1.Barkodu = "12345";

            kitapListesi.Add(kitap1);

            //2. Tanımlama Yöntemi
            kitapListesi.Add(new Kitap
            {
                Id = 2,
                SayfaSayisi = 550,
                Adi = "Sefiller",
                Yazari = "Victor Hugo",
                Barkodu = "23456"
            });

            //3. Ekleme Yöntemi
            Ekle(ref kitapListesi, new Kitap
            {
                Id = 3,
                Adi = "Savaş ve Barış",
                Barkodu = "9875",
                Yazari = "Lev Tolstoy",
                SayfaSayisi = 1000
            });

            Ekle(ref yazarListesi,new Yazar
            {
                Id = 1,
                Adi = "Tolstoy",
                DogumYeri = "Moskova",
                Yasi = 65
            });

            foreach (var kitap in kitapListesi)
            {
                Console.WriteLine($"{kitap.Id} - {kitap.Barkodu} - {kitap.Adi} - {kitap.Yazari} - {kitap.SayfaSayisi}");
            }

            Console.ReadLine();
        }
        public static void Ekle<TVeri>(ref List<TVeri> liste, TVeri veri)
        {
            liste.Add(veri);
        }
    }
}
