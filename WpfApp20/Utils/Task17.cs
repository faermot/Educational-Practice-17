using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23.Utils
{
    public class Task17
    {
        public static double Calculate(Dictionary<string, double> vars)
        {
            double n = vars["n"];
            double y = vars["y"];
            return (Math.Pow(y, 2) - 0.8 * y + Math.Sqrt(y)) / (23.1 * Math.Pow(n, 2) + Math.Cos(n));
        }
    }
}
