using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23.Utils
{
    public class Task29
    {
        public static double Calculate(Dictionary<string, double> vars)
        {
            double h = vars["h"];
            double e = vars["e"];
            double y = vars["y"];
            return (0.355 * Math.Pow(h, 2) - 4.355) / (Math.Pow(e, y + h) + Math.Sqrt(2.7 * y));
        }
    }
}
