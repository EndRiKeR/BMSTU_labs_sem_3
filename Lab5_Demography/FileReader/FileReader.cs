using System;
using System.Collections.Generic;
using System.IO;

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

                    if (words.Length != 2)
                        throw new RikerFileWrongDataException();

                    if (String.IsNullOrWhiteSpace(words[0]) ||
                        String.IsNullOrWhiteSpace(words[1]))
                        throw new RikerFileWrongDataException();

                    words[1] = words[1].Replace(".", ",");
                    //Console.WriteLine($"{words[0]}, {words[1]}");
                    demographySplit.Add(Convert.ToInt32(words[0]), Convert.ToDouble(words[1]));
                }

                return demographySplit;
            }
            catch (RikerBaseFileException)
            {
                throw;
            }
        }

        public Dictionary<int[], double[]> ParceDeathRulesData(string[] strings)
        {
            try
            {
                if (strings[0] != _deathRule)
                    throw new RikerFileWrongTypeException(_deathRule);

                Dictionary<int[], double[]> deathRule = new Dictionary<int[], double[]>();

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

                    deathRule.Add(new int[] { Convert.ToInt32(words[0]),
                                                Convert.ToInt32(words[1]) },
                                  new double[] { Convert.ToDouble(words[2]),
                                                    Convert.ToDouble(words[3]) });
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
