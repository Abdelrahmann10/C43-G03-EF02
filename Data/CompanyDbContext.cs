using EF2.Data.Configurations;
using EF2.Data.Models;
using EF2_FluentAPIs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EF2.Data
{
    internal class CompanyDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer("Server = DESKTOP-K2FJ8AV ; Database = Coppany03 ; Trusted_Connection = true ; trustservercertificate = true");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //    modelBuilder.ApplyConfiguration<Employee>(new EmployeeConfigurations());
            //    modelBuilder.ApplyConfiguration<Department>(new DepartmentConfiguration());
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly()); // No need to use the last 2 lines when use this line
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

    }
}
