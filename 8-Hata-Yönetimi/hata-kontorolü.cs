using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hata_kontrolü
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                int[] array = new int[2];

                array[0] = 1;
                array[1] = 2;

                Console.WriteLine(array[2]);

                Console.WriteLine("Yaşınızı giriniz: ");

                int age = int.Parse(Console.ReadLine());
                Console.WriteLine("Yaşınız: " + age);
            }
            catch (FormatException exception)
            {
                Console.WriteLine("Lütfen sayısal bir değer giriniz");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            finally
            {
                //mutlaka çalışmalı
                Console.WriteLine("Mutlaka çalışması gereken kod");
            }

            Console.ReadLine();
        }
    }
}
