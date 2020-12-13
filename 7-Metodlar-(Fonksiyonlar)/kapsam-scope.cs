using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kapsam_scope
{
    class Program
    {
        //Global scope alanı
        static int y = 5;

        static void Main(string[] args)
        {

            // local scope sadece metot içerisinde kullanılan kasamlara denir
            // global scope metotların dışında kullılan birden fazla metotdun kullandığı scope

            int x = 4;

            Console.ReadLine();
        }
    }
}
