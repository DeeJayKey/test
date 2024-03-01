using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public DbSet<Osoba> Osoby { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=TestDB;");
    }
}