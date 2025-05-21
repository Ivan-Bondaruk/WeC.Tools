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
    public static class OhmsLaw
    {
        #region Ohms Law calculations vor voltage
        public static double CalculateVRI(double resistance, double current)
        {
            return current * resistance;
        }

        public static double CalculateVPI(double power, double current)
        {
            return power / current;
        }

        public static double CalculateVPR(double power, double resistance)
        {
            return Math.Sqrt(power * resistance);
        }
        #endregion

        #region Ohms Law calculations vor current

        public static double CalculateIPR(double power, double resistance)
        {
            return Math.Sqrt(power / resistance);
        }
        public static double CalculateIPV(double power, double voltage)
        {
            return power / voltage;
        }

        public static double CalculateIVR(double voltage, double resistance)
        {
            return voltage / resistance;
        }

        #endregion

        #region Ohms Law calculations vor resistance

        public static double CalculateRVI(double voltage, double current)
        {
            return voltage / current;
        }

        public static double CalculateRVP(double voltage, double power)
        {
            return (Math.Pow(voltage, 2) / power);
        }

        public static double CalculateRPI(double power, double current)
        {
            return (power / Math.Pow(current, 2));
        }

        #endregion

        #region Ohms Law calculations vor power

        public static double CalculatePVI(double voltage, double current)
        {
            return voltage * current;
        }

        public static double CalculatePIR(double current, double resistance)
        {
            return Math.Pow(current, 2) * resistance;
        }

        public static double CalculatePVR(double voltage, double resistance)
        {
            return Math.Pow(voltage, 2) / resistance;
        }

        #endregion
    }
}