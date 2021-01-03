using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Yapılar
{
    public class Yazar : IData
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string DogumYeri { get; set; }
        public int Yasi { get; set; }

    }
}
