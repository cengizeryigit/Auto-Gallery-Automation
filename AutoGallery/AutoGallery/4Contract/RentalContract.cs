using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoGallery
{
    public partial class RentalContract : Form
    {
        public RentalContract()
        {
            InitializeComponent();
        }
        public int customerid;
        public int carid;
        public decimal totalfee;
        public string carsituation ="Vehicle has been delivered";
        private void RentalContract_Load(object sender, EventArgs e)
        {
            var rentalcontract = from soz in DatabaseCon.autoGalleryEntity.Sozlesme_Tablosu
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
                                 where soz.Sozlesme_Turu_Id ==1
                                 select new
                                 {
                                     ID = soz.Sozlesme_Id,
                                     MüşteriAdıSoyadı = mus.Musteri_Adi_Soyadi,
                                     MüşteriTC = mus.Musteri_Tc,
                                     MüşteriTelefon = mus.Musteri_Telefon,
                                     Marka = marka.Marka_Adi,
                                     Model = model.Model_Adi,
                                     Plaka = arac.Plaka,
                                     İlkGün = soz.Alıs_Tarihi,
                                     SonGün = soz.Veris_Tarihi,
                                     ToplamÜcret = soz.Toplam_Ucret,
                                     PersonelAdıSoyadı= per.Personel_Adi_Soyadi,
                                     SubeAdı= sube.Sube_Adi
                                 };

            AutoGallerydataGridView.DataSource = rentalcontract.ToList();
        }

        private void RentalContactButtonCustomer_Click(object sender, EventArgs e)
        {
            FormControl.rentalCustomers.Show();
        }

        private void RentalContactButtonCar_Click(object sender, EventArgs e)
        {
            
            FormControl.rentalCars.Show();
        }

        private void RentalContactButtonCalculate_Click(object sender, EventArgs e)
        {
            int firstdate= RentalContactDateTimePickerFirstDay.Value.DayOfYear;
            int lastdate= RentalContactDateTimePickerLastDay.Value.DayOfYear;
            int sayi =lastdate-firstdate;
            totalfee=sayi * Convert.ToDecimal(RentalContractTextBoxRentMoney.Text);
            RentalContractTextBoxTotalFee.Text = totalfee.ToString();
        }

        private void RentalContactButtonRentalContact_Click(object sender, EventArgs e)
        {


            Sozlesme_Tablosu sozlesme_Tablosu = new Sozlesme_Tablosu();
            sozlesme_Tablosu.Musteri_Id = customerid;
            sozlesme_Tablosu.Arac_Id = carid;
            sozlesme_Tablosu.Alıs_Tarihi = RentalContactDateTimePickerFirstDay.Value;
            sozlesme_Tablosu.Veris_Tarihi = RentalContactDateTimePickerLastDay.Value;
            sozlesme_Tablosu.Toplam_Ucret = totalfee;
            sozlesme_Tablosu.Sozlesme_Turu_Id = 1;
            sozlesme_Tablosu.Personel_Id = Login.EmployeeId;
            sozlesme_Tablosu.Sube_Id = Login.BranchId;
            DatabaseCon.autoGalleryEntity.Sozlesme_Tablosu.Add(sozlesme_Tablosu);
            DatabaseCon.autoGalleryEntity.SaveChanges();


            var rentalcontract = from soz in DatabaseCon.autoGalleryEntity.Sozlesme_Tablosu
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
                                 where soz.Sozlesme_Turu_Id == 1
                                 select new
                                 {
                                     ID = soz.Sozlesme_Id,
                                     MüşteriAdıSoyadı = mus.Musteri_Adi_Soyadi,
                                     MüşteriTC = mus.Musteri_Tc,
                                     MüşteriTelefon = mus.Musteri_Telefon,
                                     Marka = marka.Marka_Adi,
                                     Model = model.Model_Adi,
                                     Plaka = arac.Plaka,
                                     İlkGün = soz.Alıs_Tarihi,
                                     SonGün = soz.Veris_Tarihi,
                                     ToplamÜcret = soz.Toplam_Ucret,
                                     PersonelAdıSoyadı = per.Personel_Adi_Soyadi,
                                     SubeAdı = sube.Sube_Adi
                                 };

            AutoGallerydataGridView.DataSource = rentalcontract.ToList();


            RentalContractTextBoxSecurityNumber.Text = "";
            RentalContractTextBoxNameSurname.Text = "";
            RentalContractTextBoxTelephone.Text = "";
            RentalContractTextBoxAdress.Text = "";
            RentalContractTextBoxBrand.Text = "";
            RentalContractTextBoxModel.Text = "";
            RentalContractTextBoxPlate.Text = "";
            RentalContractTextBoxRentMoney.Text = "";



            var car = DatabaseCon.autoGalleryEntity.Arac_Tablosu.FirstOrDefault(a => a.Arac_Id==carid);

            car.Arac_Durumu_Id = 2;


            DatabaseCon.autoGalleryEntity.SaveChanges();
        }

        private void VehicleDelivered_Click(object sender, EventArgs e)
        {
            string plaka = AutoGallerydataGridView.CurrentRow.Cells[6].Value.ToString();
            var update = DatabaseCon.autoGalleryEntity.Arac_Tablosu.FirstOrDefault(u => u.Plaka == plaka);

            update.Arac_Durumu_Id = 1;
            DatabaseCon.autoGalleryEntity.SaveChanges();

        
            MessageBox.Show(carsituation);
        }

        private void RentalContactButtonListRentCar_Click(object sender, EventArgs e)
        {
            var rentalcontract = from soz in DatabaseCon.autoGalleryEntity.Sozlesme_Tablosu
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
                                 where arac.Arac_Durumu_Id == 2 && soz.Sozlesme_Turu_Id == 1
                                 select new
                                 {
                                     ID = soz.Sozlesme_Id,
                                     MüşteriAdıSoyadı = mus.Musteri_Adi_Soyadi,
                                     MüşteriTC = mus.Musteri_Tc,
                                     MüşteriTelefon = mus.Musteri_Telefon,
                                     Marka = marka.Marka_Adi,
                                     Model = model.Model_Adi,
                                     Plaka = arac.Plaka,
                                     İlkGün = soz.Alıs_Tarihi,
                                     SonGün = soz.Veris_Tarihi,
                                     ToplamÜcret = soz.Toplam_Ucret,
                                     PersonelAdıSoyadı = per.Personel_Adi_Soyadi,
                                     SubeAdı = sube.Sube_Adi
                                 };

            AutoGallerydataGridView.DataSource = rentalcontract.ToList();
        }

        private void RentalContactButtonListRentalContract_Click(object sender, EventArgs e)
        {
            var rentalcontract = from soz in DatabaseCon.autoGalleryEntity.Sozlesme_Tablosu
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
                                 where soz.Sozlesme_Turu_Id == 1
                                 select new
                                 {
                                     ID = soz.Sozlesme_Id,
                                     MüşteriAdıSoyadı = mus.Musteri_Adi_Soyadi,
                                     MüşteriTC = mus.Musteri_Tc,
                                     MüşteriTelefon = mus.Musteri_Telefon,
                                     Marka = marka.Marka_Adi,
                                     Model = model.Model_Adi,
                                     Plaka = arac.Plaka,
                                     İlkGün = soz.Alıs_Tarihi,
                                     SonGün = soz.Veris_Tarihi,
                                     ToplamÜcret = soz.Toplam_Ucret,
                                     PersonelAdıSoyadı = per.Personel_Adi_Soyadi,
                                     SubeAdı = sube.Sube_Adi
                                 };

            AutoGallerydataGridView.DataSource = rentalcontract.ToList();
        }

        private void AutoGallerydataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
