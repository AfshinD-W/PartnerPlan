namespace PartnerPlan.Domain.Entities
{
    public class Plan : BaseEntity<Guid>
    {
        public int? Code { get; set; }
        public int? ParentCode { get; set; }
        public int? Index { get; set; }
        public required string Title { get; set; }
        public Guid? PlanOwnerId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public User? PlanOwner { get; set; }
        public ICollection<User> Users { get; set; } = [];
    }
}
