using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05 {
    internal class Uppercase : Action {

        private string s;
        private string result;
        private bool done = false;

        public Uppercase(string input) {
            result = string.Empty;
            s = input;
            Console.WriteLine(s);
        }
        public override string CreateMessage() {
            if (done) { 
            return $"Uppercase, {s}, {result}";
            }
            else {
                return $"Uppercase, {s}, Error";
            }
        }

        public override void Do() {
            if (s != null) {
                string[] words = s.Split(' ');
                if (words.Length > 1) {
                    string maxWord = string.Empty;
                    maxWord = MaxWord(words);
                    result = maxWord.ToUpper();
                    done = true;
                    //Console.WriteLine(result);
                }
                
                
            }
        }


        public string MaxWord(String[] words) {
            int length = -1;
            string maxWord = string.Empty;
            foreach (string item in words) {
                if (item.Length > length) {
                    maxWord = item;
                    length = item.Length;  
                }
            }

            return maxWord;

        }


    }
}
