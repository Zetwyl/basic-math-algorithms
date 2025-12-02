namespace task1_series_sum
{
    public static class series_sum
    {
        public static List<int> SeriesSum(long p)
        {
            if (p <= 0)
            {
                throw new ArgumentException("Параметр 'p' должен быть больше 0.", nameof(p));
            }

            int currentTerm = 1;
            long currentSum = 0;
            List<int> numbers = new List<int>();

            while (true)
            {
                currentSum += currentTerm;
                numbers.Add(currentTerm);

                if (currentSum > p)
                {
                    break;
                }

                currentTerm++;
            }

            return numbers;
        }
    }
}