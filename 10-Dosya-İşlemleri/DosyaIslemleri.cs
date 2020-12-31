using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Dosya_işlemleri
{
    class DosyaIslemleri
    {
        public bool DosyaKontorol(string yol)
        {
            return File.Exists(yol);
        }

        public string DosyaOku(string yol)
        {
            return File.ReadAllText(yol);
        }

        public string[] DosyaOkuArray(string yol)
        {
            return File.ReadAllLines(yol);
        }

        public void DosyaOkuStream(string yol)
        {
            StreamReader okuyucu = new StreamReader(yol);
            while (!okuyucu.EndOfStream)
            {
                Console.WriteLine(okuyucu.ReadLine());
            }
        }

        public void BosDosyaOlustur(string yol)
        {
            File.Create(yol);
        }

        public void DosyayaYaz(string yol, string metin)
        {
            File.WriteAllText(yol, metin);
        }

        public void DosyayaYazArray(string yol, string[] metin)
        {
            File.WriteAllLines(yol, metin);
        }

        public void dosyayaYazStream(string yol, string[] metin)
        {
            StreamWriter yazici = new StreamWriter(yol);
            foreach (var satir in metin)
            {
                yazici.WriteLine(satir);
            }
            yazici.Close();
        }

        public void DosyaUzerineYaz(string yol, string[] metin)
        {
            File.AppendAllLines(yol,metin);
        }

        public bool DosyaOzellikOKu(string yol, FileAttributes nitelik)
        {
            return (File.GetAttributes(yol) & nitelik) == nitelik;
        }

        public void DosyaOzellikDegistir(string yol, FileAttributes nitelik)
        {
            if(DosyaOzellikOKu(yol,nitelik)){
                File.SetAttributes(yol, nitelik & ~nitelik);
            }
            else
            {
                File.SetAttributes(yol, nitelik & nitelik);
            }
        }

        public void DosyaSil(string yol)
        {
            File.Delete(yol);
        }
    }
}
