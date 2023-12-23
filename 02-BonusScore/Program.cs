namespace _02_BonusScore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // i have to write a program that calc the bonus score on the given number
            // if (num <= 100) {bonusScore = 5}
            // else if (num > 100) {bonusScore *= 0.20} 
            // else num is over 1000 bonus score are 0.10 from the num
            // bonus score if the num is even i will use the formula num % 2 == 0 and the bonus is 1 points
            // for num that ends in the 5 i will use the formula num % 10 == 5 bonus are 2 points

            int num = int.Parse(Console.ReadLine());
            double bonusScore = 0;

            if (num <= 100)
            {
                bonusScore = 5;
            }
            else if (num > 1000)
            {
                bonusScore = num * 0.10;
            }
            else
            {
                bonusScore = num * 0.20;
            }
            if (num % 2 == 0)
            {
                bonusScore += 1;
            }
            else if (num % 10 == 5)
            {
                bonusScore += 2;
            }
            Console.WriteLine(bonusScore);
            Console.WriteLine(num + bonusScore);
        }
    }
}
