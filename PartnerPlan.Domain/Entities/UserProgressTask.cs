namespace PartnerPlan.Domain.Entities
{
    public class UserProgressTask : BaseEntity
    {
        public Guid UserId { get; set; }
        public Guid PlanTaskId { get; set; }
        public DateTime WorkOnDay { get; set; } = DateTime.Now;
        public int ProgressMinutes { get; set; }

        public User? User { get; set; }
        public Plan? PlanTask { get; set; }
    }
}
