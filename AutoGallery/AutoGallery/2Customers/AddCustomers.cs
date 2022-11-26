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
    public partial class AddCustomers : Form
    {
        public AddCustomers()
        {
            InitializeComponent();
        }

        private void AddCustomers_Load(object sender, EventArgs e)
        {
            var customer = from custo in DatabaseCon.autoGalleryEntity.Musteri_Tablosu
                            
                            select new
                            {

                                ID = custo.Musteri_Id,
                                TC = custo.Musteri_Tc,
                                AdıSoyadı = custo.Musteri_Adi_Soyadi,
                                DoğumTarihi = custo.Musteri_Dogum_Tarihi,
                                Telefon = custo.Musteri_Telefon,
                                EhliyetNo = custo.Musteri_Ehliyet_No,
                                EhliyetTarihi = custo.Musteri_Ehliyet_Tarihi,
                                EMail = custo.Musteri_EMail,
                                Adres = custo.Musteri_Adres

                            };

            AutoGallerydataGridView.DataSource = customer.ToList();
            
        }

        private void AddCustomersButtonAddCustomers_Click(object sender, EventArgs e)
        {
            Musteri_Tablosu musteri_Tablosu = new Musteri_Tablosu();
            musteri_Tablosu.Musteri_Tc = AddCustomersMaskedTextBoxSecurityNumber.Text;
            musteri_Tablosu.Musteri_Adi_Soyadi = AddCustomersTextBoxNameSurname.Text;
            musteri_Tablosu.Musteri_Dogum_Tarihi = AddCustomersDateTimePickerDateofBirth.Value;
            musteri_Tablosu.Musteri_Telefon = AddCustomersMaskedTextBoxTelephone.Text;
            musteri_Tablosu.Musteri_Ehliyet_No = AddCustomersTextBoxDrivingLicenseNumber.Text;
            musteri_Tablosu.Musteri_Ehliyet_Tarihi = AddCustomersDateTimePickerDriversLicenseDate.Value;
            musteri_Tablosu.Musteri_EMail = AddCustomersTextBoxEMail.Text;
            musteri_Tablosu.Musteri_Adres = AddCustomersTextBoxAddress.Text;
            DatabaseCon.autoGalleryEntity.Musteri_Tablosu.Add(musteri_Tablosu);
            DatabaseCon.autoGalleryEntity.SaveChanges();
            var customer = from custo in DatabaseCon.autoGalleryEntity.Musteri_Tablosu

                           select new
                           {

                               ID = custo.Musteri_Id,
                               TC = custo.Musteri_Tc,
                               AdıSoyadı = custo.Musteri_Adi_Soyadi,
                               DoğumTarihi = custo.Musteri_Dogum_Tarihi,
                               Telefon = custo.Musteri_Telefon,
                               EhliyetNo = custo.Musteri_Ehliyet_No,
                               EhliyetTarihi = custo.Musteri_Ehliyet_Tarihi,
                               EMail = custo.Musteri_EMail,
                               Adres = custo.Musteri_Adres

                           };

            AutoGallerydataGridView.DataSource = customer.ToList();

            AddCustomersMaskedTextBoxSecurityNumber.Text = "";
            AddCustomersTextBoxNameSurname.Text = "";
            AddCustomersDateTimePickerDateofBirth.Value = DateTime.Now;
            AddCustomersMaskedTextBoxTelephone.Text = "";
            AddCustomersTextBoxDrivingLicenseNumber.Text = "";
            AddCustomersDateTimePickerDriversLicenseDate.Value= DateTime.Now;
            AddCustomersTextBoxEMail.Text = "";
            AddCustomersTextBoxAddress.Text = "";

        }
    }
}
