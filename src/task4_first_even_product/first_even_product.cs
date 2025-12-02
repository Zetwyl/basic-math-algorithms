using System.Numerics;

namespace task4_first_even_product
{
    public static class first_even_product
    {
        public static int GetFirstEvenProduct(BigInteger p)
        {
            if (p <= 0)
            {
                throw new ArgumentException("P должен быть больше 0");
            }

            if (p == 1)
            {
                return 0;
            }

            int count = 0;
            BigInteger current_even = 2;

            while (p != 1)
            {
                if (p % current_even != 0)
                {
                    throw new ArgumentException($"Значение P ({p}) не является произведением первых четных чисел");
                }

                p = p / current_even;
                count++;

                // Проверка на переполнение счетчика int
                if (count == int.MaxValue)
                {
                    // Для BigInteger это происходит, когда P достигает астрономических значений
                    // (более 2 миллиардов множителей).
                    throw new OverflowException("Количество множителей превысило лимит int.");
                }

                current_even += 2;
            }

            return count;
        }
    }
}