using System;
using System.Collections.Generic;
using System.Text;

namespace DemographicEngine.StructsAndEnums
{
    public struct StatisticData
    {
        public List<AgedStatistic> AgedStat { get; }
        public List<PopStatistic> PopStat { get; }

        public StatisticData(List<AgedStatistic> agedStat, List<PopStatistic> popStat)
        {
            AgedStat = agedStat;
            PopStat = popStat;
        }

    }
}
