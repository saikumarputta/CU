using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace CU.Models
{
    public class Course
    {
       [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseId { get; set; }
        public string Tittle { get; set; }
        public int Credits { get; set; }



        public ICollection<Enrollment> enrollments { get; set; }
    }
}
