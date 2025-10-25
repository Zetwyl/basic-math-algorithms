namespace task2_factorial_diff
{
    public static class FactorialOperations
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

    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 6;
            int m = 5;
            int factN = n.GetFactorial();
            int factM = m.GetFactorial();
            Console.WriteLine($"Факториал {n} = {factN}");
            Console.WriteLine($"Факториал {m} = {factM}");
            Console.WriteLine($"{n}! - {m}! = {factN - factM}");
        }
    }
}
