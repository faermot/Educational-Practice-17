using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23.Utils
{
    public class Task7
    {
        public static double Calculate(Dictionary<string, double> vars)
        {
            double m = vars["m"];
            double y = vars["y"];
            return (Math.Pow(m, 2) + 2.8 * m + 0.355) / (Math.Cos(2) * y + 3.6);
        }
    }
}
