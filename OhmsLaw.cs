/*
 * Copyright (C) 2025 Ivan Bondaruk
 * 
 * This file is part of WeC.Tools.
 * 
 * Author: Ivan Bondaruk
 * 
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
        public static double CalculateVRI(double? resistance, double? current)
        {
            if (resistance.HasValue && current.HasValue)
            {
                return current.Value * resistance.Value;
            }
            else
            {
                return -1;
            }
        }

        public static double CalculateVPI(double? power, double? current)
        {
            if (power.HasValue && current.HasValue)
            {
                return power.Value / current.Value;
            }
            else
            {
                return -1;
            }
        }

        public static double CalculateVPR(double? power, double? resistance)
        {
            if (power.HasValue && resistance.HasValue)
            {
                return Math.Sqrt(power.Value * resistance.Value);
            }
            else
            {
                return -1;
            }    
        }

        #endregion

        #region Ohms Law calculations vor current

        public static double CalculateIPR(double? power, double? resistance)
        {
            if (power.HasValue && resistance.HasValue)
            {
                return Math.Sqrt(power.Value / resistance.Value);
            }
            else
            {
                return -1;
            }
        }
        public static double CalculateIPV(double? power, double? voltage)
        {
            if (power.HasValue && voltage.HasValue)
            {
                return power.Value / voltage.Value;
            }
            else
            {
                return -1;
            }
        }

        public static double CalculateIVR(double? voltage, double? resistance)
        {
            if (voltage.HasValue && resistance.HasValue)
            {
                return voltage.Value / resistance.Value;
            }
            else
            {
                return -1;
            }
        }

        #endregion

        #region Ohms Law calculations vor resistance

        public static double CalculateRVI(double? voltage, double? current)
        {
            if (voltage.HasValue && current.HasValue)
            {
                return voltage.Value / current.Value;
            }
            else
            {
                return -1;
            }
        }

        public static double CalculateRVP(double? voltage, double? power)
        {
            if (voltage.HasValue && power.HasValue)
            {
                return (Math.Pow(voltage.Value, 2) / power.Value);
            }
            else
            {
                return -1;
            }
        }

        public static double CalculateRPI(double? power, double? current)
        {
            if (power.HasValue && current.HasValue)
            {
                return (power.Value / Math.Pow(current.Value, 2));
            }
            else
            {
                return -1;
            }
        }

        #endregion

        #region Ohms Law calculations vor power

        public static double CalculatePVI(double? voltage, double? current)
        {
            if (voltage.HasValue && current.HasValue)
            {
                return voltage.Value * current.Value;
            }
            else
            {
                return -1;
            }
        }

        public static double CalculatePIR(double? current, double? resistance)
        {
            if (current.HasValue && resistance.HasValue)
            {
                return Math.Pow(current.Value, 2) * resistance.Value;
            }
            else
            {
                return -1;
            }
        }

        public static double CalculatePVR(double? voltage, double? resistance)
        {
            if (voltage.HasValue && resistance.HasValue)
            {
                return Math.Pow(voltage.Value, 2) / resistance.Value;
            }
            else
            {
                return -1;
            }
        }

        #endregion
    }
}