using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jenerik_olmayan_koleksiyon
{
    class Program
    {
        static void Main(string[] args)
        {
            #region NonGeneric

            //farklı türlerdeki verilerin vir arada saklanabildiği koleksiyon türleridir
            //içerisindeki verilerin else edlilip kullanılabilemsei için boxing/unboxing işlemine tabi tutulması gerekir
            //System.Collection namespace inde yer alırlar

            //içerikler : ArrayList, HashTables, SortedList

            #region ArrayList Exapmle

            ArrayList Sehirler = new ArrayList();
            Sehirler.Add("istanbul");
            Sehirler.Add("ankara");
            Sehirler.Add("izmir");
            Sehirler.Add("bursa");

            foreach(var sehir in Sehirler)
            {
                Console.WriteLine(sehir);
            }

            Console.WriteLine("Count: " + Sehirler.Count);
            Console.WriteLine("Capacty: " + Sehirler.Capacity);
            Sehirler.Capacity = 100;
            Sehirler.Contains("izmir");//arar varsa true döndürür

            Sehirler.Add(3);
            Sehirler.Add(true);
            Sehirler.Add(new Program());

            #endregion

            #region HashTable Example

            Hashtable Siniflar = new Hashtable();
            Siniflar.Add("007", "Yazılım Veri Tabanı Uzmanlığı");
            Siniflar.Add("008", "Sistem ve Ağ Uzmanlığı");
            Siniflar.Add("005", "&&&&&&");
            Siniflar.Add("003", "Ağ Uzmanlığı");

            foreach(DictionaryEntry sinif in Siniflar)
            {
                Console.WriteLine(sinif.Key);
            }

            #endregion


            #endregion
        }
    }
}
