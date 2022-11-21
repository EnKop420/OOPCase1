using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCase1.Code
{
    internal class Enrollment
    {
        public Student StudentInfo { get; set; }
        public Course CourseInfo { get; set; }

        public Enrollment(Student studentinfo, Course courseinfo)
        {
            StudentInfo = studentinfo;
            CourseInfo = courseinfo;
        }
    }
}
