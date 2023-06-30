using GenericsProblem;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTest
{
    [TestClass]
    public class MaximumIntTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            int firstVal = 20;
            int secondVal = 15;
            int thirdVal = 12;
            //Act
            TestMaximum testMaximum = new TestMaximum();
            int max = testMaximum.MaxInt(firstVal, secondVal, thirdVal);
            //Assert
            Assert.AreEqual(firstVal, max);
        }
        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            int firstVal = 20;
            int secondVal = 35;
            int thirdVal = 12;
            //Act
            TestMaximum testMaximum = new TestMaximum();
            int max = testMaximum.MaxInt(firstVal, secondVal, thirdVal);
            //Assert
            Assert.AreEqual(secondVal, max);
        }
        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            int firstVal = 10;
            int secondVal = 3;
            int thirdVal = 21;
            //Act
            TestMaximum testMaximum = new TestMaximum();
            int max = testMaximum.MaxInt(firstVal, secondVal, thirdVal);
            //Assert
            Assert.AreEqual(thirdVal, max);
        }
    }
}
