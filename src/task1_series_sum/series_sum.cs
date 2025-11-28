namespace task1_series_sum
{
    public static class series_sum
    {
        public static List<int> SeriesSum(int p)
        {
            int series = 1;
            int seriesSum = 0;
            List<int> numbers = new List<int>();

            while (p >= seriesSum)
            {
                seriesSum += series;
                numbers.Add(series);
                series++;
            }

            return numbers;

        }
    }
}
