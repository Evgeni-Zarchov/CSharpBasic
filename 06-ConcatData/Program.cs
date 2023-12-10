namespace _06_ConcatData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // i have to write a program that write on the console  name age town  

            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string town = Console.ReadLine();

            // i will use string interpolation
            Console.WriteLine($"You are {firstName} {lastName}, a {age}-years old person from {town}.");
        }
    }
}
