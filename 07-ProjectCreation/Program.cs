namespace _07_ProjectCreation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // i have to write a program that calc how much hour need one architect to create 4 project for 3 hours
            string name = Console.ReadLine();
            int projects = int.Parse(Console.ReadLine());

            // i have to find total time by multiply the projects by 3

            int hourNeeded = projects * 3;

            Console.WriteLine($"The architect {name} will need {hourNeeded} hours to complete {projects} project/s.");

        }
    }
}
