using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23.Utils
{
    public class Task23
    {
        public static double Calculate(Dictionary<string, double> vars)
        {
            double d = vars["d"];
            double y = vars["y"];
            double e = vars["e"];
            return (Math.Sin(Math.Pow(y, 2) + 0.3 * d)) / (Math.Pow(e, y) + Math.Log(d));
        }
    }
}
