using System;
using System.Collections.Generic;
using System.Text;

namespace DemographicEngine.StructsAndEnums
{
    public struct AgedStatistic
    {
        public AgePeriod Period { get; }
        public int ManCounter { get; set; }
        public int WomanCounter { get; set; }

        public AgedStatistic(int startAge, int endAge, int man = 0, int woman = 0)
        {
            Period = new AgePeriod(startAge, endAge);
            ManCounter = man;
            WomanCounter = woman;
        }

        public AgedStatistic(AgePeriod agePeriod, int man = 0, int woman = 0)
        {
            Period = agePeriod;
            ManCounter = man;
            WomanCounter = woman;
        }

        public bool ContainAge(int age)
        {
            return Period.ContainAge(age);
        }

        public override string ToString()
        {
            return $"From {Period.AgeStart} to {Period.AgeEnd}: Man - {ManCounter}, Woman - {WomanCounter}";
        }

        public string GetPeriod()
        {
            return Period.GetPeriod();
        }
    }
}
