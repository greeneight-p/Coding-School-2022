using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator {
    internal class Root : Calculations {
        public override string Do(string s) {
            string[] nums = s.Split('*');
            Decimal.TryParse(nums[0], out decimal a);
            double result = Math.Sqrt((double)a);

            return Math.Round(result, 2).ToString();
        }
    }
}
