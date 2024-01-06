namespace _08_LunchTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Im at work and i want to watch my fav serial so i have 96 mins lunch and i have to calc
            // Will i have time to eat to rest a bit and to watch my fav serial

            // the input is
            // 1. Serial name
            // 2. Episode Duration
            // 3. Rest Duration

            string serialName = Console.ReadLine();
            int episodeDuration = int.Parse(Console.ReadLine());
            int restDuration = int.Parse(Console.ReadLine());

            double totalTime = restDuration * 5.0 / 8;

            // if the time left is enough i have to print the message
            // "You have enough time to watch {име на сериал} and left with {останало време} minutes free time."
            // else "You don't have enough time to watch {име на сериал}, you need {нужно време} more minutes."

            if (totalTime >= episodeDuration)
            {
                Console.WriteLine($"You have enough time to watch {serialName} and left with {Math.Ceiling(totalTime - episodeDuration)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {serialName}, you need {Math.Ceiling(episodeDuration - totalTime)} more minutes.");
            }
        }
    }
}
