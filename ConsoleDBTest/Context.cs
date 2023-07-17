using ConsoleDBTest.Models;
using Microsoft.EntityFrameworkCore;

namespace ConsoleDBTest;

public class SupContext : DbContext
{
    public DbSet<Superhero> Superheros { get; set; }

    public SupContext() : base()
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite($"Data Source=./Superhero.db;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Superhero>().ToTable("Superheros");
    }
}
