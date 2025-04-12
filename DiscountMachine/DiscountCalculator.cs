using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountMachine
{
    public class DiscountCalculator
    {
        public static int CalculateDiscount(int points)
        {
            if (points < 0)
                throw new ArgumentException("Баллы не могут быть в минусе");

            if (points < 100)
                return 1;
            else if (points < 200)
                return 3;
            else if (points < 500)
                return 5;
            else
                return 10;
        }
    }
}
