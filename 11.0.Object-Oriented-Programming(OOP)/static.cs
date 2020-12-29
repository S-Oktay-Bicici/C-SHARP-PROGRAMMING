using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_static
{

    // oluşturduğumuz method sınıfın genelini ilgilendiriyorsa method static
    //nesneleri ilgilendiriyorsa non-static olrak oluşturulacak

    //eğer bir class static olarak belirlenmişse altındaki tüm methodlar static olmak zorunda 
    class Ornek
    {
        public static void A()
        {
            Console.WriteLine("static method");
        }

        public void B()
        {
            Console.WriteLine("non static method");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Ornek.A(); 
           // Ornek.B(); //hata verecetir

            Ornek orn1 = new Ornek();

            Ornek.A();

           // Ornek.B(); //hata verecektir
        }
    }
}
