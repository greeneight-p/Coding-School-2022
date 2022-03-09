using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator {


    internal class Add : Calculations {

        public Add() {

        }


        public override string Do(string s) {
            string[] nums = s.Split('+');
            Decimal.TryParse(nums[0], out decimal a);
            Decimal.TryParse(nums[1], out decimal b);
            decimal result = a + b;

            return result.ToString();
        }
    }
}
