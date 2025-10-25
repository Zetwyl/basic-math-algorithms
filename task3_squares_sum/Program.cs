namespace task3_squares_sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 111;
            int squaresSum = 0;
            int currentNumber = 1;
            List<int> numbers = new List<int>();

            // Вычислить сумму квадратов ВСЕХ целых чисел, пока сумма < a
            while (squaresSum + 2 * (currentNumber * currentNumber) < a)
            {
                squaresSum += 2 * (currentNumber * currentNumber);
                currentNumber++;
            }

            int maxNumber = currentNumber - 1;

            for (int i = -maxNumber; i <= maxNumber; i++)
            {
                numbers.Add(i);
            }

            string result = string.Join($", ", numbers);
            Console.WriteLine($"Числа: {result}");  // Числа: -2, -1, 0, 1, 2
            Console.WriteLine($"Сумма квадратов: {squaresSum}");  // Сумма квадратов: 10
        }
    }
}
