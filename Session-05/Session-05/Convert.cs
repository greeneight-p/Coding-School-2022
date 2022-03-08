using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05 {
    internal class Convert : Action {

        private string input;
        private string result;
        private bool done;

        public Convert(string s) {
            done = false;
            input = s;
            result= String.Empty;
        }
        public override string CreateMessage() {
            if (done) {
                return $"Convert, {input}, {result}";
            }
            else {
                return $"Convert, {input}, Error";
            }

        }


        public override void Do() {

            int value=-1;

            if (Int32.TryParse(input, out value)) {
                result = FindBinary(value);
                done = true;

            }


        }


        private int FindBinaryRecursion(int num) {
            int bin;
            if (num != 0) {
                bin = (num % 2) + 10 * FindBinaryRecursion(num / 2);
                Console.Write(bin);
                return 0;
            }
            else {
                return 0;
            }

        }


        private string FindBinary(int num) {
            string result = string.Empty;
            int rem = 0;    
            while (num > 0) {
                rem = num % 2;
                num = num / 2;
                result = rem.ToString() + result;
            }
            return result;  

        }



    }
}
