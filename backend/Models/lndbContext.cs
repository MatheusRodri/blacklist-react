using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace backend.Models
{
    public partial class lndbContext : DbContext
    {
        public lndbContext()
        {
        }

        public lndbContext(DbContextOptions<lndbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TbBlacklist> TbBlacklist { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("server=localhost;user id=root;password=matheus250302;database=lndb", Microsoft.EntityFrameworkCore.ServerVersion.FromString("8.0.22-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TbBlacklist>(entity =>
            {
                entity.HasKey(e => e.IdList)
                    .HasName("PRIMARY");

                entity.Property(e => e.DsMotivo)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.NmPessoa)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
