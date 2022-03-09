using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator {
    internal class Sub : Calculations {
        public override string Do(string s) {
            string[] nums = s.Split("-");
            decimal a;
            decimal b;
            decimal result;

            if (nums.Length == 3) {
                Decimal.TryParse(nums[1], out a);
                Decimal.TryParse(nums[2], out b);
                result = -a - b;
            }
            else {
                Decimal.TryParse(nums[0], out a);
                Decimal.TryParse(nums[1], out b);
                result = a - b;
            }
            

            return result.ToString();
        }
    }
}
