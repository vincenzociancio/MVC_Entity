using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Primeira_Aplicacao_Vidly.Models
{
    public class Movie
    {
        public int id { get; set; }
        public string name { get; set; }
        [Required]
        public Genre genre { get; set; }
        [Required]
        public DateTime releaseDate { get; set; }
        [Required]
        public DateTime addDate { get; set; }
        [Required]
        public int stock { get; set; }       

    }
}