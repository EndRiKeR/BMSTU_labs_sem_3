using DemographicEngine.StaticAndConstants;
using DemographicEngine.StructsAndEnums;
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

        private event DeathEvent _personDeath;

        //Задается возраст и пол
        public Person(int nowYear, int age, DeathEvent deathEvent)
        {
            Gender = ProbabilityCalculator.IsEventHappened(StandartConstants.GenderManChange) ? Gender.Man : Gender.Woman;
            BirthYear = nowYear - age;
            Age = age;
            _personDeath += deathEvent;
        }

        public void OnYearTick(List<AgesPeriod> chanceToDie)
        {
            Age += 1;

            AgesPeriod deathChance = new AgesPeriod(0, 0, -1, -1);

            foreach(var period in chanceToDie)
            {
                if (Age >= period.AgeStart && Age <= period.AgeEnd)
                {
                    deathChance = period;
                }
            }

            if (deathChance.DeathChanceMan != -1)
            {
                double chance = (Gender == Gender.Man) ? deathChance.DeathChanceMan : deathChance.DeathChanceWoman;
                if (ProbabilityCalculator.IsEventHappened(chance))
                {
                    IsAlive = false;
                    DeathYear = BirthYear + Age;
                    _personDeath.Invoke(this);
                }
            }
               
        }

        public override string ToString()
        {
            return $" Birth in {BirthYear}, Dead in {DeathYear}, Gender: {Gender}, Age: {Age}.";
        }
    }
}
