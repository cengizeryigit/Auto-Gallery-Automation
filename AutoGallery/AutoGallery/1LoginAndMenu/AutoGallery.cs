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
    public partial class AutoGallery : Form
    {
        public AutoGallery()
        {
            InitializeComponent();
        }

        private void AutoGallery_Load(object sender, EventArgs e)
        {
            Refresh();
            FormControl.autoGalleryLoad.MdiParent = this;
            FormControl.autoGalleryLoad.Show();

            UsertoolStripMenuItemName.Text = Login.EmployeeName;
            UsertoolStripMenuItemBranch.Text = Login.BranchName;
            UsertoolStripMenuItemType.Text = Login.EmployeeType;
            
            if (Login.EmployeeTypeId == 2)
            {
                ReportToolStripMenuItem.Enabled = false;
            }
            if (Login.EmployeeTypeId == 3)
            {
                EmployeeToolStripMenuItem.Enabled = false;
                ReportToolStripMenuItem.Enabled = false;
            }
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void AddCustomerstoolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormControl.MdiHide();
            FormControl.addCustomers.MdiParent = this;
            FormControl.addCustomers.Show();
        }

        private void UpdateCustomerstoolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormControl.MdiHide();
            FormControl.updateCustomers.MdiParent = this;
            FormControl.updateCustomers.Show(); 
        }

        private void ListCarstoolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormControl.MdiHide();
            FormControl.listCars.MdiParent = this;
            FormControl.listCars.Show();
        }

        private void AddCarstoolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormControl.MdiHide();
            FormControl.addCars.MdiParent = this;
            FormControl.addCars.Show();
        }

        private void UpdateCarstoolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormControl.MdiHide();
            FormControl.updateCars.MdiParent = this;    
            FormControl.updateCars.Show();
        }

        private void RentalContracttoolStripMenuItem0_Click(object sender, EventArgs e)
        {
            FormControl.MdiHide();
            FormControl.rentalContract.MdiParent = this;
            FormControl.rentalContract.Show();
        }

        private void SalesContracttoolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormControl.MdiHide();
            FormControl.salesContract.MdiParent = this;
            FormControl.salesContract.Show();
        }

        private void ListEmployeetoolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormControl.MdiHide();
            FormControl.listEmployee.MdiParent = this;
            FormControl.listEmployee.Show();
        }

        private void AddEmployeetoolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormControl.MdiHide();
            FormControl.addEmployee.MdiParent = this;
            FormControl.addEmployee.Show();
        }

        private void UpdateEmployeetoolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormControl.MdiHide();
            FormControl.updateEmployee.MdiParent = this;
            FormControl.updateEmployee.Show();
        }

        private void ReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormControl.MdiHide();
            FormControl.report.MdiParent = this;
            FormControl.report.Show();
        }
    }
}
