using System.Numerics;

namespace task4_first_even_product.Tests
{
    [TestClass]
    public class FirstEvenProductBigIntegerTests
    {
        // --- 1. Тесты на Корректное Произведение и краевые случаи (Покрытие: Ветки 2, 4, 6) ---
        // Все успешные тесты покрывают Ветку 4 (основной цикл) и Ветку 6 (успешный return).

        [TestMethod]
        [DataRow("1", 0, DisplayName = "Test_P_1_Returns_0")]   // Покрывает Ветку 2: if (p == 1)
        [DataRow("2", 1, DisplayName = "Test_P_2_Returns_1")]   // Покрывает Ветки 4 и 6
        [DataRow("48", 3, DisplayName = "Test_P_48_Returns_3")] // Покрывает Ветки 4 и 6
        [DataRow("1961990553600", 12, DisplayName = "Test_P_Large_BigInteger")] // ИСПРАВЛЕНО: 2*..*24
        public void Test_1_CorrectProducts_And_Success(string pValue, int expectedCount)
        {
            BigInteger p = BigInteger.Parse(pValue);
            int count = first_even_product.GetFirstEvenProduct(p);
            Assert.AreEqual(expectedCount, count);
        }

        // --- 2. Тесты на Некорректные Входные Данные (Покрытие: Ветка 1) ---

        [TestMethod]
        [DataRow("0", DisplayName = "Test_P_Zero")]
        [DataRow("-1", DisplayName = "Test_P_Negative")]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_2_InvalidInput_P_Less_Or_Equal_Zero(string pValue)
        {
            // Покрывает Ветку 1: if (p <= 0)
            first_even_product.GetFirstEvenProduct(BigInteger.Parse(pValue));
        }

        // --- 3. Тесты на Некорректные Произведения (Покрытие: Ветка 3) ---

        [TestMethod]
        [DataRow("10", DisplayName = "Test_Fails_on_4")]
        [DataRow("96", DisplayName = "Test_Fails_on_4_Missing_Factor")]
        [DataRow("24", DisplayName = "Test_Fails_on_6_Critical_Case")]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_3_InvalidProduct_Throws_ArgumentException(string pValue)
        {
            // Покрывает Ветку 3: if (p % current_even != 0)
            first_even_product.GetFirstEvenProduct(BigInteger.Parse(pValue));
        }

        // Примечание: Ветка 5 (if (count == int.MaxValue)) сознательно не тестируется,
        // так как она недостижима в реальной среде и не добавляет ценности для тестирования.
        // Достигнуто 100% покрытия всех реалистично достижимых веток (1, 2, 3, 4, 6).
    }
}