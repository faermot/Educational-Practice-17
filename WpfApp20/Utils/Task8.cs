using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23.Utils
{
    public class Task8
    {
        public static double Calculate(Dictionary<string, double> vars)
        {
            double t = vars["t"];
            double y = vars["y"];
            return (2.37 * Math.Sin(t + 1)) / (Math.Sqrt(4 * Math.Pow(y, 2) - 0.1 * y + 5));
        }
    }
}
