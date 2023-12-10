namespace _08_PetShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // i have to write a program that calc the price of a food for cats and dogs
            // the food price for cat is 4 the food for dog is 2.50 per packages

            int dogFood = int.Parse(Console.ReadLine());
            int catFood = int.Parse(Console.ReadLine());

            // i have to multiply the packages by the given price so i will initialise a variable

            double priceForDog = dogFood * 2.50;
            double priceForCat = catFood * 4;

            // i have to find the total price by the dog and cat price for food

            double totalPrice = priceForDog + priceForCat;

            Console.WriteLine($"{totalPrice} lv.");
        }
    }
}
