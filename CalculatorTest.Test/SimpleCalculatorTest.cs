using CalculatorTest.Lib;

namespace CalculatorTest.Test {

    [TestClass]
    public class SimpleCalculatorTest {

        private ISimpleCalculator? simpleCalculator;

        [TestInitialize]
        public void Init() {
            simpleCalculator = new SimpleCalculator();
        }

        [TestMethod]
        public void AddReturnsSumOfTwoPositiveNumbers() {
            // Arrange
            int start = 2;
            int amount = 6;
            int expectedSum = 8;

            // Act
            int actualSum = simpleCalculator!.Add(start, amount);

            // Assert
            Assert.AreEqual(expectedSum, actualSum);
        }

        [TestMethod]
        public void AddReturnsNegativeNumberForOnePositiveAndOneLargerNegativeNumber() {
            // Arrange
            int start = -8;
            int amount = 5;
            int expectedSum = -3;

            // Act
            int actualSum = simpleCalculator!.Add(start, amount);

            // Assert
            Assert.AreEqual(expectedSum, actualSum);
        }

        [TestMethod]
        public void AddReturnsSumOfNegativeNumbers() {
            // Arrange
            int start = -8;
            int amount = -5;
            int expectedSum = -13;

            // Act
            int actualSum = simpleCalculator!.Add(start, amount);

            // Assert
            Assert.AreEqual(expectedSum, actualSum);
        }

        [TestMethod]
        public void SubtractReturnsPositiveDifferenceOfTwoPositiveNumbersWhereAmountIsSmallerThanStart() {
            // Arrange
            int start = 9;
            int amount = 6;
            int expectedDifference = 3;

            // Act
            int actualDifference = simpleCalculator!.Subtract(start, amount);

            // Assert
            Assert.AreEqual(expectedDifference, actualDifference);
        }

        [TestMethod]
        public void SubtractReturnsNegativeDifferenceOfTwoPositiveNumbersWhereAmountIsGreaterThanStart() {
            // Arrange
            int start = 6;
            int amount = 9;
            int expectedDifference = -3;

            // Act
            int actualDifference = simpleCalculator!.Subtract(start, amount);

            // Assert
            Assert.AreEqual(expectedDifference, actualDifference);
        }

        [TestMethod]
        public void SubtractReturnsSumOfStartAndAmountWhereStartIsPositiveAndAmountIsNegative() {
            // Arrange
            int start = 9;
            int amount = -6;
            int expectedDifference = 15;

            // Act
            int actualDifference = simpleCalculator!.Subtract(start, amount);

            // Assert
            Assert.AreEqual(expectedDifference, actualDifference);
        }

        [TestMethod]
        public void SubtractReturnsSumOfStartAndAmountWhereStartAndAmountAreNegative() {
            // Arrange
            int start = -9;
            int amount = -6;
            int expectedDifference = -3;

            // Act
            int actualDifference = simpleCalculator!.Subtract(start, amount);

            // Assert
            Assert.AreEqual(expectedDifference, actualDifference);
        }

    }

}