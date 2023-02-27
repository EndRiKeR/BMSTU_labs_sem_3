using System;
using MathVectorSpace;


namespace TestsPrimitiveTest
{
    class Program
    {
        static void Main(string[] args)
        {


            //тест на создание и сам факт существования вектора
            IMathVector defVec = new MathVector();
            IMathVector sizeVec = new MathVector(3);
            IMathVector doubVec = new MathVector(new double[3] { 1, 2, 3 });
            IMathVector copyIvec = new MathVector(doubVec);

            MathVector trueMVec = new MathVector(new double[3] { 1, 2, 3 });
            IMathVector copyVec = new MathVector(trueMVec);

            foreach (var point in doubVec)
            {
                Console.WriteLine($"vec axis: {point}");
            }

            Console.WriteLine($"Default Constructor: {defVec}");
            Console.WriteLine($"Size Constructor: {sizeVec}");
            Console.WriteLine($"Double[]  Constructor: {doubVec}");
            Console.WriteLine($"Copy from IMathVec Constructor: {copyIvec}");
            Console.WriteLine($"Copy from MathVec Constructor: {copyVec}");
            Console.WriteLine($"Длина вектора: {copyIvec.Length}");
            Console.WriteLine($"Количество координат вектора: {copyIvec.Dimensions}");

            try
            {
                Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\nGet and Set []\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("tmp = testVec[10];");

                //Инициализация
                IMathVector testVec = new MathVector(new double[2] { 1, 2 });
                Console.WriteLine($"TestVec: {testVec}");

                //Действия
                Console.WriteLine("Итого: ");
                double tmp = testVec[10];

            }
            catch (RikerException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\nGet and Set []\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("testVec[10] = 5;");

                //Инициализация
                IMathVector testVec = new MathVector(new double[2] { 1, 2 });
                Console.WriteLine($"TestVec: {testVec}");

                //Действия
                Console.WriteLine("Итого: ");
                testVec[10] = 1;

            }
            catch (RikerException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\nVectors / Numbers\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("tmp = vec / 2;\n");

                //Инициализация
                IMathVector testVec = new MathVector(new double[2] { 1, 2 });
                Console.WriteLine($"TestVec: {testVec}");

                //Действия
                Console.Write("Итог: ");
                IMathVector tmp = testVec / 2;
                Console.WriteLine($"{tmp}");

            }
            catch (RikerException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\nVectors / Numbers\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("tmp = vec / 0;\n");

                //Инициализация
                IMathVector testVec = new MathVector(new double[2] { 1, 2 });
                Console.WriteLine($"TestVec: {testVec}");

                //Действия
                Console.WriteLine("Итого: ");
                IMathVector tmp = testVec / 0;
                Console.WriteLine($"{tmp}");

            }
            catch (RikerException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\nVector / Vector\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("tmp = testVec / secondVec; (Good ending)\n");


                //Инициализация
                IMathVector testVec = new MathVector(new double[2] { 3, 10 });
                IMathVector secondVec = new MathVector(new double[2] { 1, 2 });

                Console.WriteLine($"TestVec: {testVec}");
                Console.WriteLine($"SecondVec: {secondVec}");


                //Действия
                IMathVector tmp = testVec / secondVec;
                Console.WriteLine($"practicalResult: {tmp}");

            }
            catch (RikerException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\nVector / Vector\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("tmp = testVec / secondVec; (Bad ending)\n");

                //Инициализация
                IMathVector testVec = new MathVector(new double[2] { 3, 10 });
                IMathVector secondVec = new MathVector(new double[2] { 1, 0 });

                Console.WriteLine($"TestVec: {testVec}");
                Console.WriteLine($"SecondVec: {secondVec}");


                //Действия
                Console.WriteLine("Итого: ");
                IMathVector tmp = testVec / secondVec;
                Console.WriteLine($"practicalResult: {tmp}");

            }
            catch (RikerException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\nVector + Number\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("tmp = testVec + 5\n");

                //Инициализация
                IMathVector testVec = new MathVector(new double[10] { 3, 10, 5, 7, 4, 3, 7, 9, 102, 3 });

                Console.WriteLine($"TestVec: {testVec}");

                //Действия
                Console.WriteLine("Итого: ");
                IMathVector tmp = testVec + 5;
                Console.WriteLine($"practicalResult: {tmp}");

            }
            catch (RikerException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\nVector - Number\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("tmp = testVec - 5\n");

                //Инициализация
                IMathVector testVec = new MathVector(new double[10] { 3, 10, 5, 7, 4, 3, 7, 9, 102, 3 });

                Console.WriteLine($"TestVec: {testVec}");

                //Действия
                Console.WriteLine("Итого: ");
                IMathVector tmp = testVec - 5;
                Console.WriteLine($"practicalResult: {tmp}");

            }
            catch (RikerException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\nVector * Number\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("tmp = testVec * 5\n");

                //Инициализация
                IMathVector testVec = new MathVector(new double[10] { 3, 10, 5, 7, 4, 3, 7, 9, 102, 3 });

                Console.WriteLine($"TestVec: {testVec}");

                //Действия
                Console.WriteLine("Итого: ");
                IMathVector tmp = testVec * 5;
                Console.WriteLine($"practicalResult: {tmp}");

            }
            catch (RikerException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\nVector / Number\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("tmp = testVec / 5\n");

                //Инициализация
                IMathVector testVec = new MathVector(new double[10] { 3, 10, 5, 7, 4, 3, 7, 9, 102, 3 });

                Console.WriteLine($"TestVec: {testVec}");

                //Действия
                Console.WriteLine("Итого: ");
                IMathVector tmp = testVec / 5;
                Console.WriteLine($"practicalResult: {tmp}");

            }
            catch (RikerException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\nVector * Vector\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("tmp = testVec * secondVec;\n");

                //Инициализация
                IMathVector testVec = new MathVector(new double[4] { 3, 10, 4, 7 });
                IMathVector secondVec = new MathVector(new double[4] { 1, 2, 9, 3 });

                Console.WriteLine($"TestVec: {testVec}");
                Console.WriteLine($"SecondVec: {secondVec}");


                //Действия
                IMathVector tmp = testVec * secondVec;
                Console.WriteLine($"practicalResult: {tmp}");

            }
            catch (RikerException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\nVector % Vector\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("tmp = testVec % secondVec;\n");

                //Инициализация
                IMathVector testVec = new MathVector(new double[2] { 3, 10 });
                IMathVector secondVec = new MathVector(new double[2] { 1, 2 });

                Console.WriteLine($"TestVec: {testVec}");
                Console.WriteLine($"SecondVec: {secondVec}");


                //Действия
                double tmp = testVec % secondVec;
                Console.WriteLine($"practicalResult: {tmp}");

            }
            catch (RikerException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\nVector != Vector\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("tmp = testVec % secondVec;\n");

                //Инициализация
                IMathVector testVec = new MathVector(new double[3] { 3, 10, 5 });
                IMathVector secondVec = new MathVector(new double[2] { 1, 2 });

                Console.WriteLine($"TestVec: {testVec}");
                Console.WriteLine($"SecondVec: {secondVec}");

                //Действия
                IMathVector tmp = testVec / secondVec;
                Console.WriteLine($"practicalResult: {tmp}");

            }
            catch (RikerException e)
            {
                Console.WriteLine(e.Message);
            }





        }
    }
}

/* TODO: 
 * +) Свои Exception
 * 2) Нормальные Unit тесты
 * 3) Угол скаляра????
 * +) MathVector.MathVector????
 * +) Для vector Act vector сделать проверку на равенство длин векторов
 * +) IMasthVec = var
 * +) Иммутабельность - неизменяемость. Хорошо, так как безопасно
 * +) Конструктор
 * +) Лист в массив
 * -) IMathVector(MathVector)
 * 
 * 10) for each
 * 11) bp b
 * 
 * 
 */
