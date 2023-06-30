using GenericsProblem;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTest
{
    [TestClass]
    public class GenericMethodTest
    {
        [TestMethod]
        public void FindMax_ReturnsMaxInteger()
        {
            // Arrange
            int firstVal = 5;
            int secondVal = 10;
            int thirdVal = 7;
            TestMaximum testMaximum = new TestMaximum();

            // Act
            int result = testMaximum.FindMax(firstVal, secondVal, thirdVal);

            // Assert
            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void FindMax_ReturnsMaxString()
        {
            // Arrange
            string firstVal = "apple";
            string secondVal = "banana";
            string thirdVal = "orange";
            TestMaximum testMaximum = new TestMaximum();

            // Act
            string result = testMaximum.FindMax(firstVal, secondVal, thirdVal);

            // Assert
            Assert.AreEqual("orange", result);
        }
        [TestMethod]
        public void FindMax_ReturnsMaxFloat()
        {
            // Arrange
            float firstVal = 1.2f;
            float secondVal = 2.0f;
            float thirdVal = 1.7f;
            TestMaximum testMaximum = new TestMaximum();

            // Act
            float result = testMaximum.FindMax(firstVal, secondVal, thirdVal);

            // Assert
            Assert.AreEqual(2.0f, result);
        }
    }
}
