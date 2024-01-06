namespace _05_GodzillaVsKong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // so i have to write a program to calc the budged for the movie will be enough or not
            // the decor for the movie is 0.10% from the budged

            double filmBudged = double.Parse(Console.ReadLine());
            int extras = int.Parse(Console.ReadLine());
            double clothesPrice = double.Parse(Console.ReadLine());
            double decor = filmBudged * 0.10;
            double sumForClothes = extras * clothesPrice;

            // if extras are over 150 the discount is 0.10 from sum for clothes 

            if (extras > 150)
            {
                sumForClothes = sumForClothes - sumForClothes * 0.10;
            }
            // to find the total price i will create a variable totalPrice = sumForClothes + decor

            double totalSum = sumForClothes + decor;
            // if the budged are enough i have to check and if yes "Action!"
            // "Wingard starts filming with {останалите пари} leva left."
            // else if not "Not enough money!"
            // "Wingard needs {парите недостигащи за филма} leva more."
            // to calc how much money is not enough i will use MATH.Abs

            if (filmBudged >= totalSum)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {filmBudged - totalSum:f2} leva left.");

            }
            else
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {Math.Abs(filmBudged - totalSum):f2} leva more.");
            }


        }
    }
}
