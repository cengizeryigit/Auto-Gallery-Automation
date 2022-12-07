using AutoGallery._8Localization;
using System;
using System.Collections;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;


namespace AutoGallery
{
    class FormControl
    {
        public static Login login = new Login();
        public static AutoGallery autoGallery = new AutoGallery();
        public static AutoGalleryLoad autoGalleryLoad = new AutoGalleryLoad();
        public static AddCustomers addCustomers = new AddCustomers();
        public static UpdateCustomers updateCustomers = new UpdateCustomers();
        public static ListCars listCars = new ListCars();
        public static AddCars addCars = new AddCars();
        public static UpdateCars updateCars = new UpdateCars();
        public static RentalCars rentalCars = new RentalCars();
        public static RentalCustomers rentalCustomers = new RentalCustomers();
        public static RentalContract rentalContract = new RentalContract();
        public static SalesCars salesCars = new SalesCars();
        public static SalesCustomers salesCustomers = new SalesCustomers();
        public static SalesContract salesContract = new SalesContract();
        public static ListEmployee listEmployee = new ListEmployee();
        public static AddEmployee addEmployee = new AddEmployee();
        public static UpdateEmployee updateEmployee = new UpdateEmployee();
        public static Report report = new Report();

        

        public static void MdiHide()
        {
            login.Hide();
            autoGalleryLoad.Hide();
            addCustomers.Hide();
            updateCustomers.Hide();
            listCars.Hide();
            addCars.Hide();
            updateCars.Hide();
            rentalContract.Hide();
            salesContract.Hide();
            listEmployee.Hide();
            addEmployee.Hide();
            updateEmployee.Hide();
            rentalCustomers.Hide();
            rentalCars.Hide();
            salesCars.Hide();
            salesCustomers.Hide();
            report.Hide();

        }

        public static void Lang()
        {
            if (Settings.Default.dil == "English")
            {
                _8Localization.Localization.Culture= new CultureInfo("");
                
                
            }
            else if (Settings.Default.dil == "Turkish")
            {
                _8Localization.Localization.Culture = new CultureInfo("tr-TR");
            }
            else if (Settings.Default.dil == "Spanish")
            {
                _8Localization.Localization.Culture = new CultureInfo("es-ES");
            }


            //Login
            login.LoginLabelLogin.Text= _8Localization.Localization.LoginLabelLogin;
            login.LoginLabelClearFields.Text = _8Localization.Localization.LoginLabelClearFields;
            login.LoginButtonLogin.Text= _8Localization.Localization.LoginButtonLogin;
            login.LoginLabelExit.Text= _8Localization.Localization.LoginLabelExit;
            login.Wronglogin= _8Localization.Localization.Wronglogin;

            //autoGallery
            autoGallery.CarsToolStripMenuItem.Text = _8Localization.Localization.CarsToolStripMenuItem;
            autoGallery.ContractToolStripMenuItem.Text = _8Localization.Localization.ContractToolStripMenuItem;
            autoGallery.ReportToolStripMenuItem.Text = _8Localization.Localization.ReportToolStripMenuItem;
            autoGallery.LanguageToolStripMenuItem.Text = _8Localization.Localization.LanguageToolStripMenuItem;
            autoGallery.ExitToolStripMenuItem.Text = _8Localization.Localization.ExitToolStripMenuItem;
            autoGallery.UserToolStripMenuItem.Text = _8Localization.Localization.UserToolStripMenuItem;
            autoGallery.AddCustomerstoolStripMenuItem.Text = _8Localization.Localization.AddCustomerstoolStripMenuItem;
            autoGallery.UpdateCustomerstoolStripMenuItem.Text = _8Localization.Localization.UpdateCustomerstoolStripMenuItem;
            autoGallery.ListCarstoolStripMenuItem.Text = _8Localization.Localization.ListCarstoolStripMenuItem;
            autoGallery.AddCarstoolStripMenuItem.Text = _8Localization.Localization.AddCarstoolStripMenuItem;
            autoGallery.UpdateCarstoolStripMenuItem.Text = _8Localization.Localization.UpdateCarstoolStripMenuItem;
            autoGallery.RentalContracttoolStripMenuItem0.Text = _8Localization.Localization.RentalContracttoolStripMenuItem0;
            autoGallery.SalesContracttoolStripMenuItem.Text = _8Localization.Localization.SalesContracttoolStripMenuItem;
            autoGallery.LanguagetoolStripMenuItemEnglish.Text = _8Localization.Localization.LanguagetoolStripMenuItemEnglish;
            autoGallery.LanguagetoolStripMenuItemTurkish.Text = _8Localization.Localization.LanguagetoolStripMenuItemTurkish;
            autoGallery.EmployeeToolStripMenuItem.Text = _8Localization.Localization.EmployeeToolStripMenuItem;
            autoGallery.ListEmployeetoolStripMenuItem.Text = _8Localization.Localization.ListEmployeetoolStripMenuItem;
            autoGallery.AddEmployeetoolStripMenuItem.Text = _8Localization.Localization.AddEmployeetoolStripMenuItem;
            autoGallery.UpdateEmployeetoolStripMenuItem.Text = _8Localization.Localization.UpdateEmployeetoolStripMenuItem;
            autoGallery.CustomersToolStripMenuItem.Text = _8Localization.Localization.CustomersToolStripMenuItem;
            autoGallery.LanguagetoolStripMenuItemSpanish.Text = _8Localization.Localization.LanguagetoolStripMenuItemSpanish;
            autoGallery.LanguagetoolStripMenuItemFrench.Text = _8Localization.Localization.LanguagetoolStripMenuItemFrench;
            autoGallery.LanguagetoolStripMenuItemJapanase.Text = _8Localization.Localization.LanguagetoolStripMenuItemJapanase;


            //AddCustomers
            addCustomers.AddCustomersLabelSecurityNumber.Text = _8Localization.Localization.AddCustomersLabelSecurityNumber;
            addCustomers.AddCustomersLabelNameSurname.Text = _8Localization.Localization.AddCustomersLabelNameSurname;
            addCustomers.AddCustomersLabelDateofBirth.Text = _8Localization.Localization.AddCustomersLabelDateofBirth;
            addCustomers.AddCustomersLabelTelephone.Text = _8Localization.Localization.AddCustomersLabelTelephone;
            addCustomers.AddCustomersLabelDrivingLicenseNunmber.Text = _8Localization.Localization.AddCustomersLabelDrivingLicenseNunmber;
            addCustomers.AddCustomersLabelDriversLicenseDate.Text = _8Localization.Localization.AddCustomersLabelDriversLicenseDate;
            addCustomers.AddCustomersLabelEMail.Text = _8Localization.Localization.AddCustomersLabelEMail;
            addCustomers.AddCustomersLabelAddress.Text = _8Localization.Localization.AddCustomersLabelAddress;
            addCustomers.AddCustomersButtonAddCustomers.Text = _8Localization.Localization.AddCustomersButtonAddCustomers;

            //UpdateCustomers
            updateCustomers.UpdateCustomersLabelSecurityNumber.Text = _8Localization.Localization.UpdateCustomersLabelSecurityNumber;
            updateCustomers.UpdateCustomersLabelNameSurname.Text = _8Localization.Localization.UpdateCustomersLabelNameSurname;
            updateCustomers.UpdateCustomersLabelDateofBirth.Text = _8Localization.Localization.UpdateCustomersLabelDateofBirth;
            updateCustomers.UpdateCustomersLabelTelephone.Text = _8Localization.Localization.UpdateCustomersLabelTelephone;
            updateCustomers.UpdateCustomersLabelDrivingLicenseNunmber.Text = _8Localization.Localization.UpdateCustomersLabelDrivingLicenseNunmber;
            updateCustomers.UpdateCustomersLabelDriversLicenseDate.Text = _8Localization.Localization.UpdateCustomersLabelDriversLicenseDate;
            updateCustomers.UpdateCustomersLabelEMail.Text = _8Localization.Localization.UpdateCustomersLabelEMail;
            updateCustomers.UpdateCustomersLabelAddress.Text = _8Localization.Localization.UpdateCustomersLabelAddress;
            updateCustomers.UpdateCustomersButtonUpdateCustomers.Text = _8Localization.Localization.UpdateCustomersButtonUpdateCustomers;

            //AddCars
            addCars.AddCarsLabelPlate.Text= _8Localization.Localization.AddCarsLabelPlate;
            addCars.AddCarsLabelRentMoney.Text= _8Localization.Localization.AddCarsLabelRentMoney;
            addCars.AddCarsLabelSalesMoney.Text= _8Localization.Localization.AddCarsLabelSalesMoney;
            addCars.AddCarsLabelYear.Text= _8Localization.Localization.AddCarsLabelYear;
            addCars.AddCarsLabelFuel.Text= _8Localization.Localization.AddCarsLabelFuel;
            addCars.AddCarsLabelKm.Text= _8Localization.Localization.AddCarsLabelKm;
            addCars.AddCarsLabelColour.Text= _8Localization.Localization.AddCarsLabelColour;
            addCars.AddCarsButtonAddCars.Text= _8Localization.Localization.AddCarsButtonAddCars;

            //ListCars
            listCars.ListCarsButtonListCars.Text = _8Localization.Localization.ListCarsButtonListCars;
            listCars.ListAllCarsButtonListAllCars.Text = _8Localization.Localization.ListAllCarsButtonListAllCars;

            //UpdateCars
            updateCars.UpdateCarsLabelPlate.Text = _8Localization.Localization.AddCarsLabelPlate;
            updateCars.UpdateCarsLabelRentMoney.Text = _8Localization.Localization.AddCarsLabelRentMoney;
            updateCars.UpdateCarsLabelSalesMoney.Text = _8Localization.Localization.AddCarsLabelSalesMoney;
            updateCars.UpdateCarsLabelYear.Text = _8Localization.Localization.AddCarsLabelYear;
            updateCars.UpdateCarsLabelFuel.Text = _8Localization.Localization.AddCarsLabelFuel;
            updateCars.UpdateCarsLabelKm.Text = _8Localization.Localization.AddCarsLabelKm;
            updateCars.UpdateCarsLabelColour.Text = _8Localization.Localization.AddCarsLabelColour;
            updateCars.UpdateCarsButtonUpdateCars.Text = _8Localization.Localization.UpdateCarsButtonUpdateCars;

            //RentalCars
            rentalCars.RentalCarsButtonListCar.Text = _8Localization.Localization.RentalCarsButtonListCar;

            //RentalCustomers
            rentalCustomers.ChooseCustomersButtonListCustomer.Text = _8Localization.Localization.ChooseCustomersButtonListCustomer;

            //RentalContract
            rentalContract.RentalContractLabelSecurityNumber.Text = _8Localization.Localization.RentalContractLabelSecurityNumber;
            rentalContract.RentalContractLabelNameSurname.Text = _8Localization.Localization.RentalContractLabelNameSurname;
            rentalContract.RentalContractLabelTelephone.Text = _8Localization.Localization.RentalContractLabelTelephone;
            rentalContract.RentalContractLabelAdress.Text = _8Localization.Localization.RentalContractLabelAdress;
            rentalContract.RentalContractLabelBrand.Text = _8Localization.Localization.RentalContractLabelBrand;
            rentalContract.RentalContractLabelModel.Text = _8Localization.Localization.RentalContractLabelModel;
            rentalContract.RentalContractLabelPlate.Text = _8Localization.Localization.RentalContractLabelPlate;
            rentalContract.RentalContractLabelRentMoney.Text = _8Localization.Localization.RentalContractLabelRentMoney;
            rentalContract.RentalContractLabelFirstDay.Text = _8Localization.Localization.RentalContractLabelFirstDay;
            rentalContract.RentalContractLabelLastDay.Text = _8Localization.Localization.RentalContractLabelLastDay;
            rentalContract.RentalContractLabelTotalFee.Text = _8Localization.Localization.RentalContractLabelTotalFee;
            rentalContract.RentalContactButtonCustomer.Text = _8Localization.Localization.RentalContactButtonCustomer;
            rentalContract.RentalContactButtonCar.Text = _8Localization.Localization.RentalContactButtonCar;
            rentalContract.RentalContactButtonCalculate.Text = _8Localization.Localization.RentalContactButtonCalculate;
            rentalContract.RentalContactButtonVehicleDelivered.Text = _8Localization.Localization.RentalContactButtonVehicleDelivered;
            rentalContract.RentalContactButtonRentalContact.Text = _8Localization.Localization.RentalContactButtonRentalContact;
            rentalContract.RentalContactButtonListRentalContract.Text = _8Localization.Localization.RentalContactButtonListRentalContract;
            rentalContract.RentalContactButtonListRentCar.Text = _8Localization.Localization.RentalContactButtonListRentCar;

            //SalesCars
            salesCars.SalesCarsButtonListCar.Text = _8Localization.Localization.SalesCarsButtonListCar;

            //SalesCustomers
            salesCustomers.SalesCustomersButtonListCustomer.Text = _8Localization.Localization.SalesCustomersButtonListCustomer;

            //SalesContract
            salesContract.SalesContractLabelSecurityNumber.Text = _8Localization.Localization.RentalContractLabelSecurityNumber;
            salesContract.SalesContractLabelNameSurname.Text = _8Localization.Localization.RentalContractLabelNameSurname;
            salesContract.SalesContractLabelTelephone.Text = _8Localization.Localization.RentalContractLabelTelephone;
            salesContract.SalesContractLabelAdress.Text = _8Localization.Localization.RentalContractLabelAdress;
            salesContract.SalesContractLabelBrand.Text = _8Localization.Localization.RentalContractLabelBrand;
            salesContract.SalesContractLabelModel.Text = _8Localization.Localization.RentalContractLabelModel;
            salesContract.SalesContractLabelPlate.Text = _8Localization.Localization.RentalContractLabelPlate;
            salesContract.SalesContractLabelSalesMoney.Text = _8Localization.Localization.SalesContractLabelSalesMoney;
            salesContract.SalesContractLabelPurchaseDate.Text = _8Localization.Localization.SalesContractLabelPurchaseDate;
            salesContract.SalesContractLabelTotalFee.Text = _8Localization.Localization.RentalContractLabelTotalFee;
            salesContract.SalesContactButtonCustomer.Text = _8Localization.Localization.SalesContactButtonCustomer;
            salesContract.SalesContactButtonCar.Text = _8Localization.Localization.SalesContactButtonCar;
            salesContract.SalesContactButtonRentalContact.Text = _8Localization.Localization.SalesContactButtonRentalContact;

            //ListEmployee
            listEmployee.ListEmployeeButtonListEmployee.Text= _8Localization.Localization.ListEmployeeButtonListEmployee;
            listEmployee.ListAllEmployeeButtonListAllEmployee.Text= _8Localization.Localization.ListAllEmployeeButtonListAllEmployee;

            //AddEmployee
            addEmployee.AddEmployeeLabelSecurityNumber.Text = _8Localization.Localization.RentalContractLabelSecurityNumber;
            addEmployee.AddEmployeeLabelNameSurname.Text = _8Localization.Localization.RentalContractLabelNameSurname;
            addEmployee.AddEmployeeLabelTelephone.Text = _8Localization.Localization.RentalContractLabelTelephone;
            addEmployee.AddEmployeeLabelAdress.Text = _8Localization.Localization.RentalContractLabelAdress;
            addEmployee.AddEmployeeLabelDateofBirth.Text = _8Localization.Localization.AddCustomersLabelDateofBirth;
            addEmployee.AddEmployeeLabelEMail.Text = _8Localization.Localization.AddCustomersLabelEMail;
            addEmployee.AddEmployeeLabelPassword.Text = _8Localization.Localization.AddEmployeeLabelPassword;
            addEmployee.AddEmployeeButtonAddEmployee.Text = _8Localization.Localization.AddEmployeeButtonAddEmployee;

            //UpdateEmployee
            updateEmployee.UpdateEmployeeLabelSecurityNumber.Text = _8Localization.Localization.RentalContractLabelSecurityNumber;
            updateEmployee.UpdateEmployeeLabelNameSurname.Text = _8Localization.Localization.RentalContractLabelNameSurname;
            updateEmployee.UpdateEmployeeLabelTelephone.Text = _8Localization.Localization.RentalContractLabelTelephone;
            updateEmployee.UpdateEmployeeLabelAdress.Text = _8Localization.Localization.RentalContractLabelAdress;
            updateEmployee.UpdateEmployeeLabelDateofBirth.Text = _8Localization.Localization.AddCustomersLabelDateofBirth;
            updateEmployee.UpdateEmployeeLabelEMail.Text = _8Localization.Localization.AddCustomersLabelEMail;
            updateEmployee.UpdateEmployeeLabelPassword.Text = _8Localization.Localization.AddEmployeeLabelPassword;
            updateEmployee.UpdateEmployeeButtonUpdateEmployee.Text = _8Localization.Localization.UpdateEmployeeButtonUpdateEmployee;

            //Report
            report.radioButton1.Text= _8Localization.Localization.radioButton1;
            report.radioButton2.Text= _8Localization.Localization.radioButton2;
            report.radioButton3.Text= _8Localization.Localization.radioButton3;
            report.radioButton4.Text= _8Localization.Localization.radioButton4;
            report.radioButton5.Text= _8Localization.Localization.radioButton5;
            report.radioButton6.Text= _8Localization.Localization.radioButton6;
            report.radioButton7.Text= _8Localization.Localization.radioButton7;
            report.radioButton8.Text= _8Localization.Localization.radioButton8;
            report.radioButton9.Text= _8Localization.Localization.radioButton9;
            report.radioButton10.Text= _8Localization.Localization.radioButton10;
            report.radioButton11.Text= _8Localization.Localization.radioButton11;
            report.ReportButtonReport.Text = _8Localization.Localization.ReportButtonReport;




        }
    }

    
}
