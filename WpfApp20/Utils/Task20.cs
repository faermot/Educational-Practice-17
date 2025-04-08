using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23.Utils
{
    public class Task20
    {
        public static double Calculate(Dictionary<string, double> vars)
        {
            double t = vars["t"];
            double y = vars["y"];
            double l = vars["l"];
            double e = vars["e"];
            return (2 * Math.Pow(t, 2) + 3 * l + 7.2) / (Math.Log(y + Math.Pow(e, 2 * t)));
        }
    }
}
