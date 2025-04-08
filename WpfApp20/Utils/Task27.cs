using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23.Utils
{
    public class Task27
    {
        public static double Calculate(Dictionary<string, double> vars)
        {
            double y = vars["y"];
            double p = vars["p"];
            return Math.Sin(Math.Pow((p + 0.4), 2)) / (Math.Pow(y, 2) + 7.325 * p);
        }
    }
}
