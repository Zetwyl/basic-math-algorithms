namespace task2_factorial_diff
{
    public static class FactorialCalculator
    {
        public static long GetDifference(int n, int m)
        {
            return GetFactorial(n) - GetFactorial(m);
        }

        public static long GetFactorial(this int num)
        {
            if (num < 0)
            {
                throw new ArgumentException("Число должно быть неотрицательным (>= 0).");
            }

            if (num == 0)
            {
                return 1;
            }

            long factorial = 1;

            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }

            return factorial;
        }
    }
}
