using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCase1.Code
{
    internal sealed class Student : Person
    {
        public int StudentId { get; set; }

        public Student(int studentid, string firstname, string lastname, DateOnly dateofbirth) : base(firstname, lastname, dateofbirth)
        {
            StudentId = studentid;
        }


        internal override List<string?> getAllCourses(List<Enrollment> studentCourse)
        {
            List<string?> result = new List<string?>();
            bool printStudent = true;
            foreach (var item in studentCourse)
            {
                if (printStudent)
                {
                    result.Add(item.StudentInfo.FirstName + item.StudentInfo.LastName);
                    printStudent = false;
                }
                if (item.StudentInfo.FirstName == FirstName && item.StudentInfo.LastName == LastName)
                {
                    if (!result.Contains(item.CourseInfo.CourseName.ToString()))
                    {
                        result.Add(item.CourseInfo.CourseName.ToString());
                    }
                }
            }

            return result;
        }
        internal override List<string?> getAllCourses(Enrollment studentCourse)
        {
            List<string?> result = new List<string?>();
            bool printStudent = true;
            foreach (var item in studentCourse.enrollment)
            {
                if (printStudent)
                {
                    result.Add($"{FirstName} {LastName} :\n");
                    printStudent = false;
                }
                if (item.StudentInfo.FirstName == FirstName && item.StudentInfo.LastName == LastName)
                {
                    if (!result.Contains(item.CourseInfo.CourseName.ToString()))
                    {
                        result.Add(item.CourseInfo.CourseName.ToString());
                    }
                }
            }
            return result;
        }


    }
}
