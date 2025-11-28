namespace task1_series_sum.Tests {

    [TestClass]
    public class SeriesSumTests
    {
        [TestMethod]
        public void Test_PositiveP_NormalCase()
        {
            List<int> result = series_sum.SeriesSum(15);
            CollectionAssert.AreEqual(new List<int> { 1, 2, 3, 4, 5, 6 }, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_ZeroOrNegativeP_ShouldThrow()
        {
            series_sum.SeriesSum(0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_NegativeP_ShouldThrow()
        {
            series_sum.SeriesSum(-5);
        }

        [TestMethod]
        public void Test_LargeP()
        {
            List<int> expected = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
            CollectionAssert.AreEqual(expected, series_sum.SeriesSum(100));
        }
    }
}