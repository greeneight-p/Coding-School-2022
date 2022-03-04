using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04 {
    internal class Class2 {

        public Class2() {

        }


        private string GetSum(int n) {

            int sum = 0;    
            for (int i = 0; i <= n; i++) {
                sum += i;
            }

            return "The answer is :" + sum;
        }


        private string GetProduct(int n) {

            int product = 1;
            for (int i = 1; i <= n; i++) {

                product *= i;

            }

            return "The answer is :" + product;
        }



        public string ExecuteChoice(int choice, int n) {

            if (choice == 1) {
                Console.WriteLine("Your order is to find the Sum of " + n);
                return GetSum(n);
            }
            else {
                Console.WriteLine("Your order is to find the Product of " +n );
                return GetProduct(n);
            }


        }
    }
}
