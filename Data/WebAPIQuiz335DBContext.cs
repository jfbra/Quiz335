using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Quiz335.Data;

namespace Quiz335.Data
{
    public class WebAPIQuiz335DBContext : DbContext
    {
        public WebAPIQuiz335DBContext(DbContextOptions<WebAPIQuiz335DBContext> options) : base(options) { }
        public DbSet<>
        public DbSet<>

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Sourve = <db name>.sqlite");
        }
    }
}
