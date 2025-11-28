namespace task4_first_even_product
{
    public static class first_even_product
    {
        public static int GetFirstEvenProduct(int p)
        {
            if (p <= 0)
                throw new ArgumentException("p должен быть больше 0");

            int count = 0;
            int current_even = 2;

            while (p != 1)
            {
                if (p % current_even != 0)
                    throw new ArgumentException($"Значение P ({p}) не является произведением первых четных чисел");

                p = p / current_even;
                current_even += 2;
                count++;
            }

            return count;
        }
    }
}