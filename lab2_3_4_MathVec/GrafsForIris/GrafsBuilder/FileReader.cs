using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace GrafsForIris
{
    class FileReader
    {
        private string _filePath;

        public void ChooseFilePath()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Файл Iris|*.csv";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                _filePath = openFileDialog.FileName;
        }

        private string[] ReadFromFile()
        {
            if (!File.Exists(_filePath))
                throw new Exception();

           

            return File.ReadAllLines(_filePath);
        }

        private IrisStruct[] ReformTextFromFile()
        { 
            string[] stringsFromFile = ReadFromFile();

            if (stringsFromFile[0] != "sepal_length,sepal_width,petal_length,petal_width,species")
                throw new Exception();

            IrisStruct[] irisesPoints = new IrisStruct[stringsFromFile.Length - 1];

            for (int i = 1; i < stringsFromFile.Length; ++i)
            {
                string row = stringsFromFile[i];
                string[] words = row.Split(',');

                if (words.Length > 5)
                    throw new Exception();

                for (int j = 0; j < 4; ++j)
                {
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

        public ListsOfIris ReadReformAndResortIrisPoints()
        {
            IrisStruct[] irisesPoints = ReformTextFromFile();

            List<IrisStruct> setosaPoint = new List<IrisStruct>();
            List<IrisStruct> versicolorPoint = new List<IrisStruct>();
            List<IrisStruct> verginicaPoint = new List<IrisStruct>();

            foreach (var point in irisesPoints)
            {
                switch(point.Species)
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
                        throw new Exception();
                }
            }

            ListsOfIris listsOfIris = new ListsOfIris(setosaPoint, verginicaPoint, versicolorPoint);

            return listsOfIris;
        }


    }
}
