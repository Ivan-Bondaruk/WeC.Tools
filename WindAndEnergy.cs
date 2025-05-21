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
    public class WindAndEnergy
    {
        public static double AirDensity = 1.225; // kg/m^3
        public static double CalculateWindPower(double? windSpeed, double? diamether)
        {
            if (windSpeed.HasValue && diamether.HasValue)
            {
                // Calculate the area of the wind turbine
                var area = Math.PI * Math.Pow(diamether.Value / 2, 2);
                // Calculate the wind power using the formula
                return 0.5 * AirDensity * area * Math.Pow(windSpeed.Value, 3);
            }
            else
            {
                return -1;
            }
        }

        public static double CalculateWindPower(double? airDensity, double? windSpeed, double? diamether)
        {
            if (airDensity.HasValue && windSpeed.HasValue && diamether.HasValue)
            {
                // Calculate the area of the wind turbine
                var area = Math.PI * Math.Pow(diamether.Value / 2, 2);
                // Calculate the wind power using the formula
                return 0.5 * airDensity.Value * area * Math.Pow(windSpeed.Value, 3);
            }
            else
            {
                return -1;
            }
        }

        public static double CalculateRealPower(double? windPower, double? efficiency)
        {
            if (windPower.HasValue && efficiency.HasValue)
            {
                return windPower.Value * efficiency.Value;
            }
            else
            {
                return -1;
            }
        }

        public static double CalculateAnnualEnergyOutput(double? realPower, double? hours)
        {
            if (realPower.HasValue && hours.HasValue)
            {
                return realPower.Value * hours.Value;
            }
            else
            {
                return -1;
            }
        }

        public static double CalculatePaybackPeriod(double? installationCost, double? energyCost, double? annualEnergy)
        {
            if (installationCost.HasValue && energyCost.HasValue && annualEnergy.HasValue)
            {
                var annualSaving = energyCost * annualEnergy;
                return installationCost.Value / annualSaving.Value;
            }
            else
            {
                return -1;
            }
        }
    }
}
