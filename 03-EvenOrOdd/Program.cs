namespace _03_EvenOrOdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // i have to write a program that shows if the number is even or odd
            // so to check if the number is even i have to divide % 2 == 0 / else odd

            double number = double.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }

        }
    }
}
