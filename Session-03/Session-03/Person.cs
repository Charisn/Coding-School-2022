using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{

    public class Person

    {    // properties
        internal Guid ID { get; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string GetName(){return Name;}

        // constructor
        public Person(){}

        // method - function
        public void SetName(string Name)
        {
        }
    }
}