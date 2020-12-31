using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegele
{
    class Faiz
    {
        public delegate void FaizHesapla(decimal Tutar, int Vade);

        public void GunlukFaiz(decimal Anapara, int Vade)
        {
            Console.WriteLine($"{Vade} Günlük Kazancınız: {Anapara * 7 * Vade / 36500}");
        }

        public void AylikFaiz(decimal Anapara, int Vade)
        {
            Console.WriteLine($"{Vade} Aylık Kazancınız: {Anapara * 10 * Vade / 1200}");
        }

        public void YillikFaiz(decimal Anapara, int Vade)
        {
            Console.WriteLine($"{Vade} Yıllık Kazancınız : {Anapara * 15 * Vade / 100}");
        }
    }
}
