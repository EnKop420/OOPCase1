using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCase1.Code
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public int Age { get; set; }

        public static int GetAge(DateOnly DateOfBirth)
        {
            DateTime today = DateTime.Today;
            var age = today.Year - DateOfBirth.Year;
            return age;
        }

        public Student(int studentid, string firstname, string lastname, DateOnly dateofbirth)
        {
            StudentId = studentid;
            FirstName = firstname;
            LastName = lastname;
            DateOfBirth = dateofbirth;
            Age = GetAge(dateofbirth);
        }

    }
}
