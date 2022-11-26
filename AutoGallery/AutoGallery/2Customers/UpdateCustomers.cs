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
    public partial class UpdateCustomers : Form
    {
        public UpdateCustomers()
        {
            InitializeComponent();
        }

        private void UpdateCustomers_Load(object sender, EventArgs e)
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

        int id;
        private void AutoGallerydataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(AutoGallerydataGridView.CurrentRow.Cells[0].Value);
            var update = DatabaseCon.autoGalleryEntity.Musteri_Tablosu.FirstOrDefault(u => u.Musteri_Id== id);

            UpdateCustomersMaskedTextBoxSecurityNumber.Text = update.Musteri_Tc;
            UpdateCustomersTextBoxNameSurname.Text = update.Musteri_Adi_Soyadi;
            UpdateCustomersDateTimePickerDateofBirth.Value = update.Musteri_Dogum_Tarihi;
            UpdateCustomersMaskedTextBoxTelephone.Text = update.Musteri_Telefon;
            UpdateCustomersTextBoxDrivingLicenseNumber.Text = update.Musteri_Ehliyet_No;
            UpdateCustomersDateTimePickerDriversLicenseDate.Value = update.Musteri_Ehliyet_Tarihi;
            UpdateCustomersTextBoxEMail.Text= update.Musteri_EMail;
            UpdateCustomersTextBoxAddress.Text = update.Musteri_Adres;
        }

        private void UpdateCustomersButtonUpdateCustomers_Click(object sender, EventArgs e)
        {
            var update = DatabaseCon.autoGalleryEntity.Musteri_Tablosu.FirstOrDefault(u => u.Musteri_Id == id);

            update.Musteri_Tc = UpdateCustomersMaskedTextBoxSecurityNumber.Text;
            update.Musteri_Adi_Soyadi = UpdateCustomersTextBoxNameSurname.Text;
            update.Musteri_Dogum_Tarihi = UpdateCustomersDateTimePickerDateofBirth.Value;
            update.Musteri_Telefon = UpdateCustomersMaskedTextBoxTelephone.Text;
            update.Musteri_Ehliyet_No = UpdateCustomersTextBoxDrivingLicenseNumber.Text;
            update.Musteri_Ehliyet_Tarihi = UpdateCustomersDateTimePickerDriversLicenseDate.Value;
            update.Musteri_EMail = UpdateCustomersTextBoxEMail.Text;
            update.Musteri_Adres = UpdateCustomersTextBoxAddress.Text;

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

            UpdateCustomersMaskedTextBoxSecurityNumber.Text = "";
            UpdateCustomersTextBoxNameSurname.Text = "";
            UpdateCustomersDateTimePickerDateofBirth.Value = DateTime.Now;
            UpdateCustomersMaskedTextBoxTelephone.Text = "";
            UpdateCustomersTextBoxDrivingLicenseNumber.Text = "";
            UpdateCustomersDateTimePickerDriversLicenseDate.Value= DateTime.Now;
            UpdateCustomersTextBoxEMail.Text = "";
            UpdateCustomersTextBoxAddress.Text = "";

        }
    }
}
