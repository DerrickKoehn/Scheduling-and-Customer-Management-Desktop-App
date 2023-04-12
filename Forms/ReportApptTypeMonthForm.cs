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
    public partial class ReportApptTypeMonthForm : Form
    {
        public ReportApptTypeMonthForm()
        {
            InitializeComponent();
        }

        private void ReportApptTypeMonth_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            
        }

        private void countButton_Click(object sender, EventArgs e)
        {
            string sqlString = $"Select * FROM appointment";
            BindingList<Appointment> tempBindingList = new BindingList<Appointment>();
            tempBindingList = Database.getAppointments(sqlString);
            int appointmentCount = 0;

            foreach (Appointment appointment in tempBindingList)
            {
                if (appointment.Type == typeTextBox.Text)
                {
                    switch (monthComboBox.Text)
                    {
                        case "January":
                            if (appointment.Start.Month == 1)
                            {
                                appointmentCount++;
                            }
                            break;

                        case "February":
                            if (appointment.Start.Month == 2)
                            {
                                appointmentCount++;
                            }
                            break;

                        case "March":
                            if (appointment.Start.Month == 3)
                            {
                                appointmentCount++;
                            }
                            break;
                        case "April":
                            if (appointment.Start.Month == 4)
                            {
                                appointmentCount++;
                            }

                            break;
                        case "May":
                            if (appointment.Start.Month == 5)
                            {
                                appointmentCount++;
                            }

                            break;
                        case "June":
                            if (appointment.Start.Month == 6)
                            {
                                appointmentCount++;
                            }

                            break;
                        case "July":
                            if (appointment.Start.Month == 7)
                            {
                                appointmentCount++;
                            }

                            break;
                        case "August":
                            if (appointment.Start.Month == 8)
                            {
                                appointmentCount++;
                            }

                            break;
                        case "September":
                            if (appointment.Start.Month == 9)
                            {
                                appointmentCount++;
                            }

                            break;
                        case "October":
                            if (appointment.Start.Month == 10)
                            {
                                appointmentCount++;
                            }

                            break;
                        case "November":
                            if (appointment.Start.Month == 11)
                            {
                                appointmentCount++;
                            }

                            break;
                        case "December":
                            if (appointment.Start.Month == 12)
                            {
                                appointmentCount++;
                            }

                            break;


                    }
                }
                
            }
            resultLabel.Text = $"{appointmentCount.ToString()} appointment matches your parameters.";
        }
    }
}
