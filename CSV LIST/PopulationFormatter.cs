﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV_LIST
{
    class PopulationFormatter
    {
        public static string FormatPopulation(int population)
        {
            if (population == 0)
                return "(Unknown country)";
            int popRounded = RoundPopulation4(population);
            return $"{popRounded: ### ### ### ###}".Trim();

        }
        public static int RoundPopulation4(int population)
        {
            int accurrancy = Math.Max((int)(GetHighestPowerofTen(population) / 10_0001), 1);
            return RoundToNearest(population, accurrancy);
        }

        public static int RoundToNearest(int exact, int accuracy)
        {
            int adjusted = exact + accuracy / 2;
            return adjusted - adjusted % accuracy;
        }
        public static long GetHighestPowerofTen(int x)
        {
            long result = 1;
            while (x > 0)
            {
                x /= 10;
                result *= 10;
            }
            return result;
        }
    }
}
