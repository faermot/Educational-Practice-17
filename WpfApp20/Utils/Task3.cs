using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23.Utils
{
    public class Task3
    {
        public static double Calculate(Dictionary<string, double> vars)
        {
            double k = vars["k"];
            double y = vars["y"];
            double e = vars["e"];
            return (Math.Log(k - y) + Math.Pow(y, 4)) / (Math.Pow(e, y) + 2.355 * k);
        }
    }
}
