using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23.Utils
{
    public class Task10
    {
        public static string Calculate(Dictionary<string, object> vars)
        {
            var doubleVars = ConvertToDoubleDictionary(vars);
            double t = doubleVars["t"];
            double y = doubleVars["y"];
            return ((2 * t + y * Math.Cos(t)) / (Math.Sqrt(y + 4.831))).ToString();
        }

        private static Dictionary<string, double> ConvertToDoubleDictionary(Dictionary<string, object> dict)
        {
            var result = new Dictionary<string, double>();
            foreach (var kvp in dict)
            {
                if (kvp.Value is double dValue)
                {
                    result[kvp.Key] = dValue;
                }
                else
                {
                    throw new InvalidCastException($"Переменная {kvp.Key} должна быть числом.");
                }
            }
            return result;
        }
    }
}
