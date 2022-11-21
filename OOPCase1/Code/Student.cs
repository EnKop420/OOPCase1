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
    }
}
