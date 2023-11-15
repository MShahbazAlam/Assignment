using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Web_API_Assignment.Models;

namespace Web_API_Assignment.Controllers
{
    [RoutePrefix("api/countries")]
    public class CountryController : ApiController
    {
        private static List<Country> countries = new List<Country>
    {
        new Country { CountryID = 1, CountryName = "India", CountryCapital = "New Delhi" },
        new Country { CountryID = 2, CountryName = "Qatar", CountryCapital = "Doha" },
        new Country { CountryID = 3, CountryName = "Germany", CountryCapital = "Berlin" }
    };

        // GET api/country - Retrieve all countries
        public IHttpActionResult Get()
        {
            return Ok(countries);
        }

        // GET api/country/{id} - Retrieve a country by ID
        public IHttpActionResult Get(int id)
        {
            var country = countries.FirstOrDefault(c => c.CountryID == id);
            if (country == null)
            {
                return NotFound();
            }
            return Ok(country);
        }

        // POST: api/Country  - Add a new country
        public IHttpActionResult Post([FromBody] Country country)
        {
            country.CountryID = countries.Count + 1;
            countries.Add(country);
            return CreatedAtRoute("DefaultApi", new { id = country.CountryID }, country);
        }

        // PUT api/country/{id} - Update a country by ID
        public IHttpActionResult Put(int id, [FromBody] Country updatedCountry)
        {
            var country = countries.FirstOrDefault(c => c.CountryID == id);
            if (country == null)
            {
                return NotFound();
            }

            country.CountryName = updatedCountry.CountryName;
            country.CountryCapital = updatedCountry.CountryCapital;

            return Ok(country);
        }

        // DELETE api/country/{id} - Delete a country by ID
        public IHttpActionResult Delete(int id)
        {
            var country = countries.FirstOrDefault(c => c.CountryID == id);
            if (country == null)
            {
                return NotFound();
            }

            countries.Remove(country);

            return Ok(country);
        }
    }

}