using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCase1.Code
{
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public static int Age { get; set; }

        internal abstract List<string?> getAllCourses(Enrollment enrollments);
        internal abstract List<string?> getAllCourses(List<Enrollment> enrollments);
        public static int ConvertToAge(DateOnly DateOfBirth)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - DateOfBirth.Year;
            return age;
        }
        public Person(string? firstName, string? lastName, DateOnly dateofbirth)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateofbirth;
            Age = ConvertToAge(DateOfBirth);
        }
        public static int GetAge()
        {
            return Age;
        }

        internal virtual string? HelloThere()
        {
            return "General Kenobi";
        }
    }
}
