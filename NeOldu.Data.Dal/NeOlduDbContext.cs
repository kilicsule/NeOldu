using Microsoft.EntityFrameworkCore;
using Neoldu.Data.Domain.Entities;
using System;

namespace NeOldu.Data.Dal
{
    public class NeOlduDbContext : DbContext
    {
        public NeOlduDbContext(DbContextOptions<NeOlduDbContext> options) : base(options)
        {

        }
        public DbSet<DeathDate> DeathDates { get; set; }
        public DbSet<People> Peoples{ get; set; }
        public DbSet<ApplicaitonBlock> ApplicaitonBlocks{ get; set; }
        public DbSet<ApplicaitonReaction> ApplicaitonReactions{ get; set; }
        public DbSet<ApplicationType> ApplicationTypes{ get; set; }
        public DbSet<ApplicationUser> ApplicationUsers{ get; set; }
        public DbSet<ApplicationUserComment> ApplicationUserComments{ get; set; }
        public DbSet<ApplicationBlock_ApplicationUser> ApplicationBlock_ApplicationUsers{ get; set; }
        public DbSet<ApplicaitonReaction_ApplicationUser> ApplicaitonReaction_ApplicationUsers{ get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<People>()
            .HasOne(b => b.ApplicaitonBlock)
            .WithOne(i => i.People)
            .HasForeignKey<ApplicaitonBlock>(b => b.PeopleId);

            modelBuilder.Entity<People>()
            .HasOne(b => b.ApplicaitonReaction)
            .WithOne(i => i.People)
            .HasForeignKey<ApplicaitonReaction>(b => b.PeopleId);
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
