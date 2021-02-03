using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Neoldu.Data.Domain.Entities;

namespace NeOldu.Data.Dal.Mapping
{
    class ApplicationBlock_ApplicationUserMap : IEntityTypeConfiguration<ApplicationBlock_ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationBlock_ApplicationUser> builder)
        {
            builder.HasKey(p => new { p.ApplicaitonBlockId, p.ApplicationUserId });

            builder.HasOne(m => m.ApplicationUser)
               .WithMany(p => p.ApplicationBlock_ApplicationUsers).HasForeignKey(t => t.ApplicationUserId);
            
            builder.HasOne(m => m.ApplicaitonBlock)
               .WithMany(p => p.ApplicationBlock_ApplicationUsers).HasForeignKey(t => t.ApplicaitonBlockId);
        }
    }
}
