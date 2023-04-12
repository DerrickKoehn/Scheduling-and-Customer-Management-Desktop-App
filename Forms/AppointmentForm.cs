using MySql.Data.MySqlClient;
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
    public partial class AppointmentForm : Form
    {
        public Appointment tempAppointment { get; set; }
        public AppointmentForm()
        {
            InitializeComponent();
            customerComboBox.DataSource = Database.getCustomers("SELECT * FROM customer");
            tempAppointment = new Appointment();
        }

        public AppointmentForm(Appointment appointment)
        {
            tempAppointment = appointment;
            InitializeComponent();
            customerComboBox.DataSource = Database.getCustomers("SELECT * FROM customer");
            customerComboBox.SelectedValue = tempAppointment.CustomerID;
            saveUpdateButton.Text = "Update";
            titleTextBox.Text = tempAppointment.Title;
            descriptionTextBox.Text = tempAppointment.Description;
            locationTextBox.Text = tempAppointment.Location;
            contactTextBox.Text = tempAppointment.Contact;
            typeTextBox.Text = tempAppointment.Type;
            urlTextBox.Text = tempAppointment.Url;
            startTimePicker.Value = tempAppointment.Start;
            endTimePicker.Value = tempAppointment.End;
        } 

        private void AppointmentForm_Load(object sender, EventArgs e)
        {
            editingAsLabel.Text += AppointmentsDashboardForm.userNameString;
            
        }

        private void validateFormContents() //checks whether user input is acceptable
        {
            //verify that selected end time is later than selected start time
            if (endTimePicker.Value < startTimePicker.Value)
            {
                throw new Exception("End time  must be after start time.");
            }
            //verify that selected timespan is not within an existing appointment
            
            foreach (Appointment item in Database.getAppointments($"SELECT * from appointment WHERE userId = (SELECT userId from user WHERE userName = '{AppointmentsDashboardForm.userNameString}')"))
            {
                if ((startTimePicker.Value > item.Start && startTimePicker.Value < item.End) || //if selected start time is within existing appointment 
                    (endTimePicker.Value > item.Start && endTimePicker.Value < item.End))      //or selected end time is within appointment
                {
                    if (item.AppointmentID != tempAppointment.AppointmentID) //if the conflict is not with same appointment.
                    {
                        throw new Exception("You have a scheduling conflict.");
                    }
                    
                }
            }

            //verify that selected appointment start time and end time are within business hours (8am - 5pm local)
            DateTime openingTime = DateTime.Parse("2022-01-01 08:00:00");
            DateTime closingTime = DateTime.Parse("2022-01-01 17:00:00");
            
            if(startTimePicker.Value.DayOfWeek == DayOfWeek.Saturday || startTimePicker.Value.DayOfWeek == DayOfWeek.Sunday ||
                endTimePicker.Value.DayOfWeek == DayOfWeek.Saturday || endTimePicker.Value.DayOfWeek == DayOfWeek.Sunday ||
                startTimePicker.Value.TimeOfDay  < openingTime.TimeOfDay || startTimePicker.Value.TimeOfDay > closingTime.TimeOfDay ||
                endTimePicker.Value.TimeOfDay < openingTime.TimeOfDay || endTimePicker.Value.TimeOfDay > closingTime.TimeOfDay)
            {
                throw new Exception("Appointments must not exceed business hours. Business hours are Monday-Friday, 8 am-5pm local time.");
            }
            
            //replace null textbox strings with "NA"
            if (titleTextBox.Text == "")
            {
                titleTextBox.Text = "NA";
            }
            if (descriptionTextBox.Text == "")

            {
                descriptionTextBox.Text = "NA";
            }
            if (locationTextBox.Text == "")
            {
                locationTextBox.Text = "NA";
            }
            if (contactTextBox.Text == "")
            {
                contactTextBox.Text = "NA";
            }
            if (typeTextBox.Text == "")
            {
                typeTextBox.Text = "NA";
            }
            if (urlTextBox.Text == "")
            {
                urlTextBox.Text = "NA";
            }

        }

        private void saveUpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                //call validation
                validateFormContents();
                //update the temporary Appointment object
                tempAppointment.CustomerID = Convert.ToInt32(customerComboBox.SelectedValue);
                tempAppointment.Title = titleTextBox.Text;
                tempAppointment.Description = descriptionTextBox.Text;
                tempAppointment.Location = locationTextBox.Text;
                tempAppointment.Contact = contactTextBox.Text;
                tempAppointment.Type = typeTextBox.Text;
                tempAppointment.Url = urlTextBox.Text;
                tempAppointment.Start = startTimePicker.Value;
                tempAppointment.End = endTimePicker.Value;
                




                //pass that object to Database.Add() or Database.Update()
                if (saveUpdateButton.Text == "Update")
                {
                    // call update appointment method from static Database class
                    Database.updateAppointment(tempAppointment);
                    this.Close();
                }
                else
                {
                    //call save appointment method from static Databse class
                    Database.saveNewAppointment(tempAppointment);
                    this.Close();
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                
            }
        }

        private void startTimePicker_ValueChanged(object sender, EventArgs e)
        {
            

        }
       

        private void endTimePicker_ValueChanged(object sender, EventArgs e)
        {
            
        }

      
    }
}
