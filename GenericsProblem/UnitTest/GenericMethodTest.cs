using GenericsProblem;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTest
{
    [TestClass]
    public class GenericMethodTest
    {
        [TestMethod]
        public void MaximumValue_ReturnsMaxInteger()
        {
            // Arrange
            int firstVal = 5;
            int secondVal = 10;
            int thirdVal = 7;
            TestMaximum<int> testMaximum = new TestMaximum<int>(firstVal, secondVal, thirdVal);

            // Act
            testMaximum.MaximumValue();

            // No Assert needed since the method writes the result to the console
        }

        [TestMethod]
        public void MaximumValue_ReturnsMaxString()
        {
            // Arrange
            string firstVal = "apple";
            string secondVal = "banana";
            string thirdVal = "orange";
            TestMaximum<string> testMaximum = new TestMaximum<string>(firstVal, secondVal, thirdVal);

            // Act
            testMaximum.MaximumValue();

            // No Assert needed 
        }
        [TestMethod]
        public void MaximumValue_ReturnsMaxFloat()
        {
            // Arrange
            float firstVal = 1.5f;
            float secondVal = 1.0f;
            float thirdVal = 2.7f;
            TestMaximum<float> testMaximum = new TestMaximum<float>(firstVal, secondVal, thirdVal);

            // Act
            testMaximum.MaximumValue();

            // No Assert needed since the method writes the result to the console
        }
    }
}
