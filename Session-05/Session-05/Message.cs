using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05 {
    internal class Message {

        public Guid MessageID { get; set; }
        public DateTime TimeStamp { get; set; }
        public string ActualMessage { get; set; }


        public Message(string m) {

            MessageID = Guid.NewGuid();
            TimeStamp = DateTime.Now;
            ActualMessage = m;

        }
    }
}
