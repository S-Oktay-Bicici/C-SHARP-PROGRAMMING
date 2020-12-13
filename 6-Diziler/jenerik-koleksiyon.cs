using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jenerik_koleksiyon
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Generic(jenerik)

            //System.Collection.Generic içerisinde yer alır
            //veriler object türürnde değil, belirtilen türde alır.
            //boxing/unboxing işlemine gerek olmadığını gösterir
            //olukşturma sırasında veri tipini belirtmek zorundadir
            //ArrayList gibi NonGeneric yağolara göre daha performaslı çalışır

            //içerikelr: Lisr, Stack, Queue, LinkedList, Dictionary, SortedDictionary, SortedSet, HashSet

            #region List Example

            List<string> Diller = new List<string>();
            Diller.Add("c");
            Diller.Add("C++");
            Diller.Add("C#");
            //Diller.Add(121); hata
            //Dillr.Add(3,2); hata

            foreach (var dil in Diller)
            {
                Console.WriteLine(dil);
            }

            for (int i = 0; i < Diller.Count; i++)
            {
                Console.WriteLine(Diller[i]);
            }

            Diller.RemoveRange(1, 2);
            foreach (var li in Diller)
            {
                Console.WriteLine(li);
            }

            #endregion

            #region Dictionary Example

            Dictionary<int, string> Kullanicilar = new Dictionary<int, string>();
            Kullanicilar.Add(2, "oktay");
            Kullanicilar.Add(5, "sadık");

            foreach (var kullanici in Kullanicilar)
            {
                Console.WriteLine(kullanici.Value);
            }

            KeyValuePair<int, string> kull = Kullanicilar.First();
            Console.WriteLine(kull.Key + " " + kull.Value);

            string str = Kullanicilar.Values.First();
            Console.WriteLine(str);

            Dictionary<int, string> Diler = new Dictionary<int, string>()
            {
                { 1, "C"},
                { 2, "C++"},
                { 3, "C#"}
            };

            List<string> diziListesi = Diler.Values.ToList();

            foreach(var dil in diziListesi)
            {
                Console.WriteLine(dil);
            }

            #endregion

            #endregion
        }
    }
}
