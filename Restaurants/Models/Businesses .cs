using Restaurants.Models.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Restaurants.Models
{
    public class Businesses
    {
        int id;
        string photo;
        string name;
        double aggregate_rating;
        string cuisines;
        double price_range;
        string address;
        string phon_numbers;

        public Businesses(int id, string photo, string name, double aggregate_rating, string cuisines, double price_range, string address, string phon_numbers)
        {
            Id = id;
            Photo = photo;
            Name = name;
            Aggregate_rating = aggregate_rating;
            Cuisines = cuisines;
            Price_range = price_range;
            Address = address;
            Phon_numbers = phon_numbers;
        }

        public int Id { get => id; set => id = value; }
        public string Photo { get => photo; set => photo = value; }
        public string Name { get => name; set => name = value; }
        public double Aggregate_rating { get => aggregate_rating; set => aggregate_rating = value; }
        public string Cuisines { get => cuisines; set => cuisines = value; }
        public double Price_range { get => price_range; set => price_range = value; }
        public string Address { get => address; set => address = value; }
        public string Phon_numbers { get => phon_numbers; set => phon_numbers = value; }

        public Businesses() { }

        public void Insert()
        {
            DBServices dbs = new DBServices();
            dbs.InsertBusinesses(this);
        }
        public List<Businesses> Read()
        {
            DBServices dbs = new DBServices();
            return dbs.ReadBusinesses();
        }
        public List<Businesses> Read(string cuisines)
        {
            DBServices dbs = new DBServices();
            return dbs.ReadBusinesses(cuisines);
        }
    }
}