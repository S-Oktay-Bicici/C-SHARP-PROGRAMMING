using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace düzensiz_diziler
{
    class Program
    {
        static void Main(string[] args)
        {

            // düzensiz (jagged) diziler 

            int[][] jagged =
            {
                new int[] {1,2,3,4,5,6},
                new int[] {1,2},
                new int[] {1,2,3,4,5},
                new int[] {1}
            };

            foreach(var jag in jagged)
            {
                foreach(var eleman in jag)
                {
                    Console.WriteLine(eleman);
                }
            }
			
			Console.ReadLine();
        }
    }
}
