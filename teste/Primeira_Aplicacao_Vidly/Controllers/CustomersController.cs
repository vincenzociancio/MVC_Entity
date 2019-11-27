using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;
using Primeira_Aplicacao_Vidly.Models;
using Primeira_Aplicacao_Vidly.ViewModels;

namespace Primeira_Aplicacao_Vidly.Controllers
{
    public class CustomersController : Controller
    {

        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool Disposed)
        {
            _context.Dispose();
        }
        

        // GET: Customers
        public ActionResult Index()
        {
            var customers = _context.customers.Include(c => c.membershipType).ToList();
            return View(customers); 
        }

        [Route("Customers/Details/{id}")]
        public ActionResult Details(int id) {

            var customer = _context.customers.SingleOrDefault(c => c.id == id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }     
        
     /*   private IEnumerable<Customer> GetCustomers()
        {

            return new List<Customer>
            {
                new Customer { name = "José das Couves", id=0},
                new Customer { name = "João da alface", id=1}
            };
        }*/
    }

    
}