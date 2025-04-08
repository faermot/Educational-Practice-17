using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23.Utils
{
    public class Task15
    {
        public static double Calculate(Dictionary<string, double> vars)
        {
            double j = vars["j"];
            double y = vars["y"];
            return (2 * Math.Sin(0.354 * y + 1)) / (Math.Log(y + 2 * j));
        }
    }
}
