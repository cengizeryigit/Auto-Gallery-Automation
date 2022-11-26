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
    public partial class AddCars : Form
    {
        public AddCars()
        {
            InitializeComponent();
        }

        private void AddCars_Load(object sender, EventArgs e)
        {
            if (Login.EmployeeTypeId == 1)
            {
                AddCarsComboBoxBranch.DataSource = DatabaseCon.autoGalleryEntity.Subeler_Tablosu.Where(s => s.Sube_Id != Login.BranchId).ToList();
                AddCarsComboBoxBranch.ValueMember = "Sube_Id";
                AddCarsComboBoxBranch.DisplayMember = "Sube_Adi";
                AddCarsComboBoxBranch.Invalidate();
            }
            else if (Login.EmployeeTypeId != 1)
            {
                AddCarsComboBoxBranch.DataSource = DatabaseCon.autoGalleryEntity.Subeler_Tablosu.Where(s => s.Sube_Id == Login.BranchId).ToList();
                AddCarsComboBoxBranch.ValueMember = "Sube_Id";
                AddCarsComboBoxBranch.DisplayMember = "Sube_Adi";
                AddCarsComboBoxBranch.Invalidate();
            }

            AddCarsComboBoxBrand.DataSource = DatabaseCon.autoGalleryEntity.Marka_Tablosu.ToList();
            AddCarsComboBoxBrand.ValueMember = "Marka_Id";
            AddCarsComboBoxBrand.DisplayMember = "Marka_Adi";
            AddCarsComboBoxBrand.Invalidate();


            var addcar = from arac in DatabaseCon.autoGalleryEntity.Arac_Tablosu
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


            AutoGallerydataGridView.DataSource = addcar.ToList();
        }



        private void AddCarsComboBoxBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            int val;
            Int32.TryParse(AddCarsComboBoxBrand.SelectedValue.ToString(), out val);

            AddCarsComboBoxModel.DataSource = DatabaseCon.autoGalleryEntity.Model_Tablosu.Where(mo => mo.Marka_Id==val).ToList();
            AddCarsComboBoxModel.ValueMember = "Model_Id";
            AddCarsComboBoxModel.DisplayMember = "Model_Adi";
            AddCarsComboBoxModel.Invalidate();
        }

        private void AddCarsButtonAddCars_Click(object sender, EventArgs e)
        {
            int val;
            Int32.TryParse(AddCarsComboBoxModel.SelectedValue.ToString(), out val);

            int val2;
            Int32.TryParse(AddCarsComboBoxBranch.SelectedValue.ToString(), out val2);

            Arac_Tablosu arac_Tablosu = new Arac_Tablosu();
            arac_Tablosu.Plaka = AddCarsTextBoxPlate.Text;
            arac_Tablosu.Model_Id = val;
            arac_Tablosu.Arac_Durumu_Id = 1;
            arac_Tablosu.Kira_Ucreti = Convert.ToInt32(AddCarsTextBoxRentMoney.Text);
            arac_Tablosu.Satis_Ucreti = Convert.ToInt32(AddCarsTextBoxSalesMoney.Text);
            arac_Tablosu.Yil = Convert.ToInt32(AddCarsTextBoxYear.Text);
            arac_Tablosu.Yakit = AddCarsTextBoxFuel.Text;
            arac_Tablosu.Km = Convert.ToInt32(AddCarsTextBoxKm.Text);
            arac_Tablosu.Renk = AddCarsTextBoxColour.Text;
            arac_Tablosu.Resim = null;
            arac_Tablosu.Sube_Id = val2;

            DatabaseCon.autoGalleryEntity.Arac_Tablosu.Add(arac_Tablosu);
            DatabaseCon.autoGalleryEntity.SaveChanges();



            var addcar = from arac in DatabaseCon.autoGalleryEntity.Arac_Tablosu
                          join
                          model in DatabaseCon.autoGalleryEntity.Model_Tablosu on arac.Model_Id equals model.Model_Id
                          join
                          marka in DatabaseCon.autoGalleryEntity.Marka_Tablosu on model.Marka_Id equals marka.Marka_Id
                          join
                          aracdurum in DatabaseCon.autoGalleryEntity.Arac_Durumu_Tablosu on arac.Arac_Durumu_Id equals aracdurum.Arac_Durumu_Id
                          join
                          sube in DatabaseCon.autoGalleryEntity.Subeler_Tablosu on arac.Sube_Id equals sube.Sube_Id
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


             AutoGallerydataGridView.DataSource = addcar.ToList();


            AddCarsTextBoxPlate.Text = "";
            AddCarsTextBoxColour.Text = "";
            AddCarsTextBoxFuel.Text = "";
            AddCarsTextBoxKm.Text = "";
            AddCarsTextBoxRentMoney.Text = "";
            AddCarsTextBoxSalesMoney.Text = "";
            AddCarsTextBoxYear.Text = "";


        }
    }
}
