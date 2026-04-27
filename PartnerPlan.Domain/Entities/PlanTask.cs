namespace PartnerPlan.Domain.Entities
{
    public class PlanTask : BaseEntity
    {
        public int Index { get; set; }
        public required string Title { get; set; }
    }
}
