using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Primeira_Aplicacao_Vidly.Models;
using Primeira_Aplicacao_Vidly.ViewModels;

namespace Primeira_Aplicacao_Vidly.Controllers
{
    public class TesteController : Controller
    {   
        // GET: Teste
        public ActionResult Index()
        {
            //        var movie = new Movie() { name = "Catch me if you can" };

              var customer = new List<Customer>
              {
                   new Customer { Name = "José das Couves"},
                  new Customer { Name = "Joáo da alface"}
              };

            /*
            var viewModel = new RandomMovieViewModel
            {
                //   Movie = movie,
                Customers = customer
            };

            */
           return View( );
        }
    }
}