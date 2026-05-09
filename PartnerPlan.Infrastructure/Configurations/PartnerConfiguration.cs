using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PartnerPlan.Domain.Entities;

namespace PartnerPlan.Infrastructure.Configurations
{
    public class PartnerConfiguration : IEntityTypeConfiguration<Partner>
    {
        public void Configure(EntityTypeBuilder<Partner> builder)
        {
            builder.HasOne(e => e.User)
                .WithMany(e => e.Partners)
                .HasForeignKey(e => e.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(e => e.PartnerUser)
                .WithMany()
                .HasForeignKey(e => e.PartnerUserId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
