using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CU.Models
{
    public enum grade { a,b,cd,e,f}
    public class Enrollment
    {
        public int EnrollmentId { get; set; }
        public int CourseId { get; set; }
        public int StudentId { get; set; }
        public grade? grade { get; set; }



        public Course Course { get; set; }
        public Student Student { get; set; }
    }
}
