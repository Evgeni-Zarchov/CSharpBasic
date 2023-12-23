namespace _01_SumSeconds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // sum seconds so i have to convert a number into minutes and seconds 
            // thw input will be 35,45,44 so i have to sum them till i have a one number
            // then i have to divide for minutes / 60 bcs one minute is 60 seconds
            // for seconds i will use % to return the remainder so if i have 80 seconds thats a 1 min and 20 seconds

            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            int fullNumber = firstNum + secondNum + thirdNum;

            int minutes = fullNumber / 60;
            int seconds = fullNumber % 60;
            if (seconds >= 10)
            {
                // so if seconds are more than 10 print Console.WriteLine($"{minutes}:{seconds}")
                Console.WriteLine($"{minutes}:{seconds}");
            }
            else
            {
                // else Console.WriteLine($"{minutes}{seconds}")
                Console.WriteLine($"{minutes}:0{seconds}");
            }
        }
    }
}
