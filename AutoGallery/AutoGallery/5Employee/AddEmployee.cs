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
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {
            if (Login.EmployeeTypeId == 1)
            {
                AddEmployeeComboBoxBranch.DataSource = DatabaseCon.autoGalleryEntity.Subeler_Tablosu.ToList();
                AddEmployeeComboBoxBranch.ValueMember = "Sube_Id";
                AddEmployeeComboBoxBranch.DisplayMember = "Sube_Adi";
                AddEmployeeComboBoxBranch.Invalidate();

                AddEmployeeComboBoxEmployeType.DataSource = DatabaseCon.autoGalleryEntity.Personel_Turu_Tablosu.Where(s => s.Personel_Turu_Id != 4).ToList();
                AddEmployeeComboBoxEmployeType.ValueMember = "Personel_Turu_Id";
                AddEmployeeComboBoxEmployeType.DisplayMember = "Personel_Turu";
                AddEmployeeComboBoxEmployeType.Invalidate();

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
                AddEmployeeComboBoxBranch.DataSource = DatabaseCon.autoGalleryEntity.Subeler_Tablosu.Where(s => s.Sube_Id == Login.BranchId).ToList();
                AddEmployeeComboBoxBranch.ValueMember = "Sube_Id";
                AddEmployeeComboBoxBranch.DisplayMember = "Sube_Adi";
                AddEmployeeComboBoxBranch.Invalidate();

                AddEmployeeComboBoxEmployeType.DataSource = DatabaseCon.autoGalleryEntity.Personel_Turu_Tablosu.Where(s => s.Personel_Turu_Id == 3).ToList();
                AddEmployeeComboBoxEmployeType.ValueMember = "Personel_Turu_Id";
                AddEmployeeComboBoxEmployeType.DisplayMember = "Personel_Turu";
                AddEmployeeComboBoxEmployeType.Invalidate();

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

        private void AddEmployeeButtonAddEmployee_Click(object sender, EventArgs e)
        {
            int val;
            Int32.TryParse(AddEmployeeComboBoxBranch.SelectedValue.ToString(), out val);

            int val2;
            Int32.TryParse(AddEmployeeComboBoxEmployeType.SelectedValue.ToString(), out val2);

            Personel_Tablosu personel_Tablosu = new Personel_Tablosu();
            personel_Tablosu.Personel_Tc = AddEmployeeTextBoxSecurityNumber.Text;
            personel_Tablosu.Personel_Adi_Soyadi = AddEmployeeTextBoxNameSurname.Text;
            personel_Tablosu.Personel_Dogum_Tarihi = AddEmployeeDateTimePickerDateofBirth.Value;
            personel_Tablosu.Personel_Telefon = AddEmployeeTextBoxTelephone.Text;
            personel_Tablosu.Personel_EMail = AddEmployeeTextBoxEMail.Text;
            personel_Tablosu.Personel_Adres = AddEmployeeTextBoxAdress.Text;
            personel_Tablosu.Personel_Resim = null;
            personel_Tablosu.Personel_Turu_Id = val2;
            personel_Tablosu.Sube_Id = val;
            personel_Tablosu.Personel_Sifre = AddEmployeeTextBoxPassword.Text;


            DatabaseCon.autoGalleryEntity.Personel_Tablosu.Add(personel_Tablosu);
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



        }
    }
}
