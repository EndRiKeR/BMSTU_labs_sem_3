using System;
using MathVector;

namespace Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //testForWork();

            //тест на создание и сам факт существования вектора
            var vec = new MathVector.MathVector();

            vec.AddAxis(3);
            vec.AddAxis(4);

            Console.WriteLine($"Длина вектора: {vec.Length}");
            Console.WriteLine($"Количество координат вектора: {vec.Dimensions}");

            //тест на ловлю ошибок
            try
            {
                Console.WriteLine("tmp = vec[10]");
                var tmp = vec[10];
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                Console.WriteLine("vec[10] = 5");
                vec[10] = 5;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                Console.WriteLine("tmp = vec / 2;");
                var tmp = vec / 2;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                Console.WriteLine("tmp = vec / 0");
                var tmp = vec / 0;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                Console.WriteLine("tmp = vec / second - good second");
                MathVector.MathVector second = new MathVector.MathVector();
                second.AddAxis(1);
                second.AddAxis(2);

                var tmp = vec / second;

                Console.WriteLine(tmp.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


            try
            {
                Console.WriteLine("tmp = vec / second - bad second");

                MathVector.MathVector second = new MathVector.MathVector();
                second.AddAxis(1);
                second.AddAxis(0);

                var tmp = vec / second;

                Console.WriteLine(tmp.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }

        private void testForWork()
        {
            var vec = new MathVector.MathVector();

            vec.AddAxis(5);
            vec.AddAxis(6);

            Console.WriteLine($"Длина вектора: {vec.Length}");
            Console.WriteLine($"Количество координат вектора: {vec.Dimensions}");

        }
    }
}

/* TODO: 
 * 1) Свои Exception
 * 2) Нормальные Unit тесты
 * 3) Угол скаляра????
 * 4) MathVector.MathVector????
 * 5) Для vector Act vector сделать проверку на равенство длин векторов
 * 6) IMasthVec = var
 * 7) Иммутабельность
 * 8) Конструктор
 * 9) Лист в массив
 * 
 * 
 */
