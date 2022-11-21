using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCase1.Code
{
    internal class Course
    {
        public string CourseName { get; set; }

        public Teacher TeacherInfo { get; set; }


        public Course(string coursename, Teacher teacherinfo)
        {
            CourseName = coursename;
            TeacherInfo = teacherinfo;
        }
    }
}
