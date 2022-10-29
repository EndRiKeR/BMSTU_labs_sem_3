using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;

namespace MathVectorSpace
{
    /// <summary>
    /// Класс, представляющий математический вектор.
    /// Наследуется от Object и IMathVector
    /// </summary>
    public class MathVector : Object, IMathVector
    {
        private double[] _axis;

        /// <summary>
        /// Конструктор по умолчанию.
        /// Создает нулевой вектор в плоскости Oxy.
        /// </summary>
        public MathVector()
        {
            _axis = new double[2] { 0, 0 };
        }

        /// <summary>
        /// Конструтор с параметром.
        /// Создает вестор в size-мерной плоскости.
        /// </summary>
        /// <exception cref="UncorrectValue_Riker">Неверное значение</exception>
        /// <param name="size">Количество осей плоскости</param>
        public MathVector(int size)
        {
            if (size <= 0)
                throw new UncorrectValue_Riker();

            _axis = new double[size];
        }

        /// <summary>
        /// Конструктор с параметром.
        /// Создает вектор по данному массиву координат.
        /// </summary>
        /// <param name="values">Массив координат</param>
        /// <exception cref="UncorrectValue_Riker">Если подан массив = 0</exception>>
        public MathVector(double[] values)
        {
            if (values.Length <= 0)
                throw new UncorrectValue_Riker();
            _axis = values;
        }

        /// <summary>
        /// Конструктор копирования.
        /// Создает копию данного вектора.
        /// </summary>
        /// <param name="mvec">Копируемый вектор</param>
        public MathVector(MathVector mvec)
        {
            _axis = mvec._axis;
        }

        /// <summary>
        /// Конструктор с параметром.
        /// Создает копию вектора, реализующего IMathVector.
        /// </summary>
        /// <param name="imvec">Копируемый вектор</param>
        public MathVector(IMathVector imvec)
        {
            _axis = new double[imvec.Dimensions];

            for (int i = 0; i < imvec.Dimensions; i++)
            {
                _axis[i] = imvec[i];
            }
        }

        /// <summary>
        /// Получить размерность вектора (количество координат).
        /// </summary>
        public int Dimensions { get => _axis.Length; }

        /// <summary>
        /// Доступ к координатам вектора по средством индекса.
        /// При некорректном индексе выкидывает IncorrectIndex_Riker().
        /// </summary>
        /// <exception cref="IncorrectIndex_Riker">Некорректный индекс</exception>
        /// <param name="i">Индекс</param>
        /// <returns>Доступ к значению координаты с возможностью чтения и изменения</returns>
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
                    throw new IncorrectIndex_Riker();

                _axis[i] = value;
            }

        }

        /// <summary>
        /// Возвращаем длину данного вектора.
        /// </summary>
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

        /// <summary>
        /// Создает новый вектор, относительно данного.
        /// Координаты нового вектора увеличены на значение number.
        /// </summary>
        /// <param name="number">Значение прироста координат</param>
        /// <returns>Новый вектор с измененными значениями</returns>
        public IMathVector SumNumber(double number)
        {
            var vecResult = new MathVector(Dimensions);

            for (int i = 0; i < Dimensions; ++i)
            {
                vecResult[i] = this[i] + number;
            }

            return vecResult;
        }

        /// <summary>
        /// Создает новый вектор, относительно данного.
        /// Координаты нового вектора увеличены в number раз.
        /// </summary>
        /// <param name="number">Множиетли координат</param>
        /// <returns>Новый вектор с измененными значениями</returns>
        public IMathVector MultiplyNumber(double number)
        {
            var vecResult = new MathVector(Dimensions);

            for (int i = 0; i < Dimensions; ++i)
            {
                vecResult[i] = this[i] * number;
            }

            return vecResult;
        }

        /// <summary>
        /// Создает новый вектор, относительно данного.
        /// Координаты нового вектора равны сумме соответствующих координат 2-х данных векторов.
        /// </summary>
        /// <exception cref="WrongVecSizes_Riker">Мерности данных векторов не равны</exception>
        /// <param name="vector">Второй вектор</param>
        /// <returns>Новый вектор с координатами, равными сумме 2-х данных</returns>
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

        /// <summary>
        /// Создает новый вектор, относительно данного.
        /// Координаты нового вектора равен произведению соответствующих координат 2-х данных векторов.
        /// </summary>
        /// <exception cref="WrongVecSizes_Riker">Мерности данных векторов не равны</exception>
        /// <param name="vector">Второй вектор</param>
        /// <returns>Новый вектор с координатами, равными произведению 2-х данных</returns>
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

        /// <summary>
        /// Находит скалярное произведение двух данных векторов.
        /// </summary>
        /// <param name="vector">Второй вектор</param>
        /// <returns>Скалярное произведение</returns>
        public double ScalarMultiply(IMathVector vector)
        {
            //Я либо дурак, либо слепой. Я не понимаю, как тут угл без угла найти
            return this.Length * vector.Length;
        }

        /// <summary>
        /// Вычисляет расстояние между 2-мя данными векторами.
        /// </summary>
        /// <exception cref="WrongVecSizes_Riker">Мерности данных векторов не равны</exception>
        /// <param name="vector">Второй вектор</param>
        /// <returns>Возвращает расстояние</returns>
        public double CalcDistance(IMathVector vector)
        {
            if (this.Dimensions != vector.Dimensions)
                throw new WrongVecSizes_Riker();

            double practicalResult = 0;
            for (int i = 0; i < Dimensions; ++i)
            {
                practicalResult += Math.Pow(this[i] - vector[i], 2);
            }
            return Math.Sqrt(practicalResult);
        }

        /// <summary>
        /// Возвращает Enumerator.
        /// </summary>
        /// <returns>Возвращает Enumerator</returns>
        public IEnumerator GetEnumerator() => _axis.GetEnumerator();

        /// <summary>
        /// Преобращает вектор в строку
        /// </summary>
        /// <returns>Строка - вектор</returns>
        public override string ToString()
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

        /// <summary>
        /// Сравнение двух MathVector.
        /// </summary>
        /// <param name="vec">Первый вектор</param>
        /// <param name="second">Второй вектор</param>
        /// <returns>Возвращает true, если все соответствующие координаты равны</returns>
        /// <exception cref="WrongVecSizes_Riker">При неравенстве длин векторов.<exception>
        public static bool operator ==(MathVector vec, MathVector second)
        {
            if (vec.Dimensions != second.Dimensions)
                throw new WrongVecSizes_Riker();

            bool practicalResult = true;

            for (int i = 0; i < vec.Dimensions; ++i)
            {
                if (vec[i] != second[i])
                {
                    practicalResult = false;
                    break;
                }
            }
            return practicalResult;
        }

        /// <summary>
        /// Сравнение двух MathVector.
        /// </summary>
        /// <param name="vec">Первый вектор</param>
        /// <param name="second">Второй вектор</param>
        /// <returns>Возвращает true, если хотя бы одни координаты не равны.</returns>
        /// <exception cref="WrongVecSizes_Riker">При неравенстве длин векторов.<exception>
        public static bool operator !=(MathVector vec, MathVector second)
        {
            if (vec.Dimensions != second.Dimensions)
                throw new WrongVecSizes_Riker();

            bool practicalResult = true;

            for (int i = 0; i < vec.Dimensions; ++i)
            {
                if (vec[i] != second[i])
                {
                    practicalResult = false;
                    break;
                }
            }
            return !practicalResult;
        }

        /// <summary>
        /// Переопределение метода Equales для MathVector.
        /// </summary>
        /// <param name="obj">Объект для сравнения</param>
        /// <returns>Результат сравнения.</returns>
        public override bool Equals(Object obj)
        {
            return this == (MathVector)obj;
        }

        /// <summary>
        /// Создает новый вектор, координаты которого равны сумме координат данного вектора и данного числа.
        /// </summary>
        /// <param name="vector">Вектор</param>
        /// <param name="number">Число</param>
        /// <returns>Новый вектор IMathVector</returns>
        public static IMathVector operator +(MathVector vector, double number)
        {
            return vector.SumNumber(number);
        }

        /// <summary>
        /// Создает новый вектор, координаты которого равны разности координат данного вектора и данного числа.
        /// </summary>
        /// <param name="vector">Вектор</param>
        /// <param name="number">Число</param>
        /// <returns>Новый вектор IMathVector</returns>
        public static IMathVector operator -(MathVector vector, double number)
        {
            return vector.SumNumber(-number);
        }

        /// <summary>
        /// Создает новый вектор, координаты которого равны произведению координат данного вектора и данного числа.
        /// </summary>
        /// <param name="vector">Вектор</param>
        /// <param name="number">Число</param>
        /// <returns>Новый вектор IMathVector</returns>
        public static IMathVector operator *(MathVector vector, double number)
        {
            return vector.MultiplyNumber(number);
        }

        /// <summary>
        /// Создает новый вектор, координаты которого равны частному координат данного вектора и данного числа.
        /// </summary>
        /// <exception cref="DivideByZero_Riker">Один из элементов Второго вектора равен 0</exception>
        /// <param name="vector">Вектор</param>
        /// <param name="number">Число</param>
        /// <returns>Новый вектор IMathVector</returns>
        public static IMathVector operator /(MathVector vector, double number)
        {
            if (number == 0)
                throw new DivideByZero_Riker();

            return vector.MultiplyNumber(1 / number);
        }

        /// <summary>
        /// Создает новый вектор, координаты которого равны сумме соответствующих координат 2-х данных векторов.
        /// </summary>
        /// <exception cref="WrongVecSizes_Riker">Мерности данных векторов не равны</exception>
        /// <param name="vector">Первый вектор</param>
        /// <param name="secondVec">Второй вектор</param>
        /// <returns>Новый вектор IMathVector</returns>
        public static IMathVector operator +(MathVector vector, MathVector secondVec)
        {
            return vector.Sum(secondVec);
        }

        /// <summary>
        /// Создает новый вектор, координаты которого равны разности соответствующих координат 2-х данных векторов.
        /// </summary>
        /// <exception cref="WrongVecSizes_Riker">Мерности данных векторов не равны</exception>
        /// <param name="vector">Первый вектор</param>
        /// <param name="secondVec">Второй вектор</param>
        /// <returns>Новый вектор IMathVector</returns>
        public static IMathVector operator -(MathVector vector, MathVector secondVec)
        {
            if (vector.Dimensions != secondVec.Dimensions)
                throw new WrongVecSizes_Riker();

            for (int i = 0; i < vector.Dimensions; i++)
            {
                secondVec[i] = -secondVec[i];
            }
            return vector.Sum(secondVec);
        }

        /// <summary>
        /// Создает новый вектор, координаты которого равны произведению соответствующих координат 2-х данных векторов.
        /// </summary>
        /// <exception cref="WrongVecSizes_Riker">Мерности данных векторов не равны</exception>
        /// <param name="vector">Первый вектор</param>
        /// <param name="secondVec">Второй вектор</param>
        /// <returns>Новый вектор IMathVector</returns>
        public static IMathVector operator *(MathVector vector, MathVector secondVec)
        {
            return vector.Multiply(secondVec);
        }

        /// <summary>
        /// Создает новый вектор, координаты которого равны частному соответствующих координат 2-х данных векторов.
        /// </summary>
        /// <exception cref="WrongVecSizes_Riker">Мерности данных векторов не равны</exception>
        /// <exception cref="DivideByZero_Riker">Один из элементов Второго вектора равен 0</exception>
        /// <param name="vector">Первый вектор</param>
        /// <param name="secondVec">Второй вектор</param>
        /// <returns>Новый вектор IMathVector</returns>
        public static IMathVector operator /(MathVector vector, MathVector secondVec)
        {
            if (vector.Dimensions != secondVec.Dimensions)
                throw new WrongVecSizes_Riker();

            for (int i = 0; i < vector.Dimensions; i++)
            {
                if (secondVec[i] == 0)
                    throw new DivideByZero_Riker();

                secondVec[i] = 1 / secondVec[i];
            }

            return vector.Multiply(secondVec);
        }

        /// <summary>
        /// Возвращает скалярное произведение двух векторов.
        /// </summary>
        /// <exception cref="WrongVecSizes_Riker">Мерности данных векторов не равны</exception>
        /// <param name="vector">Первый вектор</param>
        /// <param name="secondVec">Второй вектор</param>
        /// <returns>Новый вектор IMathVector</returns>
        public static double operator %(MathVector vector, MathVector secondVec)
        {
            if (vector.Dimensions != secondVec.Dimensions)
                throw new WrongVecSizes_Riker();

            return vector.ScalarMultiply(secondVec);
        }
    }
}
