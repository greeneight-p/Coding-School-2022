using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05 {
    internal class ActionResolver {


        public MessageLogger Logger { get; set; }

        public ActionResolver(MessageLogger logger1) {

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
                    break;
                case ActionEnum.Reverse:
                    var actionWorker2 = new Reverse(req.Input);
                    actionWorker2.Do();
                    string result2 = actionWorker2.CreateMessage();
                    var m2 = new Message(result2);
                    Logger.Write(m2);

                    break;
                default:
                    break;
            } 
           
            return response;
        }





    }
}
