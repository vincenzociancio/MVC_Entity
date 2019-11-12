using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Primeira_Aplicacao_Vidly.Models;

namespace Primeira_Aplicacao_Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() {name = "Catch me if you can"};

            //     ViewData["RandomMovie"] = movie;
            //     ViewBag.RandomMovie = movie;

            var viewResult = new ViewResult();

            return View(movie);

            // return Content("blablablahblabhlabhlabhlabhla");

            // return new EmptyResult();

           // return RedirectToAction("Index", "Home", new {page = 1, sortBy = "name"});
        }

        public ActionResult Edit(int id = 1)
           {
            return Content("ID " + id);
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;

            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "name";

            return Content(string.Format("pageindex= {0}&sortBy= {1}", pageIndex, sortBy));
        }

        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month  )
        {
            return Content(year + "/" + month );
        }
    }
}