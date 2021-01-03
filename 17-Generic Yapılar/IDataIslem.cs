using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Yapılar
{
    interface IDataIslem<T> where T:class,IData,new()
    {
        void Ekle(T veri);
        void Duzenle(T veri);
        void Sil(T veri);
        List<T> Listele();
    }
}
