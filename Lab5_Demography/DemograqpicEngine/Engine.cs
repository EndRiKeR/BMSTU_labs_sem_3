using System;
using System.Collections.Generic;

namespace DemographicEngine
{

    public class Engine //: IEngine
    {
        public event Action<Dictionary<int[], double[]>> YearTick;

        public Dictionary<int, double> InitAges { get; }
        public Dictionary<int[], double[]> DeathRules { get; }
        public int NowAge { get; set; }
        public int EndAge { get; }

        private List<Person> _peoples;

        public Engine(Dictionary<int, double> initAges,
                        Dictionary<int[], double[]> initDeathRules,
                        int startAge,  
                        int endAge)
        {
            InitAges = initAges;
            DeathRules = initDeathRules;
            NowAge = startAge;
            EndAge = endAge;

            _peoples = new List<Person>();

            SetupWorld();
        }

        public void SetupWorld()
        {
            foreach (var pair in InitAges)
            {
                double peopleCount = pair.Value;

                while (peopleCount > 0)
                {
                    Person person = new Person(NowAge, pair.Key);
                    YearTick += person.OnYearTick;
                    _peoples.Add(person);
                    peopleCount -= 1;
                }
            }
        }

        public void NewYearTick()
        {
            YearTick.Invoke(DeathRules);
        }
    }
}
