using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FilmReviewApplication.DAL.Repos
{
    public interface IRepo<T> where T : class
    {
        Task<T> GetById(int id);
        Task<List<T>> GetAll();
        Task Create(T entity);
        Task Update(T entity);
        Task Delete(int id);
       
        bool Exists(int id);
    }
}
