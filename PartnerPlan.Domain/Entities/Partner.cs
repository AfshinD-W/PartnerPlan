namespace PartnerPlan.Domain.Entities
{
    public class Partner : BaseEntity<Guid>
    {
        public Guid UserId { get; set; }
        public Guid PartnerUserId { get; set; }

        public User? User { get; set; }
        public User? PartnerUser { get; set; }
    }
}
