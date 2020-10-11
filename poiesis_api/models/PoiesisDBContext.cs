using System;
using Microsoft.EntityFrameworkCore;

namespace poiesis_api.Models
{

public class MyContext : DbContext
{
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Texto> Textos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
            .UseSqlite(@"Data Source=PoiesisDB.db;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Usuario>().ToTable("Usuarios");
        modelBuilder.Entity<Texto>().ToTable("Textos");
    }
}
}