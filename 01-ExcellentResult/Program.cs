namespace _01_ExcellentResult
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // so i have to calc the student grade if the student grade is 5.50 - 6 Excellent if less no output

            double grade = double.Parse(Console.ReadLine());

            if (grade >= 5.50)
            {
                Console.WriteLine("Excellent!");
            }
        }
    }
}
