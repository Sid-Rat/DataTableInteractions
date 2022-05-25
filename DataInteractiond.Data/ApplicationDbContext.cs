using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using DataInteractiond.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataInteractiond.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) {}
        
            public DbSet<Student> Students { get; set; }
            public DbSet<Cohorts> Cohorts { get; set; }
            public DbSet<Instructor> Instructors { get; set; }
            public DbSet<Enrollment> Enrollments { get; set; }
            public DbSet<InstructorAssignment> Assignments { get; set; }
        }
    }
}