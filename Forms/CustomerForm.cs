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
    public partial class CustomerForm : Form
    {
        public Customer tempCustomer { get; set; }
        public CustomerForm()
        {
            InitializeComponent();
            tempCustomer = new Customer();
        }
        public CustomerForm(Customer customer)
        {
            InitializeComponent();

            saveUpdateButton.Text = "Update";
            tempCustomer = customer;
            //place attributes into respective text boxes fix
            customerNameTextBox.Text = customer.CustomerName;
            addressTextBox.Text = customer.Address;
            address2TextBox.Text = customer.Address2;
            cityTextBox.Text = customer.City;
            countryTextBox.Text = customer.Country;
            postalCodeTextBox.Text = customer.PostalCode;
            phoneTextBox.Text = customer.Phone;

        }

        private void validateFormContents()
        {
            if (customerNameTextBox.Text == "")
            {
                throw new Exception("Please add a customer name.");
            }
            if (addressTextBox.Text == "")
            {
                throw new Exception("Please add an address.");
            }
            if (address2TextBox.Text == "")
            {
                address2TextBox.Text = "NA";
            }
            if (cityTextBox.Text == "")
            {
                throw new Exception("Please add a city name.");
            }
            if (countryTextBox.Text == "")
            {
                throw new Exception("Please add a country name.");
            }
            if (postalCodeTextBox.Text == "")
            {
                throw new Exception("Please add a postal code.");
            }
            if (phoneTextBox.Text == "")
            {
                phoneTextBox.Text = "NA";
            }
            if (postalCodeTextBox.Text.Length > 10)
            {
                throw new Exception("Postal code cannot be longer than 10 characters.");
            }
        }
        private void CustomerForm_Load(object sender, EventArgs e)
        {
            editingAsLabel.Text += AppointmentsDashboardForm.userNameString;
        }

        private void saveUpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                //verify that form's input data is valid
                validateFormContents();
                //update the tempCustomer object using the values in the text boxes
                tempCustomer.CustomerName = customerNameTextBox.Text;
                tempCustomer.Address = addressTextBox.Text;
                tempCustomer.Address2 = address2TextBox.Text;
                tempCustomer.City = cityTextBox.Text;
                tempCustomer.Country = countryTextBox.Text;
                tempCustomer.PostalCode = postalCodeTextBox.Text;
                tempCustomer.Phone = phoneTextBox.Text;
                tempCustomer.LastUpdateBy = AppointmentsDashboardForm.userNameString;
                tempCustomer.LastUpdate = DateTime.Now;

                if (saveUpdateButton.Text == "Update")
                {
                    Database.updateCustomer(tempCustomer);
                    this.Close();
                }
                else
                {
                    Database.saveNewCustomer(tempCustomer);
                    this.Close();
                }

            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
        }

        
    }
}
