using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dziler
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. kullanım 
            int[,] cokBoyutluDizi = new int[3,3];

            //2. kullanım
            int[,] ikiboyut = {{3, 4, 5}, {6, 7, 8}, {9, 10, 11}};


            //öok boyutlu dizi değer atama
            cokBoyutluDizi[1, 2] = 23;

            Console.WriteLine(cokBoyutluDizi[1,2]);

            foreach (var say in ikiboyut)
            {
                Console.WriteLine(say);                
            }

            
            Console.ReadLine();
        }
    }
}
