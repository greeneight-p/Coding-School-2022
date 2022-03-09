using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator {

    public enum CalcType {
        Add,
        Sub,
        Multiply,
        Divide,
        Power,
        Root
    }

    public class Factory {

        public CalcType CalcType { get; set; }
        public string Input { get; set; }
        public Factory(string input, CalcType calcType) {

            Input = input; 
            CalcType = calcType;
        }


        public string CalcResolver() {

            Calculations worker;
            string result = "Error";

            switch (CalcType) {
                case CalcType.Add:
                    worker = new Add();
                    result = worker.Do(Input);
                    break;
                case CalcType.Sub:
                    worker = new Sub();
                    result = worker.Do(Input);
                    break;
                case CalcType.Multiply:
                    worker = new Multiply();
                    result = worker.Do(Input);
                    break;
                case CalcType.Divide:
                    worker = new Divide();
                    result = worker.Do(Input);
                    break;
                case CalcType.Power:
                    worker = new Power();
                    result = worker.Do(Input);
                    break;
                case CalcType.Root:
                    worker = new Root();
                    result = worker.Do(Input);
                    break;
            }

            return result ;
        }


    }
}
