namespace task3_squares_sum
{
    public static class squares_sum
    {
        public static List<int> GetSquaresSum(int a)
        {
            if (a <= 0)
                throw new ArgumentException("a должно быть больше 0");

            int squaresSum = 0;
            int currentNumber = 1;
            List<int> numbers = new List<int>();

            // Вычислить сумму квадратов ВСЕХ целых чисел, пока сумма < a
            while (squaresSum + (2 * currentNumber * currentNumber) < a)
            {
                squaresSum += 2 * (currentNumber * currentNumber);
                currentNumber++;
            }

            int maxNumber = currentNumber - 1;

            for (int i = -maxNumber; i <= maxNumber; i++)
            {
                numbers.Add(i);
            }

            return numbers;
        }
    }
}
