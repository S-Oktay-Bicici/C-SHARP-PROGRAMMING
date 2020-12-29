using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalıtım
{
    class Program
    {
        static void Main(string[] args)
        {
            Cari musteri=new Cari();
            musteri.Kaydet(new Urun());
            Console.ReadLine();
        }
    }
}
