using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace automatedexam.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Example> Examples { get; set; }
        public DbSet<Exam> Exams { get; set; } 
        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite(" Data Source = AppDb.db");
    }
    public class Example
    {
        public int exampleId { get; set; }
        public string name { get; set; }
    }
}
