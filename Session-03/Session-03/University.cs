﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    internal class University : Institute
    {
        public Course[] Courses { get; set; }

        public Grade[] Grades { get; set; }

        public Schedule[] ScheduledCourses { get; set; }

        public Student[] Students { get; set; }

        public Student[] GetStudents() { return Students;}

        public Course[] GetCourses() { return Courses; }

        public Grade[] GetGrades() { return Grades; }

        // constructor
        public University()
        {
            Courses = new Course[20];
            Students = new Student[30];
            ScheduledCourses = new Schedule[60];
            

        }
    }
}
