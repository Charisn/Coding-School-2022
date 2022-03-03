using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    internal class Schedule
    {
        public Guid ID { get; set; }
        public Guid StudentID { get; set; } 
        public Guid ProfessorID { get; set; }

        public DateTime Callendar { get; set; }

        // constructor
        internal Schedule() { }
    }
}
