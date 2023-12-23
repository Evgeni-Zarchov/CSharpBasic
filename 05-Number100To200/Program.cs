using System.Collections.Concurrent;

namespace _05_Number100To200
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // so i have to write a program to show the number the max num is 200
            // so if the number is less than 100 output Less than 100
            // if the number is between 100 and 200 output Between 100 and 200 
            // if the number is Greater than 200 output Greater than 200

            int number = int.Parse(Console.ReadLine());

            if (number < 100)
            {
                Console.WriteLine("Less than 100");
            }
            else if (number <= 200)
            {
                Console.WriteLine("Between 100 and 200");
            }
            else
            {
                Console.WriteLine("Greater than 200");
            }
        }
    }
}
