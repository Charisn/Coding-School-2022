using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{

    internal class ActionRequest
    {
        public Guid RequestID { get; set; }
        public string Input { get; set; }

        public ActionEnum Action { get; set; }

        internal ActionRequest(Guid requestID, string input, ActionEnum action)
        {
            RequestID = requestID;
            Input = input;
            Action = action;
        }
    }
    internal class ActionResponse
    {
        public Guid RequestID { get; set; }

        public Guid ResponseID { get; set; }

        public string Output { get; set; }
        public ActionResponse(Guid requestID, Guid responseID, string output)
        {
            RequestID = requestID;
            ResponseID = responseID;
            Output = output;
        }

    }

    internal class ActionResolver
    {

        public MessageLogger Logger { get; set; }

        public ActionResolver(MessageLogger logger)
        {
            Logger = logger;
        }
        private ActionEnum

    }
}

}
