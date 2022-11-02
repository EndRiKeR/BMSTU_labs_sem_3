using DemographicEngine.StructsAndEnums;
using System;
using System.Collections.Generic;

namespace DemographicEngine
{
    public delegate void YearEvent(List<AgesPeriod> agesPeriods);

    public delegate void DeathEvent(Person person);

    public class Engine : IEngine
    {
        

        public event YearEvent YearTick;

        public Dictionary<int, double> InitAges { get; }
        public List<AgesPeriod> DeathRules { get; }
        public int NowAge { get; private set; }
        public int EndAge { get; }

        private List<Person> _peoples = new List<Person>();
        private int _populationTotal = 0;
        private int _populationMan = 0;
        private int _populationWoman = 0;

        public Engine(Dictionary<int, double> initAges,
                        List<AgesPeriod> initDeathRules,
                        int startAge,  
                        int endAge)
        {
            InitAges = initAges;
            DeathRules = initDeathRules;
            NowAge = startAge;
            EndAge = endAge;

            SetupWorld();
        }

        public void SetupWorld()
        {
            Console.WriteLine($"Setup Engine");

            foreach (var pair in InitAges)
            {
                double peopleCount = pair.Value;

                while (peopleCount > 0)
                {
                    Person person = new Person(NowAge, pair.Key, OnPersonDeath);
                    YearTick += person.OnYearTick;

                    if (person.Gender == Gender.Man)
                        _populationMan += 1;
                    else
                        _populationWoman += 1;

                    _peoples.Add(person);
                    peopleCount -= 1;
                }
            }

            Console.WriteLine($"Setup Engine done. Population in Total: {_populationTotal}, Mans population: {_populationMan}, Womans Population: {_populationWoman}.");
        }

        public void StartEngine()
        {
            Console.WriteLine($"Start Engine");
            for (int age = NowAge; age <= EndAge; ++age)
            {
                Console.WriteLine($"New Year Tick. Now Age: {NowAge}.");
                NewYearTick();
            }
        }

        public void NewYearTick()
        {
            YearTick.Invoke(DeathRules);
            NowAge += 1;
        }

        private void OnPersonDeath(Person person)
        {
            Console.WriteLine($"Person died: {person}");
            YearTick -= person.OnYearTick;

            _populationTotal -= 1;

            if (person.Gender == Gender.Man)
                _populationMan -= 1;
            else
                _populationWoman -= 1;
        }
    }
}
