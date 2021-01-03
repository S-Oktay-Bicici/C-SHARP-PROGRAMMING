using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Service;
using Service.DTO;

namespace WinForm
{
    public partial class Personel : Form
    {
        IPersonelService personelService;
        public Personel()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PersonelListe();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            PersonelListe();

        }

        void PersonelListe()
        {
            personelService = new PersonelService();
            var sonuc = personelService.personelListesi("Select * from Personel");
            dtPersonelListe.DataSource = sonuc;
            txtAdi.Text = sonuc[0].Adi;
        }

        private void dtPersonelListe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnKaydet_Click_1(object sender, EventArgs e)
        {
            personelService = new PersonelService();
            personelService.insert("insert into Personel (Adi,Soyadi,KayitTarihi) values ('" + txtAdi.Text + "','" + txtSoyadi.Text + "','" + Convert.ToDateTime(dtpTarih.Text) + "')");
            PersonelListe();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var item = (PersonelDTO)dtPersonelListe.SelectedRows[0].DataBoundItem;
            personelService = new PersonelService();
            personelService.delete("delete from Personel where Id = " + item.Id + "");
            PersonelListe();
        }

        private void dtPersonelListe_SelectionChanged(object sender, EventArgs e)
        {
            if (dtPersonelListe.SelectedRows.Count != 0)
            {
                var item = (PersonelDTO)dtPersonelListe.SelectedRows[0].DataBoundItem;
                txtAdi.Text = item.Adi;
                txtSoyadi.Text = item.SoyAdi;
                dtpTarih.Value = item.KayitTarihi;

            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            var item = (PersonelDTO)dtPersonelListe.SelectedRows[0].DataBoundItem;
            personelService = new PersonelService();
            personelService.update("update Personel set Adi = '" + txtAdi.Text + "' where Id = '" + item.Id + "'");
            PersonelListe();
        }
    }
}
