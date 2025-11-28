namespace task2_factorial_diff.Tests
{
    [TestClass]
    public class FactorialDiffTests
    {
        [TestMethod]
        public void Test_Factorial_Zero()
        {
            int num = 0;
            int result = num.GetFactorial();
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void Test_Factorial_One()
        {
            int num = 1;
            int result = num.GetFactorial();
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void Test_Factorial_NormalNumber()
        {
            int num = 5;
            int result = num.GetFactorial();
            Assert.AreEqual(120, result);
        }

        [TestMethod]
        public void Test_Factorial_LargeNumber()
        {
            int num = 10;
            int result = num.GetFactorial();
            Assert.AreEqual(3628800, result);
        }

        [TestMethod]
        public void Test_Factorial_NegativeNumber_ShouldThrow()
        {
            int num = -3;
            try
            {
                int result = num.GetFactorial();
                Assert.Fail("Expected ArgumentException for negative number");
            }
            catch (ArgumentException)
            {
                Assert.IsTrue(true);
            }
        }
    }
}
