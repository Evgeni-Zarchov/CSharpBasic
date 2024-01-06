namespace _07_Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // so Peter wants to buy N video cards M processors P ram

            // the input is
            // 1. budged
            // 2. video cards count the price is 250
            // 3. processors count the price is 35% from the video cards
            // 4. ram count the price is 10% from the video cards

            double budged = double.Parse(Console.ReadLine());
            int videoCards = int.Parse(Console.ReadLine());
            int processors = int.Parse(Console.ReadLine());
            int ram = int.Parse(Console.ReadLine());

            double videoCardPrice = videoCards * 250;
            double processorPrice = processors * videoCardPrice * 0.35;
            double ramPrice = ram * videoCardPrice * 0.10;

            // totalPrice is videoCardPrice + processorPrice + ramPrice 
            double totalPrice = videoCardPrice + processorPrice + ramPrice;

            // if video cards count is more than the processors he get an discount from the totalPrice by 0.15
            if (videoCards > processors)
            {
                totalPrice *= 0.85;
            }

            if (budged >= totalPrice)
            {
                Console.WriteLine($"You have {budged - totalPrice:f2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(budged - totalPrice):f2} leva more!");
            }

        }
    }
}
