using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sınıflar
{
    class Program
    {
        static void Main(string[] args)
        {

            //Sınıfları Array Olarak Tanımlama
            Hesaplar[] hesapArray=new Hesaplar[3]
            {
                new Hesaplar(5,"Erhan"), 
                new Hesaplar(6,"Toprak"), 
                new Hesaplar(7,"Selin")
            };

            //Oluşturulan Sınıf Dizisinin Elemanlarına Ulaşma
            hesapArray[0].HesapEkle();

            //Sınıfların Örneklerini Alternatif Oluşturma
            hesapArray[0]=new Hesaplar(5,"Erhan");
            hesapArray[1] = new Hesaplar(6, "Toprak");
            hesapArray[2]= new Hesaplar(7, "Selin");
            //Normalde Bu şekilde örnek oluşturuyoruz.
            Hesaplar hesap3=new Hesaplar(5,"Erhan");
            Hesaplar hesap4 = new Hesaplar(6, "Toprak");
            Hesaplar hesap5 = new Hesaplar(7, "Selin");


            
            Console.ReadLine();
        }
    }
}
