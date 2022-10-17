using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathVectorSpace;

namespace TestProject2.Tests
{
    [TestClass]
    public partial class AllBasicTests
    {

        // + num, 1 ситуация (Normal)

        [TestMethod]
        public void VectorPlusNumber_Normal_Test()
        {
            IMathVector vectorFirst = new MathVector(new double[] { 1, 2, 3 });
            double number = 1;
            IMathVector theoriticalResult = new MathVector(new double[] { 2, 3, 4 });

            IMathVector practicalResult = vectorFirst + number;
            Assert.AreEqual(practicalResult, theoriticalResult);
        }

        // - num, 1 ситуация (Normal)

        [TestMethod]
        public void VectorMinusNumber_Normal_Test()
        {
            IMathVector vectorFirst = new MathVector(new double[] { 1, 2, 3 });
            double number = 1;
            IMathVector theoriticalResult = new MathVector(new double[] { 0, 1, 2 });

            IMathVector practicalResult = vectorFirst - number;
            Assert.AreEqual(practicalResult, theoriticalResult);
        }

        // * num, 1 ситуация (Normal)

        [TestMethod]
        public void VectorMultiplyNumber_Normal_Test()
        {
            IMathVector vectorFirst = new MathVector(new double[] { 1, 2, 3 });
            double number = 2;
            IMathVector theoriticalResult = new MathVector(new double[] { 2, 4, 6 });

            IMathVector practicalResult = vectorFirst * number;
            Assert.AreEqual(practicalResult, theoriticalResult);
        }

        // /, 2 ситуации (Normal, DivideByZero)

        [TestMethod]
        public void VectorDivideNumber_Normal_Test()
        {
            IMathVector vectorFirst = new MathVector(new double[] { 2, 4, 6 });
            double number = 2;
            IMathVector theoriticalResult = new MathVector(new double[] { 1, 2, 3 });

            IMathVector practicalResult = vectorFirst / number;
            Assert.AreEqual(practicalResult, theoriticalResult);
        }

        [TestMethod]
        public void VectorDivideNumber_DivideByZero_Test()
        {
            IMathVector vectorFirst = new MathVector(new double[] { 2, 4, 6 });
            double number = 0;
            Assert.ThrowsException<DivideByZero_Riker>(() => vectorFirst / number);
        }

        // CalculateDistance, 2 ситуация (Normal, DiffSizes)

        [TestMethod]
        public void VectorCalculateDistance_Normal_Test()
        {
            IMathVector vectorFirst = new MathVector(new double[] { 1, 1 });
            IMathVector vectorSecond = new MathVector(new double[] { 4, 5 });

            double practicalResult = vectorSecond.CalcDistance(vectorFirst);

            Assert.AreEqual(practicalResult, 5);
        }

        [TestMethod]
        public void VectorCalculateDistance_DifferentSizes_Test()
        {
            IMathVector vectorFirst = new MathVector(new double[] { 1 });
            IMathVector vectorSecond = new MathVector(new double[] { 4, 5 });

            Assert.ThrowsException<WrongVecSizes_Riker>(() => vectorSecond.CalcDistance(vectorFirst));
        }

        // ScalarMult, 2 ситуации (Normal, DiffSizes)

        [TestMethod]
        public void VectorScalarMultiplyVector_Normal_Test()
        {
            IMathVector vectorFirst = new MathVector(new double[] { 1, 2, 3 });
            IMathVector vectorSecond = new MathVector(new double[] { 3, 2, 1 });

            double practicalResult = vectorFirst % vectorSecond;

            Assert.AreEqual(practicalResult, 14);
        }

        [TestMethod]
        public void VectorScalarMultiplyVector_DifferentSizes_Test()
        {
            IMathVector vectorFirst = new MathVector(new double[] { 1, 2 });
            IMathVector vectorSecond = new MathVector(new double[] { 3, 2, 1 });

            Assert.ThrowsException<WrongVecSizes_Riker>(() => vectorFirst % vectorSecond);
        }

        [TestMethod]
        public void Vector_Equale_Normal_Test()
        {
            double[] arr = new double[3] { 1, 2, 3 };
            double[] arrBack = new double[3] { 3, 2, 1 };

            IMathVector vectorFirst = new MathVector(arr);
            IMathVector vectorSecond = new MathVector(arrBack);

            IMathVector vector1Copy = new MathVector(arr);
            IMathVector vector2Copy = new MathVector(arrBack);

            Assert.IsTrue((MathVector)vectorFirst == (MathVector)vector1Copy);
            Assert.IsTrue((MathVector)vectorSecond == (MathVector)vector2Copy);
        }

        [TestMethod]
        public void VectorToString_Normal_Test()
        {
            IMathVector vectorFirst = new MathVector(new double[] { 1, 2, 3 });
            string temp = "[1, 2, 3]";

            string practicalResult = vectorFirst.ToString();

            Assert.AreEqual(temp, practicalResult);
        }

        [TestMethod]
        public void VectorSetValue_Normal_Test()
        {
            IMathVector vectorFirst = new MathVector(new double[] { 1, 2, 3 });
            IMathVector vectorResult = new MathVector(new double[] { 1, 0, 3 });

            vectorFirst[1] = 0;

            Assert.AreEqual(vectorFirst, vectorResult);
        }

        [TestMethod]
        public void VectorSetValue_IncorrectIndex_MoreThenZero_Test()
        {
            IMathVector vectorFirst = new MathVector(new double[] { 1, 2, 3 });

            Assert.ThrowsException<IncorrectIndex_Riker>(() => vectorFirst[1000] = 0);
        }

        [TestMethod]
        public void VectorSetValue_IncorrectIndex_ThenZero_Test()
        {
            IMathVector vectorFirst = new MathVector(new double[] { 1, 2, 3 });

            Assert.ThrowsException<IncorrectIndex_Riker>(() => vectorFirst[-1] = 0);
        }

        //Конструкторы
        [TestMethod]
        public void VectorConstructor_DefaultCon_Normal_Test()
        {
            IMathVector vectorFirst = new MathVector();
            IMathVector vectorSecond = new MathVector(new double[2] { 0, 0 });

            Assert.AreEqual(vectorFirst, vectorSecond);
        }

        [TestMethod]
        public void VectorConsructor_SizeCon_Normal_Test()
        {
            IMathVector vectorFirst = new MathVector(3);
            IMathVector vectorSecond = new MathVector(new double[3] { 0, 0, 0 });

            Assert.AreEqual(vectorFirst, vectorSecond);
        }

        [TestMethod]
        public void VectorConsructor_SizeCon_SizeLessOrEqualeZero_Test()
        {
            IMathVector vectorFirst = new MathVector(-1);

            Assert.ThrowsException<UncorrectValue_Riker>(() => new MathVector(-1));
        }


    }
}
