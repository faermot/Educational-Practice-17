using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23.Utils
{
    public class Task16
    {
        public static double Calculate(Dictionary<string, double> vars)
        {
            double e = vars["e"];
            double y = vars["y"];
            double r = vars["r"];
            double t = vars["t"];
            return (4 * Math.Pow(t, 3) + Math.Log(r)) / Math.Pow(e, (y + r)) + 7.2 * Math.Sin(r);
        }
    }
}
