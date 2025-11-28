namespace task2_factorial_diff
{
    public static class factorial_diff
    {
        public static int GetFactorial(this int num)
        {
            int factorial = 1;
            int count = 0;

            while (count != num)
            {
                factorial *= count + 1;
                count += 1;
            }
            return factorial;
        }
    }
}
