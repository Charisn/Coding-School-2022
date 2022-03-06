using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    internal class Grade
    {
        // properties
       public Guid ID { get; set; }
       public Guid StudentID { get; set; }
       public Guid CourseID { get; set; }
                
        public int grade { get; set; }

        // constructor
        public Grade(Guid studentID) { StudentID = studentID; }
    }
}
