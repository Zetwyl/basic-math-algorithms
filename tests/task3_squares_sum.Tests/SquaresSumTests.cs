namespace task3_squares_sum.Tests
{
    [TestClass]
    public class SquaresSumTests
    {
        private int CalculateSquaresSum(List<int> numbers)
        {
            int sum = 0;
            for (int i = 1; i <= numbers[numbers.Count / 2]; i++)
            {
                sum += 2 * (i * i);
            }
            return sum;
        }

        [TestMethod]
        public void Test_NormalA()
        {
            List<int> result = squares_sum.GetSquaresSum(10);

            List<int> expectedNumbers = new List<int> { -2, -1, 0, 1, 2 };
            CollectionAssert.AreEqual(expectedNumbers, result);

            int sum = CalculateSquaresSum(result);
            Assert.AreEqual(10, sum);
        }

        [TestMethod]
        public void Test_SmallA()
        {
            List<int> result = squares_sum.GetSquaresSum(1);
            CollectionAssert.AreEqual(new List<int> { 0 }, result);

            int sum = CalculateSquaresSum(result);
            Assert.AreEqual(0, sum);
        }

        [TestMethod]
        public void Test_LargeA()
        {
            List<int> result = squares_sum.GetSquaresSum(100);

            List<int> expectedNumbers = new List<int> { -6, -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5, 6 };
            CollectionAssert.AreEqual(expectedNumbers, result);

            int sum = CalculateSquaresSum(result);
            Assert.AreEqual(91, sum);
        }

        [TestMethod]
        public void Test_NegativeA_ShouldThrow()
        {
            try
            {
                squares_sum.GetSquaresSum(-5);
                Assert.Fail("Expected ArgumentException for negative a");
            }
            catch (ArgumentException)
            {
                Assert.IsTrue(true);
            }
        }
    }
}