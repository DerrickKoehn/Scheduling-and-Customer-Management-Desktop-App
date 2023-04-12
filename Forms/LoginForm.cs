using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SoftwareII.Classes;
using static SoftwareII.Classes.Database;
using static SoftwareII.Classes.Translation;

namespace SoftwareII.Forms
{
    public partial class LoginForm : Form
    {
        public string userName;
        public string loginErrorMessage = "Username or password is incorrect.";
        public LoginForm()
        {
            InitializeComponent();
            
           if(CultureInfo.CurrentCulture.Name.Contains("es"))
            {
                this.Text = "Inicia Sesión";
                usernameLabel.Text = "Nombre Usuario";
                passwordLabel.Text = "Contraseña";
                submitButton.Text = "Enviar";
                instructionsLabel.Text = "Introduzca el nombre de usuario y la contraseña.";
                loginErrorMessage = "El nombre de usuario o la contraseña son incorrectos.";

            }

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            try
            {
                //return row from database if username and password match a record
                DataSet dataSet = new DataSet();
                MySqlDataAdapter adapter = new MySqlDataAdapter();

                adapter.SelectCommand = new MySqlCommand($"SELECT * from user WHERE userName = '{usernameTextBox.Text}' " +
                    $"AND password = '{passwordTextBox.Text}'", databaseConnection);

                adapter.Fill(dataSet);
                
                //if there is a row, the username and password matched
                if (dataSet.Tables[0].Rows.Count > 0)
                {



                    userName = usernameTextBox.Text;
                    //record the successful login in login.txt
                    if (File.Exists("login.txt"))
                    {
                        using (StreamWriter sw = File.AppendText("login.txt"))
                        {
                            sw.WriteLine($"Login: Username - {usernameTextBox.Text} Date & Time: {DateTime.Now.ToUniversalTime().ToString()} ");
                        }
                    }
                    else
                    {
                        using (StreamWriter sw = File.CreateText("login.txt"))
                        {
                            sw.WriteLine($"Login: Username - {usernameTextBox.Text} Date & Time: {DateTime.Now.ToUniversalTime().ToString()} ");

                        }
                    }
                    this.Hide();
                }
                else
                {
                    if (File.Exists("login.txt"))
                    {
                        using (StreamWriter sw = File.AppendText("login.txt"))
                        {
                            sw.WriteLine($"Unsuccessful Login Attempt: Username - {usernameTextBox.Text} Date & Time: {DateTime.Now.ToUniversalTime().ToString()} ");
                        }
                    }
                    else
                    {
                        using (StreamWriter sw = File.CreateText("login.txt"))
                        {
                            sw.WriteLine($"Unsuccessful Login Attempt: Username - {usernameTextBox.Text} Date & Time: {DateTime.Now.ToUniversalTime().ToString()} ");

                        }
                    }
                    throw new Exception(loginErrorMessage);
                }
            }
            catch (Exception exception)
            {

                errorMessageLabel.Text = exception.Message;
                errorMessageLabel.Visible = true;
                
            }
            

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
