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
    public partial class RentalCars : Form
    {
        public RentalCars()
        {
            InitializeComponent();
        }

        private void AutoGallerydataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(AutoGallerydataGridView.CurrentRow.Cells[0].Value);
            var car = DatabaseCon.autoGalleryEntity.Arac_Tablosu.FirstOrDefault(u => u.Arac_Id == id);
            var model = DatabaseCon.autoGalleryEntity.Model_Tablosu.FirstOrDefault(mo => mo.Model_Id == car.Model_Id);
            var marka = DatabaseCon.autoGalleryEntity.Marka_Tablosu.FirstOrDefault(ma => ma.Marka_Id == model.Marka_Id);


            FormControl.rentalContract.carid = id;
            FormControl.rentalContract.RentalContractTextBoxBrand.Text = marka.Marka_Adi;
            FormControl.rentalContract.RentalContractTextBoxModel.Text = model.Model_Adi;
            FormControl.rentalContract.RentalContractTextBoxPlate.Text = car.Plaka;
            FormControl.rentalContract.RentalContractTextBoxRentMoney.Text = car.Kira_Ucreti.ToString();

            this.Hide();
        }

        private void ChooseCars_Load(object sender, EventArgs e)
        {
           
           
            
            
        }

        private void ChooseCarsButtonListCar_Click(object sender, EventArgs e)
        {
        if (Login.EmployeeTypeId == 1)
        {
            var car = from arac in DatabaseCon.autoGalleryEntity.Arac_Tablosu
                      join
                      model in DatabaseCon.autoGalleryEntity.Model_Tablosu on arac.Model_Id equals model.Model_Id
                      join
                      marka in DatabaseCon.autoGalleryEntity.Marka_Tablosu on model.Marka_Id equals marka.Marka_Id
                      join
                      aracdurum in DatabaseCon.autoGalleryEntity.Arac_Durumu_Tablosu on arac.Arac_Durumu_Id equals aracdurum.Arac_Durumu_Id
                      join
                      sube in DatabaseCon.autoGalleryEntity.Subeler_Tablosu on arac.Sube_Id equals sube.Sube_Id
                      where arac.Arac_Durumu_Id == 1
                      select new
                      {
                          ID = arac.Arac_Id,
                          Marka = marka.Marka_Adi,
                          Model = model.Model_Adi,
                          Plaka = arac.Plaka,
                          Durum = aracdurum.Arac_Durumu,
                          KiraÜcreti = arac.Kira_Ucreti,
                          SatışÜcreti = arac.Satis_Ucreti,
                          Yıl = arac.Yil,
                          Yakıt = arac.Yakit,
                          KM = arac.Km,
                          Renk = arac.Renk,
                          Şube = sube.Sube_Adi

                      };


            AutoGallerydataGridView.DataSource = car.ToList();
        }
        else if (Login.EmployeeTypeId != 1)
        {
            var car = from arac in DatabaseCon.autoGalleryEntity.Arac_Tablosu
                      join
                      model in DatabaseCon.autoGalleryEntity.Model_Tablosu on arac.Model_Id equals model.Model_Id
                      join
                      marka in DatabaseCon.autoGalleryEntity.Marka_Tablosu on model.Marka_Id equals marka.Marka_Id
                      join
                      aracdurum in DatabaseCon.autoGalleryEntity.Arac_Durumu_Tablosu on arac.Arac_Durumu_Id equals aracdurum.Arac_Durumu_Id
                      join
                      sube in DatabaseCon.autoGalleryEntity.Subeler_Tablosu on arac.Sube_Id equals sube.Sube_Id
                      where arac.Arac_Durumu_Id == 1 && arac.Sube_Id == Login.BranchId
                      select new
                      {
                          ID = arac.Arac_Id,
                          Marka = marka.Marka_Adi,
                          Model = model.Model_Adi,
                          Plaka = arac.Plaka,
                          Durum = aracdurum.Arac_Durumu,
                          KiraÜcreti = arac.Kira_Ucreti,
                          SatışÜcreti = arac.Satis_Ucreti,
                          Yıl = arac.Yil,
                          Yakıt = arac.Yakit,
                          KM = arac.Km,
                          Renk = arac.Renk,
                          Şube = sube.Sube_Adi

                      };

            

            AutoGallerydataGridView.DataSource = car.ToList();
            }
        }
    }
}
