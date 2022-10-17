using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MathVectorSpace
{
    public interface IMathVector : IEnumerable
    {
        /// <summary>
        /// Получить размерность вектора (количество координат).
        /// </summary>
        int Dimensions { get; }

        /// <summary>
        /// Индексатор для доступа к элементам вектора. Нумерация с нуля.
        /// </summary>
        double this[int i] { get; set; }

        /// <summary>Рассчитать длину (модуль) вектора.</summary>
        double Length { get; }

        /// <summary>Покомпонентное сложение с числом.</summary>
        IMathVector SumNumber(double number);

        /// <summary>Покомпонентное умножение на число.</summary>
        IMathVector MultiplyNumber(double number);

        /// <summary>Сложение с другим вектором.</summary>
        IMathVector Sum(IMathVector vector);

        /// <summary>Покомпонентное умножение с другим вектором.</summary>
        IMathVector Multiply(IMathVector vector);

        /// <summary>Скалярное умножение на другой вектор.</summary>
        double ScalarMultiply(IMathVector vector);

        /// <summary>
        /// Вычислить Евклидово расстояние до другого вектора.
        /// </summary>
        double CalcDistance(IMathVector vector);

        /// <summary>
        /// Создает новый вектор, координаты которого равны сумме координат данного вектора и данного числа.
        /// </summary>
        /// <param name="vector">Вектор</param>
        /// <param name="number">Число</param>
        /// <returns>Новый вектор IMathVector</returns>
        public static IMathVector operator +(IMathVector vector, double number)
        {
            return vector.SumNumber(number);
        }

        /// <summary>
        /// Создает новый вектор, координаты которого равны разности координат данного вектора и данного числа.
        /// </summary>
        /// <param name="vector">Вектор</param>
        /// <param name="number">Число</param>
        /// <returns>Новый вектор IMathVector</returns>
        public static IMathVector operator -(IMathVector vector, double number)
        {
            return vector.SumNumber(-number);
        }

        /// <summary>
        /// Создает новый вектор, координаты которого равны произведению координат данного вектора и данного числа.
        /// </summary>
        /// <param name="vector">Вектор</param>
        /// <param name="number">Число</param>
        /// <returns>Новый вектор IMathVector</returns>
        public static IMathVector operator *(IMathVector vector, double number)
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
        public static IMathVector operator /(IMathVector vector, double number)
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
        public static IMathVector operator +(IMathVector vector, IMathVector secondVec)
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
        public static IMathVector operator -(IMathVector vector, IMathVector secondVec)
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
        public static IMathVector operator *(IMathVector vector, IMathVector secondVec)
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
        public static IMathVector operator /(IMathVector vector, IMathVector secondVec)
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
        public static double operator %(IMathVector vector, IMathVector secondVec)
        {
            if (vector.Dimensions != secondVec.Dimensions)
                throw new WrongVecSizes_Riker();

            return vector.ScalarMultiply(secondVec);
        }
    }
}
