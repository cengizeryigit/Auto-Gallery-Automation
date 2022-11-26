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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public static string Wronglogin = "User was not found";
        public static string BranchName;
        public static int BranchId;
        public static string EmployeeType;
        public static string EmployeeName;
        public static int EmployeeTypeId;
        public static int EmployeeId;
        
        private void Login_Load(object sender, EventArgs e)
        {
            Refresh();
            LoginComboBox.DataSource = DatabaseCon.autoGalleryEntity.Subeler_Tablosu.ToList();
            LoginComboBox.ValueMember = "Sube_Id";
            LoginComboBox.DisplayMember = "Sube_Adi";
            LoginComboBox.Invalidate();
        }

        private void LoginButtonLogin_Click(object sender, EventArgs e)
        {
            int val;
            Int32.TryParse(LoginComboBox.SelectedValue.ToString(), out val);                    
            var user = DatabaseCon.autoGalleryEntity.Personel_Tablosu.FirstOrDefault(u=> u.Personel_EMail==LoginTextBoxUsername.Text && u.Personel_Sifre == LoginTextBoxPassword.Text && u.Sube_Id== val);
          
            if (user != null)
            {
                var userbranch = DatabaseCon.autoGalleryEntity.Subeler_Tablosu.FirstOrDefault(s => s.Sube_Id == user.Sube_Id);
                var usertype = DatabaseCon.autoGalleryEntity.Personel_Turu_Tablosu.FirstOrDefault(pt => pt.Personel_Turu_Id == user.Personel_Turu_Id);
              
                EmployeeName = user.Personel_Adi_Soyadi;
                BranchName = userbranch.Sube_Adi;
                BranchId = user.Sube_Id;
                EmployeeType = usertype.Personel_Turu;
                EmployeeTypeId = user.Personel_Turu_Id;
                EmployeeId= user.Personel_Id;

                FormControl.autoGallery.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(Wronglogin);
            }
            
        }

        private void LoginLabelExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginLabelClearFields_Click(object sender, EventArgs e)
        {
            LoginTextBoxUsername.Clear();
            LoginTextBoxPassword.Clear();
            LoginTextBoxUsername.Focus();
        }

        

        
    }
}
