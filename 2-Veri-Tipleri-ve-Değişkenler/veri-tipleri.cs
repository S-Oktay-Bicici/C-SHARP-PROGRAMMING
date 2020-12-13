using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veri_tipleri
{
    class Program
    {
        static void Main(string[] args)
        {
			// int veri tipi ve ekrana yazdırma yöntemleri
			int numara = 10;
			Console.WriteLine(numara);
			Console.WriteLine("Numara {0}", numara);
			Console.WriteLine("Numara " + numara);
			Console.WriteLine(int.MaxValue + " ile " + int.MinValue + " arasındadır.");

			Console.WriteLine("--------------------------");

			//long veri tipi 
			long numara1 = 214783648;
			Console.WriteLine(numara1);
			Console.WriteLine("Numara {0}", numara1);
			Console.WriteLine("Numara " + numara1);
			Console.WriteLine(long.MaxValue + " ile " + long.MinValue + " arasındadır.");

			Console.WriteLine("--------------------------");

			//short veri tipi
			short numara2 = 32767;
			Console.WriteLine(numara2);
			Console.WriteLine("Numara {0}", numara2);
			Console.WriteLine("Numara " + numara2);
			Console.WriteLine(short.MaxValue + " ile " + short.MinValue + " arasındadır.");

			Console.WriteLine("--------------------------");

			//byte veri tipi 
			byte numara3 = 255;
			Console.WriteLine(numara3);
			Console.WriteLine("Numara {0}", numara3);
			Console.WriteLine("Numara " + numara3);
			Console.WriteLine(byte.MaxValue + " ile " + byte.MinValue + " arasındadır.");

			Console.WriteLine("--------------------------");

			//sbyte veri tipi 
			sbyte numara9 = 100;
			Console.WriteLine(numara9);
			Console.WriteLine("Numara {0}", numara9);
			Console.WriteLine("Numara " + numara9);
			Console.WriteLine(sbyte.MaxValue + " ile " + sbyte.MinValue + " arasındadır.");

			Console.WriteLine("--------------------------");

			//bool veri tipi
			bool numara4 = true; // false
			Console.WriteLine(numara4);
			Console.WriteLine("Numara {0}", numara4);
			Console.WriteLine("Numara " + numara4);

			Console.WriteLine("--------------------------");

			//char veri tipi
			char karakter = 'A';
			Console.WriteLine(karakter);
			Console.WriteLine("Karakter" + karakter);
			Console.WriteLine("Karakter {0}", karakter);
			Console.WriteLine(char.MaxValue + " ile " + char.MinValue + " arasındadır.");

			Console.WriteLine("--------------------------");

			//string veri tipi 
			string kelime = "sadık oktay biçici";
			Console.WriteLine(kelime);
			Console.WriteLine("ismim " + kelime);
			Console.WriteLine("ismim {0}", kelime);

			Console.WriteLine("--------------------------");

			//double veri tipi 
			double numara5 = 10.4;
			Console.WriteLine(numara5);
			Console.WriteLine("Numara {0}", numara5);
			Console.WriteLine("Numara " + numara5);
			Console.WriteLine(double.MaxValue + " ile " + double.MinValue + " arasındadır.");

			Console.WriteLine("--------------------------");

			//decimal veri tipi
			decimal numara6 = 3.45m;
			Console.WriteLine(numara6);
			Console.WriteLine("Numara {0}", numara6);
			Console.WriteLine("Numara " + numara6);
			Console.WriteLine(decimal.MaxValue + " ile " + decimal.MinValue + " arasındadır.");

			Console.WriteLine("--------------------------");

			//nullable veri tipi

			int? num = null;
			double? dob = null;
			bool? cins = null;

			Console.WriteLine("--------------------------");

			//var  hangi değeri atarssak o veri tipine sahip oluyor
			var numara7 = 333;
			var kelime2 = "degişik";

			Console.WriteLine(numara7);
			Console.WriteLine(kelime2);

			//object her türlü değeri barındırabilen değişken tipi
			object string_values = "Oktay";
			object int_values = 20;
			object bool_values = true;

			Console.WriteLine(string_values);
			Console.WriteLine(int_values);
			Console.WriteLine(bool_values);

			Console.ReadLine();
		}
    }
}
