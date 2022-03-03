using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{


    internal class Institute{

        public Guid ID { get; set; }
        public string Name { get; set; }
        public int YearsInService { get; set; }

        // constructor
        public Institute() { 
            ID = Guid.NewGuid();

        }

        public void SetName(string name)
        {
            Name = name;
        }
        
    }
}
