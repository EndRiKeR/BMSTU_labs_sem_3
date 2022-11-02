using System;
using System.Collections.Generic;
using System.Text;

namespace DemographicEngine.StructsAndEnums
{
    public struct AgesPeriod
    {
        public int AgeStart { get; }
        public int AgeEnd { get; }
        public double DeathChanceMan { get; }
        public double DeathChanceWoman { get; }

        public AgesPeriod(int start, int end, double man, double woman)
        {
            AgeStart = start;
            AgeEnd = end;
            DeathChanceMan = man;
            DeathChanceWoman = woman;
        }

        public override string ToString()
        {
            return $"From {AgeStart} to {AgeEnd}: Man - {DeathChanceMan}, Woman - {DeathChanceWoman}";
        }
    }
}
