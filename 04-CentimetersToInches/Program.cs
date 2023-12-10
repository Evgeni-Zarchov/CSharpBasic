namespace _04_CentimetersToInches
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // i have to write a program that convert a cm into inches

            double cm = double.Parse(Console.ReadLine());

            // i will initialise a variable to convert cm * 2.54

            double inches = cm * 2.54;

            Console.WriteLine(inches);
        }
    }
}
