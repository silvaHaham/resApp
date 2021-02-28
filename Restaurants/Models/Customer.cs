using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Restaurants.Models.DAL;

namespace Restaurants.Models
{
    public class Customer
    {
        int id;
        string fname;
        string lname;
        string email;
        string phoneN;
        string password;
        string photoName;

        public Customer() { }

        public Customer(string fname, string lname, string email, string phoneN, string password, string photoName)
        {

            Fname = fname;
            Lname = lname;
            Email = email;
            PhoneN = phoneN;
            Password = password;
            PhotoName = photoName;
        }
        public int Id { get => id; set => id = value; }
        public string Fname { get => fname; set => fname = value; }
        public string Lname { get => lname; set => lname = value; }
        public string Email { get => email; set => email = value; }
        public string PhoneN { get => phoneN; set => phoneN = value; }
        public string Password { get => password; set => password = value; }
        public string PhotoName { get => photoName; set => photoName = value; }

        public void InsertC()
        {
            DBServices dbs = new DBServices();
            dbs.InsertCustomer(this);
        }
    }
}