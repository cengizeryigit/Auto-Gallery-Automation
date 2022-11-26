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
    public partial class RentalCustomers : Form
    {
        public RentalCustomers()
        {
            InitializeComponent();
        }

        private void AutoGallerydataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(AutoGallerydataGridView.CurrentRow.Cells[0].Value);
            var update = DatabaseCon.autoGalleryEntity.Musteri_Tablosu.FirstOrDefault(u => u.Musteri_Id == id);

            FormControl.rentalContract.customerid= id;
            FormControl.rentalContract.RentalContractTextBoxSecurityNumber.Text = update.Musteri_Tc;
            FormControl.rentalContract.RentalContractTextBoxNameSurname.Text = update.Musteri_Adi_Soyadi;
            FormControl.rentalContract.RentalContractTextBoxTelephone.Text = update.Musteri_Telefon;
            FormControl.rentalContract.RentalContractTextBoxAdress.Text = update.Musteri_Adres;

            this.Hide();
            
        }

        private void ChooseCustomers_Load(object sender, EventArgs e)
        {
            
        }

        private void ChooseCustomersButtonListCustomer_Click(object sender, EventArgs e)
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
    }
}
