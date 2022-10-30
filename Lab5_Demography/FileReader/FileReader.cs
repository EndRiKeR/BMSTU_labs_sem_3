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

        public Dictionary<int, double> ParceDataInitialAgeData(string[] strings)
        {
            try
            {
                if (strings[0] != _initalAgeDataType && strings[0] != _deathRule)
                    throw new RikerFileWrongTypeException(strings[0] == _initalAgeDataType ? _initalAgeDataType : _deathRule);

                Dictionary<int, double> demographySplit = new Dictionary<int, double>();

                for (int i = 1; i < strings.Length; ++i)
                {
                    string row = strings[i];
                    string[] words = row.Split(',');

                    if (words.Length != 5)
                        throw new RikerFileWrongDataException();

                    for (int j = 0; j < 4; ++j)
                    {
                        if (String.IsNullOrWhiteSpace(words[j]))
                            throw new RikerFileWrongDataException();

                        words[j] = words[j].Replace(".", ",");
                    }

                }
            }
            catch (RikerBaseFileExceptions)
            {
                throw;
            }
        }

        private


    }
}
