namespace PartnerPlan.Domain.Entities
{
    public class UserProgressTask : BaseEntity
    {
        public Guid PlanTaskId { get; set; }
        public Guid UserId { get; set; }
        public DateTime WorkOnDay { get; set; }
        public int ProgressMinutes { get; set; }
    }
}
