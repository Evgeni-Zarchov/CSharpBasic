namespace _03_TimePlus15Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // i have to write a program that calc time plus 15 mins
            // the input is hour and minutes 

            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            minutes = minutes + hours * 60;

            minutes = minutes + 15;

            hours = minutes / 60;
            minutes = minutes % 60;

            bool newDay = hours == 24;

            if (newDay)
            {
                Console.WriteLine($"0:{minutes:D2}");
            }
            else
            {
                Console.WriteLine($"{hours}:{minutes:D2}");
            }
        }
    }
}

