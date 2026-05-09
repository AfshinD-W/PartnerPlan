using Microsoft.EntityFrameworkCore;
using PartnerPlan.Domain.Entities;
using PartnerPlan.Domain.Interfaces;

namespace PartnerPlan.Infrastructure.BaseRepository
{
    public class Repository<TKey, TEntity> : IRepository<TKey, TEntity> where TKey : IEquatable<TKey> where TEntity : class, IBaseEntity<TKey>
    {
        private DbContext _dbContext;
        private DbSet<TEntity> _dbSet;
        public Repository(DbContext dBContext)
        {
            _dbContext = dBContext;
            _dbSet = _dbContext.Set<TEntity>();
        }

        public async Task CreateAsync(TEntity entity)
        {
            entity.Created = DateTime.Now;
            _dbSet.Add(entity);
        }

        public async Task DeleteAsync(TEntity entity)
        {
            _dbSet.Remove(entity);
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<TEntity?> GetByIdAsybc(TKey id)
        {
            return await _dbSet.FirstOrDefaultAsync(t => t.Id.Equals(id));
        }

        public async Task UpdateAsync(TEntity entity)
        {
            entity.Updated = DateTime.Now;
            _dbSet.Update(entity);
        }
    }
}
