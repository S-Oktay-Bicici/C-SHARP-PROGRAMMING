using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErişimBelirleyicileri
{
    //Sadece Kendi Projesinde Örneği Oluşturulabilir
    class InternalSinif : MetotErisimBelirleyicileri
    {
        void Metot()
        {
            MetotErisimBelirleyicileri erisim = new MetotErisimBelirleyicileri();

            ProtectedMetot();
            ProtectedInternalMetot();
        }


    }
    //Referans olarak eklenen tüm Projelerde örneği oluşturulabilir
    public class PublicSinif
    {
        void Metot()
        {
            MetotErisimBelirleyicileri erisim = new MetotErisimBelirleyicileri();
            erisim.ProtectedInternalMetot();
        }
    }
}
