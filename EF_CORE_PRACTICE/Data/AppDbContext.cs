using EF_CORE_PRACTICE.Models;
using Microsoft.EntityFrameworkCore;

namespace EF_CORE_PRACTICE.Data;

public class AppDbContext : DbContext
{
    public DbSet<Department> Departments => Set<Department>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(
                "Server=localhost,1433;" +
                "Database=EfcoreDb;" +
                "User Id=sa;Password=n3v1tnpYqFRD3b/iPU7HrhyPFBRwqs8s;" +
                "Encrypt=True;" +
                "TrustServerCertificate=True");
            optionsBuilder.LogTo(Console.WriteLine);
        }
        
    }
}