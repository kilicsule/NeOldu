using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Neoldu.Data.Domain.Entities;

namespace NeOldu.Data.Dal.Mapping
{
    class ApplicaitonReaction_ApplicationUserMap : IEntityTypeConfiguration<ApplicaitonReaction_ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicaitonReaction_ApplicationUser> builder)
        {
            builder.HasKey(p => new { p.ApplicaitonReactionId, p.ApplicationUserId });

            builder.HasOne(m => m.ApplicationUser)
               .WithMany(p => p.ApplicaitonReaction_ApplicationUsers).HasForeignKey(t => t.ApplicationUserId);
            
            builder.HasOne(m => m.ApplicaitonReaction)
               .WithMany(p => p.ApplicaitonReaction_ApplicationUsers).HasForeignKey(t => t.ApplicaitonReactionId);
        }
    }
}
