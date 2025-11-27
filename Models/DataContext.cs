using Microsoft.EntityFrameworkCore;

namespace RazorPageExample.Models;

public class DataContext: DbContext
{
    public DbSet<Employee> Employees { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=DESKTOP-8GFIJ5R; Database=RazorDb; Trusted_Connection=True;TrustServerCertificate=True;");
    }
}