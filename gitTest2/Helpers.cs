using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gitTest2
{
    internal class Helpers
    {
        public static double CalculateFine(double overTime, double fineAmount)
        {
            return overTime * fineAmount;
        }
    }
}
