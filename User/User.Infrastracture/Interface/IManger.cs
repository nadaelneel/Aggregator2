using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User.Infrastracture.Interface
{
    public interface IManger<T>
    {
        Task<T> GetByIdAsync(int id);

        IQueryable<T> GetAllAsyncNoTracking();
        Task<List<T>> GetAllAsync();

        Task AddAsync(T entity);

        Task DeleteAsync(T entity);

        Task UpdateAsync(T entity);
    }
}
