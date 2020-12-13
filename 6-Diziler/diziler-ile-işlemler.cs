using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diziler3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi1 = {4,1, 3, 2};
            int[] dizi2 = new int[6];

            //ikinci elemandan itibareen koopyalama yapıyor
            dizi1.CopyTo(dizi2,2);

            Array.Copy(dizi1,0,dizi2,2,2);


            foreach (var item in dizi2)
            {
                Console.WriteLine(item);   
            }

            //sıralama yapar
            Array.Sort(dizi1);
            foreach (var item in dizi1)
            {
                Console.WriteLine(item);
            }

            //tersine çevirme
            Array.Reverse(dizi1);
            foreach (var item in dizi1)
            {
                Console.WriteLine(item);
            }


            //diziyi temizler
            Array.Clear(dizi1,1,2);
            foreach (var item in dizi1)
            {
                Console.WriteLine(item);
            }
        }
    }
}
