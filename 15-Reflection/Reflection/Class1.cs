using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    class Class1
    {
        public Class1(int parametre1, bool parametre2)
        {
            Console.WriteLine($"Yapıcı Metot Çalıştı. {parametre1} {parametre2}");
        }
        public int IntegerProp { get; set; }
        public void deneme()
        {
            Console.WriteLine($"Metot Çalıştı.");
        }
        public void deneme1(int parametre1, bool parametre2)
        {
            Console.WriteLine($"Metot Çalıştı. {parametre1} {parametre2}");
        }
    }
}
