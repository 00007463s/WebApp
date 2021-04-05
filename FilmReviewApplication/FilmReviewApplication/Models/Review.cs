using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmReviewApplication.Models
{
    public class Review
    {
        public int Id { get; set; }

        [Required]
        [MinLength(10)]
        public string ReviewText { get; set; }

        public int FilmId { get; set; }

        public int UserId { get; set; }

        public int Rating { get; set; }

        public virtual Film Film { get; set; }
        public virtual User User { get; set; }
    }
}
