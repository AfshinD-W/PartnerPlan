using PartnerPlan.Domain.Entities;

namespace PartnerPlan.Domain.Interfaces
{
    public interface IBaseService<TKey, TEntity> where TKey : IEquatable<TKey> where TEntity : class, IBaseEntity<TKey>
    {
        Task<TEntity> CreateAsync(TEntity entity, bool autoSave = false);
        Task<TEntity> UpdateAsync(TEntity entity, bool autoSave = false);
        Task<TEntity> DeleteAsync(TKey id, bool autoSave = false);
    }
}
