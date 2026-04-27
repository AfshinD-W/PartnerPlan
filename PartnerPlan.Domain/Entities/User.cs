namespace PartnerPlan.Domain.Entities
{
    public class User : BaseEntity
    {
        public required string Name { get; set; }
        public required string Email { get; set; }
        public required string HashPassword { get; set; }
        public bool IsConfirm { get; set; }

        public ICollection<Plan>? Plans { get; set; }
        public ICollection<Partner>? Partners { get; set; }
        public ICollection<UserProgressTask>? ProgressTasks { get; set; }
    }
}
