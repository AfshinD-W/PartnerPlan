namespace PartnerPlan.Domain.Entities
{
    public interface IBaseEntity<TKey> where TKey : IEquatable<TKey>
    {
        TKey Id { get; set; }
        Guid CreatorId { get; set; }
        DateTime Created { get; set; }
        Guid UpdateorId { get; set; }
        DateTime Updated { get; set; }
    }
}
