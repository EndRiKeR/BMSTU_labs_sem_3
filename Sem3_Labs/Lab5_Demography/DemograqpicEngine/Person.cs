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

        public event DeathEvent _personDeath;
        public event BirthEvent _personBirth;

        public Person(int nowYear, int age, DeathEvent deathEvent, BirthEvent birthEvent)
        {
            Gender = ProbabilityCalculator.IsEventHappened(StandartConstants.GenderManChange) ? Gender.Man : Gender.Woman;
            BirthYear = nowYear - age;
            Age = age;
            _personDeath += deathEvent;
            _personBirth += birthEvent;
        }

        public void OnYearTick(List<AgesDeathPeriod> chanceToDie)
        {
            AgesDeathPeriod deathChance = new AgesDeathPeriod(0, 0, -1, -1);

            foreach(var period in chanceToDie)
            {
                if (period.Period.ContainAge(Age))
                {
                    deathChance = period;
                }
            }

            if (Gender == Gender.Woman && Age >= 18 && ProbabilityCalculator.IsEventHappened(StandartConstants.ChildBirthChance))
            {
                var child = new Person(BirthYear + Age, 0, _personDeath, _personBirth);
                _personBirth.Invoke(child);
            }

            if (deathChance.DeathChanceMan != -1)
            {
                double chance = (Gender == Gender.Man) ? deathChance.DeathChanceMan : deathChance.DeathChanceWoman;
                if (ProbabilityCalculator.IsEventHappened(chance))
                {
                    IsAlive = false;
                    DeathYear = BirthYear + Age;
                    //Отписать движок
                    _personDeath.Invoke(this);
                }
            }

            Age += 1;
        }

        public override string ToString()
        {
            return $" Birth in {BirthYear}, Dead in {DeathYear}, Gender: {Gender}, Age: {Age}.";
        }
    }
}
