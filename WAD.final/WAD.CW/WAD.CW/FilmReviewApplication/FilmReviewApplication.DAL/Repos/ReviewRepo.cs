using FilmReviewApplication.DAL.DBO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmReviewApplication.DAL.Repos
{
    public class ReviewRepo : Repo, IRepo<Review>
    {
        public ReviewRepo(FilmReviewApplicationDbContext context) : base(context)
        {

        }

        public async Task Create(Review entity)
        {
            _context.Reviews.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var review = await _context.Reviews.FindAsync(id);
            _context.Reviews.Remove(review);
            await _context.SaveChangesAsync();
        }

        public bool Exists(int id)
        {
            return _context.Reviews.Any(e => e.Id == id);
        }

        public async Task<List<Review>> GetAll()
        {
            return await _context.Reviews.ToListAsync();
        }

        public async Task<Review> GetById(int id)
        {
            return await _context.Reviews.FindAsync(id);
        }

        public async Task Update(Review entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
