namespace PartnerPlan.Domain.Entities
{
    public class Plan : BaseEntity
    {
        public int? Code { get; set; }
        public string? Title { get; set; }
        public Guid PlanOwner { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public required ICollection<User> Users { get; set; }
    }
}
