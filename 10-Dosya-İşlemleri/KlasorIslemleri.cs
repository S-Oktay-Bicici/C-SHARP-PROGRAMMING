using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Dosya_işlemleri
{
    class KlasorIslemleri
    {
        public bool KasorKontrol(string yol)
        {
            return Directory.Exists(yol);
        }
        public void KlasorOlustur(string yol)
        {
            Directory.CreateDirectory(yol);
        }
    }
}
