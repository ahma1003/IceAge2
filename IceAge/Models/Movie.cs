using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IceAge.Models;
using System.Data.Entity;


namespace IceAge.Models
{
    public class Movie
    {
        public int MovieId { get; set; }
        public String MovieName { get; set; }
        public String Production { get; set; }
        public int Price { get; set; }
        public DateTime CreateDate { get; set; }
    }

    public class MovieDBContext : DbContext                     // inherit from DB Context (EntityFramework)
    {
        public DbSet<Movie> Movie { get; set; }
    }
}