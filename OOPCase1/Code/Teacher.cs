using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace OOPCase1.Code
{
    internal sealed class Teacher : Person
    {
        public string Department { get; set; }

        public Teacher(string department, string firstname, string lastname, DateOnly dateofbirth) : base(firstname, lastname, dateofbirth)
        {
            Department = department;
        }
        
        public string? getDepartment(Enrollment department)
        {
            return department.CourseInfo.TeacherInfo.Department;
        }
        internal override List<string?> getAllCourses(Enrollment teacherCourses)
        {
            List<string?> result = new List<string?>();
            foreach (var item in teacherCourses.enrollment)
            {
                result.Add(item.CourseInfo.CourseName);
            }
            return result;
        }
        internal override string? getDateOfBirth()
        {
            return "Hello There";
        }
    }
}
