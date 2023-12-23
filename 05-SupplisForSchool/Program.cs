namespace _05_SupplisForSchool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // i have to create a program that calc school supplies

            // the following input will contain 
            // 1. pack of pencils price 5.80
            // 2. pack of markers price 7.20
            // 3.chemical 1.20 per (litre)
            // and discount 20 percent so i have to calc during the input * 0.01;
            // the input comes with packages so i will count in the input
            // is better to declare a variable for every pack then to count but is for university task it will do the work 
            double packOfPencils = double.Parse(Console.ReadLine()) * 5.80;
            double packOfMarkers = double.Parse(Console.ReadLine()) * 7.20;
            double chemical = double.Parse(Console.ReadLine()) * 1.20;
            double discount = double.Parse(Console.ReadLine()) * 0.01;

            double totalPrice = packOfPencils + packOfMarkers + chemical;
            double finalSum = totalPrice - (totalPrice * discount);

            Console.WriteLine(finalSum);
        }
    }
}
