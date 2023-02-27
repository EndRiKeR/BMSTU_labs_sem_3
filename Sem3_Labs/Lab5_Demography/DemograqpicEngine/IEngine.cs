using System;
using System.Collections.Generic;
using System.Text;
using DemographicEngine.StructsAndEnums;

namespace DemographicEngine
{
    public interface IEngine
    {
        event YearEvent YearTick;
        void SetupWorld();
        StatisticData StartEngine();
        void NewYearTick();

    }
}
