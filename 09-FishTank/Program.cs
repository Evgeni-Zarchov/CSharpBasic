namespace _09_FishTank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // so Lubo have aquarium and i have to calc how much water he will need to fill the aquarium
            // so he have some taken space bcs of the pump and i have to calc the percent / 100;

            double aquaLength = double.Parse(Console.ReadLine());
            double aquaWidth = double.Parse(Console.ReadLine());
            double aquaHeight = double.Parse(Console.ReadLine());
            // i will divide here on the console 
            double perCent = double.Parse(Console.ReadLine()) / 100;

            double totalWater = aquaLength * aquaWidth * aquaHeight / 1000;
            double totalCubicWater = totalWater - (totalWater * perCent);
            Console.WriteLine(totalCubicWater);


        }
    }
}
