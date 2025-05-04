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

namespace WeC.Operations
{
    public class WindAndEnergy
    {
        public static double AirDensity = 1.225; // kg/m^3
        public static double CalculateWindPower(double windSpeed, double diamether)
        {
            // Calculate the area of the wind turbine
            double area = Math.PI * Math.Pow(diamether / 2, 2);
            // Calculate the wind power using the formula
            return 0.5 * AirDensity * area * Math.Pow(windSpeed, 3);
        }

        public static double CalculateWindPower(double airDensity, double windSpeed, double diamether)
        {
            // Calculate the area of the wind turbine
            double area = Math.PI * Math.Pow(diamether / 2, 2);
            // Calculate the wind power using the formula
            return 0.5 * airDensity * area * Math.Pow(windSpeed, 3);
        }
    }
}
