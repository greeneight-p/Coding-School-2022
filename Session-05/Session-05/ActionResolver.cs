using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05 {
    internal class ActionResolver {


        public MessageLogger Logger { get; set; }

        public ActionResolver() {

            Logger = new MessageLogger();

        }



        public ActionResponse Execute( ActionRequest req) {

            
            switch (req.ActionType) {
                case ActionEnum.Convert:
                    var x = new Convert(req.Input);
                    x.Do();
                    Console.WriteLine(x.CreateMessage());

                 
                    break;
                case ActionEnum.Uppercase:
                    break;
                case ActionEnum.Reverse:
                    break;
                default:
                    break;
            }







            var response = new ActionResponse(req.RequestID);
            return response;
        }





    }
}
