using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05 {
    internal class Reverse : Action {

        private string s;
        private string result;
        private bool done = false;
        public Reverse(string input) {
            result = string.Empty;
            s = input;
        }

        public override string CreateMessage() {
            if (done) {
                return $"Reverse, {s}, {result}";
            }
            else {
                return $"Reverse, {s}, Error";
            }
        }

        public override void Do() {
            if (s != null) {
                result = ReverseString(s);
                done = true;    
                //Console.WriteLine(result);
                
            }
        }


        public string ReverseString(string input) {

            char[] chars = input.ToCharArray();
            char temp = chars[0];

            for (int i = 0; i < chars.Length / 2; i++) {

                temp = chars[i];
                chars[i] = chars[chars.Length - 1 - i];
                chars[chars.Length - 1 - i] = temp;

            }

            string name = new string(chars);
            return name;
        }
    }
}
