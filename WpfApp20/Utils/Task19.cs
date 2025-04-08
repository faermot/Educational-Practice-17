using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23.Utils
{
    public class Task19
    {
        public static double Calculate(Dictionary<string, double> vars)
        {
            double q = vars["q"];
            double y = vars["y"];
            return (Math.Log(0.7 * y + 2 * q)) / Math.Sqrt((3 * Math.Pow(y, 2) + 0.5 * y + 4));
        }
    }
}
