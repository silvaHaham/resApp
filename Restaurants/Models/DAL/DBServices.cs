using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Data;
using System.Text;
using System.IO;
using Restaurants.Models;

namespace Restaurants.Models.DAL
{
    public class DBServices
    {
        //add the static to have persistant storage
        public SqlDataAdapter da;
        public DataTable dt;

        static public List<Businesses> businessesList;

        //public void InsertBusinesses(Businesses businesses)
        //{
        //    if (businessesList==null)
        //    businessesList = new List<Businesses>();
        //    businessesList.Add(businesses);

        //}
        // This method creates a connection to the database according to the connectionString name in the web.config 
        public SqlConnection connect(String conString)
        {

            // read the connection string from the configuration file
            string cStr = WebConfigurationManager.ConnectionStrings[conString].ConnectionString;
            SqlConnection con = new SqlConnection(cStr);
            con.Open();
            return con;
        }
        // This method inserts a student to the student table 
        public int InsertBusinesses(Businesses businesses)
        {

            SqlConnection con;
            SqlCommand cmd;

            try
            {
                con = connect("DBConnectionString"); // create the connection
            }
            catch (Exception ex)
            {
                throw (ex);
            }

            String cStr = BuildInsertCommand(businesses);      // helper method to build the insert string

            cmd = CreateCommand(cStr, con);             // create the command

            try
            {
                int numEffected = cmd.ExecuteNonQuery(); // execute the command
                return numEffected;
            }
            catch (Exception ex)
            {
                // write to log
                throw (ex);
            }

            finally
            {
                if (con != null)
                {
                    // close the db connection
                    con.Close();
                }
            }

        }
        // Build the Insert command String
        private String BuildInsertCommand(Businesses businesses)
        {
            String command;

            StringBuilder sb = new StringBuilder();
            // use a string builder to create the dynamic string
            sb.AppendFormat("Values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')", businesses.Id, businesses.Photo, businesses.Name, businesses.Aggregate_rating, businesses.Cuisines, businesses.Price_range, businesses.Address, businesses.Phon_numbers);
            String prefix = "INSERT INTO Restaurants_2021 " + "(id, photo, name, aggregate_rating, cuisines, price_range, address, phon_numbers) ";
            command = prefix + sb.ToString();

            return command;
        }
        // Create the SqlCommand
        private SqlCommand CreateCommand(String CommandSTR, SqlConnection con)
        {

            SqlCommand cmd = new SqlCommand(); // create the command object

            cmd.Connection = con;              // assign the connection to the command object

            cmd.CommandText = CommandSTR;      // can be Select, Insert, Update, Delete 

            cmd.CommandTimeout = 10;           // Time to wait for the execution' The default is 30 seconds

            cmd.CommandType = System.Data.CommandType.Text; // the type of the command, can also be stored procedure

            return cmd;
        }
        public List<Businesses> ReadBusinesses()
        {
            return businessesList;

        }
        public List<Businesses> ReadBusinesses(string cuisines)
        {
            List<Businesses> filteredList = new List<Businesses>();
            foreach (Businesses b in businessesList)
            {
                if (b.Cuisines == cuisines)
                {
                    filteredList.Add(b);
                }
            }
            return filteredList;
        }
        public int InsertCustomer(Customer customer)
        {

            SqlConnection con;
            SqlCommand cmd;

            try
            {
                con = connect("DBConnectionString"); // create the connection
            }
            catch (Exception ex)
            {
                // write to log
                throw (ex);
            }

            String cStr = BuildInsertCustomerCommand(customer);      // helper method to build the insert string

            cmd = CreateCommand(cStr, con);             // create the command

            try
            {
                int numEffected = cmd.ExecuteNonQuery(); // execute the command
                return numEffected;
            }
            catch (Exception ex)
            {
                // write to log
                throw (ex);
            }

            finally
            {
                if (con != null)
                {
                    // close the db connection
                    con.Close();
                }
            }

        }

        private String BuildInsertCustomerCommand(Customer customer)
        {
            String command;

            StringBuilder sb = new StringBuilder();
            // use a string builder to create the dynamic string
            sb.AppendFormat("Values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", customer.Fname, customer.Lname, customer.Email, customer.PhoneN, customer.Password, customer.PhotoName);
            String prefix = "INSERT INTO Customers_2021 " + "(fname, lname, email, phoneN, password, photoName) ";
            command = prefix + sb.ToString();

            return command;
        }


    }
}