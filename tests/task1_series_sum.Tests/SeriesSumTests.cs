namespace task1_series_sum.Tests {

    [TestClass]
    public class SeriesSumTests
    {
        // --- 1. Проверка некорректного ввода (Ветка 1) ---
        [DataTestMethod]
        [DataRow(0, DisplayName = "P равно нулю")]
        [DataRow(-1, DisplayName = "P отрицательное")]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_1_InvalidP_Throws(int p)
        {
            series_sum.SeriesSum(p);
        }

        // --- 2. Проверка краевых и нормальных случаев (Ветки 2, 3, 4) ---

        // P=1: Наименьшее P. S_1=1, S_2=3. 3 > 1. Ожидаем {1, 2}.
        [TestMethod]
        public void Test_2_P1_Min()
        {
            CollectionAssert.AreEqual(new List<int> { 1, 2 }, series_sum.SeriesSum(1));
        }

        // P=9: Нормальный случай. S_3=6, S_4=10. 10 > 9. Ожидаем {1, 2, 3, 4}.
        [TestMethod]
        public void Test_3_P9_Normal()
        {
            CollectionAssert.AreEqual(new List<int> { 1, 2, 3, 4 }, series_sum.SeriesSum(9));
        }

        // P=10: Пограничный случай P = S_n. S_4=10, S_5=15. 15 > 10. Ожидаем {1, 2, 3, 4, 5}.
        [TestMethod]
        public void Test_4_P10_EqualsSum()
        {
            CollectionAssert.AreEqual(new List<int> { 1, 2, 3, 4, 5 }, series_sum.SeriesSum(10));
        }

        // 4. Проверка корректности работы цикла. p=100. S_13=91, S_14=105. 105 > 100. Ожидаем {1..14}.
        [TestMethod]
        public void Test_5_P100_Large()
        {
            List<int> expected = Enumerable.Range(1, 14).ToList();
            CollectionAssert.AreEqual(expected, series_sum.SeriesSum(100));
        }

        [TestMethod]
        public void Test_6_P_MaxIntBoundary()
        {
            // Используем P, которое меньше S_46339 (которое равно 1073680630)
            long p = 1073672630L;

            List<int> result = series_sum.SeriesSum(p);
            long actualSum = result.Sum(x => (long)x); // actualSum будет S_46339 = 1073680630

            // Ожидается 46339 элементов, так как S_46338 < P, а S_46339 > P.
            Assert.AreEqual(46339, result.Count);

            // Ожидается, что последний элемент будет 46339.
            Assert.AreEqual(46339, result[result.Count - 1]);

            // Проверяем, что итоговая сумма (S_46339 = 1073680630) действительно больше P (1073672630).
            Assert.IsTrue(actualSum > p); // 1073680630 > 1073672630. True.
        }
    }
}