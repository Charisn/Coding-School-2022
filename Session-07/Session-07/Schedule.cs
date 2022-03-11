using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07
{
    internal class Schedule
    {   
        //properties
        public Guid ID { get; set; }
        public Guid StudentID { get; set; } 
        public Guid ProfessorID { get; set; }

        public DateTime Callendar { get; set; }

        // constructor
        internal Schedule() { }
    }
}
