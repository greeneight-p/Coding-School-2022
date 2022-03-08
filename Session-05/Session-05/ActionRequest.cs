using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05 {


    enum ActionEnum {
        Convert,
        Uppercase,
        Reverse

    }

    internal class ActionRequest {

        public Guid RequestID { get; set; }
        public string Input { get; set; }
        public ActionEnum ActionType { get; set; }  


        public ActionRequest() {

            Input = string.Empty;
            RequestID = Guid.NewGuid();

        }
    }
}
