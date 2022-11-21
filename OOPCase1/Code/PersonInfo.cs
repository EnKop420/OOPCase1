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
        public int Age { get; set; }

        public static int GetAge(DateOnly DateOfBirth)
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
            Age = GetAge(DateOfBirth);
        }
    }
}
