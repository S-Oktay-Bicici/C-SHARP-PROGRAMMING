using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aritmetik Operatörler - Matematiksel İşlemler
            int sayi1 = 100;
            int sayi2 = 25;

            //Toplama
            Console.WriteLine(sayi1 + sayi2);
            //Çıkarma
            Console.WriteLine(sayi1 - sayi2);
            //Çarpma
            Console.WriteLine(sayi1 * sayi2);
            //Bölme
            Console.WriteLine(sayi1 / sayi2);


            //Bölmede Kalan
            Console.WriteLine(sayi1 % sayi2);


            ////Sayı Arttırma
            ////Tanımlanan Değer Değişir.
            //Console.WriteLine(++sayi1);
            ////Değer Değişmez.
            //Console.WriteLine(sayi1 + 1);


            ////Sayı Azaltma
            //Console.WriteLine(--sayi1);


            ////Arttırma Operatörünü Önek olarak kullandığımızda iki sayıda değişmektedir.
            //sayi2 = ++sayi1;
            ////Arttırma Operatörünü Sonek olarak kullandığımızda sadece sayi1 değişmektedir.
            //sayi2 = sayi1++;
            //Console.WriteLine($"{sayi1} ve {sayi2}");


            //Karşılaştırma Operatörleri - True veya False şeklinde dönüş yapar.

            //Küçüktür
            Console.WriteLine(sayi1 < sayi2);
            //Küçük Eşittir
            Console.WriteLine(sayi1 <= sayi2);


            //Büyüktür
            Console.WriteLine(sayi1 > sayi2);
            //Büyük Eşittir
            Console.WriteLine(sayi1 >= sayi2);

            //Eşittir
            Console.WriteLine(sayi1 == sayi2);
            //Eşit Değildir
            Console.WriteLine(sayi1 != sayi2);

            //As Operatörü
            object sayi3 = 35;
            sayi3 = sayi3 as Nullable<int>;

            //Is Operatörü
            int sayi4 = 45;
            Console.WriteLine(sayi4 is int);


            //Mantıksal Operatörler - True veya False şeklinde dönüş yapar.

            //Ve Operatörü - Şartlardan herhangi biri sağlanmazsa False değeri döndürür.
            Console.WriteLine(sayi1 == 100 && sayi2 == 24 && sayi4 == 45);

            //Veya Operatörü - Şartlardan herhangi biri sağlanırsa true değeri döndürür.
            Console.WriteLine(sayi1 == 100 || sayi2 == 24 || sayi4 == 44);

            //Değil Operatörü
            Console.WriteLine(!(sayi1 == 100));

            //Atama Operatörleri(=)
            int sayi5 = 25;
            int sayi6 = sayi5;

            //İşlem Atama Operatörleri
            int sayi7 = 49;
            int sayi8 = 150;

            //Toplam İşlemi
            //Normal Kullanım
            sayi7 = sayi7 + sayi8;
            //İşlem Atama Şeklinde Kullanım
            sayi7 += sayi8;

            //Çıkarma İşlemi
            //Normal Kullanım
            sayi7 = sayi7 - sayi8;
            //İşlem Atama Şeklinde Kullanım
            sayi7 -= sayi8;

            //Çarpma İşlemi
            //Normal Kullanım
            sayi7 = sayi7 * sayi8;
            //İşlem Atama Şeklinde Kullanım
            sayi7 *= sayi8;

            //Bölme İşlemi
            //Normal Kullanım
            sayi7 = sayi7 / sayi8;
            //İşlem Atama Şeklinde Kullanım
            sayi7 /= sayi8;

            //Bölmede Kalan İşlemi
            //Normal Kullanım
            sayi7 = sayi7 % sayi8;
            //İşlem Atama Şeklinde Kullanım
            sayi7 %= sayi8;

            //Tür Dönüşüm Operatörleri
            double sayi9 = 4.88;
            int sayi10 = (int)sayi9;

            Console.WriteLine(sayi10);

            //İndeks Operatörler[4]

            //Operatörlerde İşlem Önceliği
            //İşlemlerinizde öncelikle parantez içi işlemler sonra çarpma bölme işlemleri son olarak toplama çıkarma işlemleri yapılır.
            Console.WriteLine((9+5*5)*2);
            Console.WriteLine(9 + 5 * 2);
            Console.ReadLine();
        }
    }
}
