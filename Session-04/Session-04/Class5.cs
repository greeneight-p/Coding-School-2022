using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04 {
    internal class Class5 {

        public Class5() {

        }



        public string SortArray(int[] ar1) {

            int temp = 0;

            for (int i = 0; i < ar1.Length; i++) {
                for (int j = 0; j < ar1.Length; j++) {

                    if (ar1[i] < ar1[j]) {
                        temp = ar1[i];
                        ar1[i] = ar1[j];
                        ar1[j] = temp;

                    }
                }
            }



            return CreateStringFromArray(ar1);
        }


        public string CreateStringFromArray(int[] result) {

            string resultString = "(";
            for (int m = 0; m < result.Length; m++) {

                resultString += $"{result[m]},";

            }
           resultString += ")";

            return resultString;
        }

    }
}
