using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04 {
    internal class Class1 {

        public Class1() {

        }

        public string ReverseString(string input) { 

            char[] chars = input.ToCharArray();
            char temp = chars[0];

            for (int i = 0; i < chars.Length/2; i++) {

                temp = chars[i];
                chars[i] = chars[chars.Length-1-i];
                chars[chars.Length - 1 - i] = temp;

            }

            string name = new string(chars);
            return name;
        }






    }
}
