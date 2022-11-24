using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCase1.Code
{
    internal class Course
    {
        public EnumFag CourseName { get; set; }

        public Teacher TeacherInfo { get; set; }


        public Course(EnumFag coursename, Teacher teacherinfo)
        {
            CourseName = coursename;
            TeacherInfo = teacherinfo;
        }

        public void GetAllStudents(List<Enrollment> enrollmentList)
        {
            List<string?> students = new List<string?>();
            foreach (var item in enrollmentList)
            {
                if (item.CourseInfo.CourseName == CourseName)
                {
                    string? CheckContain = item.StudentInfo.FirstName + " " + item.StudentInfo.LastName;
                    if (!students.Contains(CheckContain))
                    {
                        students.Add(item.StudentInfo.FirstName + " " + item.StudentInfo.LastName);
                    }
                }
            }
            CheckIfErrorThrow(students);

        }

        public void CheckIfErrorThrow(List<string?> studentList)
        {
            if (studentList.Count < 8)
            {
                throw new Exception("Der er for lidt elev til at opret dette fag");
            }
            else if(studentList.Count > 16)
            {
                throw new Exception("Der er for mange elever oprettet til dette fag.");
            }
        }
    }
}
