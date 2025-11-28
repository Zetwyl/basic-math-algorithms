namespace task1_series_sum
{
    public static class series_sum
    {
        public static List<int> SeriesSum(int p)
        {
            if (p <= 0)
                throw new ArgumentException("p должен быть больше 0");

            int series = 1;
            int seriesSum = 0;
            List<int> numbers = new List<int>();

            while (seriesSum <= p)
            {                
                seriesSum += series;
                numbers.Add(series);
                series++;
            }

            return numbers;

        }
    }
}
