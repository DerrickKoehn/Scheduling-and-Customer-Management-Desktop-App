using SoftwareII.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareII.Forms
{
    public partial class CustomerDashboardForm : Form
    {
        public BindingList<Customer> visibleCustomers = new BindingList<Customer>();
        public CustomerDashboardForm()
        {
            InitializeComponent();
            visibleCustomers = Database.getCustomers("SELECT * FROM customer, address, city, country where customer.addressId = address.addressId and address.cityId = city.cityId and city.countryId = country.countryId");
            customersDGV.DataSource = visibleCustomers;
        }

        private void CustomerDashboardForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void addCustomerButton_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm();
            customerForm.ShowDialog();
            //refresh the list of customers
            visibleCustomers = null;
            visibleCustomers = Database.getCustomers("SELECT * FROM customer, address, city, country where customer.addressId = address.addressId and address.cityId = city.cityId and city.countryId = country.countryId");
            customersDGV.DataSource = visibleCustomers;
            customersDGV.Refresh();
            
        }

        private void editCustomerButton_Click(object sender, EventArgs e)
        {
            Customer tempCustomer = customersDGV.CurrentRow.DataBoundItem as Customer;
            CustomerForm customerForm = new CustomerForm(tempCustomer);
            customerForm.ShowDialog();
            //refresh the list of customers
            
            visibleCustomers = Database.getCustomers("SELECT * FROM customer, address, city, country where customer.addressId = address.addressId and address.cityId = city.cityId and city.countryId = country.countryId");
            customersDGV.DataSource = visibleCustomers;
            customersDGV.Refresh();
        }

        private void deleteCustomerButton_Click(object sender, EventArgs e)
        {
            Customer tempCustomer = customersDGV.CurrentRow.DataBoundItem as Customer;
            try
            {
                BindingList < Appointment > tempBindingList = Database.getAppointments("SELECT * FROM appointment");
                foreach (Appointment item in tempBindingList)
                {
                    if (item.CustomerID == tempCustomer.CustomerId)
                    {
                        throw new Exception("There is an appontment scheduled with this customer. You must delete appointments before you can delete the customer.");

                    }
                }
                Database.deleteCustomer(tempCustomer);


            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
            visibleCustomers = Database.getCustomers("SELECT * FROM customer, address, city, country where customer.addressId = address.addressId and address.cityId = city.cityId and city.countryId = country.countryId");
            customersDGV.DataSource = visibleCustomers;
            customersDGV.Refresh();
        }

        private void customersDGV_SelectionChanged(object sender, EventArgs e)
        {
            if (customersDGV.SelectedRows.Count > 0)
            {
                editCustomerButton.Enabled = true;
                deleteCustomerButton.Enabled = true;
            }
            else
            {
                editCustomerButton.Enabled = false;
                deleteCustomerButton.Enabled = false;
            }
        }
    }
}
