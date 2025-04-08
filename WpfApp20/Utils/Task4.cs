using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23.Utils
{
    public class Task4
    {
        public static double Calculate(Dictionary<string, double> vars)
        {
            double x = vars["x"];
            double y = vars["y"];
            double w = vars["w"];
            return 9.33 * (Math.Pow(w, 3) + Math.Sqrt(w)) / (Math.Log(y + 3.5) + Math.Sqrt(y));
        }
    }
}
