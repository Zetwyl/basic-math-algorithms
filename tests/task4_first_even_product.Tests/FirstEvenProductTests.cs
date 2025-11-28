namespace task4_first_even_product.Tests
{
    [TestClass]
    public class FirstEvenProductTests
    {
        [TestMethod]
        public void Test_CorrectProduct()
        {
            // 3840 = 2 * 4 * 6 * 8 * 10
            int count = first_even_product.GetFirstEvenProduct(3840);
            Assert.AreEqual(5, count);
        }

        [TestMethod]
        public void Test_MinimalCorrectProduct()
        {
            // 2 = первый четный множитель
            int count = first_even_product.GetFirstEvenProduct(2);
            Assert.AreEqual(1, count);
        }

        [TestMethod]
        public void Test_IncorrectProduct_ShouldThrow()
        {
            try
            {
                first_even_product.GetFirstEvenProduct(100); // не является произведением первых четных
                Assert.Fail("Expected ArgumentException for invalid product");
            }
            catch (ArgumentException)
            {
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void Test_Zero_ShouldThrow()
        {
            try
            {
                first_even_product.GetFirstEvenProduct(0);
                Assert.Fail("Expected ArgumentException for zero");
            }
            catch (ArgumentException)
            {
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void Test_Negative_ShouldThrow()
        {
            try
            {
                first_even_product.GetFirstEvenProduct(-48);
                Assert.Fail("Expected ArgumentException for negative number");
            }
            catch (ArgumentException)
            {
                Assert.IsTrue(true);
            }
        }
    }
}