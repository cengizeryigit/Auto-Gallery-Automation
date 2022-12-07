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
    public partial class LoginRun : Form
    {
        public LoginRun()
        {
            InitializeComponent();
        }

        private void LoginRun_Load(object sender, EventArgs e)
        {
            FormControl.Lang();
            FormControl.login.Show();
            this.Hide();
        }
    }
}
