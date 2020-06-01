using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst2.Context
{
    public class DatabaseDbContext : DbContext
    {
        public DatabaseDbContext(DbContextOptions options) : base(options)
        {

        }

        DbSet<Department> Departments {get;set;}
        DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().HasData(
                new Department() { Id=1, Name="R&D", Location="Midland, MI", Type="Science", Budget=100000000000000},
                new Department() { Id=2, Name="HR", Location="Dhaka, Bangladesh", Type="Administrative", Budget=200000000000000},
                new Department() { Id=3, Name="Fun Department", Location="Party City, USA", Type="Administrative", Budget=53}
                
                );

            modelBuilder.Entity<Employee>().HasData(
                 new Employee() { Id = 1, FirstName = "Peter", LastName = "Venkman", Email = "venkman@ghostbusters.co", DepartmentId = 1 },
                 new Employee() { Id = 2, FirstName = "Ray", LastName = "Stantz", Email = "ray@ghostbusters.co", DepartmentId = 2 },
                 new Employee() { Id = 3, FirstName = "Egon", LastName = "Spengler", Email = "egon@ghostbusters.co", DepartmentId = 3 },
                 new Employee() { Id = 4, FirstName = "Slimer", Email = "slimer@ghosts.co", DepartmentId = 2 },
                                 new Employee() { Id = 5, FirstName = "Dana", LastName = "Barrett", Email = "dana@nyphil.co", DepartmentId = 3 });
        }
    }
}
