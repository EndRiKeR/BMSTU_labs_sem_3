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

        //Задается возраст и пол
        public Person(int nowYear, int age)
        {
            Gender = ProbabilityCalculator.IsEventHappened(StandartConstants.GenderManChange) ? Gender.Man : Gender.Woman;
            BirthYear = nowYear - age;
            Age = age;
        }

        public void OnYearTick(Dictionary<int[], double[]> chanceToDie)
        {
            int[] nowAgePer = new int[1]();

            foreach(int[] agesPeriod in chanceToDie.Keys)
            {
                if (Age >= agesPeriod[0] && Age <= agesPeriod[1])
                {

                }
            }

            double[] changes = chanceToDie[];

            if (ProbabilityCalculator.IsEventHappened(chanceToDie[][Gender == Gender.Man ? 0 : 1]))
                return;
        }


    }
}
