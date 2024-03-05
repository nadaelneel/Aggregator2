using Departments.Infrastracture.Context;
using Departments.Infrastracture.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Departments.Infrastracture.Reposatories
{
    public class Manger<T> : IManger<T> where T : class
    {
        #region Fields
        private readonly AppDbContext _db;
        private readonly DbSet<T> Set;
        #endregion
        #region Contractors
        public Manger(AppDbContext db)
        {
            _db = db;
            Set = _db.Set<T>();
        }
        #endregion
        #region Methods

        public async Task AddAsync(T entity)
        {
            await Set.AddAsync(entity);
        }


        public async Task DeleteAsync(T entity)
        {
            Set.Remove(entity);
        }

        public async Task<List<T>> GetAllAsync()
        {
            return Set.ToList();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await Set.FindAsync(id);
        }
        public IQueryable<T> GetAll()
        {
            return Set;
        }
        public IQueryable<T> GetAllAsyncNoTracking()
        {
            return Set.AsNoTracking();
        }

        public async Task UpdateAsync(T entity)
        {
            Set.Update(entity);
        }

        #endregion
    }
}
