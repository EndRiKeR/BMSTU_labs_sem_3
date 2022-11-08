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
        public void IncrementMan()
        {
            ManCounter += 1;
        }

        public void IncrementWoman()
        {
            WomanCounter += 1;
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
