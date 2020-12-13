using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operatörler
{
    class Program
    {
        static void Main(string[] args)
        {

            // aritmatik operatörler - matematiksel işlemler 

            int number1 = 120;
            int number2 = 25;

            //toplama
            Console.WriteLine(number1 + number2);

            //çıkarma 
            Console.WriteLine(number1 - number2);

            //çarpma
            Console.WriteLine(number1 * number2);

            //bölme 
            Console.WriteLine(number1 / number2);

            //mod alma
            Console.WriteLine(number2 % number1);


            //karşılaştırma operatörleri

            Console.WriteLine(number1 < number2);
            Console.WriteLine(number1 > number2);
            Console.WriteLine(number1 <= number2);
            Console.WriteLine(number1 >= number2);
            Console.WriteLine(number1 == number2);
            Console.WriteLine(number1 != number2);

            //Is operatörü
            int number3 = 35;
            Console.WriteLine(number3 is int);


            //mantıksal operatörler
            Console.WriteLine(number1 == 120 && number2 == 25);
            Console.WriteLine(number1 != 120 || number2 == 25);
            Console.WriteLine(!(number1 == 120));


            Console.ReadLine();
        }
    }
}
