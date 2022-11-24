using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCase1.Code
{
    internal class Enrollment:IComparable<Enrollment>
    {
        public Student StudentInfo { get; set; }
        public Course CourseInfo { get; set; }
        public List<Enrollment> nrollments { get; set; }

        public Enrollment(Student studentinfo, Course courseinfo)
        {
            StudentInfo = studentinfo;
            CourseInfo = courseinfo;
        }
        public Enrollment()
        {

        }
        public int CompareTo(Enrollment other)
        {
            return string.Compare(other.StudentInfo.LastName,StudentInfo.LastName);
        }
        public void EnrollStudent(Enrollment enrollment)
        {
            nrollments.Add(enrollment);
            nrollments.Sort();
            nrollments.Reverse();
        }
    }
}
