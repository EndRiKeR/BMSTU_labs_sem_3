using DemographicEngine.StructsAndEnums;
using System;
using System.Collections.Generic;

namespace DemographicEngine
{
    public delegate void YearEvent(List<AgesDeathPeriod> agesPeriods);

    public delegate void DeathEvent(Person person);
    public delegate void BirthEvent(Person person);
    public delegate void PingEvent(int age);
    //public delegate void StatisticEvent(List<PopStatistic> data);
    //public delegate void DemographyStatisticEvent(List<AgedStatistic> data);


    public class Engine : IEngine
    {
        public event YearEvent YearTick;
        public event PingEvent Ping;
        //public event StatisticEvent StatisticSend;
        //public event DemographyStatisticEvent DemographyStatisticSend;

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

        private List<PopStatistic> _listStatisticData = new List<PopStatistic>();

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

        public StatisticData StartEngine()
        {
            _listStatisticData.Clear();
            Console.WriteLine($"Start Engine");
            for (int age = NowAge; age <= EndAge; ++age)
            {
                Console.WriteLine($"New Year Tick. Now Age: {NowAge}. Population in Total: {_populationTotal}, Mans population: {_populationMan}, Womans Population: {_populationWoman}.");
                NewYearTick();
            }

            return new StatisticData(FormAgedStatisticData(), _listStatisticData);
            //StatisticSend.Invoke(_listStatisticData);
            //DemographyStatisticSend.Invoke(FormAgedStatisticData());
        }

        public void NewYearTick()
        {
            YearTick.Invoke(DeathRules);
            Ping(NowAge);
            NowAge += 1;

            _listStatisticData.Add(FormPopStatistic());
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

        private PopStatistic FormPopStatistic()
        {
            PopStatistic data = new PopStatistic(NowAge, _populationTotal, _populationMan, _populationWoman);
            return data;
        }

        private List<AgedStatistic> FormAgedStatisticData()
        {
            //0-18, 19-44, 45-65 и 66-100 
            List<AgePeriod> agePeriods = new List<AgePeriod>()
            {
                new AgePeriod(0, 18),
                new AgePeriod(19, 44),
                new AgePeriod(45, 65),
                new AgePeriod(66, 100),
                new AgePeriod(101, 120),
            };

            List<AgedStatistic> data = new List<AgedStatistic>();
            /*{
                new AgedStatistic(0, 18),
                new AgedStatistic(19, 44),
                new AgedStatistic(45, 65),
                new AgedStatistic(66, 100),
                new AgedStatistic(101, 120),
            };*/

            _peoples.Sort((a, b) => a.Age.CompareTo(b.Age));
            int period = 0;
            int manCount = 0;
            int womanCount = 0;

            foreach (var people in _peoples)
            {
                if (!agePeriods[period].ContainAge(people.Age))
                {
                    data.Add(new AgedStatistic(agePeriods[period], manCount, womanCount));

                    ++period;
                    manCount = 0;
                    womanCount = 0;
                }

                if (agePeriods[period].ContainAge(people.Age))
                    if (people.Gender == Gender.Man)
                        manCount++;
                    //tmp.IncrementMan();
                    else
                        womanCount++;
                    //tmp.WomanCounter += 1;


            }

            while (period < agePeriods.Count)
            {
                data.Add(new AgedStatistic(agePeriods[period], 0, 0));
                ++period;
            }

            return data;
        }
    }
}
