using System;
using System.Collections.Generic;
using System.Text;

namespace DemographicEngine
{
    public interface IEngine
    {
        event YearEvent YearTick;
        void SetupWorld();
        void StartEngine();
        void NewYearTick();

    }
}
