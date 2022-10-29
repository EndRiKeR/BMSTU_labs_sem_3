using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrafsForIris
{
    struct IrisStruct
    {
        public double SepalLength { get; }
        public double SepalWidth { get; }
        public double PetalLength { get; }
        public double PetalWidth { get; }
        public string Species { get; }

        public IrisStruct(double sl, double sw, double pl, double pw, string species)
        {
            SepalLength = sl;
            SepalWidth = sw;
            PetalLength = pl;
            PetalWidth = pw;
            Species = species;
        }

        public override string ToString()
        {
            return $"{Species}: SepalLength = {SepalLength}, SepalWidth = {SepalWidth}, PetalLength = {PetalLength}, PetalWidth = {PetalWidth}\n";
        }

    }

    struct ListsOfIris
    {
        public List<IrisStruct> Setosa { get; }
        public List<IrisStruct> Versicolor { get; }
        public List<IrisStruct> Virginica { get; }

        public ListsOfIris(List<IrisStruct> setosa,
                                List<IrisStruct> versicolor,
                                List<IrisStruct> virinica)
        {
            Setosa = setosa;
            Versicolor = versicolor;
            Virginica = virinica;
        }

        public override string ToString()
        {
            string main = "";

            main += "Setosa main:\n";

            foreach (var point in Setosa)
            {
                main += point.ToString();
            }

            main += "\nVersicolor main:\n";

            foreach (var point in Versicolor)
            {
                main += point.ToString();
            }

            main += "\nVirinica main:\n";

            foreach (var point in Virginica)
            {
                main += point.ToString();
            }

            return main;
        }

    }

}
