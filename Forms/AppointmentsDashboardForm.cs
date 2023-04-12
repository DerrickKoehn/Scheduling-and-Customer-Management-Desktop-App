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
    public partial class AppointmentsDashboardForm : Form
    {
        public BindingList<Appointment> visibleAppointments = new BindingList<Appointment>();
        public static string userNameString { get; set; }
       
        public AppointmentsDashboardForm(string userNameStringInput)
        {
            InitializeComponent();
            userNameString = userNameStringInput;
            AppointmentsDashboardForm.userNameString = userNameString;
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            viewSelectorComboBox.SelectedIndex = 0;
            
        }

        private void viewSelectorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (viewSelectorComboBox.Text == "All")
            {
                visibleAppointments = Database.getAppointments($"SELECT * from appointment WHERE userId = (SELECT userId from user WHERE userName='{userNameString}')");
                
                //The following lambda sorts the list of appointments using only a single line of code.
                visibleAppointments = new BindingList<Appointment>(visibleAppointments.OrderBy(appointment => appointment.Start).ToList());

                appointmentsDGV.DataSource = visibleAppointments;
                
            }
            else if (viewSelectorComboBox.Text == "This Week")
            {
                BindingList<Appointment> tempBindingList = new BindingList<Appointment>();
                visibleAppointments = Database.getAppointments($"SELECT * from appointment WHERE userId = (SELECT userId from user WHERE userName='{userNameString}')");
                foreach (Appointment item in visibleAppointments)
                {
                    if(item.Start > DateTime.Now && item.Start < DateTime.Now.AddDays(7))
                    {
                        tempBindingList.Add(item);
                    }
                }
                visibleAppointments = tempBindingList;
                //The following lambda sorts the list of appointments using only a single line of code.
                visibleAppointments = new BindingList<Appointment>(visibleAppointments.OrderBy(appointment => appointment.Start).ToList());
                appointmentsDGV.DataSource = visibleAppointments;
            }
            else if (viewSelectorComboBox.Text== "This Month")
            {
                BindingList<Appointment> tempBindingList = new BindingList<Appointment>();
                visibleAppointments = Database.getAppointments($"SELECT * from appointment WHERE userId = (SELECT userId from user WHERE userName='{userNameString}')");
                foreach (Appointment item in visibleAppointments)
                {
                    if (item.Start > DateTime.Now && item.Start < DateTime.Now.AddDays(30))
                    {
                        tempBindingList.Add(item);
                    }
                }
                visibleAppointments = tempBindingList;
                //The following lambda sorts the list of appointments using only a single line of code.
                visibleAppointments = new BindingList<Appointment>(visibleAppointments.OrderBy(appointment => appointment.Start).ToList());
                appointmentsDGV.DataSource = visibleAppointments;
            }
        }
        private void appointmentsDGV_SelectionChanged(object sender, EventArgs e)
        {
            if(appointmentsDGV.SelectedRows.Count > 0)
            {
                editAppointmentButton.Enabled = true;
                deleteAppointmentButton.Enabled = true;
            }
            else
            {
                editAppointmentButton.Enabled = false;
                deleteAppointmentButton.Enabled = false;
            }
        }

        private void addAppointmentButton_Click(object sender, EventArgs e)
        {
            AppointmentForm appointmentForm = new AppointmentForm();
            appointmentForm.ShowDialog();

            //a simple way to refresh the datagrid after changes via appointmentForm
            viewSelectorComboBox_SelectedIndexChanged(sender, e);
        }

        private void editAppointmentButton_Click(object sender, EventArgs e)
        {
            Appointment tempAppointment = appointmentsDGV.CurrentRow.DataBoundItem as Appointment;
            AppointmentForm appointmentForm = new AppointmentForm(tempAppointment);
            
            appointmentForm.ShowDialog();
            //a simple way to refresh the datagrid after changes via appointmentForm
            viewSelectorComboBox_SelectedIndexChanged(sender, e);
        }

        private void deleteAppointmentButton_Click(object sender, EventArgs e)
        {
            Appointment tempAppointment = appointmentsDGV.CurrentRow.DataBoundItem as Appointment;
            //delete the appointment
            Database.deleteAppointment(tempAppointment);
            //refresh the datagrid
            viewSelectorComboBox_SelectedIndexChanged(sender, e);

        }
    }
}
