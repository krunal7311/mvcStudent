using System;
using Microsoft.EntityFrameworkCore;
using mvcStudent.Models;
using System.Data;


namespace mvcStudent.Models
{
    public class StudentContext: DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options)
            : base(options)
        {
        }

        public DbSet<mvcStudent.Models.Student> Movie { get; set; }
        public DbSet<mvcStudent.Models.Course> Course { get; set; }
        public DbSet<mvcStudent.Models.Enrollment> Enrollment { get; set; }

    }
}
