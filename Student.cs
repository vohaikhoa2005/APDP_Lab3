using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Student
    {
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public DateTime EnrollmentDate { get; set; } = DateTime.Now;
        public static int TotalStudent { get; set; } = 0;

        public Student()
        {
            StudentID = 0;
            FirstName = "Michel";
            LastName = "Ject";
            DateOfBirth = null;
            EnrollmentDate = DateTime.Now;
            TotalStudent++;
        }
        public Student(string firstName, string lastName, DateTime? dateOfBirth = null)
        {
            StudentID = this.StudentID;
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            EnrollmentDate = DateTime.Now;
            TotalStudent++;
        }
    }
}
