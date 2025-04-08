using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23.Utils
{
    public class Task30
    {
        public static double Calculate(Dictionary<string, double> vars)
        {
            double p = vars["p"];
            double e = vars["e"];
            double y = vars["y"];
            return (3 * Math.Pow(y, 2) + Math.Sqrt(y + 1)) / (Math.Log(p + y) + Math.Pow(e, p));
        }
    }
}
