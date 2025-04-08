using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23.Utils
{
    public class Task5
    {
        public static double Calculate(Dictionary<string, double> vars)
        {
            double a = vars["a"];
            double y = vars["y"];
            double e = vars["e"];
            double t = vars["t"];
            return (7.8 * Math.Pow(a, 2) + 3.52 * t) / (Math.Log(a + (2 * y)) + Math.Pow(e, y));
        }
    }
}
