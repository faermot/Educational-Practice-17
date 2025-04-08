using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23.Utils
{
    public class Task2
    {
        public static string Calculate(Dictionary<string, object> vars)
        {
            var doubleVars = ConvertToDoubleDictionary(vars);
            double d = doubleVars["d"];
            double y = doubleVars["y"];
            return Convert.ToString(Math.Log(d) + 3.5 * (Math.Pow(d, 2) + 1) / (Math.Cos(2 * y)));
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
