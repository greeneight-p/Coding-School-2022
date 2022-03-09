using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator {
    internal class Power : Calculations {
        public override string Do(string s) {
            string[] nums = s.Split('p');
            Decimal.TryParse(nums[0], out decimal a);
            Decimal.TryParse(nums[1], out decimal b);
            double result = Math.Pow((double)a, (double)b);

            return Math.Round(result, 2).ToString();
        }
    }
}
