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
        public static double CircleRadius(double? diameter)
        {
            if (diameter.HasValue)
            {
                return diameter.Value / 2;
            }
            else
            {
                return -1;
            }
        }

        public static double CircleDiameter(double? radius)
        {
            if (radius.HasValue)
            {
                return radius.Value * radius.Value;
            }
            else
            {
                return -1;
            }
        }

        public static double CircleArea(double? radius)
        {
            if (radius.HasValue)
            {
                return Math.PI * Math.Pow(radius.Value, 2);
            }
            else
            {
                return -1;
            }
        }

        public static double CircleCircumference(double? radius)
        {
            if (radius.HasValue)
            {
                return 2 * Math.PI * radius.Value;
            }    
            else
            {
                return -1;
            }
        }
    }
}
