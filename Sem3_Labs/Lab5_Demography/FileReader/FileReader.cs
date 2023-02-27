using System;
using System.Collections.Generic;
using System.IO;
using DemographicEngine.StructsAndEnums;

namespace FileReader
{
    public class Reader
    {
        private string _initalAgeDataType = "Age, CountOn1000";
        private string _deathRule = "StartAge, EndAge, ChangeDeathMan, ChangeDeathWoman";

        public string[] ReadFromFile(string filePath)
        {
            if (!File.Exists(filePath))
                throw new RikerFileNotExistsException();

            FileInfo fileInfo = new FileInfo(filePath);

            if (fileInfo.Length > 15000 || fileInfo.Length <= 60)
                throw new RikerFileWrongSizeException();

            return File.ReadAllLines(filePath);
        }

        public Dictionary<int, double> ParceInitialAgeData(string[] strings)
        {

            try
            {
                if (strings[0] != _initalAgeDataType)
                    throw new RikerFileWrongTypeException(_initalAgeDataType);

                Dictionary<int, double> demographySplit = new Dictionary<int, double>();

                foreach (var row in strings)
                {
                    if (row == _initalAgeDataType)
                        continue;

                    string[] words = row.Split(',');
                    string strCount = "";

                    if (words.Length > 2 || words.Length < 1)
                        throw new RikerFileWrongDataException();

                    if (words.Length == 1)
                        strCount = "0";
                    else
                        strCount = words[1];

                    if (String.IsNullOrWhiteSpace(words[0]) ||
                        String.IsNullOrWhiteSpace(strCount))
                        throw new RikerFileWrongDataException();

                    strCount = strCount.Replace(".", ",");

                    int age = 0;
                    double countOn1000 = 0;

                    if (!int.TryParse(words[0], out age) || !double.TryParse(strCount, out countOn1000))
                        throw new RikerFileWrongDataException();

                    if (age < 0 || countOn1000 < 0)
                        throw new RikerFileWrongDataException();

                    //Console.WriteLine($"{words[0]}, {words[1]}");
                    demographySplit.Add(age, countOn1000);
                }

                return demographySplit;
            }
            catch (RikerBaseFileException)
            {
                throw;
            }
        }

        public List<AgesDeathPeriod> ParceDeathRulesData(string[] strings)
        {
            try
            {
                if (strings[0] != _deathRule)
                    throw new RikerFileWrongTypeException(_deathRule);

                List<AgesDeathPeriod> deathRule = new List<AgesDeathPeriod>();

                foreach (var row in strings)
                {
                    if (row == _deathRule)
                        continue;

                    string[] words = row.Split(',');

                    if (words.Length != 4)
                        throw new RikerFileWrongDataException();

                    for (int i = 0; i < 4; i ++)
                    {
                        if (String.IsNullOrWhiteSpace(words[i]))
                            throw new RikerFileWrongDataException();

                        words[i] = words[i].Replace(".", ",");
                    }

                    int start = 0;
                    int end = 0;
                    double man = 0;
                    double woman = 0;

                    if (!int.TryParse(words[0], out start) ||
                        !int.TryParse(words[1], out end) ||
                        !double.TryParse(words[2], out man) ||
                        !double.TryParse(words[3], out woman))
                        throw new RikerFileWrongDataException();

                    AgesDeathPeriod ages = new AgesDeathPeriod(start,
                                                                end,
                                                                man,
                                                                woman);

                    if (start < 0 || end < 0 || man < 0 || woman< 0)
                        throw new RikerFileWrongDataException();

                    deathRule.Add(ages);
                }

                return deathRule;
            }
            catch (RikerBaseFileException)
            {
                throw;
            }
        }




    }
}
