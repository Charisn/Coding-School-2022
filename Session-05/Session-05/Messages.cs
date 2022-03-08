using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    public class Messages
    {
        public Guid ID { get; set; }

        public DateTime DateTime { get; set; }
        
        public string Message { get; set; }

        public Messages(string message, DateTime dateTime, Guid id)
        {
            ID = id;
            DateTime = dateTime;
            Message = message;
        }
    }
}
