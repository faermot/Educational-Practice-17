using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23.Utils
{
    public class Task11
    {
        public static double Calculate(Dictionary<string, double> vars)
        {
            double n = vars["n"];
            double y = vars["y"];
            return Math.Pow(y, 2) + (0.5 * n + 4.8) / (Math.Sin(y));
        }
    }
}
