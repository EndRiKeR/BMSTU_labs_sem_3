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

        /// <summary>
        /// ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        /// </summary>

        [TestMethod]
        public void VectorMultiplyNumberTestNormal()
        {
            IMathVector vectorFirst = new MathVector(new double[] { 1, 2, 3 });
            double number = 2;
            IMathVector theoriticalResult = new MathVector(new double[] { 2, 4, 6 });

            IMathVector practicalResult = vectorFirst * number;
            Assert.IsTrue(practicalResult == theoriticalResult);
        }

        [TestMethod]
        public void VectorCalculateDistanceVectorTestNormal()
        {
            IMathVector vectorFirst = new MathVector(new double[] { 1, 1 });
            IMathVector vectorSecond = new MathVector(new double[] { 4, 5 });

            double practicalResult = vectorSecond.CalcDistance(vectorFirst);

            Assert.AreEqual(practicalResult, 5);
        }

        [TestMethod]
        public void VectorCalculateDistanceVectorTestDifferentDimensions()
        {
            IMathVector vectorFirst = new MathVector(new double[] { 1, 2, 3 });
            IMathVector vectorSecond = new MathVector(new double[] { 3, 2, 1, 0 });
            double practicalResult = 0;

            Assert.ThrowsException<WrongVecSizes_Riker>(() => practicalResult = vectorFirst % vectorSecond);
        }

        [TestMethod]
        public void VectorScalarMultiplyVectorTestNormal()
        {
            IMathVector vectorFirst = new MathVector(new double[] { 1, 2, 3 });
            IMathVector vectorSecond = new MathVector(new double[] { 3, 2, 1 });

            double practicalResult = vectorFirst % vectorSecond;

            Assert.IsTrue(practicalResult == 10);
        }

        [TestMethod]
        public void SomeOfVectorsIsEmtyVectorPlusVectorTest()
        {
            IMathVector vectorFirst = new MathVector(new double[] { 1, 2, 3 });
            IMathVector vectorSecond = new MathVector(new double[] { });
            IMathVector vector3 = new MathVector(new double[] { });

            Assert.ThrowsException<WrongVecSizes_Riker>(() => vector3 = vectorFirst + vectorSecond);
        }

        [TestMethod]
        public void SomeOfVectorsIsEmtyVectorMinusVectorTest()
        {
            IMathVector vectorFirst = new MathVector(new double[] { 1, 2, 3 });
            IMathVector vectorSecond = new MathVector(new double[] { });
            IMathVector vector3 = new MathVector(new double[] { });

            Assert.ThrowsException<WrongVecSizes_Riker>(() => vector3 = vectorFirst - vectorSecond);
        }

        [TestMethod]
        public void SomeOfVectorsIsEmtyVectorDivideVectorTest()
        {
            IMathVector vectorFirst = new MathVector(new double[] { 1, 2, 3 });
            IMathVector vectorSecond = new MathVector(new double[] { });
            IMathVector vector3 = new MathVector(new double[] { });

            Assert.ThrowsException<WrongVecSizes_Riker>(() => vector3 = vectorFirst / vectorSecond);
        }

        [TestMethod]
        public void SomeOfVectorsIsEmtyVectorMultiplyVectorTest()
        {
            IMathVector vectorFirst = new MathVector(new double[] { 1, 2, 3 });
            IMathVector vectorSecond = new MathVector(new double[] { });
            IMathVector vector3 = new MathVector(new double[] { });

            Assert.ThrowsException<WrongVecSizes_Riker>(() => vector3 = vectorFirst * vectorSecond);
        }

        [TestMethod]
        public void SomeOfVectorsIsEmtyVectorPlusNumberTest()
        {
            IMathVector vectorFirst = new MathVector(new double[] { });
            double number = 1;
            IMathVector practicalResult = new MathVector(new double[] { });

            Assert.ThrowsException<WrongVecSizes_Riker>(() => practicalResult = vectorFirst + number);
        }

        [TestMethod]
        public void SomeOfVectorsIsEmtyVectorMinusNumberTest()
        {
                IMathVector vectorFirst = new MathVector(new double[] { });
                double number = 1;
                IMathVector practicalResult = new MathVector(new double[] { });

                Assert.ThrowsException<Exception_Riker>(() => practicalResult = vectorFirst - number);
        }

        [TestMethod]
        public void SomeOfVectorsIsEmtyVectorDivideNumberTest()
        {
            IMathVector vectorFirst = new MathVector(new double[] { });
            double number = 1;
            IMathVector practicalResult = new MathVector(new double[] { });

            Assert.ThrowsException<UncorrectValue_Riker>(() => practicalResult = vectorFirst / number);
        }

        [TestMethod]
        public void SomeOfVectorsIsEmtyVectorMultiplyNumberTest()
        {
            IMathVector vectorFirst = new MathVector(new double[] { });
            double number = 1;
            IMathVector practicalResult = new MathVector(new double[] { });

            Assert.ThrowsException<UncorrectValue_Riker>(() => practicalResult = vectorFirst * number);
        }

        [TestMethod]
        public void VectorScalarMultiplyVectorTestDifferentDimensions()
        {
            IMathVector vectorFirst = new MathVector(new double[] { 1, 2, 3 });
            IMathVector vectorSecond = new MathVector(new double[] { 3, 2, 1, 0 });
            double practicalResult = 0;

            Assert.ThrowsException<WrongVecSizes_Riker>(() => practicalResult = vectorFirst % vectorSecond);
        }

        [TestMethod]
        public void VectorPlusVectorTestDifferentDimensions()
        {
            IMathVector vectorFirst = new MathVector(new double[] { 1, 2, 3 });
            IMathVector vectorSecond = new MathVector(new double[] { 3, 2, 1, 0 });
            IMathVector vector3 = new MathVector(new double[] { });

            Assert.ThrowsException<WrongVecSizes_Riker>(() => vector3 = vectorFirst + vectorSecond);

        }

        [TestMethod]
        public void VectorMinusVectorTestDifferentDimensions()
        {
            IMathVector vectorFirst = new MathVector(new double[] { 1, 2, 3 });
            IMathVector vectorSecond = new MathVector(new double[] { 3, 2, 1, 0 });
            IMathVector vector3 = new MathVector(new double[] { });

            Assert.ThrowsException<WrongVecSizes_Riker>(() => vector3 = vectorFirst - vectorSecond);
        }

        [TestMethod]
        public void VectorMultiplyVectorTestDifferentDimensions()
        {
            IMathVector vectorFirst = new MathVector(new double[] { 1, 2, 3 });
            IMathVector vectorSecond = new MathVector(new double[] { 3, 2, 1, 0 });
            IMathVector vector3 = new MathVector(new double[] { });

            Assert.ThrowsException<WrongVecSizes_Riker>(() => vector3 = vectorFirst / vectorSecond);
        }

        [TestMethod]
        public void ConstantVectorsTest()
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
        public void PrintTestNormal()
        {
            IMathVector vectorFirst = new MathVector(new double[] { 1, 2, 3 });
            string temp = "[1, 2, 3]";

            string practicalResult = vectorFirst.ToString();

            Assert.IsTrue(temp == practicalResult);
        }

        [TestMethod]
        public void SetValueTestNormal()
        {
            IMathVector vectorFirst = new MathVector(new double[] { 1, 2, 3 });
            IMathVector vectorResult = new MathVector(new double[] { 1, 0, 3 });

            vectorFirst[1] = 0;

            Assert.IsTrue(vectorFirst == vectorResult);
        }

        [TestMethod]
        public void SetValueTestIndexMoreThanDimensions()
        {
            IMathVector vectorFirst = new MathVector(new double[] { 1, 2, 3 });

            Assert.ThrowsException<UncorrectValue_Riker>(() => vectorFirst[1000] = 0);
        }

        [TestMethod]
        public void SetValueTestIndexLessThanZero()
        {
            IMathVector vectorFirst = new MathVector(new double[] { 1, 2, 3 });

            Assert.ThrowsException<UncorrectValue_Riker>(() => vectorFirst[-1] = 0);
        }

        [TestMethod]
        public void VectorDivideVectorTestDifferentDimensions()
        {
            IMathVector vectorFirst = new MathVector(new double[] { 1, 2, 3 });
            IMathVector vectorSecond = new MathVector(new double[] { 3, 2, 1, 0 });
            IMathVector vector3 = new MathVector(new double[] { });

            Assert.ThrowsException<WrongVecSizes_Riker>(() => vector3 = vectorFirst * vectorSecond);
        }

        [TestMethod]
        public void VectorDivideVectorTestZero()
        {
            IMathVector vectorFirst = new MathVector(new double[] { 1, 2, 3 });
            IMathVector vectorSecond = new MathVector(new double[] { 0, 0, 0 });
            IMathVector vector3 = new MathVector(new double[] { });

            Assert.ThrowsException<DivideByZero_Riker>(() => vector3 = vectorFirst / vectorSecond);
        }

        [TestMethod]
        public void EqualsVectorsTestNormalSimilarVectors()
        {
            IMathVector vectorFirst = new MathVector(new double[] { 1, 2, 3 });
            IMathVector vectorSecond = new MathVector(new double[] { 1, 2, 3 });

            Assert.IsTrue((MathVector)vectorFirst == (MathVector)vectorSecond);
        }

        [TestMethod]
        public void EqualsVectorsTestNormalNotSimilarVectors()
        {
            IMathVector vectorFirst = new MathVector(new double[] { 1, 2, 3 });
            IMathVector vectorSecond = new MathVector(new double[] { 0, 0, 0 });

            Assert.IsTrue(!(vectorFirst == vectorSecond));
        }

        [TestMethod]
        public void EqualsVectorsTestDifferrentSizes()
        {
            IMathVector vectorFirst = new MathVector(new double[] { 1, 2, 3 });
            IMathVector vectorSecond = new MathVector(new double[] { 1, 2, 3, 4 });

            Assert.IsTrue(!(vectorFirst == vectorSecond));
        }

        [TestMethod]
        public void NotEqualsVectorsTestNormalSimilarVectors()
        {
            IMathVector vectorFirst = new MathVector(new double[] { 1, 2, 3 });
            IMathVector vectorSecond = new MathVector(new double[] { 1, 2, 3 });

            Assert.IsTrue(!((MathVector)vectorFirst != (MathVector)vectorSecond));
        }

        [TestMethod]
        public void NotEqualsVectorsTestNormalNotSimilarVectors()
        {
            IMathVector vectorFirst = new MathVector(new double[] { 1, 2, 3 });
            IMathVector vectorSecond = new MathVector(new double[] { 0, 0, 0 });

            Assert.IsTrue(vectorFirst != vectorSecond);
        }

        [TestMethod]
        public void NotEqualsVectorsTestDifferrentSizes()
        {
            IMathVector vectorFirst = new MathVector(new double[] { 1, 2, 3 });
            IMathVector vectorSecond = new MathVector(new double[] { 1, 2, 3, 4 });

            Assert.IsTrue(vectorFirst != vectorSecond);
        }

        [TestMethod]
        public void VectorDivideNumberTestZero()
        {
            IMathVector vectorFirst = new MathVector(new double[] { 1, 2, 3 });
            double number = 0;
            IMathVector vector3 = new MathVector(new double[] { });

            Assert.ThrowsException<DivideByZero_Riker>(() => vector3 = vectorFirst / number);
        }

        [TestMethod]
        public void VectorThatIndexLessThanZero()
        {
            IMathVector vectorFirst = new MathVector(new double[] { 1, 2, 3 });
            double temp = 0;

            Assert.ThrowsException<IncorrectIndex_Riker>(() => temp = vectorFirst[-1]);
        }

        [TestMethod]
        public void VectorThatIndexMoreThanDimensions()
        {
            IMathVector vectorFirst = new MathVector(new double[] { 1, 2, 3 });
            double temp = 0;

            Assert.ThrowsException<IncorrectIndex_Riker>(() => temp = vectorFirst[1000]);
        }
    }
}
