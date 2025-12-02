namespace task2_factorial_diff.Tests
{
    [TestClass]
    public class FactorialDiffTests
    {
        // --- Тесты для GetFactorial(int num) ---

        [TestMethod]
        public void Test_Factorial_Zero()
        {
            // Граничный случай: 0! = 1
            int num = 0;
            long result = num.GetFactorial();
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void Test_Factorial_NormalNumber()
        {
            // Обычный рабочий случай: 5! = 120
            int num = 5;
            long result = num.GetFactorial();
            Assert.AreEqual(120, result);
        }

        [TestMethod]
        public void Test_Factorial_LargeNumber()
        {
            int num = 10;
            long result = num.GetFactorial();
            Assert.AreEqual(3628800, result);
        }

        [TestMethod]
        public void Test_Factorial_NegativeNumber_ShouldThrow()
        {
            // Обработка некорректного ввода (отрицательное число)
            int num = -3;
            // Использование Assert.ThrowsException для более чистого и идиоматичного теста на исключение
            Assert.ThrowsException<ArgumentException>(() => num.GetFactorial());
        }

        // --- Тесты для GetDifference(int n, int m) ---
        // Покрывают основной функционал N! - M!

        [TestMethod]
        public void Test_Difference_PositiveResult()
        {
            // N > M: 5! - 3! = 120 - 6 = 114
            long result = FactorialCalculator.GetDifference(5, 3);
            Assert.AreEqual(114, result);
        }

        [TestMethod]
        public void Test_Difference_NegativeResult()
        {
            // N < M: 3! - 5! = 6 - 120 = -114 (Проверка отрицательного результата)
            long result = FactorialCalculator.GetDifference(3, 5);
            Assert.AreEqual(-114, result);
        }

        [TestMethod]
        public void Test_Difference_ZeroResult_SameNumbers()
        {
            // N = M: 4! - 4! = 0
            long result = FactorialCalculator.GetDifference(4, 4);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Test_Difference_WithZeroFactorial()
        {
            // Использование 0!: 3! - 0! = 6 - 1 = 5
            long result = FactorialCalculator.GetDifference(3, 0);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void Test_Difference_N_Is_Negative_ShouldThrow()
        {
            // Проверка исключения, когда N < 0
            Assert.ThrowsException<ArgumentException>(() => FactorialCalculator.GetDifference(-1, 5));
        }

        [TestMethod]
        public void Test_Difference_M_Is_Negative_ShouldThrow()
        {
            // Проверка исключения, когда M < 0
            Assert.ThrowsException<ArgumentException>(() => FactorialCalculator.GetDifference(5, -1));
        }
    }
}
