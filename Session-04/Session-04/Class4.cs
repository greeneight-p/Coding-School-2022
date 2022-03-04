using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04 {
    internal class Class4 {

        public Class4() {

        }


        public string MultiplyArrays(int[] ar1, int[] ar2) {
            
            int[] result = new int[ar1.Length * ar2.Length];

            int k = 0;
            for (int i = 0; i < ar1.Length; i++) {
                for (int j = 0; j < ar2.Length; j++) {

                    result[k] = ar1[i] * ar2[j];
                    k++;

                }

            }

            string resultString = "|";

            for (int m= 0; m < result.Length; m++) {

                resultString += $"{result[m]}|"; 

            }


            return resultString;
        }


   






    }
}
