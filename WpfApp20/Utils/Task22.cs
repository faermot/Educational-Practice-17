using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23.Utils
{
    internal class Task22
    {
        public static double Calculate(Dictionary<string, double> vars)
        {
            double t = vars["t"];
            double y = vars["y"];
            return (4.351 * Math.Pow(y, 3) + 2 * t * Math.Log(t)) / (Math.Sqrt(Math.Cos(2 * y) + 4.351));
        }
    }
}
