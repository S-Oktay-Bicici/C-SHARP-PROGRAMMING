using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErişimBelirleyicileri
{
    public class MetotErisimBelirleyicileri
    {
        //Sadece bulunduğu sınıfta çağırılabilirler.
        private void PrivateMetot()
        {

        }
        //Sadece bulunduğu projede çağırılabilirler.
        internal void InternalMetot()
        {
            PrivateMetot();
        }
        //Tüm projelerden erişilebilir.
        public void PublicMetot()
        {
            
        }
        //Sadece miras alınan sınıf içerisinde çağırılabilirler.
        protected void ProtectedMetot()
        {

        }
        //Miras alındığında veya kendi projesi içinde örneği oluşturulduğunda çağırılabilirler.
        protected internal void ProtectedInternalMetot()
        {

        }
    }
}
