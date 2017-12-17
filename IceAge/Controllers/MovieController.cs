using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IceAge.Models;
using System.Collections;


namespace IceAge.Controllers
{
    public class MovieController : Controller
    {
       
        // GET: Movie
        public ActionResult Index()
        {
            Movie film = new Movie();

            film.MovieId = 1;
            film.MovieName = "Shrek";
            film.Production = "Dream Works";
            film.Price = 80;
            film.CreateDate = DateTime.Now; 

            List<Movie> firstMovie = new List<Movie>();

            firstMovie.Add(film);


            return View(firstMovie);
        }
    }
}