namespace _02_RadiansToDegree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // i have to create a program that calc degrees into radians 
            // so i have to use the formula degree = radian * 180 / pi so i will use Match.PI
            double radians = double.Parse(Console.ReadLine());

            double degrees = radians * 180 / Math.PI;

            Console.WriteLine(degrees);
        }
    }
}
