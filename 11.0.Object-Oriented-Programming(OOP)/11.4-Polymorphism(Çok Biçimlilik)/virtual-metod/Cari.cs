using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMetot
{
    class Cari:KayitSinifi
    {
		//ekle metodu override ediliyor
        public override void Ekle()
        {
            base.Ekle(); //super anahtar kelimesine benziyor
            Console.WriteLine("Kayıt Eklendi.");
            base.Ekle();
        }
    }
}
