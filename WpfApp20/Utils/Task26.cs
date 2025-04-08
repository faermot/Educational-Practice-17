using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23.Utils
{
    public class Task26
    {
        public static double Calculate(Dictionary<string, double> vars)
        {
            double y = vars["y"];
            double u = vars["u"];
            return (Math.Sin(2 * u)) / (Math.Log(2 * y + u));
        }
    }
}
