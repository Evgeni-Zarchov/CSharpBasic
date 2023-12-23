namespace _03_DepositCalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            double depositedSum = double.Parse(Console.ReadLine());
            int depositedTerm = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine()) * 0.01;

            double finalSum = depositedSum + depositedTerm * ((depositedSum * percent) / 12);

            Console.WriteLine(finalSum);


        }
    }
}
