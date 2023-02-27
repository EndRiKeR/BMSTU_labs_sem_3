using System;
using System.Collections.Generic;
using System.Text;

namespace DemographicEngine.StructsAndEnums
{
    public struct AgesDeathPeriod
    {
        public AgePeriod Period { get; }
        public double DeathChanceMan { get; }
        public double DeathChanceWoman { get; }

        public AgesDeathPeriod(int start, int end, double man, double woman)
        {
            Period = new AgePeriod(start, end);
            DeathChanceMan = man;
            DeathChanceWoman = woman;
        }

        public bool ContainAge(int age)
        {
            return Period.ContainAge(age);
        }

        public override string ToString()
        {
            return $"From {Period.AgeStart} to {Period.AgeEnd}: Man - {DeathChanceMan}, Woman - {DeathChanceWoman}";
        }

        public string GetPeriod()
        {
            return Period.GetPeriod();
        }
    }
}
