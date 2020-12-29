using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kutuphane1 = Sınıf_Kutuphanesi;
using Kutuphane2 = Sınıf_Kutuphanesi_2;
using ErişimBelirleyicileri;

namespace SınıflarıCagirma
{
    class Program
    {
        static void Main(string[] args)
        {
            Kutuphane2.IlkKutuphanem kutuphane = new Kutuphane2.IlkKutuphanem();
            Kutuphane2.IkinciKutuphanem kutuphane2 = new Kutuphane2.IkinciKutuphanem();
         
            kutuphane.HosGeldin();
            kutuphane2.HosGeldin();
            PublicSinif Sinif=new PublicSinif();
            MetotErisimBelirleyicileri erisim = new MetotErisimBelirleyicileri();
   
        }
    }
}
