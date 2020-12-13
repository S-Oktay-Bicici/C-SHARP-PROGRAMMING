using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_birleştirme_yöntemi
{
    class Program
    {
        static void Main(string[] args)
        {
            string ad, soyad, email, link_profil, sonuc, ayirac = "--------";
            ad = "Sadık Oktay";
            soyad = "Biçici";
            email = "491633oktay@gmail.com";
            link_profil = "sadık-oktay-bicici";
            sonuc = ayirac + "\n" +
                    "ad: " + ad + "\n" +
                    "soyad: " + soyad + "\n" +
                    "email: " + email + "\n" +
                    "linkedin: " + link_profil + "\n" +
                    ayirac;
            Console.WriteLine(sonuc);

            StringBuilder builder = new StringBuilder();
            builder.Append("Ad: " + ad);
            builder.Append(Environment.NewLine);
            builder.Append("Soyad: ");
            builder.Append(soyad);
            Console.WriteLine(builder.ToString());

            Console.ReadLine();



        }
    }
}
