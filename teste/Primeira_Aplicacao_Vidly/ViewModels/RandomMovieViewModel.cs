using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Primeira_Aplicacao_Vidly.Models;

namespace Primeira_Aplicacao_Vidly.ViewModels
{
    public partial class RandomMovieViewModel
    {
       public Movie Movie { get; set; }
       public List<Customer> Customers { get; set; }
    }
}