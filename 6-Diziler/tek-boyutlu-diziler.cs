using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diaiziler
{
    class Program
    {
        static void Main(string[] args)
        {
            //dizi tanımlama
            int[] dizi = new int[25];
            bool[] dizi1 = new bool[10];
            int[] dizi2;
            dizi2 = new int[20];

            //diziye değer atama 
            int[] strdizi = new int[3];
            strdizi[0] = 5;
            strdizi[1] = 7;
            strdizi[2] = 6;

            //string dizi oluşturma 
            string[] sDizi = new string[4];
            sDizi[0] = "a";
            sDizi[1] = "A";
            sDizi[2] = "O";
            sDizi[3] = "k";

            //diziyi oluştururken değer atama
            float[] fDizi = new float[3];
            float[] fDizi1 = {1.3F, 3.2F,1.5F};
            string[] fString = {"ali", "veli", "mehmet"};
            string[] fString2 = new string[] {"aşi","keli","alm"};

            int[] d1, d2, d3;
            d1 = new int[4];
            d2 = new int[3];
            d3 = new int[10];

            //dinamik dizi
            Console.WriteLine("Eleman sayısı: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int[] dizii = new int[sayi];

            for(int i= 0; i < dizii.Length;i++)
            {
                Console.WriteLine(dizii[i]);
            }

            Console.ReadLine();
        }
    }
}
