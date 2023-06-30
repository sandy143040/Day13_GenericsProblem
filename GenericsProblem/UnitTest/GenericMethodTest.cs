using GenericsProblem;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTest
{
    [TestClass]
    public class GenericMethodTest
    {
        [TestMethod]
        public void FindMax_ReturnsMaxAmongFourIntegers()
        {
            // Arrange
            int firstVal = 5;
            int secondVal = 10;
            int thirdVal = 7;
            int fourthVal = 12;
            TestMaximum<int> testMaximum = new TestMaximum<int>(firstVal, secondVal, thirdVal, fourthVal);

            // Act
            int result = testMaximum.FindMax();

            // Assert
            Assert.AreEqual(12, result);
        }
        [TestMethod]
        public void FindMax_ReturnsMaxAmongFourFloats()
        {
            // Arrange 
            float firstVal = 3.5f;
            float secondVal = 2.1f;
            float thirdVal = 4.8f;
            float fourthVal = 1.9f;
            TestMaximum<float> testMaximum = new TestMaximum<float>(firstVal, secondVal, thirdVal, fourthVal);

            // Act
            float result = testMaximum.FindMax();

            // Assert
            Assert.AreEqual(4.8f, result);
        }
        [TestMethod]
        public void FindMax_ReturnsMaxAmongFourStrings()
        {
            // Arrange "apple", "banana", "orange", "mango"
            string firstVal = "apple";
            string secondVal = "banana";
            string thirdVal = "orange";
            string fourthVal = "mango";
            TestMaximum<string> testMaximum = new TestMaximum<string>(firstVal, secondVal, thirdVal, fourthVal);

            // Act
            string result = testMaximum.FindMax();

            // Assert
            Assert.AreEqual("orange", result);
        }
    }
}
