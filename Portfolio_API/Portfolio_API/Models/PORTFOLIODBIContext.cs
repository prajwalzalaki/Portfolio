using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Portfolio_API.Models
{
    public partial class PORTFOLIODBIContext : DbContext
    {
        public PORTFOLIODBIContext()
        {
        }

        public PORTFOLIODBIContext(DbContextOptions<PORTFOLIODBIContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Portfolio> Portfolio { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost;database=PORTFOLIODBI;integrated security=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Portfolio>(entity =>
            {
                entity.ToTable("Portfolio_Table");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ContactNo).HasColumnName("Contact_No");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Gender)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProfilePicture)
                    .HasColumnName("Profile_Picture")
                    .HasMaxLength(500);

                entity.Property(e => e.TotalInvestment).HasColumnName("Total_Investment");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
