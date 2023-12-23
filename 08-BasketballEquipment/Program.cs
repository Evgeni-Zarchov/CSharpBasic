namespace _08_BasketballEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // so Desi want to train basketball and i have to write a program that calc the money by year price
            // on the first input i will have basketball shoes the price is less than year tax by 40%
            // on the second input i will have basketball dress the price is less than shoes price by 20%
            // on the third input i will have basket ball the price is 1/4 from the dress
            // the last input will be accessories the price will be 1/5 from ball
            int yearTax = int.Parse(Console.ReadLine());

            double basketBallShoes = yearTax - yearTax * 0.40;
            double basketDress = basketBallShoes - basketBallShoes * 0.20;
            double ball = basketDress / 4;
            double acc = ball / 5;
            double totalPrice = yearTax + basketBallShoes + basketDress + ball + acc;
            Console.WriteLine(totalPrice);


        }
    }
}
