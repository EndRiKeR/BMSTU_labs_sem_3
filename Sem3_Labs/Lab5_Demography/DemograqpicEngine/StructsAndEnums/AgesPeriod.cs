using System;
using System.Collections.Generic;
using System.Text;

namespace DemographicEngine.StructsAndEnums
{

    public struct AgePeriod
    {
        public int AgeStart { get; }
        public int AgeEnd { get; }

        public AgePeriod(int start, int end)
        {
            AgeStart = start;
            AgeEnd = end;
        }

        public bool ContainAge(int age)
        {
            return (age >= AgeStart && age <= AgeEnd);
        }

        public override string ToString()
        {
            return $"Age Period From {AgeStart} To {AgeEnd}";
        }

        public string GetPeriod()
        {
            return $"{AgeStart}-{AgeEnd}";
        }
    }
   
}
