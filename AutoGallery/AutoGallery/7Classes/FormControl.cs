using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }

    
}
