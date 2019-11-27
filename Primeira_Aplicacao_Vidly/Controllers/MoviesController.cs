using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Primeira_Aplicacao_Vidly.Models;
using Primeira_Aplicacao_Vidly.ViewModels;

namespace Primeira_Aplicacao_Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
    /*        var movie = new Movie() {name = "Catch me if you can"};
 
            var customer = new List<Customer>
            {
                new Customer { Name = "José das Couves"},
                new Customer { Name = "Joáo da alface"}
            };
            
            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customer
            };
 */
            return View();
           
        }

        public ActionResult Edit(int id = 1)
           {
            return Content("ID " + id);
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            var movies = GetMovies();
            return View(movies);
            /*     if (!pageIndex.HasValue)
                     pageIndex = 1;

                 if (String.IsNullOrWhiteSpace(sortBy))
                     sortBy = "name";

                 return Content(string.Format("pageindex= {0}&sortBy= {1}", pageIndex, sortBy));
                 */
        }

        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month  )
        {
            return Content(year + "/" + month );
        }

        public ActionResult Details(int id)
        {
            var movies = GetMovies().SingleOrDefault(c => c.id == id);

            if (movies == null)
                return HttpNotFound();

            return View(movies);
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
                {
                new Movie { name = "Catch me if you can", id = 0},
                new Movie { name = "The Wolf of Wall Street", id = 1}
               };
        }
    }
}