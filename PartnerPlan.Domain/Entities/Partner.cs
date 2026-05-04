namespace PartnerPlan.Domain.Entities
{
    public class Partner
    {
        public Guid UserId { get; set; }
        public Guid PartnerUserId { get; set; }

        public User? User { get; set; }
        public User? PartnerUser { get; set; }
    }
}
