namespace _04_vacationBookList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // i have to write a program vacation book list
            // the following input will contain 

            // num of pages 
            // pages 
            // days count 

            // i have to get my input

            int numOfPages = int.Parse(Console.ReadLine());
            int pages = int.Parse(Console.ReadLine());
            int daysCount = int.Parse(Console.ReadLine());

            int hoursNeed = numOfPages / pages;

            double totalTime = hoursNeed / daysCount;

            Console.WriteLine(totalTime);


        }
    }
}
