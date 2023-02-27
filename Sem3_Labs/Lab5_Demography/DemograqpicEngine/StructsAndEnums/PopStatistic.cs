using System;
using System.Collections.Generic;
using System.Text;

namespace DemographicEngine.StructsAndEnums
{

    public struct PopStatistic
    {
        public int Age { get; }
        public int PopTotal { get; }
        public int PopMan { get; }
        public int PopWoman { get; }

        public PopStatistic(int age, int popTotal, int popMan, int popWoman)
        {
            Age = age;
            PopTotal = popTotal;
            PopMan = popMan;
            PopWoman = popWoman;
        }

        public override string ToString()
        {
            return $"Statistic Data:" +
                    $"Age: {Age}" +
                    $"Total Population: {PopTotal}" +
                    $"Man Population: {PopMan}" +
                    $"Woman Population: {PopWoman}";
        }


    }
}
