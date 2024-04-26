using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace EmployeeManagement.DataAccess.Context
{
    public class ApiDbContext : DbContext
    {
        
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options) { }

        public DbSet<Employee> employees { get; set; }

        public DbSet<User> users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Name = "Admin", Password = "Admin@123"}
                );
        }
    }
}
