using Microsoft.EntityFrameworkCore;
using ShrimpPond.Domain.Alarm;
using ShrimpPond.Domain.Farm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShrimpPond.Persistant.DatabaseContext
{
    public class ShrimpPondDbContext :DbContext
    {
        public ShrimpPondDbContext(DbContextOptions<ShrimpPondDbContext> options) : base(options) { }

        public DbSet<Alarm> Alarms { get; set; }
        public DbSet<Farm> Farms { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Relationship
            modelBuilder.Entity<Alarm>(entity =>
            {
                entity.HasOne(a => a.Farm)
                .WithMany()
                .HasForeignKey(a => a.FarmID)
                .OnDelete(DeleteBehavior.NoAction);
            });


            // Each Table
            modelBuilder.Entity<Alarm>(e =>
            {
                e.HasKey(e => e.Id);
                e.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Farm>(e =>
            {
                e.HasKey(e => e.Id);
                e.Property(e => e.Id).ValueGeneratedOnAdd();
            });

        }
    }
}
