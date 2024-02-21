using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EvaluationSampleCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EvaluationSimpleCode
{
    [TestClass]
    public class MathOerationTest
    {
        [TestMethod]
        [DataRow(5, 3, 2)]
        [DataRow(10, 2, 8)]
        [DataRow(0, 0, 0)]
        public int Subtract_WithValidParameters_ReturnsCorrectResult(int numberOne, int numberTwo)
        {
            var mathOperations = new MathOperations();

            var result = mathOperations.Subtract(numberOne, numberTwo);

            return result;
        }

        [TestMethod]
        [DataRow(1200, 5)]
        [DataRow(10, 15)]
        public void Subtract_WithInvalidParameters_ThrowsArgumentException(int numberOne, int numberTwo)
        {
            var mathOperations = new MathOperations();

            Assert.ThrowsException<ArgumentException>(() => mathOperations.Subtract(numberOne, numberTwo));
        }
        [TestMethod]
        [DataRow(5)]
        [DataRow(10)]
        [DataRow(1)]
        public string GetColorFromOddsNumber_TestMethod_ValidInput_ReturnsCorrectColor(int number)
        {
            // Arrange
            var mathOperations = new MathOperations();

            // Act
            var result = mathOperations.GetColorFromOddsNumber(number);

            // Assert
            return result;
        }
        [TestMethod]
        [DataRow(-5)]
        public void GetColorFromOddsNumber_TestMethod_InvalidInput_ThrowsArgumentException(int number)
        {
            // Arrange
            var mathOperations = new MathOperations();

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => mathOperations.GetColorFromOddsNumber(number));
        }
    }

}

