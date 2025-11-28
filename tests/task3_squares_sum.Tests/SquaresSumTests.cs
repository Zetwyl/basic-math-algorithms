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
            // A = 10 → проверка среднего случая
            List<int> result = squares_sum.GetSquaresSum(10);

            // Последние числа включаются только пока сумма < 10
            List<int> expected = new List<int> { -2, -1, 0, 1, 2 };
            CollectionAssert.AreEqual(expected, result);

            // Дополнительно проверяем сумму квадратов
            int sum = 0;
            for (int i = 1; i <= 2; i++)
                sum += i * i;
            Assert.IsTrue(sum < 10);
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
            // A = 100 → длинная последовательность
            List<int> result = squares_sum.GetSquaresSum(100);

            // Последние числа включаются пока сумма < 100
            List<int> expected = new List<int> { -6, -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5, 6 };
            CollectionAssert.AreEqual(expected, result);

            // Проверка суммы квадратов положительных чисел
            int sum = 0;
            for (int i = 1; i <= 6; i++)
                sum += i * i;
            Assert.IsTrue(sum < 100);
        }

        [TestMethod]
        public void Test_NonPositiveA_ShouldThrow()
        {
            try
            {
                squares_sum.GetSquaresSum(0);
                Assert.Fail("Expected ArgumentException");
            }
            catch (ArgumentException)
            {
                Assert.IsTrue(true);
            }

            try
            {
                squares_sum.GetSquaresSum(-5);
                Assert.Fail("Expected ArgumentException");
            }
            catch (ArgumentException)
            {
                Assert.IsTrue(true);
            }
        }

    }
}