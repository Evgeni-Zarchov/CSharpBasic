namespace _06_Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // so i have to write a program that calc how much material and money will cost Ivan to repaint 

            double nylon = double.Parse(Console.ReadLine());
            double paint = double.Parse(Console.ReadLine());
            double thinner = double.Parse(Console.ReadLine()) * 5;
            double hours = double.Parse(Console.ReadLine());

            double nylonPrice = (nylon + 2) * 1.50;
            double paintPrice = paint * 14.50;
            // so i have to calc the paint percent bcs Ivan want to add 10% more paint 
            double paintPerCent = paintPrice * 0.10 + paintPrice;
            double finalSum = nylonPrice + paintPerCent + thinner + 0.40;
            double workersHour = (finalSum * 0.30) * hours;
            double totalPrice = finalSum + workersHour;

            Console.WriteLine(totalPrice);
        }
    }
}
