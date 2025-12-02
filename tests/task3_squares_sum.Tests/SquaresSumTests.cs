namespace task3_squares_sum.Tests
{
    [TestClass]
    public class SquaresSumTests
    {
        // Вспомогательная функция для проверки суммы
        private int CalculateSquaresSum(List<int> numbers)
        {
            // Берем максимальное число в списке (оно же N)
            // Список: [-N, ..., -1, 0, 1, ..., N]. Максимальное находится по индексу (Count - 1)
            int N = numbers.Count > 0 ? numbers[numbers.Count - 1] : 0;

            int sum = 0;
            for (int i = 1; i <= N; i++)
            {
                // Умножаем на 2, так как учитываем квадраты отрицательных и положительных чисел
                sum += 2 * (i * i);
            }
            return sum;
        }

        // 1. Средний случай (A > 10, чтобы получить нетривиальный результат)
        [TestMethod]
        public void Test_NormalA_AEquals11()
        {
            // A = 11. Сумма до N=1: 2. Сумма до N=2: 10. Сумма до N=3: 28.
            // 10 < 11. 28 !< 11. max N = 2.
            List<int> result = squares_sum.GetSquaresSum(11);

            List<int> expected = new List<int> { -2, -1, 0, 1, 2 };
            CollectionAssert.AreEqual(expected, result);

            // Проверяем, что сумма квадратов < A
            int finalSum = CalculateSquaresSum(result); // = 10
            Assert.IsTrue(finalSum < 11, $"Сумма квадратов ({finalSum}) должна быть меньше A (11).");
        }

        // 2. Минимально допустимый случай (A=1)
        [TestMethod]
        public void Test_SmallestPossibleA_AEquals1()
        {
            // A = 1. Сумма 2*1^2 = 2. 2 !< 1. max N = 0.
            List<int> result = squares_sum.GetSquaresSum(1);
            List<int> expected = new List<int> { 0 };
            CollectionAssert.AreEqual(expected, result);

            int finalSum = CalculateSquaresSum(result); // = 0
            Assert.AreEqual(0, finalSum);
        }

        // 3. Граничный случай: A очень близко к сумме
        [TestMethod]
        public void Test_BoundaryCase_SumIsVeryCloseToA()
        {
            // Возьмем A = 3. Сумма N=1: 2. Сумма N=2: 10.
            // 2 < 3. 10 !< 3. max N = 1.
            List<int> result = squares_sum.GetSquaresSum(3);
            List<int> expected = new List<int> { -1, 0, 1 };
            CollectionAssert.AreEqual(expected, result);

            int finalSum = CalculateSquaresSum(result); // = 2
            Assert.IsTrue(finalSum < 3);

            // Проверяем, что следующий квадрат вытолкнет сумму за A
            Assert.IsTrue(finalSum + 2 * (2 * 2) >= 3); // 2 + 8 = 10 >= 3
        }

        // 4. Длинная последовательность (A=100)
        [TestMethod]
        public void Test_LargeA_AEquals100()
        {
            // A = 100. Сумма до N=4: 60. Сумма до N=5: 110.
            // 60 < 100. 110 !< 100. max N = 4.
            List<int> result = squares_sum.GetSquaresSum(100);

            List<int> expected = new List<int> { -4, -3, -2, -1, 0, 1, 2, 3, 4 };
            CollectionAssert.AreEqual(expected, result);

            int finalSum = CalculateSquaresSum(result); // = 60
            Assert.IsTrue(finalSum < 100);
        }

        // 5. Проверка исключения для A=0 (Граничный случай для исключений)
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_NonPositiveA_AEqualsZero_ShouldThrow()
        {
            squares_sum.GetSquaresSum(0);
        }

        // 6. Проверка исключения для A<0 (Типичный отрицательный случай)
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_NonPositiveA_ANegative_ShouldThrow()
        {
            squares_sum.GetSquaresSum(-5);
        }

    }
}