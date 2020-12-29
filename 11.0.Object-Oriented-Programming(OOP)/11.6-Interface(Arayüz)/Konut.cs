using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arayüzler
{
    class Konut : IEmlak,IAdres
    {
        public int MetreKare { get; set; }
        public string Adres { get; set; }
        public string Fiyat { get; set; }
        public string Cephe { get; set; }
        public string Il { get; set; }
        public string Ilce { get; set; }
        public string Semt { get; set; }

        public void Kirala()
        {
            Console.WriteLine("Konut Kiralandı.");
        }

        public void Sat()
        {
            throw new NotImplementedException();
        }

        public void GunlukKiralik()
        {

        }

        public void DevrenSatilik()
        {

        }
    }
}
