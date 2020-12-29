using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enum_kullanımı
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
                C# dilinde "enum" yapısı bu yapı yazılım dilinde enum enumaration ya da enum sabitleri olarak adlandırılır.
                Değişkenlerin alabileceği değerlerin sabiti (belli) olduğu durumlarda programı daha okunabilir hale getirmek için kullanılır.
                Programda birçok değişkene tek tek sayısal değer vermek yerine "enum" kullanılabilir.
            */

            Console.WriteLine(Yetki.Admin);

            var id = (int)Yetki.Admin;
            Console.WriteLine(id);

            Console.ReadLine();
        }

        enum Yetki
        {
            Normal,
            Moderator,
            Admin = 3,
            SuperAdmin = 4
        }
    }
}
