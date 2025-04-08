using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23.Utils
{
    public class Task14
    {
        public static double Calculate(Dictionary<string, double> vars)
        {
            double h = vars["h"];
            double y = vars["y"];
            double e = vars["e"];
            return Math.Pow(e, (y + 2.5) + Math.Pow((7.1 * h), 2)) / (Math.Log(Math.Sqrt(y + 0.04 * h)));
        }
    }
}
