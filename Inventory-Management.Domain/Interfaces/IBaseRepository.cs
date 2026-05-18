using Inventory_Managment.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Managment.Domain.Interfaces
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        Task<T> AddAsync(T entity);
        void Delete(T entity);
        IQueryable<T> GetEntity();
        public Task<T> GetByIdAsync(long id);
        public Task<IEnumerable<T>> GetAllAsync();
        Task DeleteAllAsync();
        Task<T> UpdateAsync(T entity);
    }
}
