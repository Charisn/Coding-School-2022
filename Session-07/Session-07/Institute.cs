using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07
{


    internal class Institute
    {

        // properties
        public Guid ID { get; set; }
        public string Name { get; set; }
        public int YearsInService { get; set; }

        // constructor
        public Institute() { 
            ID = Guid.NewGuid();

        }


        // method
        public void SetName(string name)
        {
            Name = name;
        }
        
    }
    
}
