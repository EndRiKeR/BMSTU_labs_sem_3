using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathVectorSpace;

namespace UnitTests
{
    [TestClass]
    class TestsProperties
    {
        [TestMethod]
        public void VectorPlusVectorTestNormal()
        {
            IMathVector vector1 = new MathVector(new double[] { 1, 2, 3 });
            IMathVector vector2 = new MathVector(new double[] { 3, 2, 1 });
            IMathVector excepted = new MathVector(new double[] { 4, 4, 4 });

            IMathVector result = vector1 + vector2;
            Assert.IsTrue(result == excepted);
        }

        [TestMethod]
        public void VectorMinusVectorTestNormal()
        {
            IMathVector vector1 = new MathVector(new double[] { 1, 2, 3 });
            IMathVector vector2 = new MathVector(new double[] { 3, 2, 1 });
            IMathVector excepted = new MathVector(new double[] { -2, 0, 2 });

            IMathVector result = vector1 - vector2;
            Assert.IsTrue(result == excepted);
        }

        [TestMethod]
        public void VectorMultiplyVectorTestNormal()
        {
            IMathVector vector1 = new MathVector(new double[] { 1, 2, 3 });
            IMathVector vector2 = new MathVector(new double[] { 3, 2, 1 });
            IMathVector excepted = new MathVector(new double[] { 3, 4, 3 });

            IMathVector result = vector1 * vector2;
            Assert.IsTrue(result == excepted);
        }

        [TestMethod]
        public void VectorDivideVectorTestNormal()
        {
            IMathVector vector1 = new MathVector(new double[] { 1, 2, 3 });
            IMathVector vector2 = new MathVector(new double[] { 2, 2, 1 });
            IMathVector excepted = new MathVector(new double[] { 0.5, 1, 3 });

            IMathVector result = vector1 / vector2;
            Assert.IsTrue(result == excepted);
        }

        [TestMethod]
        public void VectorPlusNumberTestNormal()
        {
            IMathVector vector1 = new MathVector(new double[] { 1, 2, 3 });
            double number = 1;
            IMathVector excepted = new MathVector(new double[] { 2, 3, 4 });

            IMathVector result = vector1 + number;
            Assert.IsTrue(result == excepted);
        }

        [TestMethod]
        public void VectorMinusNumberTestNormal()
        {
            IMathVector vector1 = new MathVector(new double[] { 1, 2, 3 });
            double number = 1;
            IMathVector excepted = new MathVector(new double[] { 0, 1, 2 });

            IMathVector result = vector1 - number;
            Assert.IsTrue(result == excepted);
        }

        [TestMethod]
        public void VectorDivideNumberTestNormal()
        {
            IMathVector vector1 = new MathVector(new double[] { 1, 2, 3 });
            double number = 2;
            IMathVector excepted = new MathVector(new double[] { 0.5, 1, 1.5 });

            IMathVector result = vector1 / number;
            Assert.IsTrue(result == excepted);
        }

        [TestMethod]
        public void VectorMultiplyNumberTestNormal()
        {
            IMathVector vector1 = new MathVector(new double[] { 1, 2, 3 });
            double number = 2;
            IMathVector excepted = new MathVector(new double[] { 2, 4, 6 });

            IMathVector result = vector1 * number;
            Assert.IsTrue(result == excepted);
        }

        [TestMethod]
        public void VectorCalculateDistanceVectorTestNormal()
        {
            IMathVector vector1 = new MathVector(new double[] { 1, 2, 3 });
            IMathVector vector2 = new MathVector(new double[] { 3, 2, 1 });
            
            double result = vector1.CalcDistance(vector2);

            Assert.IsTrue(result == 48);
        }

        [TestMethod]
        public void VectorCalculateDistanceVectorTestDifferentDimensions()
        {
            IMathVector vector1 = new MathVector(new double[] { 1, 2, 3 });
            IMathVector vector2 = new MathVector(new double[] { 3, 2, 1, 0 });
            double result = 0;

            Assert.ThrowsException<WrongVecSizes_Riker>(() => result = vector1 % vector2);
        }

        [TestMethod]
        public void VectorScalarMultiplyVectorTestNormal()
        {
            IMathVector vector1 = new MathVector(new double[] { 1, 2, 3 });
            IMathVector vector2 = new MathVector(new double[] { 3, 2, 1 });
            
            double result = vector1 % vector2;

            Assert.IsTrue(result == 10);
        }

        [TestMethod]
        public void SomeOfVectorsIsEmtyVectorPlusVectorTest()
        {
            IMathVector vector1 = new MathVector(new double[] { 1, 2, 3 });
            IMathVector vector2 = new MathVector(new double[] { });
            IMathVector vector3 = new MathVector(new double[] { });

            Assert.ThrowsException<WrongVecSizes_Riker>(() => vector3 = vector1 + vector2);
        }

        [TestMethod]
        public void SomeOfVectorsIsEmtyVectorMinusVectorTest()
        {
            IMathVector vector1 = new MathVector(new double[] { 1, 2, 3 });
            IMathVector vector2 = new MathVector(new double[] { });
            IMathVector vector3 = new MathVector(new double[] { });

            Assert.ThrowsException<WrongVecSizes_Riker>(() => vector3 = vector1 - vector2);
        }

        [TestMethod]
        public void SomeOfVectorsIsEmtyVectorDivideVectorTest()
        {
            IMathVector vector1 = new MathVector(new double[] { 1, 2, 3 });
            IMathVector vector2 = new MathVector(new double[] { });
            IMathVector vector3 = new MathVector(new double[] { });

            Assert.ThrowsException<WrongVecSizes_Riker>(() => vector3 = vector1 / vector2);
        }

        [TestMethod]
        public void SomeOfVectorsIsEmtyVectorMultiplyVectorTest()
        {
            IMathVector vector1 = new MathVector(new double[] { 1, 2, 3 });
            IMathVector vector2 = new MathVector(new double[] { });
            IMathVector vector3 = new MathVector(new double[] { });

            Assert.ThrowsException<WrongVecSizes_Riker>(() => vector3 = vector1 * vector2);
        }

        [TestMethod]
        public void SomeOfVectorsIsEmtyVectorPlusNumberTest()
        {
            IMathVector vector1 = new MathVector(new double[] { });
            double number = 1;
            IMathVector result = new MathVector(new double[] { });

            Assert.ThrowsException<WrongVecSizes_Riker>(() => result = vector1 + number);
        }

        [TestMethod]
        public void SomeOfVectorsIsEmtyVectorMinusNumberTest()
        {
            IMathVector vector1 = new MathVector(new double[] { });
            double number = 1;
            IMathVector result = new MathVector(new double[] { });

            Assert.ThrowsException<WrongVecSizes_Riker>(() => result = vector1 - number);
        }

        [TestMethod]
        public void SomeOfVectorsIsEmtyVectorDivideNumberTest()
        {
            IMathVector vector1 = new MathVector(new double[] { });
            double number = 1;
            IMathVector result = new MathVector(new double[] { });

            Assert.ThrowsException<WrongVecSizes_Riker>(() => result = vector1 / number);
        }
        
        [TestMethod]
        public void SomeOfVectorsIsEmtyVectorMultiplyNumberTest()
        {
            IMathVector vector1 = new MathVector(new double[] { });
            double number = 1;
            IMathVector result = new MathVector(new double[] { });

            Assert.ThrowsException<WrongVecSizes_Riker>(() => result = vector1 * number);
        }

        [TestMethod]
        public void VectorScalarMultiplyVectorTestDifferentDimensions()
        {
            IMathVector vector1 = new MathVector(new double[] { 1, 2, 3 });
            IMathVector vector2 = new MathVector(new double[] { 3, 2, 1, 0 });
            double result = 0;

            Assert.ThrowsException<WrongVecSizes_Riker>(() => result = vector1 % vector2);
        }

        [TestMethod]
        public void VectorPlusVectorTestDifferentDimensions()
        {
            IMathVector vector1 = new MathVector(new double[] { 1, 2, 3 });
            IMathVector vector2 = new MathVector(new double[] { 3, 2, 1, 0 });
            IMathVector vector3 = new MathVector(new double[] { });

            Assert.ThrowsException<WrongVecSizes_Riker>(() => vector3 = vector1 + vector2);

        }

        [TestMethod]
        public void VectorMinusVectorTestDifferentDimensions()
        {
            IMathVector vector1 = new MathVector(new double[] { 1, 2, 3 });
            IMathVector vector2 = new MathVector(new double[] { 3, 2, 1, 0 });
            IMathVector vector3 = new MathVector(new double[] { });

            Assert.ThrowsException<WrongVecSizes_Riker>(() => vector3 = vector1 - vector2);
        }

        [TestMethod]
        public void VectorMultiplyVectorTestDifferentDimensions()
        {
            IMathVector vector1 = new MathVector(new double[] { 1, 2, 3 });
            IMathVector vector2 = new MathVector(new double[] { 3, 2, 1, 0 });
            IMathVector vector3 = new MathVector(new double[] { });

            Assert.ThrowsException<WrongVecSizes_Riker>(() => vector3 = vector1 / vector2);
        }

        [TestMethod]
        public void ConstantVectorsTest()
        {
            IMathVector vector1 = new MathVector(new double[] { 1, 2, 3 });
            IMathVector vector2 = new MathVector(new double[] { 3, 2, 1 });

            IMathVector vector1Copy = new MathVector(new double[] { 1, 2, 3 });
            IMathVector vector2Copy = new MathVector(new double[] { 3, 2, 1 });

            IMathVector vector3 = vector1 / vector2;

            Assert.IsTrue((vector1 == vector1Copy) && (vector2 == vector2Copy));
        }

        [TestMethod]
        public void PrintTestNormal()
        {
            IMathVector vector1 = new MathVector(new double[] { 1, 2, 3 });
            string temp = "{1, 2, 3}";

            string result = vector1.ToString();

            Assert.IsTrue(temp == result);
        }

        [TestMethod]
        public void SetValueTestNormal()
        {
            IMathVector vector1 = new MathVector(new double[] { 1, 2, 3 });
            IMathVector vectorResult = new MathVector(new double[] { 1, 0, 3 });

            vector1[1] = 0;

            Assert.IsTrue(vector1 == vectorResult);
        }

        [TestMethod]
        public void SetValueTestIndexMoreThanDimensions()
        {
            IMathVector vector1 = new MathVector(new double[] { 1, 2, 3 });

            Assert.ThrowsException<UncorrectValue_Riker>(() => vector1[1000] = 0);
        }

        [TestMethod]
        public void SetValueTestIndexLessThanZero()
        {
            IMathVector vector1 = new MathVector(new double[] { 1, 2, 3 });

            Assert.ThrowsException<UncorrectValue_Riker>(() => vector1[-1] = 0);
        }

        [TestMethod]
        public void VectorDivideVectorTestDifferentDimensions()
        {
            IMathVector vector1 = new MathVector(new double[] { 1, 2, 3 });
            IMathVector vector2 = new MathVector(new double[] { 3, 2, 1, 0 });
            IMathVector vector3 = new MathVector(new double[] { });

            Assert.ThrowsException<WrongVecSizes_Riker>(() => vector3 = vector1 * vector2);
        }

        [TestMethod]
        public void VectorDivideVectorTestZero()
        {
            IMathVector vector1 = new MathVector(new double[] { 1, 2, 3 });
            IMathVector vector2 = new MathVector(new double[] { 0, 0, 0 });
            IMathVector vector3 = new MathVector(new double[] { });

            Assert.ThrowsException<DivideByZero_Riker>(() => vector3 = vector1 / vector2);
        }

        [TestMethod]
        public void EqualsVectorsTestNormalSimilarVectors()
        {
            IMathVector vector1 = new MathVector(new double[] { 1, 2, 3 });
            IMathVector vector2 = new MathVector(new double[] { 1, 2, 3 });

            Assert.IsTrue(vector1 == vector2);
        }
        
        [TestMethod]
        public void EqualsVectorsTestNormalNotSimilarVectors()
        {
            IMathVector vector1 = new MathVector(new double[] { 1, 2, 3 });
            IMathVector vector2 = new MathVector(new double[] { 0, 0, 0 });

            Assert.IsTrue(!(vector1 == vector2));
        }

        [TestMethod]
        public void EqualsVectorsTestDifferrentSizes()
        {
            IMathVector vector1 = new MathVector(new double[] { 1, 2, 3 });
            IMathVector vector2 = new MathVector(new double[] { 1, 2, 3, 4 });

            Assert.IsTrue(!(vector1 == vector2));
        }

        [TestMethod]
        public void NotEqualsVectorsTestNormalSimilarVectors()
        {
            IMathVector vector1 = new MathVector(new double[] { 1, 2, 3 });
            IMathVector vector2 = new MathVector(new double[] { 1, 2, 3 });

            Assert.IsTrue(!(vector1 != vector2));
        }

        [TestMethod]
        public void NotEqualsVectorsTestNormalNotSimilarVectors()
        {
            IMathVector vector1 = new MathVector(new double[] { 1, 2, 3 });
            IMathVector vector2 = new MathVector(new double[] { 0, 0, 0 });

            Assert.IsTrue(vector1 != vector2);
        }

        [TestMethod]
        public void NotEqualsVectorsTestDifferrentSizes()
        {
            IMathVector vector1 = new MathVector(new double[] { 1, 2, 3 });
            IMathVector vector2 = new MathVector(new double[] { 1, 2, 3, 4 });

            Assert.IsTrue(vector1 != vector2);
        }

        [TestMethod]
        public void VectorDivideNumberTestZero()
        {
            IMathVector vector1 = new MathVector(new double[] { 1, 2, 3 });
            double number = 0;
            IMathVector vector3 = new MathVector(new double[] { });

            Assert.ThrowsException<DivideByZero_Riker>(() => vector3 = vector1 / number);
        }

        [TestMethod]
        public void VectorThatIndexLessThanZero()
        {
            IMathVector vector1 = new MathVector(new double[] { 1, 2, 3 });
            double temp = 0;

            Assert.ThrowsException<IncorrectIndex_Riker>(() => temp = vector1[-1]);
        }

        [TestMethod]
        public void VectorThatIndexMoreThanDimensions()
        {
            IMathVector vector1 = new MathVector(new double[] { 1, 2, 3 });
            double temp = 0;

            Assert.ThrowsException<IncorrectIndex_Riker>(() => temp = vector1[1000]);
        }
    }
}

