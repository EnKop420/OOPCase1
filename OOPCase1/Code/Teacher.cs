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

        public static Teacher niels = new("Lærer", "Niels", "Olesen", new DateOnly(1971, 1, 23));
        public static Teacher peter = new("Lærer", "Peter", "Lindenskov", new DateOnly(1960, 2, 28));
        public static Teacher henrik = new("Lærer", "Henrik", "Poulsen", new DateOnly(1970, 3, 12));
        public static Teacher jan = new("Lærer", "Jan", "Johansen", new DateOnly(1950, 4, 21));

        public static Course clientsideProgrammering = new(EnumFag.Clientsideprogrammering, peter);
        public static Course grundlæggende = new(EnumFag.Grundlæggendeprogrammering, niels);
        public static Course studieteknik = new(EnumFag.Studieteknik, niels);
        public static Course oop = new(EnumFag.OOP, niels);
        public static Course databaseProgrammering = new(EnumFag.Datebaseprogrammering, niels);
        public static Course computerTeknologi = new(EnumFag.Computerteknologi, jan);
        public static Course netværk = new(EnumFag.Netværk, henrik);
        public string? getDepartment(Enrollment department)
        {
            return department.CourseInfo.TeacherInfo.Department;
        }
        internal override List<string?> getAllCourses(List<Enrollment> teacherCourses)
        {
            List<string?> result = new List<string?>();
            foreach (var item in teacherCourses)
            {
                if (item.CourseInfo.TeacherInfo.FirstName == FirstName && item.CourseInfo.TeacherInfo.LastName == LastName)
                {
                    if (!result.Contains(item.CourseInfo.CourseName.ToString()))
                    {
                        result.Add(item.CourseInfo.CourseName.ToString());
                    }
                }
            }
            return result;
        }
        internal override List<string?> getAllCourses(Enrollment teacherCourses)
        {
            List<string?> result = new List<string?>();
            foreach (var item in teacherCourses.enrollment)
            {
                if (item.CourseInfo.TeacherInfo.FirstName == FirstName && item.CourseInfo.TeacherInfo.LastName == LastName)
                {
                    if (!result.Contains(item.CourseInfo.CourseName.ToString()))
                    {
                        result.Add(item.CourseInfo.CourseName.ToString());
                    }
                }
            }
            return result;
        }
        internal override string? HelloThere()
        {
            return "Hello There";
        }
    }
}
