using DemographicEngine.StructsAndEnums;
using System;
using System.Collections.Generic;

namespace DemographicEngine
{
    public delegate void YearEvent(List<AgesDeathPeriod> agesPeriods);

    public delegate void DeathEvent(Person person);
    public delegate void BirthEvent(Person person);
    public delegate void StatisticEvent(StatisticData data);
    public delegate void DemographyStatisticEvent(List<AgedStatistic> data);


    public class Engine : IEngine
    {
        public event YearEvent YearTick;
        public event StatisticEvent StatisticSend;
        public event DemographyStatisticEvent DemographyStatisticSend;

        public Dictionary<int, double> InitAges { get; }
        public List<AgesDeathPeriod> DeathRules { get; }
        public int NowAge { get; private set; }
        public int EndAge { get; }
        public int Population { get; }

        private List<Person> _peoples = new List<Person>();
        private int _populationTotal = 0;
        private int _populationMan = 0;
        private int _populationWoman = 0;

        private const int _ModifierForInitialAges = 1000;
        private const int _peoplesInOnePersion = 10000;

        public Engine(Dictionary<int, double> initAges,
                        List<AgesDeathPeriod> initDeathRules,
                        int startAge,  
                        int endAge,
                        int population)
        {
            InitAges = initAges;
            DeathRules = initDeathRules;
            NowAge = startAge;
            EndAge = endAge;
            Population = population;

            SetupWorld();
        }

        public void SetupWorld()
        {
            //Console.WriteLine($"Setup Engine");

            foreach (var pair in InitAges)
            {
                double peopleCount = (pair.Value / _ModifierForInitialAges)  * Population;

                while (peopleCount > 0)
                {
                    Person person = new Person(NowAge, pair.Key, OnPersonDeath, OnPersonBirth);
                    NewPersonArrived(person);
                    peopleCount -= _peoplesInOnePersion;
                }
            }

            //Console.WriteLine($"Setup Engine done. Population in Total: {_populationTotal}, Mans population: {_populationMan}, Womans Population: {_populationWoman}.");
        }

        public void StartEngine()
        {
            Console.WriteLine($"Start Engine");
            for (int age = NowAge; age <= EndAge; ++age)
            {
                Console.WriteLine($"New Year Tick. Now Age: {NowAge}. Population in Total: {_populationTotal}, Mans population: {_populationMan}, Womans Population: {_populationWoman}.");
                NewYearTick();
            }

            DemographyStatisticSend.Invoke(FormAgedStatisticData());


        }

        public void NewYearTick()
        {
            YearTick.Invoke(DeathRules);
            StatisticSend.Invoke(FormStatisticData());
            NowAge += 1;
        }

        private void OnPersonBirth(Person child)
        {
            //Console.WriteLine($"Person birth: {child.Gender}");
            NewPersonArrived(child);
        }

        private void OnPersonDeath(Person person)
        {
            //Console.WriteLine($"Person died: {person}");
            YearTick -= person.OnYearTick;

            _peoples.Remove(person);

            _populationTotal -= 1;

            if (person.Gender == Gender.Man)
                _populationMan -= 1;
            else
                _populationWoman -= 1;
        }

        private void NewPersonArrived(Person person)
        {
            YearTick += person.OnYearTick;

            if (person.Gender == Gender.Man)
                _populationMan += 1;
            else
                _populationWoman += 1;
            _populationTotal += 1;

            _peoples.Add(person);
        }

        private StatisticData FormStatisticData()
        {
            StatisticData data = new StatisticData(NowAge, _populationTotal, _populationMan, _populationWoman);
            return data;
        }

        private List<AgedStatistic> FormAgedStatisticData()
        {
            //0-18, 19-44, 45-65 и 66-100 
            List<AgedStatistic> data = new List<AgedStatistic>();
            data.Add(new AgedStatistic(0, 18));
            data.Add(new AgedStatistic(19, 44));
            data.Add(new AgedStatistic(45, 65));
            data.Add(new AgedStatistic(66, 100));
            data.Add(new AgedStatistic(101, 120));

            foreach(var people in _peoples)
            {
                for(int period = 0; period < data.Count; period++)
                {
                    if (data[period].ContainAge(people.Age))
                        if (people.Gender == Gender.Man)
                            data[period].IncrementMan();
                        else
                            data[period].IncrementWoman();
                }
                

            }
            return data;
        }
    }
}
