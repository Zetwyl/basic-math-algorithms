namespace task3_squares_sum
{
    public static class squares_sum
    {
        public static List<int> GetSquaresSum(int a)
        {
            if (a <= 0)
                throw new ArgumentException("a должно быть неотрицательным");

            int squaresSum = 0;
            int currentNumber = 1;
            List<int> numbers = new List<int>();

            // Вычислить сумму квадратов ВСЕХ целых чисел, пока сумма < a
            while (squaresSum + (currentNumber * currentNumber) < a)
            {
                squaresSum += (currentNumber * currentNumber);
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
