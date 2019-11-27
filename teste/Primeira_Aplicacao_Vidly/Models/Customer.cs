using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Primeira_Aplicacao_Vidly.Models
{
    public class Customer
    {
        public int id { get; set; }
        [Required]
        [StringLength(255)]
        public string name { get; set; }
        //public List<Movie> Movie  { get; set; }
        public bool isSubscribeNewsLetter { get; set; }
        public MembershipType membershipType { get; set; }


    }
}