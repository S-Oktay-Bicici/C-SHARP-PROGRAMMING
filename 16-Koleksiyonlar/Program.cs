using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayListKoleksiyonu();
            //HashTableKoleksiyonu();
            //SortedListKoleksiyonu();
            //StackKoleksiyonu();
            //QueueKoleksiyonu();
            //ListKoleksiyonu();
            //DictionaryKoleksiyonu();
            //DigerKoleksiyonlar();
            List<Kitap> kitapListesi = new List<Kitap>();

            //1. Tanımlama Yöntemi
            Kitap kitap1 = new Kitap();
            kitap1.Id = 1;
            kitap1.Adi = "Vadideki Zambak";
            kitap1.Yazari = "Balzac";
            kitap1.SayfaSayisi = 250;
            kitap1.Barkodu = "12345";

            kitapListesi.Add(kitap1);

            //2. Tanımlama Yöntemi
            kitapListesi.Add(new Kitap
            {
                Id = 2,
                SayfaSayisi = 550,
                Adi = "Sefiller",
                Yazari = "Victor Hugo",
                Barkodu = "23456"
            });

            foreach (var kitap in kitapListesi)
            {
                Console.WriteLine($"{kitap.Id} - {kitap.Barkodu} - {kitap.Adi} - {kitap.Yazari} - {kitap.SayfaSayisi}");
            }

            Console.ReadLine();
        }

        private static void DigerKoleksiyonlar()
        {
            SortedDictionary<string, string> sorted = new SortedDictionary<string, string>();
            Queue<string> stringQueue = new Queue<string>();
            Stack<int> intStack = new Stack<int>();
        }

        private static void DictionaryKoleksiyonu()
        {
            Dictionary<string, string> sozluk = new Dictionary<string, string>();
            sozluk.Add("Desk", "Masa");
            sozluk.Add("Chair", "Sandalye");

            foreach (var item in sozluk.Values)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("---------------");
            Console.WriteLine("Bir Kelime Girin");
            Console.WriteLine(sozluk[Console.ReadLine()]);
        }

        private static void ListKoleksiyonu()
        {
            List<string> Isimler = new List<string>();
            Isimler.Add("Erhan");
            Isimler.Add("Selin");
            Isimler.Add("Toprak");
            Isimler.AddRange(new string[] { "Ahmet", "Mehmet" });
        }

        private static void QueueKoleksiyonu()
        {
            Queue queue = new Queue();

            queue.Enqueue("Erhan");
            queue.Enqueue("Toprak");
            queue.Enqueue("Selin");
            queue.Enqueue(123);


            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-----------");
            Console.WriteLine(queue.Peek());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine("-----------");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
        }

        private static void StackKoleksiyonu()
        {
            Stack stack = new Stack();
            stack.Push("Erhan");
            stack.Push(123);
            stack.Push(true);

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("---------------");
            //Diziden ilk çıkacak elemana ulaşmak için kullanılır.
            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine("---------------");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }

        private static void SortedListKoleksiyonu()
        {
            SortedList sortedList = new SortedList();
            sortedList.Add(4, "Erhan");
            sortedList.Add(3, "Toprak");
            sortedList.Add(5, "Selin");

            foreach (var item in sortedList.Values)
            {
                Console.WriteLine(item);
            }
        }

        private static void HashTableKoleksiyonu()
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add("A", "Erhan");
            hashtable.Add("B", 15);
            hashtable.Add("C", 38.7);
            hashtable.Add(1, "Toprak");

            foreach (var item in hashtable.Keys)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("--------------------");
            //Değer Atama
            hashtable["B"] = "Selin";
            //Değere Ulaşma
            Console.WriteLine(hashtable["B"]);

            hashtable.Remove("C");
            foreach (var item in hashtable.Keys)
            {
                Console.WriteLine(item);
            }
        }

        private static void ArrayListKoleksiyonu()
        {
            //ArrayList Koleksiyonu
            ArrayList arrayList = new ArrayList();

            arrayList.Add(5);
            arrayList.Add(true);
            arrayList.Add("Erhan");
            arrayList.Add('K');
            arrayList.AddRange(new object[] { "Toprak", "Selin", "Erhan", 35.2, false });


            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            //Doğrudan eleman ismiyle silme
            arrayList.Remove("Erhan");
            //İndex numarasıyla Silme
            arrayList.RemoveAt(2);
            //İstediğimiz yerden istediğimiz kadar kayıt silme
            arrayList.RemoveRange(0, 3);


            Console.WriteLine("-------------------------------");

            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            //Arraylistten Eleman silindiğinde kapasite değişmez.

            Console.WriteLine(arrayList.Capacity);

            //Değer Atama
            arrayList[2] = false;
            //Değer Ulaşma
            Console.WriteLine(arrayList[2]);
        }
    }
}
