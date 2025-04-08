using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23.Utils
{
    public class Task21
    {
        public static double Calculate(Dictionary<string, double> vars)
        {
            double k = vars["k"];
            double p = vars["p"];
            double d = vars["d"];
            double x = vars["x"];
            return (Math.Sqrt(k + 2.6 * p * Math.Sin(k))) / (x - Math.Pow(d, 3));
        }
    }
}
