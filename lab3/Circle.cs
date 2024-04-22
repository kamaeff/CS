using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab3
{
    public class Circle
    {
        public static double CircleSquare(double r)
        {
            return Math.Round(Math.Pow(r, 2) * 3.14, 2);
        }
    }
}