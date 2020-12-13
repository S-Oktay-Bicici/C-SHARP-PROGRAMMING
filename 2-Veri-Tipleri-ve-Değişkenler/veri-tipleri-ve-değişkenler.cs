using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_VeriTipleriVeDegiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            //-----------Tam Sayı Değişkenleri---------------
            //
            sbyte sbyteDegiskeni = 100;
            //-128 ile 127 Arasında

            byte byteDegiskeni = 40;
            //0 ile 255 Arasında

            short shortDegiskeni = -300;
            //-32.768 ile 32.767 Arasında

            ushort ushortDegiskeni = 100;
            //0 ile 65.535 Arasında

            int intDegiskeni = 100;
            //-2.147.483.648 ile 2.147.483.647 Arasında

            uint uintDegiskeni = 100;
            //0 ile 4.294.967.295 Arasında

            long longDegiskeni = 100;
            //–9.223.372.036.854.775.808 ile 9.223.372.036.854.775.807 Arasında

            ulong ulongDegiskeni = 100;
            //0 ile 18.446.744.073.709.551.615 Arasında

            //-------------------------------------------------------------------
            //
            //-----------Ondalıklı Sayı Değişkenleri-----------------------------
            //
            float floatDegiskeni = 100.2F;
            //1.5 × 10^−45 ile 3.4 × 10^38 Arasında

            double doubleDegiskeni = 100.2;
            //5.0 × 10^−324 ile 1.7 × 10^308 Arasında

            decimal decimalDegiskeni = 100.2M;
            //–7.9 × 10^−28 ile 7,9 × 10^28 Arasında
            //-------------------------------------------------------------------
            //
            //-------------Mantıksal Değişkenler---------------------------------
            //
            bool boolDegiskeni = true;
            //-------------------------------------------------------------------
            //
            //-------------Metinsel Değişkenler---------------------------------
            //
            char charDegiskeni = 'a';
            string stringDegiskeni = "Benim Adım Erhan GÜVEN. C# Derslerine Hoşgeldiniz.";

            int sayi1,sayi2,sayi3;

            //Değişken boş tanımlanıp sonradan değer atanabilir.
            //int sayi2;
            //sayi2 = 100;

            //Değişken tanımlanırken değer atanabilir.
            //int sayi3 = 4785;

            Console.WriteLine("Lütfen bir sayı girin");
            sayi1=Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Lütfen bir sayı daha girin");
            sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lütfen bir sayı daha girin");
            sayi3 = Convert.ToInt32(Console.ReadLine());


            string veri = "1";
            int sayi4 = Convert.ToInt32(veri);
            Console.WriteLine(sayi4);

            object obje=new object();

            //var anahtarı aldığı ilk değerden sonra tipi belirlenir.
            var degisken = "Erhan";
            degisken = "Erhan";

            //Bu şekilde toplama işleminde değişkenlerimiz sayısal veri tipinde olduğundan matematiksel toplama yapılır.
            //Console.WriteLine(sayi1+sayi2+sayi3);

            //Console.WriteLine(String.Format("Sayi 1 = {0} , Sayi 2 = {1} , Sayi 3 = {2}", sayi1, sayi2, sayi3));
            Console.WriteLine($"Sayi 1 = {sayi1} , Sayi 2 = {sayi2} , Sayi 3 = {sayi3}");

            //Console.WriteLine(sbyte.MinValue + " ile " + sbyte.MaxValue);
            //Console.WriteLine(sbyteDegiskeni);
            Console.ReadLine();

        }
    }
}
