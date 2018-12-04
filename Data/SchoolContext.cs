using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CU.Models
{
    public class SchoolContext : DbContext
    {
        public SchoolContext (DbContextOptions<SchoolContext> options)
            : base(options)
        {
        }

        public DbSet<CU.Models.Student> Student { get; set; }
        public DbSet<CU.Models.Enrollment> enrollments { get; set; }
        public DbSet<CU.Models.Course> courses { get; set; }
    }
}
