using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMetot
{
    class KayitSinifi
    {
        public virtual void Ekle()
        {
            Console.WriteLine("Kayıt Ekleniyor.");
        }

        public virtual void Sil()
        {
            Console.WriteLine("Kayıt Siliniyor.");
        }
    }
}
