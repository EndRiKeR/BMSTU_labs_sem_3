using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathVectorSpace;

namespace TestProject2.Tests
{
    [TestClass]
    class VectorByNumberTests
    {
        [TestMethod]
        public void test()
        {
            Assert.Fail();
        }

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

    }
}
