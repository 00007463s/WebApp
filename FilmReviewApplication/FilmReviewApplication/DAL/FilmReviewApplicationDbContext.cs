using FilmReviewApplication.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmReviewApplication.DAL
{

    public class FilmReviewApplicationDbContext :DbContext
    {
        public FilmReviewApplicationDbContext(DbContextOptions<FilmReviewApplicationDbContext> options) : base(options)
        {

        }
        public virtual DbSet<Film> Films { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Review> Reviews { get; set; }
    }
}
