using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;

namespace MathVectorSpace
{
    public class MathVector : Object, IMathVector
    {
        private double[] _axis;

        //Немножко конструкторов))))
        public MathVector()
        {
            _axis = new double[1] { 0 };
        }

        public MathVector(int size)
        {
            if (size <= 0)
                throw new UncorrectValue_Riker();

            _axis = new double[size];
        }

        //params?
        public MathVector(double[] values)
        {
            _axis = values;
        }

        public MathVector(MathVector mvec)
        {
            _axis = mvec._axis;
        }

        public MathVector(IMathVector imvec)
        {
            _axis = new double[imvec.Dimensions];

            for (int i = 0; i < imvec.Dimensions; i++)
            {
                _axis[i] = imvec[i];
            }
        }

        public int Dimensions { get => _axis.Length; }

        public double this[int i]
        {
            get
            {
                if (i < 0 || i >= _axis.Length)
                    throw new IncorrectIndex_Riker();

                return _axis[i];
            }
            set
            {
                if (i < 0 || i >= _axis.Length)
                    //_axis.Add(value);
                    throw new IncorrectIndex_Riker();

                _axis[i] = value;
            }

        }

        public double Length
        {
            get
            {
                double sum = 0;
                foreach (var pos in _axis)
                {
                    sum += Math.Pow(pos, 2);
                }
                return Math.Sqrt(sum);
            }

        }

        public IMathVector SumNumber(double number)
        {
            var vecResult = new MathVector(Dimensions);

            for (int i = 0; i < Dimensions; ++i)
            {
                vecResult[i] = this[i] + number;
            }

            return vecResult;
        }


        public IMathVector MultiplyNumber(double number)
        {
            var vecResult = new MathVector(Dimensions);

            for (int i = 0; i < Dimensions; ++i)
            {
                vecResult[i] = this[i] * number;
            }

            return vecResult;
        }

        public IMathVector Sum(IMathVector vector)
        {
            if (this.Dimensions != vector.Dimensions)
                throw new WrongVecSizes_Riker();

            var vecResult = new MathVector(Dimensions);

            for (int i = 0; i < Dimensions; ++i)
            {
                vecResult[i] = this[i] + vector[i];
            }

            return vecResult;
        }

        public IMathVector Multiply(IMathVector vector)
        {
            if (this.Dimensions != vector.Dimensions)
                throw new WrongVecSizes_Riker();

            var vecResult = new MathVector(Dimensions);

            for (int i = 0; i < Dimensions; ++i)
            {
                vecResult[i] = this[i] * vector[i];
            }

            return vecResult;
        }

        public double ScalarMultiply(IMathVector vector)
        {
            //Я либо дурак, либо слепой. Я не понимаю, как тут угл без угла найти
            return this.Length * vector.Length;
        }

        public double CalcDistance(IMathVector vector)
        {
            if (this.Dimensions != vector.Dimensions)
                throw new WrongVecSizes_Riker();

            double result = 0;
            for (int i = 0; i < Dimensions; ++i)
            {
                result += (Math.Pow(this[i], 2) - Math.Pow(vector[i], 2));
            }
            return Math.Sqrt(result);
        }

        public IEnumerator GetEnumerator() => _axis.GetEnumerator();

        public override string? ToString()
        {
            var str = "[";
            for (int i = 0; i < Dimensions; i++)
            {
                str += string.Format($"{_axis[i].ToString()}");
                if (i != Dimensions - 1)
                    str += ", ";
            }
            str += "]";
            return str;
        }

        /*public static IMathVector operator +(IMathVector vector, double number)
        {
            return vector.SumNumber(number);
        }

        public static IMathVector operator -(IMathVector vector, double number)
        {
            return vector.SumNumber(-number);
        }

        public static IMathVector operator *(IMathVector vector, double number)
        {
            return vector.MultiplyNumber(number);
        }

        public static IMathVector operator /(IMathVector vector, double number)
        {
            if (number == 0)
                throw new DivideByZero_Riker();

            return vector.MultiplyNumber(1 / number);
        }

        public static IMathVector operator +(IMathVector vector, IMathVector secondVec)
        {
            return vector.Sum(secondVec);
        }

        public static IMathVector operator -(IMathVector vector, IMathVector secondVec)
        {
            for (int i = 0; i < 4; i++)
            {
                secondVec[i] = -secondVec[i];
            }
            return vector.Sum(secondVec);
        }

        public static IMathVector operator *(IMathVector vector, IMathVector secondVec)
        {
            return vector.Multiply(secondVec);
        }

        public static IMathVector operator /(IMathVector vector, IMathVector secondVec)
        {
            if (vector.Length != secondVec.Length)
                throw new WrongVecSizes_Riker();

            for (int i = 0; i < _axis.Length; i++)
            {
                if (secondVec[i] == 0)
                    throw new DivideByZero_Riker();

                secondVec[i] = 1 / secondVec[i];
            }

            return vector.Multiply(secondVec);
        }

        public static double operator %(IMathVector vector, IMathVector secondVec)
        {
            if (vector.Length != secondVec.Length)
                throw new WrongVecSizes_Riker();
            return vector.ScalarMultiply(secondVec);
        }*/
    }
}
