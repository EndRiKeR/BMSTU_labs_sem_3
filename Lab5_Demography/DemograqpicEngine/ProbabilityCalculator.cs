using System;
using System.Collections.Generic;
using System.Text;

namespace DemographicEngine
{
    public static class ProbabilityCalculator
    {
        private static readonly Random _random = new Random();

        public static bool IsEventHappened(double eventProbability)
        {
            return _random.NextDouble() <= eventProbability;
        }

    }
}
