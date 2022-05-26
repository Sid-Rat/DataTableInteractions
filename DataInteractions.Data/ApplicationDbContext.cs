using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataInteractions.Data;
using DataInteractions.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataInteractions.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {}
        
            public DbSet<Student> Students { get; set; }
            public DbSet<Cohort> Cohorts { get; set; }
            public DbSet<Instructor> Instructors { get; set; }
            public DbSet<Enrollment> Enrollments { get; set; }
            public DbSet<InstructorAssignment> Assignments { get; set; }
    }
}