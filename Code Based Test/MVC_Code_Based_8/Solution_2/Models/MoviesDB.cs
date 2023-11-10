using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace Solution_2.Models
{
    public class MoviesDB : DbContext
    {
        //    public DbSet<Movies> Movie { get; set; }

        public DbSet<Movies> Movie { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movies>().HasKey(m => m.Mid);
            base.OnModelCreating(modelBuilder);
        }
    }
}