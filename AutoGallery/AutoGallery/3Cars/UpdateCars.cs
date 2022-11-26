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
    public partial class UpdateCars : Form
    {
        public UpdateCars()
        {
            InitializeComponent();
        }

        private void UpdateCars_Load(object sender, EventArgs e)
        {
            var updatecar = from arac in DatabaseCon.autoGalleryEntity.Arac_Tablosu
                         join
                         model in DatabaseCon.autoGalleryEntity.Model_Tablosu on arac.Model_Id equals model.Model_Id
                         join
                         marka in DatabaseCon.autoGalleryEntity.Marka_Tablosu on model.Marka_Id equals marka.Marka_Id
                         join
                         aracdurum in DatabaseCon.autoGalleryEntity.Arac_Durumu_Tablosu on arac.Arac_Durumu_Id equals aracdurum.Arac_Durumu_Id
                         join
                         sube in DatabaseCon.autoGalleryEntity.Subeler_Tablosu on arac.Sube_Id equals sube.Sube_Id
                         where arac.Arac_Durumu_Id==1
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

            AutoGallerydataGridView.DataSource = updatecar.ToList();

            if (Login.EmployeeTypeId == 1 || Login.EmployeeTypeId == 2)
            {
                UpdateCarsComboBoxBranch.DataSource = DatabaseCon.autoGalleryEntity.Subeler_Tablosu.Where(s => s.Sube_Id != 1).ToList();
                UpdateCarsComboBoxBranch.ValueMember = "Sube_Id";
                UpdateCarsComboBoxBranch.DisplayMember = "Sube_Adi";
                UpdateCarsComboBoxBranch.Invalidate();
            }
            else if (Login.EmployeeTypeId == 3)
            {
                UpdateCarsComboBoxBranch.DataSource = DatabaseCon.autoGalleryEntity.Subeler_Tablosu.Where(s => s.Sube_Id == Login.BranchId).ToList();
                UpdateCarsComboBoxBranch.ValueMember = "Sube_Id";
                UpdateCarsComboBoxBranch.DisplayMember = "Sube_Adi";
                UpdateCarsComboBoxBranch.Invalidate();
            }

            UpdateCarsComboBoxBrand.DataSource = DatabaseCon.autoGalleryEntity.Marka_Tablosu.ToList();
            UpdateCarsComboBoxBrand.ValueMember = "Marka_Id";
            UpdateCarsComboBoxBrand.DisplayMember = "Marka_Adi";
            UpdateCarsComboBoxBrand.Invalidate();
        }

        int id;

        private void AutoGallerydataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(AutoGallerydataGridView.CurrentRow.Cells[0].Value);
            var update = DatabaseCon.autoGalleryEntity.Arac_Tablosu.FirstOrDefault(u => u.Arac_Id == id);  

            UpdateCarsTextBoxPlate.Text = update.Plaka;
            UpdateCarsTextBoxRentMoney.Text = update.Kira_Ucreti.ToString();
            UpdateCarsTextBoxSalesMoney.Text = update.Satis_Ucreti.ToString();
            UpdateCarsTextBoxYear.Text = update.Yil.ToString();
            UpdateCarsTextBoxFuel.Text = update.Yakit;
            UpdateCarsTextBoxKm.Text = update.Km.ToString();
            UpdateCarsTextBoxColour.Text = update.Renk;

        }

        private void UpdateCarsComboBoxBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            int val;
            Int32.TryParse(UpdateCarsComboBoxBrand.SelectedValue.ToString(), out val);

            UpdateCarsComboBoxModel.DataSource = DatabaseCon.autoGalleryEntity.Model_Tablosu.Where(mo => mo.Marka_Id==val).ToList();
            UpdateCarsComboBoxModel.ValueMember = "Model_Id";
            UpdateCarsComboBoxModel.DisplayMember = "Model_Adi";
            UpdateCarsComboBoxModel.Invalidate();
        }

        private void UpdateCarsButtonUpdateCars_Click(object sender, EventArgs e)
        {
            var update = DatabaseCon.autoGalleryEntity.Arac_Tablosu.FirstOrDefault(u => u.Arac_Id == id);

            int val;
            Int32.TryParse(UpdateCarsComboBoxModel.SelectedValue.ToString(), out val);

            int val2;
            Int32.TryParse(UpdateCarsComboBoxBranch.SelectedValue.ToString(), out val2);

            
            update.Plaka = UpdateCarsTextBoxPlate.Text;
            update.Model_Id = val;
            update.Arac_Durumu_Id = 1;
            update.Kira_Ucreti = Convert.ToDecimal(UpdateCarsTextBoxRentMoney.Text);
            update.Satis_Ucreti = Convert.ToDecimal(UpdateCarsTextBoxSalesMoney.Text);
            update.Yil = Convert.ToInt32(UpdateCarsTextBoxYear.Text);
            update.Yakit = UpdateCarsTextBoxFuel.Text;
            update.Km = Convert.ToInt32(UpdateCarsTextBoxKm.Text);
            update.Renk = UpdateCarsTextBoxColour.Text;
            update.Resim = null;
            update.Sube_Id = val2;

            DatabaseCon.autoGalleryEntity.SaveChanges();

            var updatecar = from arac in DatabaseCon.autoGalleryEntity.Arac_Tablosu
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
            AutoGallerydataGridView.DataSource = updatecar.ToList();

            UpdateCarsTextBoxPlate.Text = "";
            UpdateCarsTextBoxColour.Text = "";
            UpdateCarsTextBoxFuel.Text = "";
            UpdateCarsTextBoxKm.Text = "";
            UpdateCarsTextBoxRentMoney.Text = "";
            UpdateCarsTextBoxSalesMoney.Text = "";
            UpdateCarsTextBoxYear.Text = "";
        }
    }
}
