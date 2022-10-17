using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathVectorSpace;

namespace TestProject2.Tests
{
    [TestClass]
    public class VectorByVector
    {
        // +, 2 ситуации

        [TestMethod]
        public void VectorPlusVector_Normal_Test()
        {
            IMathVector vectorFirst = new MathVector(new double[] { 1, 2, 3 });
            IMathVector vectorSecond = new MathVector(new double[] { 3, 2, 1 });
            IMathVector theoryResult = new MathVector(new double[] { 4, 4, 4 });

            IMathVector practicalResult = vectorFirst + vectorSecond;

            Assert.AreEqual(practicalResult, theoryResult);
        }

        [TestMethod]
        public void VectorPlusVector_DifferentSizes_Test()
        {
            IMathVector vectorFirst = new MathVector(new double[] { 1, 2, 3 });
            IMathVector vectorSecond = new MathVector(new double[] { 3, 2 });

            Assert.ThrowsException<WrongVecSizes_Riker>(() => vectorFirst + vectorSecond);
            //Лямбда функция для чайников: (аргументы в скобочках) => (одно действие, тк )
        }

        // -, 2 ситуации (Normal, DiffSizes)

        [TestMethod]
        public void VectorMinusVector_Normal_Test()
        {
            IMathVector vectorFirst = new MathVector(new double[] { 1, 2, 3 });
            IMathVector vectorSecond = new MathVector(new double[] { 3, 2, 1 });
            IMathVector theoriticalResult = new MathVector(new double[] { -2, 0, 2 });

            IMathVector practicalResult = vectorFirst - vectorSecond;

            Assert.AreEqual(practicalResult, theoriticalResult);
        }

        [TestMethod]
        public void VectorMinusVector_DifferentSizes_Test()
        {
            IMathVector vectorFirst = new MathVector(new double[] { 1, 2, 3 });
            IMathVector vectorSecond = new MathVector(new double[] { 3, 2 });

            Assert.ThrowsException<WrongVecSizes_Riker>(() => vectorFirst - vectorSecond);
        }

        // *, 2 ситуации (Normal, DiffSizes)

        [TestMethod]
        public void VectorMultiplyVector_Normal_Test()
        {
            IMathVector vectorFirst = new MathVector(new double[] { 1, 2, 3 });
            IMathVector vectorSecond = new MathVector(new double[] { 3, 2, 1 });
            IMathVector theoriticalResult = new MathVector(new double[] { 3, 4, 3 });

            IMathVector practicalResult = vectorFirst * vectorSecond;
            Assert.AreEqual(practicalResult, theoriticalResult);
        }

        [TestMethod]
        public void VectorMultiplyVector_DifferentSizes_Test()
        {
            IMathVector vectorFirst = new MathVector(new double[] { 1, 2, 3 });
            IMathVector vectorSecond = new MathVector(new double[] { 2, 2 });

            Assert.ThrowsException<WrongVecSizes_Riker>(() => vectorFirst * vectorSecond);
        }

        // /, 3 ситуации (Normal, DiffSizes, DivideByZero)
        [TestMethod]
        public void VectorDivideVector_Normal_Test()
        {
            IMathVector vectorFirst = new MathVector(new double[] { 1, 2, 3 });
            IMathVector vectorSecond = new MathVector(new double[] { 2, 2, 1 });
            IMathVector theoriticalResult = new MathVector(new double[] { 0.5, 1, 3 });

            IMathVector practicalResult = vectorFirst / vectorSecond;
            Assert.AreEqual(practicalResult, theoriticalResult);
        }

        [TestMethod]
        public void VectorDivideVector_DifferentSizes_Test()
        {
            IMathVector vectorFirst = new MathVector(new double[] { 1, 2 });
            IMathVector vectorSecond = new MathVector(new double[] { 2, 2, 1 });

            Assert.ThrowsException<WrongVecSizes_Riker>(() => vectorFirst / vectorSecond);
        }

        [TestMethod]
        public void VectorDivideVector_DivideByZero_Test()
        {
            IMathVector vectorFirst = new MathVector(new double[] { 1, 2, 1 });
            IMathVector vectorSecond = new MathVector(new double[] { 2, 0, 1 });

            Assert.ThrowsException<DivideByZero_Riker>(() => vectorFirst / vectorSecond);
        }
    }
}
