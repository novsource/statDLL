using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stat
{
    public class CalculatorBase
    {
        public static string Add(double x, double y)
        {
            return string.Format("{0}", y + x);
        }

        public static string Substract(double x, double y)
        {
            return string.Format("{0}", y - x);
        }

        public static string Multiply(double x, double y)
        {
            return string.Format("{0}", y * x);
        }

        public static string Divide(double y, double x)
        {
            if (y == 0) 
            {
                return "А вот так не надо делать";
            }

            return string.Format("{0}", y / x);
        }
    }
}
