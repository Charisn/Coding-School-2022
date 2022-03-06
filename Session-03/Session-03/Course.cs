using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    internal class Course
    {
        //properties
        public Guid ID { get; set; }

        public string Code { get; set; }
        public string Subject { get; set; }


        // constructor
        internal Course() {}
    }
}
