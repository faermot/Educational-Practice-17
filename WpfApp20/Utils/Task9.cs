using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23.Utils
{
    public class Task9
    {
        public static double Calculate(Dictionary<string, double> vars)
        {
            double w = vars["w"];
            double y = vars["y"];
            return (Math.Pow(y + 2 * w, 3)) / (Math.Log(y + 0.75));
        }
    }
}
