namespace _03_RecrAngleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Rectangle calculator with side a side b

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            // im have to initialise a new variable to calc the two side

            int area = a * b;
            Console.WriteLine(area);


        }
    }
}
