using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmReviewApplication.Models
{
    public class Film
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Genre { get; set; }

        [Required]
        [Range(2000, int.MaxValue)]
        public int Year { get; set; }

        [Required]

        public string CountryofProduction { get; set; }

        public virtual ICollection<Review> Reviews { get; set; }
    }
}
