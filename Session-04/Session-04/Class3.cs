using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04 {
    internal class Class3 {

        public Class3() {

        }

        public string GetPrimeNumbers(int n) {

            string primeNumbers = string.Empty; 
            
            if (n == 1) {
                primeNumbers += $"{n}";
            }
            Console.WriteLine(primeNumbers);

            for (int i = 3; i <= n; i++) {

                if (i % 2 != 0) {
                    primeNumbers += $"{i} ";

                }
            }

            return "The prime numbers till " + n + " are: " + primeNumbers;
        }
    }
}
