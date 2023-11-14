using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace Solution_2.Models
{
    public class MoviesDB : DbContext
    {
<<<<<<< HEAD
        public MoviesDB() :base("MoviesDB")
=======
         public MoviesDB() :base("MoviesDB")
>>>>>>> f7656b70eaccbaa526fee63d0be314388f2da0ac
        {

        }
        public DbSet<Movies> Movie { get; set; }
<<<<<<< HEAD
        
=======
>>>>>>> f7656b70eaccbaa526fee63d0be314388f2da0ac
    }
}
