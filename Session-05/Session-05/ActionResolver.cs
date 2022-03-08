using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05 {
    internal class ActionResolver {

        private int count;
        public MessageLogger Logger { get; set; }

        public ActionResolver(MessageLogger logger1) {
            count = 0;

            Logger = logger1 ?? throw new ArgumentNullException(nameof(logger1));

        }



        public ActionResponse Execute( ActionRequest req) {


            var response = new ActionResponse(req.RequestID);



            switch (req.ActionType) {
                case ActionEnum.Convert:
                    var actionWorker1 = new Convert(req.Input);
                    actionWorker1.Do();
                    string result1 = actionWorker1.CreateMessage();
                    var m = new Message(result1);
                    Logger.Write(m);
                    response.Output = result1;

                    break;
                case ActionEnum.Uppercase:
                    
                    var actionWorker3 = new Uppercase(req.Input);
                    actionWorker3.Do();
                    string result3 = actionWorker3.CreateMessage();
                    var m3 = new Message(result3);
                    Logger.Write(m3);
                    response.Output = result3;

                    break;
                case ActionEnum.Reverse:
                    var actionWorker2 = new Reverse(req.Input);
                    actionWorker2.Do();
                    string result2 = actionWorker2.CreateMessage();
                    var m2 = new Message(result2);
                    Logger.Write(m2);
                    response.Output = result2;

                    break;
                default:
                    break;
            }


            //to parakatw kommati de nomizw na t zitouse i aksisi, to ekana egw gia na dokimasw kai na dw kapoia pragmata 
            count++;
            Console.WriteLine("New RequestID =>"+count);
            Console.WriteLine(req.RequestID);
            Console.WriteLine("New ResponseID paired to previous Req ID");
            Console.WriteLine(response.ResponseID);
            Console.WriteLine(response.RequestID+"\n");

            return response;
        }





    }
}
