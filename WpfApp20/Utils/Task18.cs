using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23.Utils
{
    public class Task18
    {
        public static double Calculate(Dictionary<string, double> vars)
        {
            double k = vars["k"];
            double y = vars["y"];
            return (Math.Sqrt(Math.Pow(Math.Sin(y), 2) + 6.835)) / ((Math.Log(y + k) + 3 * Math.Pow(y, 2)));
        }
    }
}
