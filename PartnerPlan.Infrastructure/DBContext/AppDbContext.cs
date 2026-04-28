using Microsoft.EntityFrameworkCore;
using PartnerPlan.Domain.Entities;

namespace PartnerPlan.Infrastructure.DBContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Partner> Partners { get; set; }
        public DbSet<Plan> Plans { get; set; }
        public DbSet<PlanTask> PlanTasks { get; set; }
        public DbSet<UserProgressTask> UserProgressTasks { get; set; }
    }
}
