namespace _02_GreaterNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // i have to write a program that read a 2 int numbers and to show greater number in the output

            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine(num1);
            }
            else
            {
                Console.WriteLine(num2);
            }
        }
    }
}
