using System;
using System.Collections.Generic;
using System.Text;

namespace DemographicEngine
{
    public class Person
    {
        public Gender Gender { get; }
        public int BirthYear { get; }
        public int DeathYear { get; private set; } = -1;
        public bool IsAlive { get; private set; } = true;
        public int Age { get; private set; }

        private Dictionary<int, double> _changeToDie;

        //Задается возраст и пол
        public Person(int nowYear, int age)
        {
            Gender = ProbabilityCalculator.IsEventHappened(StandartConstants.GenderManChange) ? Gender.Man : Gender.Woman;
            BirthYear = nowYear - age;
            Age = age;
        }

        public void OnYearTick()
        {
            if (ProbabilityCalculator.IsEventHappened(1)) ;
        }


    }
}
