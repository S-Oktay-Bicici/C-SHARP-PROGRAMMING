using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S_sharp
{
    class Program
    {
        static void Main(string[] args)
        {

            //1. kulllanım 
            int[] sayilar = new int[3];

            //2. kulllanım 
            int[] sayilar1;
            sayilar1 = new int[3];

            //3. kullanım 
            int[] sayilar3 = new int[] {55, 45, 64};

            //4. kullanım 
            int[] sayilar4 = new[] {55, 4, 3};

            //5. kulanım
            int[] sayilar5 = {3, 5, 7, 3};

            //6. kulllanım 
            int[] sayilar6;
            sayilar1 = new int[3] {6,5,2};

            //1. ve 2. kullanım da değer atama 
            sayilar[0] = 55;
            sayilar[1] = 43;
            sayilar[2] = 23;

            //double tipinde tanımlama
            double[] ondalıkdizi = {4.3, 6.5, 3};

            //string tipinde tanımlama
            string[] cicekler = {"paaptya", "gül", "yonca", "buket"};

            //char tipinde tanımlama
            char[] sesliharafler = {'a', 'e', 'i'};

            Console.ReadLine();
        }
    }
}
