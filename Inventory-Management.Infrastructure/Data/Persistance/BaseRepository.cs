using Inventory_Managment.Domain.Entities;
using Inventory_Managment.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Inventory_Managment.Infrastructure.Data.Persistance
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        private readonly DbContext _context;
        private readonly DbSet<T> _dbSet;

        public BaseRepository(DbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public IQueryable<T> GetEntity()
        {
            return _dbSet.AsQueryable();
        }

        public virtual async Task<T?> GetByIdAsync(long id)
        {
            return await _dbSet.FindAsync(id);
        }

        public virtual async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T> AddAsync(T entity)
        {
            entity.CreatedWhen = DateTime.Now;
            await _dbSet.AddAsync(entity);
            return entity;
        }

        public async Task<IEnumerable<T>> AddManyAsync(IEnumerable<T> entities)
        {
            var entitiesList = entities.ToList();
            foreach (var entity in entitiesList)
            {
                entity.CreatedWhen = DateTime.Now;
            }
            await _dbSet.AddRangeAsync(entitiesList);
            return entitiesList;
        }

        public async Task<T> UpdateAsync(T entity)
        {
            entity.ChangedWhen = DateTime.Now;
            _dbSet.Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
          
        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }

        public async Task DeleteAllAsync()
        {
            var entities = await _dbSet.ToListAsync();
            _dbSet.RemoveRange(entities);
        }
    }
}
