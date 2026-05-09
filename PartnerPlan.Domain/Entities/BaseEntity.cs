namespace PartnerPlan.Domain.Entities
{
    public class BaseEntity<TKey> where TKey : IEquatable<TKey>
    {
        public required TKey Id { get; set; }
        public Guid CreatorId { get; set; }
        public DateTime Created { get; set; }
        public Guid UpdateorId { get; set; }
        public DateTime Updated { get; set; }
    }
}
