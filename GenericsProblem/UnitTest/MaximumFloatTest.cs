using GenericsProblem;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTest
{
    [TestClass]
    public class MaximumFloatTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            float firstVal = 2.3f;
            float secondVal = 1.9f;
            float thirdVal = 1.0f;
            //Act
            TestMaximum testMaximum = new TestMaximum();
            float max = testMaximum.MaxFloat(firstVal, secondVal, thirdVal);
            //Assert
            Assert.AreEqual(firstVal, max);
        }
        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            float firstVal = 2.0f;
            float secondVal = 3.5f;
            float thirdVal = 1.2f;
            //Act
            TestMaximum testMaximum = new TestMaximum();
            float max = testMaximum.MaxFloat(firstVal, secondVal, thirdVal);
            //Assert
            Assert.AreEqual(secondVal, max);
        }
        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            float firstVal = 1.0f;
            float secondVal = 1.3f;
            float thirdVal = 2.1f;
            //Act
            TestMaximum testMaximum = new TestMaximum();
            float max = testMaximum.MaxFloat(firstVal, secondVal, thirdVal);
            //Assert
            Assert.AreEqual(thirdVal, max);
        }
    }
}
