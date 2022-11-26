using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoGallery
{
    public partial class SalesContract : Form
    {
        public SalesContract()
        {
            InitializeComponent();
        }
        public int customerid;
        public int carid;
        

        private void SalesContract_Load(object sender, EventArgs e)
        {
            var salescontract = from soz in DatabaseCon.autoGalleryEntity.Sozlesme_Tablosu
                                 join
                                 mus in DatabaseCon.autoGalleryEntity.Musteri_Tablosu on soz.Musteri_Id equals mus.Musteri_Id
                                 join
                                 arac in DatabaseCon.autoGalleryEntity.Arac_Tablosu on soz.Arac_Id equals arac.Arac_Id
                                 join
                                 model in DatabaseCon.autoGalleryEntity.Model_Tablosu on arac.Model_Id equals model.Model_Id
                                 join
                                 marka in DatabaseCon.autoGalleryEntity.Marka_Tablosu on model.Marka_Id equals marka.Marka_Id
                                 join
                                 per in DatabaseCon.autoGalleryEntity.Personel_Tablosu on soz.Personel_Id equals per.Personel_Id
                                 join
                                 sube in DatabaseCon.autoGalleryEntity.Subeler_Tablosu on soz.Sube_Id equals sube.Sube_Id
                                 where soz.Sozlesme_Turu_Id == 2
                                 select new
                                 {
                                     ID = soz.Sozlesme_Id,
                                     MüşteriAdıSoyadı = mus.Musteri_Adi_Soyadi,
                                     MüşteriTC = mus.Musteri_Tc,
                                     MüşteriTelefon = mus.Musteri_Telefon,
                                     Marka = marka.Marka_Adi,
                                     Model = model.Model_Adi,
                                     Plaka = arac.Plaka,
                                     Gün = soz.Alıs_Tarihi,
                                     ToplamÜcret = soz.Toplam_Ucret,
                                     PersonelAdıSoyadı = per.Personel_Adi_Soyadi,
                                     SubeAdı = sube.Sube_Adi
                                 };

            AutoGallerydataGridView.DataSource = salescontract.ToList();
        }

        private void SalesContactButtonCustomer_Click(object sender, EventArgs e)
        {
            FormControl.salesCustomers.Show();
        }

        private void SalesContactButtonCar_Click(object sender, EventArgs e)
        {
            FormControl.salesCars.Show();
        }
        
        private void SalesContactButtonRentalContact_Click(object sender, EventArgs e)
        {
            Sozlesme_Tablosu sozlesme_Tablosu = new Sozlesme_Tablosu();
            sozlesme_Tablosu.Musteri_Id = customerid;
            sozlesme_Tablosu.Arac_Id = carid;
            sozlesme_Tablosu.Alıs_Tarihi = SalesContactDateTimePickerFirstDay.Value;
            sozlesme_Tablosu.Veris_Tarihi = null;
            sozlesme_Tablosu.Toplam_Ucret = Convert.ToDecimal(SalesContractTextBoxTotalFee.Text);
            sozlesme_Tablosu.Sozlesme_Turu_Id = 2;
            sozlesme_Tablosu.Personel_Id = Login.EmployeeId;
            sozlesme_Tablosu.Sube_Id = Login.BranchId;
            DatabaseCon.autoGalleryEntity.Sozlesme_Tablosu.Add(sozlesme_Tablosu);
            DatabaseCon.autoGalleryEntity.SaveChanges();

            var salescontract = from soz in DatabaseCon.autoGalleryEntity.Sozlesme_Tablosu
                                join
                                mus in DatabaseCon.autoGalleryEntity.Musteri_Tablosu on soz.Musteri_Id equals mus.Musteri_Id
                                join
                                arac in DatabaseCon.autoGalleryEntity.Arac_Tablosu on soz.Arac_Id equals arac.Arac_Id
                                join
                                model in DatabaseCon.autoGalleryEntity.Model_Tablosu on arac.Model_Id equals model.Model_Id
                                join
                                marka in DatabaseCon.autoGalleryEntity.Marka_Tablosu on model.Marka_Id equals marka.Marka_Id
                                join
                                per in DatabaseCon.autoGalleryEntity.Personel_Tablosu on soz.Personel_Id equals per.Personel_Id
                                join
                                sube in DatabaseCon.autoGalleryEntity.Subeler_Tablosu on soz.Sube_Id equals sube.Sube_Id
                                where soz.Sozlesme_Turu_Id == 2
                                select new
                                {
                                    ID = soz.Sozlesme_Id,
                                    MüşteriAdıSoyadı = mus.Musteri_Adi_Soyadi,
                                    MüşteriTC = mus.Musteri_Tc,
                                    MüşteriTelefon = mus.Musteri_Telefon,
                                    Marka = marka.Marka_Adi,
                                    Model = model.Model_Adi,
                                    Plaka = arac.Plaka,
                                    Gün = soz.Alıs_Tarihi,
                                    ToplamÜcret = soz.Toplam_Ucret,
                                    PersonelAdıSoyadı = per.Personel_Adi_Soyadi,
                                    SubeAdı = sube.Sube_Adi
                                };

            AutoGallerydataGridView.DataSource = salescontract.ToList();

            SalesContractTextBoxSecurityNumber.Text = "";
            SalesContractTextBoxNameSurname.Text = "";
            SalesContractTextBoxTelephone.Text = "";
            SalesContractTextBoxAdress.Text = "";
            SalesContractTextBoxBrand.Text = "";
            SalesContractTextBoxModel.Text = "";
            SalesContractTextBoxPlate.Text = "";
            SalesContractTextBoxSalesMoney.Text = "";

            var car = DatabaseCon.autoGalleryEntity.Arac_Tablosu.FirstOrDefault(a => a.Arac_Id == carid);

            car.Arac_Durumu_Id = 3;


            DatabaseCon.autoGalleryEntity.SaveChanges();
        }
    }
}
