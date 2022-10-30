using System;
using System.Collections.Generic;
using System.Text;

namespace DemograqpicEngine
{
    public class Person
    {
        public Gender Gender { get; set; }
        public DateTime BirthYear { get; set; }
        public bool IsAlive { get; private set; } = true;
        public DateTime DeathYear { get; set; }

        private Dictionary<int, double> _changeToDie;

        public void OnYearTick()
        {

        }


    }
}
