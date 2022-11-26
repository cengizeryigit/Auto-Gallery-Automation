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
    public partial class SalesCustomers : Form
    {
        public SalesCustomers()
        {
            InitializeComponent();
        }

        

        private void AutoGallerydataGridView_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(AutoGallerydataGridView.CurrentRow.Cells[0].Value);
            var update = DatabaseCon.autoGalleryEntity.Musteri_Tablosu.FirstOrDefault(u => u.Musteri_Id == id);

            FormControl.salesContract.customerid = id;
            FormControl.salesContract.SalesContractTextBoxSecurityNumber.Text = update.Musteri_Tc;
            FormControl.salesContract.SalesContractTextBoxNameSurname.Text = update.Musteri_Adi_Soyadi;
            FormControl.salesContract.SalesContractTextBoxTelephone.Text = update.Musteri_Telefon;
            FormControl.salesContract.SalesContractTextBoxAdress.Text = update.Musteri_Adres;

            this.Hide();
        }

        private void SalesCustomersButtonListCustomer_Click(object sender, EventArgs e)
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
