using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arayüzler
{
    interface IEmlak
    {
        int MetreKare { get; set; }
        string Fiyat { get; set; }

        void Sat();
        void Kirala();
    }
}
