using System;
using System.Collections.Generic;
using System.Text;

namespace FilmReviewApplication.DAL.Repos
{
    public abstract class Repo
    {
        protected readonly FilmReviewApplicationDbContext _context;

        protected Repo(FilmReviewApplicationDbContext context)
        {
            _context = context;
        }
    }
}
