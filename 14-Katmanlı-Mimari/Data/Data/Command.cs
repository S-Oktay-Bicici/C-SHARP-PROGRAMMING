using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Command
    {
        Baglanti baglanti = new Baglanti();
        public SqlCommand command(String sqlCumlesi)
        {
            SqlCommand cmd = new SqlCommand(sqlCumlesi, baglanti.baglantiAc());
            return cmd;
        }
    }
}
