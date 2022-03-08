using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05 {
    internal class MessageLogger {

        public Message[] Messages { get; set; }
        private int i;
        public MessageLogger() {
           i = 0;
           Messages = new Message[20];
        }



        public void ReadAll() {
            for (int j = 0; j < i; j++) {
                Console.WriteLine(Messages[j].ActualMessage);
            }
        }

        public void Clear() {

        }


        public void Write(Message message) {
            if (i < 19) {
                Messages[i] = message;
                i++;
            }
            else {
                Console.WriteLine("Message logger array is full !");
            }
        }
    }
}
