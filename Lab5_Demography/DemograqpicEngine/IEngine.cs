using System;
using System.Collections.Generic;
using System.Text;

namespace DemograqpicEngine
{
    public interface IEngine
    {
        event Action YearTick;
        void SetupWorld();
        void NewYearTick();

    }
}
