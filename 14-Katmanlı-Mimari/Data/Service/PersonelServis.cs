using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Service.DTO;

namespace Service
{
    public class PersonelService : IPersonelService
    {
        Baglanti bag = new Baglanti();
        Command cmd = new Command();

        public void delete(string sqlCumlesi)
        {
            SqlCommand cmd1 = cmd.command(sqlCumlesi);

            cmd1.ExecuteNonQuery();

            bag.baglantiKapat();
        }

        public int insert(string sqlCumlesi)
        {
            SqlCommand cmd1 = cmd.command(sqlCumlesi);

            cmd1.ExecuteNonQuery();

            bag.baglantiKapat();

            return 0;
        }

        public void update(string sqlCumlesi)
        {
            SqlCommand cmd1 = cmd.command(sqlCumlesi);

            cmd1.ExecuteNonQuery();

            bag.baglantiKapat();
        }

        public List<PersonelDTO> personelListesi(string sqlCumlesi)
        {
            SqlCommand cmd1 = cmd.command(sqlCumlesi);
            SqlDataReader dr = cmd1.ExecuteReader();
            List<PersonelDTO> pdto = new List<PersonelDTO>();
                while (dr.Read())
            {
                pdto.Add(new PersonelDTO
                {
                    Id = Convert.ToInt32(dr["Id"].ToString()),
                    Adi = dr["Adi"].ToString(),
                    SoyAdi = dr["Soyadi"].ToString(),
                    KayitTarihi = Convert.ToDateTime(dr["KayitTarihi"].ToString()),
                });
            }
            bag.baglantiKapat();
            return pdto;
        }
    }
}
