using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Neoldu.Data.Domain.Entities;

namespace NeOldu.Data.Dal.Mapping
{
    public class ApplicationUserMap : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.HasOne(m => m.ApplicationType)
               .WithMany(p => p.ApplicationUser).HasForeignKey(t => t.ApplicationTypeId);

            builder.HasMany(m => m.ApplicationUserComments)
               .WithOne(p => p.ApplicationUser).HasForeignKey(t => t.ApplicationUserId);
        }
    }
}
