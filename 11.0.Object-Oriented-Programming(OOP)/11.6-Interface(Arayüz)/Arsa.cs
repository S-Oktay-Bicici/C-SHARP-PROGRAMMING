using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Arayüzler
{
    class Arsa : IEmlak, IAdres
    {
        public int MetreKare { get; set; }
        public string Adres { get; set; }
        public string Fiyat { get; set; }
        public string ImarDurumu { get; set; }
        public string Il { get; set; }
        public string Ilce { get; set; }
        public string Semt { get; set; }

        public void Kirala()
        {
            throw new NotImplementedException();
        }

        public void Sat()
        {
            throw new NotImplementedException();
        }
    }
}
