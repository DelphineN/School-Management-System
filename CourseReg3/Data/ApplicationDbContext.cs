using CourseReg3.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseReg3.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Courses> Courses { get; set; }
        public DbSet<Students> Students { get; set; }
        public DbSet<Instructors> Instructors { get; set; }
    }
}
