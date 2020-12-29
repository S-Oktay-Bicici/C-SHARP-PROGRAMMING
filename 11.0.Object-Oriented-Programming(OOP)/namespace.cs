using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//using ProjectA.TeamA;   // da eklenebilir

namespace Class_namespace
{
    class Program
    {
        static void Main(string[] args)
        {
            ProjectA.TeamA.ClassA sinif1 = new ProjectA.TeamA.ClassA();
            sinif1.Yaz();

            Console.ReadLine();

            ProjectA.TeamA.ClassA.Print();

            //yukarıda eklenen kütüphane ile

            //ClassA sinit2 = new ClassA();
            //sinif2.Yaz();
        }
    }
}

namespace ProjectA
{
    namespace TeamA
    {
        class ClassA
        {
            public static void Print()
            {
                Console.WriteLine("ProjeA, EkipA, SınıjA, Print()");
            }

            public void Yaz()
            {
                Console.WriteLine("ProjeA, EkipA, SınıjA, Yaz()");
            }
        }
    }

    namespace TeamB
    {
        class ClassA
        {
            public static void Print()
            {
                Console.WriteLine("ProjeA, EkipB, SınıjA, Print()");
            }
        }
    }
}

namespace ProjectB
{
    namespace TeamA
    {
        class ClassA
        {
            public static void Print()
            {
                Console.WriteLine("ProjeB, EkipA, SınıfA, Print()");
            }
        }
    }
}
