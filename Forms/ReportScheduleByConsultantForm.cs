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
    public partial class ReportScheduleByConsultantForm : Form
    {
        public ReportScheduleByConsultantForm()
        {
            InitializeComponent();
        }

        private void ReportScheduleByConsultantForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            consultantsComboBox.DataSource = Database.getUsers("SELECT * FROM user");
        }

        private void consultantsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            appointmentsDGV.DataSource = Database.getAppointments($"SELECT * FROM appointment WHERE userId = (SELECT userId from user WHERE userName = '{consultantsComboBox.Text}')");
            appointmentsDGV.Refresh();
        }
    }
}
