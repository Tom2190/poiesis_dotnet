using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace poiesis_api.Models
{
    public partial class PoiesisDBContext : DbContext
    {
        public PoiesisDBContext()
        {
        }

        public PoiesisDBContext(DbContextOptions<PoiesisDBContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Texto> Texto { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost;Database=PoiesisDB;User=sa;Password=hola1234;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Texto>(entity =>
            {
                entity.HasKey(e => e.idTexto);

                entity.Property(e => e.idTexto)
                    .HasColumnName("IDTexto")
                    .ValueGeneratedNever();

   
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}