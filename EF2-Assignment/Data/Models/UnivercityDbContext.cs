using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF2_Assignment.Data.Models
{
    internal class UnivercityDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer("Server = DESKTOP-K2FJ8AV ; Database = Univercity ; Trusted_Connection = true ; trustservercertificate = true");
        public DbSet<Course> Courses { get; set; }
        public DbSet<Course_Inst> Course_Insts { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> instructors { get; set; }
        public DbSet<Stu_Course> stu_Courses { get; set; }
        public DbSet<Student> students { get; set; }
        public DbSet<Topic> Topics { get; set; }
    }
}
