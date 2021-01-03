using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Baglanti
    {
        SqlConnection baglan = new SqlConnection(@"server=S-OKTAY;user id=S-OKTAY\491633;Initial Catalog=YurtYonetim;Integrated Security=True");
        public SqlConnection baglantiAc()
        {
            baglan.Open();
            return baglan;
        }

        public SqlConnection baglantiKapat()
        {
            baglan.Close();
            return baglan;
        }
    }
}
