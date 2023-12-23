namespace _06_SpeedInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // so i have to write a program to follow the speed 
            // if the speed is 10 inclusive output "slow"
            // if the speed is over 10 and 50 inclusive output "average"
            // if the speed is over 50 and 150 inclusive output "fast"
            // if the speed is over 150 and to 1000 inclusive output "ultra fast"
            // if the speedi is over 1000 output "extremely fast"

            double speed = double.Parse(Console.ReadLine());

            if (speed <= 10)
            {
                Console.WriteLine("slow");
            }
            else if (speed <= 50)
            {
                Console.WriteLine("average");
            }
            else if (speed <= 150)
            {
                Console.WriteLine("fast");
            }
            else if (speed <= 1000)
            {
                Console.WriteLine("ultra fast");
            }
            else
            {
                Console.WriteLine("extremely fast");
            }
        }
    }
}
