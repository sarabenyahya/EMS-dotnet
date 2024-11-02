using EMS.Api.Entities;
using Microsoft.EntityFrameworkCore;
using Bogus;

namespace EMS.Api.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
   public DbSet<Employee> Employees => Set<Employee>();
   public DbSet<Department> Department => Set<Department>();
   private Faker Faker { get; } = new Faker();

   protected override void OnModelCreating(ModelBuilder modelBuilder)
   {
      modelBuilder.Entity<Department>().HasData(
         new Department { Id = 1, Name = "IT" },
         new Department { Id = 2, Name = "Resources Humaines" },
         new Department { Id = 3, Name = "Ventes" },
         new Department { Id = 4, Name = "Marketing" },
         new Department { Id = 5, Name = "Finance" },
         new Department { Id = 6, Name = "Administration" }
      );

      
   }
}
