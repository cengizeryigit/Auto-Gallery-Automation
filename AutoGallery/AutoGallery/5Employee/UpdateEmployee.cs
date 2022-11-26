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
    public partial class UpdateEmployee : Form
    {
        public UpdateEmployee()
        {
            InitializeComponent();
        }

        private void UpdateEmployee_Load(object sender, EventArgs e)
        {
            if (Login.EmployeeTypeId == 1)
            {
                UpdateEmployeeComboBoxBranch.DataSource = DatabaseCon.autoGalleryEntity.Subeler_Tablosu.ToList();
                UpdateEmployeeComboBoxBranch.ValueMember = "Sube_Id";
                UpdateEmployeeComboBoxBranch.DisplayMember = "Sube_Adi";
                UpdateEmployeeComboBoxBranch.Invalidate();

                UpdateEmployeeComboBoxEmployeType.DataSource = DatabaseCon.autoGalleryEntity.Personel_Turu_Tablosu.ToList();
                UpdateEmployeeComboBoxEmployeType.ValueMember = "Personel_Turu_Id";
                UpdateEmployeeComboBoxEmployeType.DisplayMember = "Personel_Turu";
                UpdateEmployeeComboBoxEmployeType.Invalidate();

                var employee = from emp in DatabaseCon.autoGalleryEntity.Personel_Tablosu
                               join
                               empt in DatabaseCon.autoGalleryEntity.Personel_Turu_Tablosu on emp.Personel_Turu_Id equals empt.Personel_Turu_Id
                               join
                               branch in DatabaseCon.autoGalleryEntity.Subeler_Tablosu on emp.Sube_Id equals branch.Sube_Id
                               
                               select new
                               {
                                   ID = emp.Personel_Id,
                                   TC = emp.Personel_Tc,
                                   AdıSoyadı = emp.Personel_Adi_Soyadi,
                                   DoğumTarihi = emp.Personel_Dogum_Tarihi,
                                   Telefon = emp.Personel_Telefon,
                                   Adres = emp.Personel_Adres,
                                   EMail = emp.Personel_EMail,
                                   Türü = empt.Personel_Turu,
                                   Şube = branch.Sube_Adi

                               };

                AutoGallerydataGridView.DataSource = employee.ToList();
            }
            else if (Login.EmployeeTypeId == 2)
            {
                UpdateEmployeeComboBoxBranch.DataSource = DatabaseCon.autoGalleryEntity.Subeler_Tablosu.Where(s => s.Sube_Id == Login.BranchId).ToList();
                UpdateEmployeeComboBoxBranch.ValueMember = "Sube_Id";
                UpdateEmployeeComboBoxBranch.DisplayMember = "Sube_Adi";
                UpdateEmployeeComboBoxBranch.Invalidate();

                UpdateEmployeeComboBoxEmployeType.DataSource = DatabaseCon.autoGalleryEntity.Personel_Turu_Tablosu.Where(s => s.Personel_Turu_Id == 3).ToList();
                UpdateEmployeeComboBoxEmployeType.ValueMember = "Personel_Turu_Id";
                UpdateEmployeeComboBoxEmployeType.DisplayMember = "Personel_Turu";
                UpdateEmployeeComboBoxEmployeType.Invalidate();

                var employee = from emp in DatabaseCon.autoGalleryEntity.Personel_Tablosu
                               join
                               empt in DatabaseCon.autoGalleryEntity.Personel_Turu_Tablosu on emp.Personel_Turu_Id equals empt.Personel_Turu_Id
                               join
                               branch in DatabaseCon.autoGalleryEntity.Subeler_Tablosu on emp.Sube_Id equals branch.Sube_Id
                               where emp.Sube_Id == Login.BranchId
                               select new
                               {
                                   ID = emp.Personel_Id,
                                   TC = emp.Personel_Tc,
                                   AdıSoyadı = emp.Personel_Adi_Soyadi,
                                   DoğumTarihi = emp.Personel_Dogum_Tarihi,
                                   Telefon = emp.Personel_Telefon,
                                   Adres = emp.Personel_Adres,
                                   EMail = emp.Personel_EMail,
                                   Türü = empt.Personel_Turu,
                                   Şube = branch.Sube_Adi

                               };

                AutoGallerydataGridView.DataSource = employee.ToList();
            }



           
        }

        int id;
        private void AutoGallerydataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(AutoGallerydataGridView.CurrentRow.Cells[0].Value);
            var update = DatabaseCon.autoGalleryEntity.Personel_Tablosu.FirstOrDefault(u => u.Personel_Id == id);

            UpdateEmployeeTextBoxSecurityNumber.Text=update.Personel_Tc;
            UpdateEmployeeTextBoxNameSurname.Text = update.Personel_Adi_Soyadi;
            UpdateEmployeeDateTimePickerDateofBirth.Value = update.Personel_Dogum_Tarihi;
            UpdateEmployeeTextBoxTelephone.Text = update.Personel_Telefon;
            UpdateEmployeeTextBoxEMail.Text = update.Personel_EMail;
            UpdateEmployeeTextBoxAdress.Text = update.Personel_Adres;
            UpdateEmployeeTextBoxPassword.Text = update.Personel_Sifre;
        }

        private void UpdateEmployeeButtonUpdateEmployee_Click(object sender, EventArgs e)
        {
            var update = DatabaseCon.autoGalleryEntity.Personel_Tablosu.FirstOrDefault(u => u.Personel_Id == id);

            int val;
            Int32.TryParse(UpdateEmployeeComboBoxBranch.SelectedValue.ToString(), out val);

            int val2;
            Int32.TryParse(UpdateEmployeeComboBoxEmployeType.SelectedValue.ToString(), out val2);

            update.Personel_Tc = UpdateEmployeeTextBoxSecurityNumber.Text;
            update.Personel_Adi_Soyadi = UpdateEmployeeTextBoxNameSurname.Text;
            update.Personel_Dogum_Tarihi = UpdateEmployeeDateTimePickerDateofBirth.Value;
            update.Personel_Telefon = UpdateEmployeeTextBoxTelephone.Text;
            update.Personel_EMail = UpdateEmployeeTextBoxEMail.Text;
            update.Personel_Adres = UpdateEmployeeTextBoxAdress.Text;
            update.Personel_Sifre = UpdateEmployeeTextBoxPassword.Text;
            update.Personel_Turu_Id = val2;
            update.Sube_Id = val;

            DatabaseCon.autoGalleryEntity.SaveChanges();

            if (Login.EmployeeTypeId == 1)
            {
                var employee = from emp in DatabaseCon.autoGalleryEntity.Personel_Tablosu
                               join
                               empt in DatabaseCon.autoGalleryEntity.Personel_Turu_Tablosu on emp.Personel_Turu_Id equals empt.Personel_Turu_Id
                               join
                               branch in DatabaseCon.autoGalleryEntity.Subeler_Tablosu on emp.Sube_Id equals branch.Sube_Id
                               where emp.Sube_Id != 1
                               select new
                               {
                                   ID = emp.Personel_Id,
                                   TC = emp.Personel_Tc,
                                   AdıSoyadı = emp.Personel_Adi_Soyadi,
                                   DoğumTarihi = emp.Personel_Dogum_Tarihi,
                                   Telefon = emp.Personel_Telefon,
                                   Adres = emp.Personel_Adres,
                                   EMail = emp.Personel_EMail,
                                   Türü = empt.Personel_Turu,
                                   Şube = branch.Sube_Adi

                               };

                AutoGallerydataGridView.DataSource = employee.ToList();
            }
            else if (Login.EmployeeTypeId == 2)
            {
                var employee = from emp in DatabaseCon.autoGalleryEntity.Personel_Tablosu
                               join
                               empt in DatabaseCon.autoGalleryEntity.Personel_Turu_Tablosu on emp.Personel_Turu_Id equals empt.Personel_Turu_Id
                               join
                               branch in DatabaseCon.autoGalleryEntity.Subeler_Tablosu on emp.Sube_Id equals branch.Sube_Id
                               where emp.Sube_Id == Login.BranchId
                               select new
                               {
                                   ID = emp.Personel_Id,
                                   TC = emp.Personel_Tc,
                                   AdıSoyadı = emp.Personel_Adi_Soyadi,
                                   DoğumTarihi = emp.Personel_Dogum_Tarihi,
                                   Telefon = emp.Personel_Telefon,
                                   Adres = emp.Personel_Adres,
                                   EMail = emp.Personel_EMail,
                                   Türü = empt.Personel_Turu,
                                   Şube = branch.Sube_Adi

                               };

                AutoGallerydataGridView.DataSource = employee.ToList();
            }
            UpdateEmployeeTextBoxSecurityNumber.Text = "";
            UpdateEmployeeTextBoxNameSurname.Text = "";
            UpdateEmployeeDateTimePickerDateofBirth.Value = DateTime.Now;
            UpdateEmployeeTextBoxTelephone.Text ="";
            UpdateEmployeeTextBoxEMail.Text = "";
            UpdateEmployeeTextBoxAdress.Text = "";
            UpdateEmployeeTextBoxPassword.Text = "";

        }
    }
}
