using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using MathVectorSpace;

namespace GrafsForIris.GrafsBuilder
{
    class FileReader
    {
        private string _filePath;
        private const string _fileType = "sepal_length,sepal_width,petal_length,petal_width,species";
        private const string _irisType = "setosaversicolorvirginica";

        private const int _maxSizeInByte = 5000;
        private const int _minSizeInByte = 60;

        /// <summary>
        /// Выдает диалоговое окно и берет путь *.csv 
        /// </summary>
        public void ChooseFilePath()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Файл Iris|*.csv";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                _filePath = openFileDialog.FileName;
        }

        /// <summary>
        /// Считывает строки из файла
        /// </summary>
        /// <returns>Массив строк</returns>
        /// <exception cref="RikerFileNotExistsException"></exception>
        /// <exception cref="RikerFileWrongSizeExceptions"></exception>
        private string[] ReadFromFile()
        {
            if (!File.Exists(_filePath))
                throw new RikerFileNotExistsException();

            FileInfo fileInfo = new FileInfo(_filePath);

            if (fileInfo.Length > _maxSizeInByte || fileInfo.Length < _minSizeInByte)
                throw new RikerFileWrongSizeExceptions();

            return File.ReadAllLines(_filePath);
        }

        /// <summary>
        /// Преобразует строки в массив точек Ирисов
        /// </summary>
        /// <returns>массив точек Ирисов</returns>
        /// <exception cref="RikerFileWrongTypeExceptions"></exception>
        /// <exception cref="RikerFileWrongDataExceptions"></exception>
        private IrisStruct[] ReformTextFromFile()
        { 
            try
            {
                string[] stringsFromFile = ReadFromFile();

                if (stringsFromFile[0] != _fileType)
                    throw new RikerFileWrongTypeExceptions(_fileType);

                IrisStruct[] irisesPoints = new IrisStruct[stringsFromFile.Length - 1];

                for (int i = 1; i < stringsFromFile.Length; ++i)
                {
                    string row = stringsFromFile[i];
                    string[] words = row.Split(',');

                    if (words.Length != 5)
                        throw new RikerFileWrongDataExceptions();

                    for (int j = 0; j < 4; ++j)
                    {
                        if (String.IsNullOrWhiteSpace(words[j]))
                            throw new RikerFileWrongDataExceptions();

                        words[j] = words[j].Replace(".", ",");
                    }

                    IrisStruct irisStruct = new IrisStruct(Convert.ToDouble(words[0]),
                                                            Convert.ToDouble(words[1]),
                                                            Convert.ToDouble(words[2]),
                                                            Convert.ToDouble(words[3]),
                                                            words[4]);

                    irisesPoints[i - 1] = irisStruct;
                }

                return irisesPoints;
            }
            catch(RikerBaseFileExceptions)
            {
                throw;
            }
        }

        /// <summary>
        /// Сортирует массив точек Ирисов по типам
        /// </summary>
        /// <returns>Отсортированные точки по массивам</returns>
        /// <exception cref="RikerFileUnexpectedExceptions"></exception>
        public ListsOfIris ReadReformAndResortIrisPoints()
        {
            try
            {
                IrisStruct[] irisesPoints = ReformTextFromFile();

                List<IrisStruct> setosaPoint = new List<IrisStruct>();
                List<IrisStruct> versicolorPoint = new List<IrisStruct>();
                List<IrisStruct> verginicaPoint = new List<IrisStruct>();

                foreach (var point in irisesPoints)
                {
                    switch (point.Species)
                    {
                        case "setosa":
                            setosaPoint.Add(point);
                            break;
                        case "versicolor":
                            versicolorPoint.Add(point);
                            break;
                        case "virginica":
                            verginicaPoint.Add(point);
                            break;
                        default:
                            throw new RikerWrongIrisTypeException(point.Species);
                    }
                }

                ListsOfIris listsOfIris = new ListsOfIris(setosaPoint, versicolorPoint, verginicaPoint);

                return listsOfIris;
            }
            catch(RikerBaseFileExceptions)
            {
                throw;
            }
        }


    }
}
