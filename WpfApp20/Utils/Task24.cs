using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23.Utils
{
    public class Task24
    {
        public static double Calculate(Dictionary<string, double> vars)
        {
            double k = vars["k"];
            double y = vars["y"];
            double e = vars["e"];
            return (Math.Log(2 * k + 4.3)) / (Math.Pow(e, k + y) + Math.Sqrt(y));
        }
    }
}
