using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23.Utils
{
    public class Task12
    {
        public static double Calculate(Dictionary<string, double> vars)
        {
            double t = vars["t"];
            double y = vars["y"];
            return (Math.Sin(Math.Pow((2 * t + 1), 2)) + 0.3) / Math.Log(t + y);
        }
    }
}
