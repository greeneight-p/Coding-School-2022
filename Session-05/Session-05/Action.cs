using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05 {
    internal abstract class Action {


        public Action() {

        }

        public abstract void Do();
        public abstract string CreateMessage();

    }
}
