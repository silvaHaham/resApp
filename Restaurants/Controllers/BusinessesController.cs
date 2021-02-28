using Restaurants.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.IO;

namespace Restaurants.Controllers
{
    public class BusinessesController : ApiController
    {
        // GET api/<controller>
        public List<Businesses> Get()
        {
            Businesses businesses = new Businesses();
            List<Businesses> bList=businesses.Read();
            return bList;
        }
        //public List<Businesses> Get(string cuisines)
        //{
        //    Businesses businesses = new Businesses();
        //    List<Businesses> bList = businesses.Read(cuisines);
        //    return bList;
        //}

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]Businesses businesses)
        {
            businesses.Insert();
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}