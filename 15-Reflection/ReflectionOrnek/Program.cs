using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionOrnek
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] BankaBilgileri = new string[4];
            BankaBilgileri[0] = "VakıfBAnk";
            BankaBilgileri[1] = "Ziraat";
            BankaBilgileri[2] = "Akbank";
            BankaBilgileri[3] = "HalkBank";

            Console.WriteLine("Kredi Hesaplama Uygulaması");
            Console.WriteLine("1- VakıfBank");
            Console.WriteLine("2- Ziraat");
            Console.WriteLine("3- Akbank");
            Console.WriteLine("4- HalkBank");
            Console.WriteLine("Lütfen bir seçim yapın");

            /*
            switch (Console.ReadLine())
            {
                case "1":
                    Vakıfbank vakıfbank = new Vakıfbank();
                    vakıfbank.KrediHesapla();
                    break;
                case "2":
                    Ziraat ziraat = new Ziraat();
                    ziraat.KrediHesapla();
                    break;
                case "3":
                    Akbank akbank = new Akbank();
                    akbank.KrediHesapla();
                    break;
                case "4":
                    HalkBank halkbank = new HalkBank();
                    halkbank.KrediHesapla();
                    break;
            }*/ 

            string GelenVeri = BankaBilgileri[Convert.ToInt32(Console.ReadLine()) - 1];
            Assembly assembly = Assembly.GetExecutingAssembly();
            var tip = assembly.GetType($"{assembly.GetName().Name}.Bankalar.{GelenVeri}");
            var instance = Activator.CreateInstance(tip);
            MethodInfo method = tip.GetMethod("KrediHesapla");
            method.Invoke(instance, null);

            Console.ReadLine();
        }
    }
}
