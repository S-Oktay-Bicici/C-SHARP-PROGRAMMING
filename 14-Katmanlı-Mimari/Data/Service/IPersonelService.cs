using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service.DTO;

namespace Service
{
    public interface IPersonelService
    {
        int insert(string sqlCumlesi);
        void delete(string sqlCumlesi);
        void update(string sqlCumlesi);

        List<PersonelDTO> personelListesi(string sqlCumlesi);
    }
}
