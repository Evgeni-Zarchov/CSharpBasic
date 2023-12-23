namespace _07_FoodDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // so i have to write a program for restaurant menu
            // on first input i will have chicken menu the price is 10.35
            // on the second input i will have fish menu the price is 12.40
            // on the third input i will have vegan menu the price is 8.15
            // the group will order dessert that will be 20% from total price
            // delivery price is 2.50

            double chickenMenu = double.Parse(Console.ReadLine());
            double fishMenu = double.Parse(Console.ReadLine());
            double veganMenu = double.Parse(Console.ReadLine());

            double chickenPrice = chickenMenu * 10.35;
            double fishPrice = fishMenu * 12.40;
            double veganPrice = veganMenu * 8.15;

            double sum = chickenPrice + fishPrice + veganPrice;
            double dessertPrice = 0.20 * sum;
            double totalSum = sum + dessertPrice + 2.50;

            Console.WriteLine(totalSum);

        }
    }
}