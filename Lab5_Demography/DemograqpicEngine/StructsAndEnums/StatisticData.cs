using System;
using System.Collections.Generic;
using System.Text;

namespace DemographicEngine.StructsAndEnums
{

    /*
        populationTotal - график изменения общего населения по годам в виде spline chart;
        populationMan - график изменения населения мужского пола по годам в виде spline chart;
        populationWoman - график изменения населения женского пола по годам в виде spline chart;
        ??? возрастной состав населения мужского пола на конец моделирования для возрастных категорий 0-18, 19-45, 45-65 и 65-100 лет в виде bar chart;
        ??? возрастной состав населения женского пола на конец моделирования для возрастных категорий 0-18, 19-44, 45-65 и 66-100 лет в виде bar chart.
    */

    public struct StatisticData
    {
        public int Age { get; }
        public int PopTotal { get; }
        public int PopMan { get; }
        public int PopWoman { get; }

        public StatisticData(int age, int popTotal, int popMan, int popWoman)
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
