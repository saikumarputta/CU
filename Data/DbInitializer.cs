using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CU.Models;

namespace CU.Data
{
    public class DbInitializer
    {
        public static void Initialize(SchoolContext context)
        {
            context.Database.EnsureCreated();
            if (context.Student.Any())
            {
                return;   //Db has been seeded
            }
            var student = new Student[]
            {
            new Student{FirstName="Carson",LastName="Alexander",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Student{FirstName="Meredith",LastName="Alonso",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{FirstName="Arturo",LastName="Anand",EnrollmentDate=DateTime.Parse("2003-09-01")},
            new Student{FirstName="Gytis",LastName="Barzdukas",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{FirstName="Yan",LastName="Li",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{FirstName="Peggy",LastName="Justice",EnrollmentDate=DateTime.Parse("2001-09-01")},
            new Student{FirstName="Laura",LastName="Norman",EnrollmentDate=DateTime.Parse("2003-09-01")},
            new Student{FirstName="Nino",LastName="Olivetto",EnrollmentDate=DateTime.Parse("2005-09-01")}
            };
            foreach (Student s in student)
            {
                context.Student.Add(s);
            }
            context.SaveChanges();

            var course = new Course[]
            {
                new Course{CourseId=1050,Tittle="Chemistry",Credits=3},
            new Course{CourseId=4022,Tittle="Microeconomics",Credits=3},
            new Course{CourseId=4041,Tittle="Macroeconomics",Credits=3},
            new Course{CourseId=1045,Tittle="Calculus",Credits=4},
            new Course{CourseId=3141,Tittle="Trigonometry",Credits=4},
            new Course{CourseId=2021,Tittle="Composition",Credits=3},
            new Course{CourseId=2042,Tittle="Literature",Credits=4}
            };

            foreach (Course c in course)
            {
                context.courses.Add(c);
            }
            context.SaveChanges();

            var enrollments = new Enrollment[]
            {
                new Enrollment{StudentId=1,CourseId=1050,grade=grade.a},
            new Enrollment{StudentId=1,CourseId=4022,grade=grade.b},
            new Enrollment{StudentId=1,CourseId=4041,grade=grade.cd},
            new Enrollment{StudentId=2,CourseId=1045,grade=grade.b},
            new Enrollment{StudentId=2,CourseId=3141,grade=grade.a},
            new Enrollment{StudentId=2,CourseId=2021,grade=grade.b},
            new Enrollment{StudentId=3,CourseId=1050},
            new Enrollment{StudentId=4,CourseId=1050},
            new Enrollment{StudentId=4,CourseId=4022,grade=grade.cd},
            new Enrollment{StudentId=5,CourseId=4041,grade=grade.a},
            new Enrollment{StudentId=6,CourseId=1045},
            new Enrollment{StudentId=7,CourseId=3141,grade=grade.a},
            };
            foreach (Enrollment e in enrollments)
            {
                context.enrollments.Add(e);
            }
            context.SaveChanges();



        }

    }
}
