using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeC.Operations
{
    public static class Circle
    {
        public static double CircleRadius(double diameter)
        {
            return diameter / 2;
        }

        public static double CircleDiameter(double radius)
        {
            return radius * radius;
        }

        public static double CircleArea(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public static double CircleCircumference(double radius)
        {
            return 2 * Math.PI * radius;
        }
    }
}
