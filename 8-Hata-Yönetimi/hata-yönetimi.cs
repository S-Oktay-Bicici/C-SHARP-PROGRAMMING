using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hata_Yönetimi
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Try Bloğuna Girildi.");
                //int a = Convert.ToInt32("Erhan");
                //int b = 100 / Convert.ToInt32(0);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("0 sayısına bölünme hatası");
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format hatası");
            }
            finally
            {
                Console.WriteLine("İşlem Yapıldı.");
            }

            string[] isimler = {"Erhan", "Toprak", "Selin"};

            foreach (var isim in isimler)
            {
                Console.WriteLine(isim);
            }
            Console.ReadLine();

        }
    }
}
