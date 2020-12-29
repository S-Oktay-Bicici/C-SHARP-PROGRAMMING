using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_String_İşlemleri
{
    class Program
    {
        static void Main(string[] args)
        {
            string cumle = "Sadık Oktay Biçici";

            Console.WriteLine(cumle.Length);

            Console.WriteLine(cumle.Remove(3, 5));

            Console.WriteLine(cumle.Insert(2, " DEvexpres"));

            Console.WriteLine(cumle.Replace("Temel", "Ana"));

            Console.WriteLine(cumle.Trim('C'));

            Console.WriteLine(cumle.TrimStart('C'));

            Console.WriteLine(cumle.TrimEnd('C'));

            Console.WriteLine(cumle.ToUpper());

            Console.WriteLine(cumle.ToLower());

            Console.WriteLine(cumle.Contains("Temel"));

            Console.WriteLine(cumle.Substring(3, 5));

            Console.WriteLine(cumle.StartsWith("C#"));

            Console.WriteLine(cumle.EndsWith("Hoşgeldiniz"));

            Console.WriteLine(cumle.Equals("C#"));

            Console.WriteLine(cumle.LastIndexOf("e"));

            Console.WriteLine(cumle.IndexOf("e"));


            string parcaliVeri = "Bicici-Oktay*Sadık";
            char[] ayrac = { '-', '*' };

            string[] parcaliVeriArray = parcaliVeri.Split(ayrac);


            foreach (var item in parcaliVeriArray)
            {
                Console.WriteLine(item);
            }

            foreach (var item in parcaliVeri.Split(ayrac))
            {
                Console.WriteLine(item);
            }
            //Yeni Satıra Geçmek İçin Kullanılır.
            Console.WriteLine("C#\deneme");
			
            //Tab Boşluğu vermek için kullanılır.
            Console.WriteLine("C#\tTab");
			
            //Satır başını değiştirme
            Console.WriteLine("Biçici\rOktay");
			
            //Bip sesi çıkarma
            //Console.WriteLine("SAdık\aOKtay");
            //Bir önceki karakteri silme
            Console.WriteLine("Oktay\bSdık");

            Console.WriteLine("C:\\Belgeler\\abc.txt");
            Console.WriteLine(@"C:\Belgeler\abc.txt");
            int a = 15;
            Console.WriteLine("\"\'\x23  \x22");

            Console.WriteLine($"{a} {a*2}");

            Console.WriteLine(String.Format("{0} {1} {2}",a,a*2,a*a));

            string[] dizi = {"mert", "Selin", "okaty"};
            string[] dizi2 = { "Mehmet", "Abdullah", "Ali" };

            Console.WriteLine($"{dizi[0],-20} {dizi[1],-20} {dizi[2],-20}");
            //Sağa dayalı formatta eksi işaretini kaldır.
            Console.WriteLine($"{dizi2[0],-20} {dizi2[1],-20} {dizi2[2],-20}");

            string veri="";

            for (int i = 0; i < dizi.Length; i++)
            {
                veri += dizi[i];
            }

            StringBuilder veri2=new StringBuilder();

            for (int i = 0; i < dizi.Length; i++)
            {
                veri2.Append(dizi[i]);
            }

            Console.WriteLine(veri);

            Console.WriteLine(veri2);
            Console.ReadLine();
        }
    }
}
