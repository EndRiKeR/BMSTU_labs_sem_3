using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathVectorSpace;


namespace GrafsForIris
{
    struct SortedVectorsStruct
    {
        //Как называется это свойство, которое можно инициализировать без set == Кто бы мог подумать. но это readonly
        //Посчитать медиану любого поля и вывести вместе со значением на графике
        public List<MathVector> Setosa { get; }
        public List<MathVector> Versicolor { get; }
        public List<MathVector> Virginica { get; }

        public SortedVectorsStruct(List<MathVector> setosa,
                                List<MathVector> versicolor,
                                List<MathVector> virinica)
        {
            Setosa = setosa;
            Versicolor = versicolor;
            Virginica = virinica;
        }

        public override string ToString()
        {
            string tmp = string.Join(Setosa.ToString(), Versicolor.ToString(), Virginica.ToString());
            return tmp; 
        }

    }

    struct MiddleVectors
    {
        public MathVector Setosa { get; }
        public MathVector Versicolor { get; }
        public MathVector Virginica { get; }

        public MiddleVectors(MathVector setosa,
                                MathVector versicolor,
                                MathVector virinica)
        {
            Setosa = setosa;
            Versicolor = versicolor;
            Virginica = virinica;
        }

        public override string ToString()
        {
            string tmp = string.Join(Setosa.ToString(), Versicolor.ToString(), Virginica.ToString());
            return tmp;
        }
    }

    struct DistanceValues
    {
        public double Setosa { get; }
        public double Versicolor { get; }
        public double Virginica { get; }

        public DistanceValues(double setosa,
                                double versicolor,
                                double virinica)
        {
            Setosa = setosa;
            Versicolor = versicolor;
            Virginica = virinica;
        }

        public override string ToString()
        {
            string tmp = string.Join(" ", "[", Setosa.ToString(), ",", Versicolor.ToString(), ",", Virginica.ToString(), "]");
            return tmp;
        }
    }
}
