using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine((int)Cariler.ALICI);

            EnumYapisi enumYapisi = new EnumYapisi();

            enumYapisi.KayitEkle(Cariler.PERSONEL);
            enumYapisi.KayitEkle(Cariler.SATICI);

            enumYapisi.KyitEkle(Cariler.TOPTANCI);

        }
    }

    public enum Cariler
    {
 
        ALICI = 100,
        SATICI = 10,
        PERSONEL = 44,
        TOPTANCI = 40

    }

    class EnumYapisi
    {
        public void KayitEkle(Cariler cari)
        {
            Console.WriteLine($"{cari} veritabanınna eklendi");
        }

        public void KyitEkle(Cariler cari)
        {
            Console.WriteLine($"{(int)cari} veritabanınna eklendi");
        }
    }
}
