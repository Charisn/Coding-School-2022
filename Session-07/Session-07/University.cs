using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07
{
    internal class University : Institute
    {
        //properties
        public Student[] Students { get; set; }

        public Courses[] Courses { get; set; }

        public Grade[] Grades { get; set; }

        public Schedule[] ScheduledCourses { get; set; }  

        public Student[] GetStudents() 
        { return Students;}

        public Courses[] GetCourses() 
        { return Courses; }

        public Grade[] GetGrades() 
        { return Grades; }

        // constructor
        public University()
        {
            Courses = new Courses[20];
            Students = new Student[30];
            ScheduledCourses = new Schedule[60];
        }
        // method
        public void GetSchedule(
            Guid ProfessorID,
            DateTime dateTime,
            Guid CourseID
        ) {}

    }
}
