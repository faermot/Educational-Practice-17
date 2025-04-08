using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23.Utils
{
    public class Task28
    {
        public static double Calculate(Dictionary<string, double> vars)
        {
            double v = vars["v"];
            double e = vars["e"];
            double y = vars["y"];
            return (0.004 * v + Math.Pow(e, 2 * y)) / (Math.Pow(e, y / 2));
        }
    }
}
