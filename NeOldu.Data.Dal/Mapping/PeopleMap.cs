using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Neoldu.Data.Domain.Entities;

namespace NeOldu.Data.Dal.Mapping
{
    public class PeopleMap : IEntityTypeConfiguration<People>
    {
        public void Configure(EntityTypeBuilder<People> builder)
        {
            builder.HasMany(m => m.ApplicationUserComments)
               .WithOne(p => p.People).HasForeignKey(t => t.PeopleId);

            builder.HasOne(m => m.DeathDate)
               .WithMany(p => p.Peoples).HasForeignKey(t => t.DeathDateId);
        }
    }
}
