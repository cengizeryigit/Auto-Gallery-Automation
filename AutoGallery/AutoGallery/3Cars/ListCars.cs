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
    public partial class ListCars : Form
    {
        public ListCars()
        {
            InitializeComponent();
        }

        private void ListCars_Load(object sender, EventArgs e)
        {
            if (Login.EmployeeTypeId == 1)
            {
                ListCarsComboBox.DataSource = DatabaseCon.autoGalleryEntity.Subeler_Tablosu.Where(s => s.Sube_Id != Login.BranchId).ToList();
                ListCarsComboBox.ValueMember = "Sube_Id";
                ListCarsComboBox.DisplayMember = "Sube_Adi";
                ListCarsComboBox.Invalidate();
            }
            else if(Login.EmployeeTypeId == 2)
            {
                ListCarsComboBox.DataSource = DatabaseCon.autoGalleryEntity.Subeler_Tablosu.Where(s => s.Sube_Id==Login.BranchId).ToList();
                ListCarsComboBox.ValueMember = "Sube_Id";
                ListCarsComboBox.DisplayMember = "Sube_Adi";
                ListCarsComboBox.Invalidate();
            }
            else if (Login.EmployeeTypeId == 3)
            {
                ListCarsComboBox.DataSource = DatabaseCon.autoGalleryEntity.Subeler_Tablosu.Where(s => s.Sube_Id == Login.BranchId).ToList();
                ListCarsComboBox.ValueMember = "Sube_Id";
                ListCarsComboBox.DisplayMember = "Sube_Adi";
                ListCarsComboBox.Invalidate();
            }

        }

        private void ListCarsButtonListCars_Click(object sender, EventArgs e)
        {
            int val;
            Int32.TryParse(ListCarsComboBox.SelectedValue.ToString(), out val);

            var listcar = from arac in DatabaseCon.autoGalleryEntity.Arac_Tablosu
                          join
                          model in DatabaseCon.autoGalleryEntity.Model_Tablosu on arac.Model_Id equals model.Model_Id
                          join
                          marka in DatabaseCon.autoGalleryEntity.Marka_Tablosu on model.Marka_Id equals marka.Marka_Id
                          join
                          aracdurum in DatabaseCon.autoGalleryEntity.Arac_Durumu_Tablosu on arac.Arac_Durumu_Id equals aracdurum.Arac_Durumu_Id
                          where
                          arac.Arac_Durumu_Id == 1 && arac.Sube_Id == val
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
                              Renk = arac.Renk
                              
                          };


            AutoGallerydataGridView.DataSource = listcar.ToList();
                        

        }

        private void ListAllCarsButtonListAllCars_Click(object sender, EventArgs e)
        {
            int val;
            Int32.TryParse(ListCarsComboBox.SelectedValue.ToString(), out val);

            var listcar = from arac in DatabaseCon.autoGalleryEntity.Arac_Tablosu
                          join
                          model in DatabaseCon.autoGalleryEntity.Model_Tablosu on arac.Model_Id equals model.Model_Id
                          join
                          marka in DatabaseCon.autoGalleryEntity.Marka_Tablosu on model.Marka_Id equals marka.Marka_Id
                          join
                          aracdurum in DatabaseCon.autoGalleryEntity.Arac_Durumu_Tablosu on arac.Arac_Durumu_Id equals aracdurum.Arac_Durumu_Id
                          where
                          arac.Sube_Id == val
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
                              Renk = arac.Renk

                          };


            AutoGallerydataGridView.DataSource = listcar.ToList();
        }
    }
}
