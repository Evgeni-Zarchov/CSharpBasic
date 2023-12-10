namespace _09_YardGreening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // i have to write a program Yard Greening

            double meters = double.Parse(Console.ReadLine());
            // i have to calc square meters by 7.61
            double totalSquareMeters = meters * 7.61;

            // disount is 18 so i have to cal the total meters by totalSquareMeters * 0.18;

            double discount = totalSquareMeters * 0.18;


            Console.WriteLine($"The final price is: {totalSquareMeters - discount} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
        }
    }
}
