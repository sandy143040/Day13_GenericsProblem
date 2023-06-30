using GenericsProblem;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTest
{
    [TestClass]
    public class MaximumStringTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            string firstVal = "mango";
            string secondVal = "apple";
            string thirdVal = "banana";
            //Act
            TestMaximum testMaximum = new TestMaximum();
            string max = testMaximum.MaxString(firstVal, secondVal, thirdVal);
            //Assert
            Assert.AreEqual(firstVal, max);
        }
        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            string firstVal = "apple";
            string secondVal = "mango";
            string thirdVal = "banana";
            //Act
            TestMaximum testMaximum = new TestMaximum();
            string max = testMaximum.MaxString(firstVal, secondVal, thirdVal);
            //Assert
            Assert.AreEqual(secondVal, max);
        }
        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            string firstVal = "sandeep";
            string secondVal = "kumar";
            string thirdVal = "singh";
            //Act
            TestMaximum testMaximum = new TestMaximum();
            string max = testMaximum.MaxString(firstVal, secondVal, thirdVal);
            //Assert
            Assert.AreEqual(thirdVal, max);
        }
    }
}
