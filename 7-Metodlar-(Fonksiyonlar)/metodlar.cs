using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace döngüler
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> isimler = new List<string>()
            {
                "Serdar","Yılmaz","Hülya","Ahmet","Kerem","Hasan","Ayşegül","Melda","Erdem","Gizem"
            };

            List<string> isimler2 = new List<string>()
            {
                "Hasan","Ayşegül","Melda","Erdem","Gizem"
            };

            EkranaSayiYazdirma(100);

            SelamVer("Erkin");
                
            SelamVer(isimler);

            Console.ReadLine();
        }

        static void EkranaSayiYazdirma(int maxNumber)
        {
            for (int i = 0; i <= maxNumber; i++)
            {
                Console.Write(i + "-");
                if (i % 10 == 0 && i != 0)
                {
                    Console.WriteLine();
                }
            }
        }

        static void SelamVer(List<string> list)
        {
            Console.WriteLine("Listenin Eleman Sayısı " + list.Count);
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
        }

        static void SelamVer(string isim)
        {
            Console.WriteLine("Hello " + isim);
        }

        static void SelamVer()
        {

        }

        static DateTime BugununTarihi()
        {
            DateTime today = DateTime.Now;
            return today;
        }

        static string BugunGunlerdenNe(int dayCount)
        {
            DateTime tarih = DateTime.Now;
            tarih = tarih.AddDays(dayCount);
            DayOfWeek today = tarih.DayOfWeek;

            switch (today)
            {
                case DayOfWeek.Sunday:
                    return "Pazar";
                case DayOfWeek.Monday:
                    return "Pazartesi";
                case DayOfWeek.Tuesday:
                    return "Salı";
                case DayOfWeek.Wednesday:
                    return "Çarşamba";
                case DayOfWeek.Thursday:
                    return "Perşembe";
                case DayOfWeek.Friday:
                    return "Cuma";
                case DayOfWeek.Saturday:
                    return "Cumartesi";
                default:
                    return "";
            }
        }

        static int HangiYildayiz()
        {
            return DateTime.Now.Year;
        }
    }
}
