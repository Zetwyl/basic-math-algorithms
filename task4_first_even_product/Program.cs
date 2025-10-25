namespace task4_first_even_product
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int p = 3840; // 2, 8, 48, 384, 3840
            int count = 0;
            int current_even = 2;

            while (p != 1)
            {
                if (p % current_even != 0)
                {
                    throw new ArgumentException($"Значение P ({p}) не является произведением первых четных чисел");
                }

                p = p / current_even;
                current_even += 2;
                count++;
            }

            Console.WriteLine($"Сомножителей взято: {count}");
        }
    }
}
