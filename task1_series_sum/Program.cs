namespace task1_series_sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int series = 1;
            int seriesSum = 0;
            int p = 15;
            List<int> numbers = new List<int>();

            while (p >= seriesSum)
            {
                seriesSum += series;
                numbers.Add(series);
                series++;
            }

            string numbersStr = string.Join($", ", numbers);
            Console.WriteLine($"Num: {numbersStr}");
        }
    }
}
