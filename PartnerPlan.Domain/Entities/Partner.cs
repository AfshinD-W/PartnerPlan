namespace PartnerPlan.Domain.Entities
{
    public class Partner
    {
        public Guid UserId { get; set; }
        public Guid PartnerId { get; set; }

        public required User User { get; set; }
        public required User PartnerUser { get; set; }
    }
}
