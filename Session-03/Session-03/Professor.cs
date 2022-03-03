using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    internal class Professors : Person
    {
        private string Rank { get; set; }

        public Course[] Courses { get; set; }

        public void Teach(Course courses, DateTime date)
        { }
        internal void SetGrade(Schedule StudentID ,Grade courseID, Grade grades) { }

        public string GetName(string Name)
        {
            return "Dr." + Name;
        }



            // constructor
            internal Professors() { }

        
    }



}
