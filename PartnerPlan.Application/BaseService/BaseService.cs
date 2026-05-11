using PartnerPlan.Domain.Entities;
using PartnerPlan.Domain.Interfaces;

namespace PartnerPlan.Application.BaseService
{
    public class BaseService<TKey, TEntity> : IBaseService<TKey, TEntity> where TKey : IEquatable<TKey> where TEntity : class, IBaseEntity<TKey>
    {
        private readonly IRepository<TKey, TEntity> _repository;
        public BaseService(IRepository<TKey, TEntity> repository)
        {
            _repository = repository;
        }

        public async Task<TEntity> CreateAsync(TEntity entity, bool autoSave)
        {
            await _repository.AddAsync(entity);

            if (autoSave)
                await _repository.SaveChangeAsync();

            return entity;
        }

        public async Task<TEntity> DeleteAsync(TKey id, bool autoSave)
        {
            TEntity deletedItem = await _repository.GetByIdAsync(id) ?? throw new Exception($"There is no record with this id: {id}");

            await _repository.RemoveAsync(deletedItem);

            if (autoSave)
                await _repository.SaveChangeAsync();

            return deletedItem;
        }

        public async Task<TEntity> UpdateAsync(TEntity entity, bool autoSave)
        {
            TEntity updatedItem = await _repository.GetByIdAsync(entity.Id) ?? throw new Exception($"There is no record with this id: {id}");

            await _repository.UpdateAsync(entity);

            if (autoSave)
                await _repository.SaveChangeAsync();

            return updatedItem;
        }
    }
}
