using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
   public class ReflectionKomutlar
    {
        public void Calistir()
        {
            Console.WriteLine("Metot Çalıştırıldı");
        }

        public void MuzikCal(string[] Liste)
        {
            Console.WriteLine("Müzik Çal Metodu Çalıştırıldı. Müzik Listesi Aşağıda");
            foreach (var item in Liste)
            {
                Console.WriteLine(item);
            }
        }
    }
}
