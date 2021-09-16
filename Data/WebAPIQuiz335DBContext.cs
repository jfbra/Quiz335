using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Quiz335.Data;
using Quiz335.Models;

namespace Quiz335.Data
{
    public class WebAPIQuiz335DBContext : DbContext
    {
        public WebAPIQuiz335DBContext(DbContextOptions<WebAPIQuiz335DBContext> options) : base(options) { }
        public DbSet<Student> Students { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<Marks> Marks { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrolement> Enrolements { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = Quiz335Database.sqlite");
        }
    }
}
