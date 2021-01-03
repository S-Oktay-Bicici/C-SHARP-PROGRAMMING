using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Net.Mime;
using System.Text;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {

            Assembly assembly = Assembly.GetExecutingAssembly();
            //foreach (var item in assembly.GetTypes())
            //{
            //    Console.WriteLine(item.Name);
            //}

            //foreach (var item in assembly.GetType($"{assembly.GetName().Name}.Class1").GetMethods())
            //{
            //    Console.WriteLine(item.Name);
            //}

            foreach (var item in assembly.GetType($"{assembly.GetName().Name}.Class1").GetMethod("deneme1").GetParameters())
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.ParameterType);
            }

            //Class1 sinif=new Class1();
            //sinif.deneme1(15,true);

            var tip = assembly.GetType($"{assembly.GetName().Name}.Class1");
            var instance = Activator.CreateInstance(tip, new object[] { 15, false });

            MethodInfo method = tip.GetMethod("deneme1");
            method.Invoke(instance, new object[] { 15, false });

            MethodInfo method2 = tip.GetMethod("deneme");
            method2.Invoke(instance, null);

            PropertyInfo propertyInfo = tip.GetProperty("IntegerProp");

            propertyInfo.SetValue(instance, 55);

            Console.WriteLine(propertyInfo.GetValue(instance));

            //Solution içindeki diğer projelere ulaşmak.(Referans Alındıysa Çalışır)
            Assembly disAssembly = Assembly.Load(" /*proje ismini veriyoruz*/ ");
            foreach (var sinif in disAssembly.GetTypes())
            {
                Console.WriteLine(sinif.Name);
            }

            var tip2 = disAssembly.GetType(" /*proje ismini veriyoruz*/ "); 
            var instance2 = Activator.CreateInstance(tip2);

            MethodInfo method3 = tip2.GetMethod("HosGeldin");
            method3.Invoke(instance2, null);


            //Solution içindeki diğer projelere ulaşmak.(Referans Alınmasına Gerek Yok.)
            Assembly disAssemblyReferanssiz = Assembly.LoadFile(@" /*projenin konumunu veriyoruz*/ "); 

            foreach (var sinif in disAssemblyReferanssiz.GetTypes())
            {
                Console.WriteLine(sinif.Name);
            }

            Assembly UygulamaAssembly=Assembly.GetExecutingAssembly();

            var ReflectionTip = assembly.GetType("Reflection.ReflectionKomutlar");
            var instanceReflection = Activator.CreateInstance(ReflectionTip);
            Console.WriteLine("Lütfen Bir Komut Girin");

            char ayrac = ' ';
            string Komut = Console.ReadLine();
            string[] KomutParca = Komut.Split(ayrac);
            string[] Parametreler=new string[KomutParca.Length - 1];
            Array.Copy(KomutParca, 1, Parametreler, 0, KomutParca.Length - 1);


            MethodInfo KomutMetodu = ReflectionTip.GetMethod(KomutParca[0]);

            if (Parametreler.Length==0)
            {
                 KomutMetodu.Invoke(instanceReflection, null);
            }
            else
            {
                KomutMetodu.Invoke(instanceReflection, new object[]{Parametreler});
            }

            //KomutMetodu.Invoke(instanceReflection, Parametreler.Length == 0 ? null : new object[]{ Parametreler } );

            Console.ReadLine();

        }
    }
}
