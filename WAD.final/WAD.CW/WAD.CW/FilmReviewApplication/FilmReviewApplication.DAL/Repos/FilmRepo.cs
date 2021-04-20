using FilmReviewApplication.DAL.DBO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmReviewApplication.DAL.Repos
{
    public class FilmRepo : Repo, IRepo<Film>
    {
        public FilmRepo(FilmReviewApplicationDbContext context) : base(context)
        {

        }

        public async Task Create(Film entity)
        {
            _context.Films.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var film = await _context.Films.FindAsync(id);
            _context.Films.Remove(film);
            await _context.SaveChangesAsync();
        }

        public bool Exists(int id)
        {
            return _context.Films.Any(e => e.Id == id);
        }

        public async Task<List<Film>> GetAll()
        {
            return await _context.Films.ToListAsync();
        }

        public async Task<Film> GetById(int id)
        {
            return await _context.Films.FindAsync(id);
        }

        public async Task Update(Film entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
