using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_destructor
{
    class Otomobil
    {

        public Otomobil()//ypıcı metod 
        {
            Console.WriteLine("Sınıf oluşturuluyor");
        }

        ~Otomobil()//yıkıcı metod
        {
            Console.WriteLine("Sınıf yıkılıyor");
            Console.ReadLine();
        }

        
    }
}
