using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    internal class Student: Person{

        //properties
        public int RegistrationNumber { get; set; }
        public Course[] Courses { get; set; }

        // constructor
        public Student() { }

        //methods
        public void Attend(Course courses, DateTime dateTime) { }
        public void WriteExam(Course courses, DateTime dateTime) { }


       


    }

}
