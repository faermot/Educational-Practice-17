using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23.Utils
{
    public class Task25
    {
        public static double Calculate(Dictionary<string, double> vars)
        {
            double c = vars["c"];
            double t = vars["t"];
            return Math.Cos(Math.Pow(c, 2)) + (3 * Math.Pow(t, 3) + 3) / Math.Sqrt(c + t);
        }
    }
}

