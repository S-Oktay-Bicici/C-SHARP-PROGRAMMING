using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace döngüler
{
    class Program
    {
        static void Main(string[] args)
        {
            //for döngüsü 

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("----------------------");

            for (int i = 0; i < 100; i+=2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("----------------------");

            //while döngüsü 

            int number = 0;
            while (number <= 50)
            {
                Console.WriteLine(number);
                number++;
            }

            Console.WriteLine("---------------------");

            //do while döngüsü 

            int num = 1;
            do
            {
                Console.WriteLine(num);
                num++;
            } while (num <= 50);

            Console.WriteLine("---------------------");

            //break anahtar kullanımı 

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                if (i == 5)
                {
                    break;
                }
            }

            Console.WriteLine("-------------------");

            // contiune anahtar kullanımı

            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    continue;
                }
                Console.WriteLine(i);
            }

            Console.WriteLine("-----------------");

            //goto anahtar kullanımı

            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    goto git;
                }
                Console.WriteLine(i);
            git:
                Console.WriteLine("gidildi");
            }

            Console.WriteLine("-----------------");

            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    goto got;
                }
                Console.WriteLine(i);
            }

            got:
                Console.WriteLine("gidildi");

            Console.ReadLine();
        }
    }
}
