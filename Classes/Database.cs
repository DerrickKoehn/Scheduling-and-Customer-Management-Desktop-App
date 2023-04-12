using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoftwareII.Forms;

namespace SoftwareII.Classes
{
    public static class Database
    {
        public static MySqlConnection databaseConnection { get; set; }

        //connection methods
        public static void openConnection()
        {
            try
            {
                databaseConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["localdb"].ConnectionString);
                databaseConnection.Open();
                
            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
            

        }

        public static void closeConnection()
        {
            if (databaseConnection != null)
            {
                databaseConnection.Close();
            }
        }
        //appointment methods
        public static BindingList<Appointment> getAppointments(string sqlQueryString)
        {
            //create a bindinglist to hold appointment objects
            BindingList<Appointment> listOfAppointments = new BindingList<Appointment>();

            //execute a mySql Command and save its contents in a data reader object
            MySqlCommand mySqlCommand = new MySqlCommand(sqlQueryString, databaseConnection);
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

            //as long as the .Read() method returns true, loop will continue
            while(mySqlDataReader.Read())
            {
                //create a temporary appointment object
                Appointment tempAppointment = new Appointment();
                //for each property in the appointment...
                foreach (var property in typeof(Appointment).GetProperties())
                {
                    //if it's a DateTime property
                    if (property.PropertyType.ToString() == "System.DateTime")
                    {
                        //set its value to local time representation of the stored time string
                        DateTime tempDateTime = DateTime.Parse(mySqlDataReader[property.Name].ToString());
                        tempDateTime = DateTime.SpecifyKind(tempDateTime, DateTimeKind.Utc);
                        tempDateTime = tempDateTime.ToLocalTime();
                        property.SetValue(tempAppointment, tempDateTime);
                        
                    }
                    else
                    {
                        //for any other property type, convert string from query into correct datatype and set as property value
                        property.SetValue(tempAppointment, 
                                    Convert.ChangeType(mySqlDataReader[property.Name].ToString(), property.PropertyType));
                    }
                    
                }
                //when finished populating Appointment object, add it to the bindnglist
                listOfAppointments.Add(tempAppointment);

            }

            mySqlDataReader.Close();
            //when finished processing data from sql request, return the bindinglist
            return listOfAppointments;
        }

        public static void updateAppointment(Appointment appointment)
        {
            string sqlString = $"UPDATE appointment SET" +
                $" start = '{appointment.Start.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss")}'," +
                $" end = '{appointment.End.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss")}'," +
                $" customerId = '{appointment.CustomerID}'," +
                $" userId = (SELECT userId FROM user WHERE userName = '{AppointmentsDashboardForm.userNameString}')," +
                $" title = '{appointment.Title}'," +
                $" description = '{appointment.Description}'," +
                $" location = '{appointment.Location}'," +
                $" contact = '{appointment.Contact}'," +
                $" type = '{appointment.Type}'," +
                $" url = '{appointment.Url}'," +
                $" lastUpdateBy = '{AppointmentsDashboardForm.userNameString}'," +
                $" lastUpdate = '{DateTime.Now.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss")}'" +
                $" WHERE appointmentId = {appointment.AppointmentID}";
            
            MySqlCommand mySqlCommand = new MySqlCommand(sqlString, databaseConnection);
            mySqlCommand.ExecuteNonQuery();
        }
        public static void saveNewAppointment(Appointment appointment)
        {
            string sqlString = $"INSERT INTO appointment (" +
                $"start, " +
                $"end, " +
                $"customerId, " +
                $"userId, " +
                $"title, " +
                $"description, " +
                $"location, " +
                $"contact, " +
                $"type, " +
                $"url, " +
                $"lastUpdateBy, " +
                $"lastUpdate, " +
                $"createDate, " +
                $"createdBy) " +
                $"VALUES (" +
                $"'{appointment.Start.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss")}', " +
                $"'{appointment.End.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss")}', " +
                $"'{appointment.CustomerID}', " +
                $"(SELECT userId FROM user WHERE userName = '{AppointmentsDashboardForm.userNameString}'), " +
                $"'{appointment.Title}', " +
                $"'{appointment.Description}', " +
                $"'{appointment.Location}', " +
                $"'{appointment.Contact}', " +
                $"'{appointment.Type}', " +
                $"'{appointment.Url}', " +
                $"'{AppointmentsDashboardForm.userNameString}'," +
                $"'{DateTime.Now.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss")}', " +
                $"'{DateTime.Now.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss")}', " +
                $"'{AppointmentsDashboardForm.userNameString}')";

            MySqlCommand mySqlCommand = new MySqlCommand(sqlString, databaseConnection);
            mySqlCommand.ExecuteNonQuery();
        }
        public static void deleteAppointment(Appointment appointment)
        {
            string sqlString = $"DELETE from appointment WHERE appointmentId = {appointment.AppointmentID}";
            MySqlCommand mySqlCommand = new MySqlCommand(sqlString, databaseConnection);
            mySqlCommand.ExecuteNonQuery();
        }
        //customer methods
        public static BindingList<Customer> getCustomers(string sqlQueryString)
        {
            //create a bindinglist to hold customer objects
            BindingList<Customer> listOfCustomers = new BindingList<Customer>();

            //execute a mySql Command and save its contents in a data reader object
            MySqlCommand mySqlCommand = new MySqlCommand(sqlQueryString, databaseConnection);
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

            //as long as the .Read() method returns true, loop will continue
            while (mySqlDataReader.Read())
            {
                //create a temporary customer object
                Customer tempCustomer = new Customer();
                //for each property in the customer.
                foreach (var property in typeof(Customer).GetProperties())
                {
                    try
                    {
                        //if it's a DateTime property
                        if (property.PropertyType.ToString() == "System.DateTime")
                        {
                            //set its value to local time representation of the stored time string
                            DateTime tempDateTime = DateTime.Parse(mySqlDataReader[property.Name].ToString());
                            tempDateTime = DateTime.SpecifyKind(tempDateTime, DateTimeKind.Utc);
                            tempDateTime = tempDateTime.ToLocalTime();
                            property.SetValue(tempCustomer, tempDateTime);

                        }
                        else if (property.PropertyType.ToString() == "System.Int32")
                        {
                            int tempInt = Convert.ToInt32(mySqlDataReader[property.Name]);
                            property.SetValue(tempCustomer, tempInt);
                        }
                        else
                        {
                            //for any other property type, convert string from query into correct datatype and set as property value

                            property.SetValue(tempCustomer,
                                              Convert.ChangeType(mySqlDataReader[property.Name].ToString(), property.PropertyType));


                        }
                    }
                    catch
                    {

                    }



                }
                //when finished populating Appointment object, add it to the bindnglist
                listOfCustomers.Add(tempCustomer);

            }

            mySqlDataReader.Close();
            //when finished processing data from sql request, return the bindinglist
            return listOfCustomers;
        }

        public static void saveNewCustomer(Customer customer)
        {
            //save country
            string sqlString = $"INSERT INTO country (" +
                $"country, " +
                $"createDate, " +
                $"createdBy, " +
                $"lastUpdate, " +
                $"lastUpdateBy) " +
                $"VALUES (" +
                $"'{customer.Country}', " +
                $"'{customer.LastUpdate.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss")}', " +
                $"'{customer.LastUpdateBy}', " +
                $"'{customer.LastUpdate.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss")}', " +
                $"'{customer.LastUpdateBy}')";

            MySqlCommand mySqlCommand = new MySqlCommand(sqlString, databaseConnection);
            mySqlCommand.ExecuteNonQuery();

            //save city
            sqlString = $"INSERT INTO city (" +
                $"city, " +
                $"countryId, " +
                $"createDate, " +
                $"createdBy, " +
                $"lastUpdate, " +
                $"lastUpdateBy) " +
                $"VALUES (" +
                $"'{customer.City}'," +
                $" LAST_INSERT_ID(), " +
                $"'{customer.LastUpdate.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss")}', " +
                $"'{customer.LastUpdateBy}', " +
                $"'{customer.LastUpdate.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss")}', " +
                $"'{customer.LastUpdateBy}')";

            mySqlCommand = new MySqlCommand(sqlString, databaseConnection);
            mySqlCommand.ExecuteNonQuery();

            //save address
            sqlString = $"INSERT INTO address (" +
                $"address, " +
                $"address2, " +
                $"cityId, " +
                $"postalCode, " +
                $"phone, " +
                $"createDate, " +
                $"createdBy, " +
                $"lastUpdate, " +
                $"lastUpdateBy) " +
                $"VALUES (" +
                $"'{customer.Address}'," +
                $"'{customer.Address2}'," +
                $" LAST_INSERT_ID(), " +
                $" '{customer.PostalCode}'," +
                $" '{customer.Phone}'," +
                $" '{customer.LastUpdate.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss")}'," +
                $" '{customer.LastUpdateBy}', " +
                $" '{customer.LastUpdate.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss")}'," +
                $" '{customer.LastUpdateBy}')";

            mySqlCommand = new MySqlCommand(sqlString, databaseConnection);
            mySqlCommand.ExecuteNonQuery();

            //save customer
            sqlString = $"INSERT INTO customer (" +
                $"customerName, " +
                $"addressId, " +
                $"active, " +
                $"createDate, " +
                $"createdBy, " +
                $"lastUpdate, " +
                $"lastUpdateBy) " +
                $"VALUES (" +
                $"'{customer.CustomerName}'," +
                $" LAST_INSERT_ID(), " +
                $"1, " +
                $"'{customer.LastUpdate.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss")}', " +
                $"'{customer.LastUpdateBy}', " +
                $"'{customer.LastUpdate.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss")}', " +
                $"'{customer.LastUpdateBy}')";

            mySqlCommand = new MySqlCommand(sqlString, databaseConnection);
            mySqlCommand.ExecuteNonQuery();


        }
        public static void updateCustomer(Customer customer)
        {
            //update customer table
            string sqlString = $"UPDATE customer SET" +
                $" customerName = '{customer.CustomerName}'," +
                $" lastUpdate = '{customer.LastUpdate.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss")}'," +
                $" lastUpdateBy = '{customer.LastUpdateBy}' " +
                
                $" WHERE customerId = {customer.CustomerId}";

            MySqlCommand mySqlCommand = new MySqlCommand(sqlString, databaseConnection);
            mySqlCommand.ExecuteNonQuery();
            //update address table
            sqlString = $"UPDATE address SET" +
                $" address = '{customer.Address}'," +
                $" address2 = '{customer.Address2}'," +
                $" postalCode = '{customer.PostalCode}'," +
                $" lastUpdate = '{customer.LastUpdate.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss")}'," +
                $" lastUpdateBy = '{customer.LastUpdateBy}', " +
                $" phone = '{customer.Phone}'" +

                $" WHERE addressId = {customer.AddressId}";
            mySqlCommand = new MySqlCommand(sqlString, databaseConnection);
            mySqlCommand.ExecuteNonQuery();

            //update city table
            sqlString = $"UPDATE city SET" +
                $" city = '{customer.City}'," +
                $" lastUpdate = '{customer.LastUpdate.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss")}'," +
                $" lastUpdateBy = '{customer.LastUpdateBy}' " +

                $" WHERE cityId = {customer.CityId}";

            mySqlCommand = new MySqlCommand(sqlString, databaseConnection);
            mySqlCommand.ExecuteNonQuery();
            //update country table
            sqlString = $"UPDATE country SET" +
                $" country = '{customer.Country}'," +
                $" lastUpdate = '{customer.LastUpdate.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss")}'," +
                $" lastUpdateBy = '{customer.LastUpdateBy}' " +

                $" WHERE countryId = {customer.CountryId}";

            mySqlCommand = new MySqlCommand(sqlString, databaseConnection);
            mySqlCommand.ExecuteNonQuery();
        }
        public static void deleteCustomer(Customer customer)
        {

            //delete customer
            string sqlString = $"DELETE from customer WHERE customerId = {customer.CustomerId}";
            MySqlCommand mySqlCommand = new MySqlCommand(sqlString, databaseConnection);
            mySqlCommand.ExecuteNonQuery();

            //delete address
            sqlString = $"DELETE from address WHERE addressId = {customer.AddressId}";
            mySqlCommand = new MySqlCommand(sqlString, databaseConnection);
            mySqlCommand.ExecuteNonQuery();

            //delete city
            sqlString = $"DELETE from city WHERE cityId = {customer.CityId}";
            mySqlCommand = new MySqlCommand(sqlString, databaseConnection);
            mySqlCommand.ExecuteNonQuery();

            //delete country
            sqlString = $"DELETE from country WHERE countryId = {customer.CountryId}";
            mySqlCommand = new MySqlCommand(sqlString, databaseConnection);
            mySqlCommand.ExecuteNonQuery();
        }

        //consultant user method
        public static BindingList<string> getUsers(string sqlQueryString)
        {
            BindingList<string> tempBindingList = new BindingList<string>();
            MySqlCommand mySqlCommand = new MySqlCommand(sqlQueryString, databaseConnection);
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
            while (mySqlDataReader.Read())
            {
                //create a temporary appointment object
                string tempString = "";
                tempString = mySqlDataReader["userName"].ToString();
                tempBindingList.Add(tempString);
            }
            mySqlDataReader.Close();
                return tempBindingList;
        }
    }
}
