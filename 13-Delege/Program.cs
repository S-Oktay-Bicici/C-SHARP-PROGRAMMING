using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegele
{
    class Program
    {

        //delegeler kullanılan metodların dönüş tipinde olmak zorundadır.
        delegate void PizzaYap();
        static void Main(string[] args)
        {
            PizzaYap pizzaYap = new PizzaYap(StandartMalzeme);
            pizzaYap += SucukluPizza;
            pizzaYap += VejeteryanPizza;
            pizzaYap -= SucukluPizza;

            pizzaYap();


            //delegeler parametre olarak da verilebilir
            PizzaYapMetodu(SucukluPizza);



            Faiz faizSinif = new Faiz();
            Faiz.FaizHesapla faizHesapla;
            faizHesapla = faizSinif.GunlukFaiz;
            faizHesapla += faizSinif.AylikFaiz;
            faizHesapla += faizSinif.YillikFaiz;

            faizHesapla(10000,12);

            Console.ReadLine();

        }

        static void PizzaYapMetodu(PizzaYap pizzaMetodu)
        {
            pizzaMetodu += StandartMalzeme;
            pizzaMetodu();
        }

        static void StandartMalzeme()
        {
            Console.WriteLine("Hamur eklendi.");
            Console.WriteLine("Domates sosu eklendi.");
            Console.WriteLine("Kaşar Peyniri eklendi.");
        }

        static void SucukluPizza()
        {
            Console.WriteLine("Sucuk eklendi.");
            Console.WriteLine("Baharat eklendi.");
        }

        static void VejeteryanPizza()
        {
            Console.WriteLine("Dere Otu eklnedi.");
            Console.WriteLine("Baharat eklendi.");
        }

        static void TonBalikliPizza()
        {
            Console.WriteLine("Ton balığı eklendi.");
            Console.WriteLine("Dere otu eklendi.");
        }
    }
}
