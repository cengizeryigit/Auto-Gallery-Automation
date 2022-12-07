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
    public partial class ListEmployee : Form
    {
        public ListEmployee()
        {
            InitializeComponent();
        }

        private void ListEmployee_Load(object sender, EventArgs e)
        {
            if (Login.EmployeeTypeId == 1)
            {
                ListEmployeeComboBox.DataSource = DatabaseCon.autoGalleryEntity.Subeler_Tablosu.ToList();
                ListEmployeeComboBox.ValueMember = "Sube_Id";
                ListEmployeeComboBox.DisplayMember = "Sube_Adi";
                ListEmployeeComboBox.Invalidate();
            }
            else if (Login.EmployeeTypeId == 2)
            {
                ListEmployeeComboBox.DataSource = DatabaseCon.autoGalleryEntity.Subeler_Tablosu.Where(s => s.Sube_Id == Login.BranchId).ToList();
                ListEmployeeComboBox.ValueMember = "Sube_Id";
                ListEmployeeComboBox.DisplayMember = "Sube_Adi";
                ListEmployeeComboBox.Invalidate();
            }
        }

        private void ListEmployeeButtonListEmployee_Click(object sender, EventArgs e)
        {
            int val;
            Int32.TryParse(ListEmployeeComboBox.SelectedValue.ToString(), out val);

            var listemployee = from personel in DatabaseCon.autoGalleryEntity.Personel_Tablosu
                               join
                               tur in DatabaseCon.autoGalleryEntity.Personel_Turu_Tablosu on personel.Personel_Turu_Id equals tur.Personel_Turu_Id
                               join
                               sube in DatabaseCon.autoGalleryEntity.Subeler_Tablosu on personel.Sube_Id equals sube.Sube_Id
                               where personel.Sube_Id==val && personel.Personel_Turu_Id != 4
                               select new
                               {
                                   ID = personel.Personel_Id,
                                   TC = personel.Personel_Tc,
                                   AdıSoyadı = personel.Personel_Adi_Soyadi,
                                   DoğumTarihi = personel.Personel_Dogum_Tarihi,
                                   Telefon = personel.Personel_Telefon,
                                   EMail = personel.Personel_EMail,
                                   Adres = personel.Personel_Adres,
                                   Türü = tur.Personel_Turu,
                                   Şube = sube.Sube_Adi

                               };

            AutoGallerydataGridView.DataSource = listemployee.ToList();
        }

        private void ListAllEmployeeButtonListAllEmployee_Click(object sender, EventArgs e)
        {
            int val;
            Int32.TryParse(ListEmployeeComboBox.SelectedValue.ToString(), out val);

            var listemployee = from personel in DatabaseCon.autoGalleryEntity.Personel_Tablosu
                               join
                               tur in DatabaseCon.autoGalleryEntity.Personel_Turu_Tablosu on personel.Personel_Turu_Id equals tur.Personel_Turu_Id
                               join
                               sube in DatabaseCon.autoGalleryEntity.Subeler_Tablosu on personel.Sube_Id equals sube.Sube_Id
                               where personel.Sube_Id == val
                               select new
                               {
                                   ID = personel.Personel_Id,
                                   TC = personel.Personel_Tc,
                                   AdıSoyadı = personel.Personel_Adi_Soyadi,
                                   DoğumTarihi = personel.Personel_Dogum_Tarihi,
                                   Telefon = personel.Personel_Telefon,
                                   EMail = personel.Personel_EMail,
                                   Adres = personel.Personel_Adres,
                                   Türü = tur.Personel_Turu,
                                   Şube = sube.Sube_Adi

                               };

            AutoGallerydataGridView.DataSource = listemployee.ToList();
        }
    }
}
