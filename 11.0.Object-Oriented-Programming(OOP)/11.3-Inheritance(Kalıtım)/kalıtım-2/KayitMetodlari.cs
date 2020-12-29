using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalıtım
{
  class KayitMetodlari
    {
        public void Kaydet(IKayit kayit)
        {
            Console.WriteLine(kayit.GetType().Name + " Kaydedildi");
        }

        public void Sil()
        {
            Console.WriteLine("Silindi.");
        }
    }
}
