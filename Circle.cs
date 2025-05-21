/*
 * Copyright (C) 2025 Ivan Bondaruk
 * 
 * This file is part of WeC.
 * 
 * It under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 * 
 * Author: Ivan Bondaruk
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeC.Tools
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
