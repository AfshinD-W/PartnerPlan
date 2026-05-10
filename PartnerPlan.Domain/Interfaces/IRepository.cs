using PartnerPlan.Domain.Entities;

namespace PartnerPlan.Domain.Interfaces
{
    public interface IRepository<TKey, TEntity> where TKey : IEquatable<TKey> where TEntity : class, IBaseEntity<TKey>
    {
        Task<TEntity?> GetByIdAsybc(TKey id);
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task AddAsync(TEntity entity);
        Task UpdateAsync(TEntity entity);
        Task RemoveAsync(TEntity entity);
        Task<int> SaveChangeAsync();
    }
}
