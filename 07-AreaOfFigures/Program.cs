namespace _07_AreaOfFigures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // so i have to write a program to calc the area of figures
            // for square i have to use a formula a * a
            // for rectangle the formula is length * width
            // for circle a = pi * r * r
            // for triangle a * h / 2

            string figures = Console.ReadLine();
            double area = 0;

            if (figures == "square")
            {
                double sideA = double.Parse(Console.ReadLine());
                area = sideA * sideA;
            }
            else if (figures == "rectangle")
            {
                double length = double.Parse(Console.ReadLine());
                double width = double.Parse(Console.ReadLine());
                area = length * width;
            }
            else if (figures == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                area = Math.PI * radius * radius;
            }
            else if (figures == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                area = (a * h) / 2;
            }
            Console.WriteLine("{0:F3}", area);
        }
    }
}
