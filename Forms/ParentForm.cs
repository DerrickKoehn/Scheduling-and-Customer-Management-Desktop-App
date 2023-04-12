using SoftwareII.Classes;
using SoftwareII.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SoftwareII
{
	public partial class ParentForm : Form
	{
		public string userNameString = "";
		public Form visibleForm = null;
		public ParentForm()
		{
			InitializeComponent();
		}

		

        private void ParentForm_Load(object sender, EventArgs e)
        {
			Database.openConnection();
			LoginForm loginForm = new LoginForm();
			loginForm.ShowDialog();
			menuStrip.Visible = true;
			userNameString = loginForm.userName;
			menuStripUsernameTextBox.Text = $"Welcome, {userNameString}!";
			loginForm.Close();
			AppointmentsDashboardForm.userNameString = userNameString;
			visibleForm = new AppointmentsDashboardForm(userNameString);
			visibleForm.MdiParent = this;
			visibleForm.Show();
			
			BindingList<Appointment> tempList = Database.getAppointments($"SELECT * from appointment WHERE userId = (SELECT userId from user WHERE userName = '{userNameString}')");
			
			if(tempList.Any(appointment => (appointment.Start > DateTime.Now && appointment.Start < DateTime.Now.AddMinutes(15))))
			{
				MessageBox.Show("Your next appointment begins in less than 15 minutes.");
			}
			/*
			The abovelambda expression eliminated several lines of code, replacing a foreach loop and several
			associated lines of code.
			
			*/
			
		}

        
       

        private void appointmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
			visibleForm.Close();
			visibleForm = new AppointmentsDashboardForm(AppointmentsDashboardForm.userNameString);
			visibleForm.MdiParent = this;
			visibleForm.Show();
			
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
			visibleForm.Close();
			visibleForm = new CustomerDashboardForm();
			visibleForm.MdiParent = this;
			visibleForm.Show();
        }

        private void apptTypeMonthMenuItem_Click(object sender, EventArgs e)
        {
			visibleForm.Close();
			visibleForm = new ReportApptTypeMonthForm();
			visibleForm.MdiParent = this;
			visibleForm.Show();
        }

        private void scheduleByConsultantToolStripMenuItem_Click(object sender, EventArgs e)
        {
			visibleForm.Close();
			visibleForm = new ReportScheduleByConsultantForm();
			visibleForm.MdiParent = this;
			visibleForm.Show();
        }

        private void customReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
			visibleForm.Close();
			visibleForm = new ReportLoginStats();
			visibleForm.MdiParent = this;
			visibleForm.Show();
		}

        
    }
}
