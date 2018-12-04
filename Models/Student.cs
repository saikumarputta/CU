using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CU.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime EnrollmentDate { get; set; }


        public ICollection<Enrollment> enrollments { get; set; }
    }
}
