using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathVectorSpace;

namespace GrafsForIris
{
    internal class VectorWorker
    {
        public SortedVectorsStruct FromIrisesToVectors(ListsOfIris irises)
        {
            List<MathVector> setosaVecs = new List<MathVector>();
            List<MathVector> versicolorVecs = new List<MathVector>();
            List<MathVector> verginicaVecs = new List<MathVector>();

            foreach (var iris in irises.Setosa)
            {
                MathVector tmp = new MathVector(new double[] { iris.SepalLength, iris.SepalWidth, iris.PetalLength, iris.PetalWidth });

                setosaVecs.Add(tmp);
            }

            foreach (var iris in irises.Versicolor)
            {
                MathVector tmp = new MathVector(new double[] { iris.SepalLength, iris.SepalWidth, iris.PetalLength, iris.PetalWidth });

                versicolorVecs.Add(tmp);
            }

            foreach (var iris in irises.Virginica)
            {
                MathVector tmp = new MathVector(new double[] { iris.SepalLength, iris.SepalWidth, iris.PetalLength, iris.PetalWidth });

                verginicaVecs.Add(tmp);
            }

            SortedVectorsStruct sortedVector = new SortedVectorsStruct(setosaVecs, versicolorVecs, verginicaVecs);

            return sortedVector;
        }

        public MiddleVectors CountMiddleForVectors(SortedVectorsStruct vecs)
        {
            MathVector setosaMiddle = new MathVector(new double[4]);
            MathVector versicolorMiddle = new MathVector(new double[4]);
            MathVector verginicaMiddle = new MathVector(new double[4]);

            foreach (var vec in vecs.Setosa)
            {
                setosaMiddle = (MathVector)(setosaMiddle + vec);
            }

            foreach (var vec in vecs.Versicolor)
            { 
                versicolorMiddle = (MathVector)(versicolorMiddle + vec);
            }
              
            foreach (var vec in vecs.Virginica)
            {
                verginicaMiddle = (MathVector)(verginicaMiddle + vec);
            }

            setosaMiddle = (MathVector)(setosaMiddle / vecs.Setosa.Count);
            versicolorMiddle = (MathVector)(versicolorMiddle / vecs.Versicolor.Count);
            verginicaMiddle = (MathVector)(verginicaMiddle / vecs.Virginica.Count);

            return new MiddleVectors(setosaMiddle, versicolorMiddle, verginicaMiddle);

        }

        public DistanceValues CountDistanceBetweenVectors(MiddleVectors vectors)
        {
            double distSetosaAndVersicolor = vectors.Setosa.CalcDistance(vectors.Versicolor);
            double distVersicolorAndVerginica = vectors.Versicolor.CalcDistance(vectors.Virginica);
            double distVerginicaAndSetosa = vectors.Virginica.CalcDistance(vectors.Setosa);

            return new DistanceValues(distSetosaAndVersicolor, distVersicolorAndVerginica, distVerginicaAndSetosa);
        }

        public DistanceValues CountVectorsMedians(SortedVectorsStruct vectors)
        {
            List<double> setosaVec = new List<double>();
            List<double> versicolorVec = new List<double>();
            List<double> virginicaVec = new List<double>();

            foreach (var vec in vectors.Setosa)
            {
                setosaVec.Add(vec[0]);
            }

            foreach (var vec in vectors.Versicolor)
            {
                versicolorVec.Add(vec[0]);
            }

            foreach (var vec in vectors.Virginica)
            {
                virginicaVec.Add(vec[0]);
            }

            double distSetosaAndVersicolor = GetMedian(setosaVec);
            double distVersicolorAndVerginica = GetMedian(versicolorVec);
            double distVerginicaAndSetosa = GetMedian(virginicaVec);

            return new DistanceValues(distSetosaAndVersicolor, distVersicolorAndVerginica, distVerginicaAndSetosa);
        }

        private double GetMedian(List<double> list)
        {
            List<double> tmp = new List<double>(list);

            tmp.Sort();

            int sizeHalf = tmp.Count / 2;
            int sizeDivideTrash = tmp.Count % 2;

            if (tmp.Count != 1)
                return (sizeDivideTrash) != 0 ? tmp[sizeHalf] : ((tmp[sizeHalf - 1] + tmp[sizeHalf]) / 2);
            else
                return tmp[0];

        }

    }
}
