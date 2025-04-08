using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23.Utils
{
    public class Task13
    {
        public static double Calculate(Dictionary<string, double> vars)
        {
            double h = vars["h"];
            double y = vars["y"];
            double e = vars["e"];
            return (Math.Sin(2 * y + h) + Math.Pow(h, 2)) / (Math.Pow(e, h) + y);
        }
    }
}
