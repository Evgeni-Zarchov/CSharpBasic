using System.Collections.Concurrent;
using System.Net.WebSockets;

namespace _04_ToyShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // so Petia has a shop she have a big order so she have to complete the order 
            // and she wants to go on an excursion from the order money 
            // so my task is to write a program to check if the money is enough
            // if the toys are over 50 0.25 discount 
            // so from the money she have to pay a rent 0.10;

            double excursionPrice = double.Parse(Console.ReadLine());
            double puzzles = double.Parse(Console.ReadLine());
            double doll = double.Parse(Console.ReadLine());
            double bear = double.Parse(Console.ReadLine());
            double minions = double.Parse(Console.ReadLine());
            double trucks = double.Parse(Console.ReadLine());

            double toyCount = puzzles + doll + bear + minions + trucks;
            double totalPrice = puzzles * 2.60 + doll * 3 + bear * 4.10 + minions * 8.20 + trucks * 2;

            if (toyCount >= 50)
            {
                totalPrice = totalPrice - totalPrice * 0.25;
            }
            // the next line i will calc the rent totalPrice = totalPrice - totalPrice * 0.10;
            totalPrice = totalPrice - totalPrice * 0.10;

            // now i have to check the budged if the budged is enough "Yes! {totalPrice - budged} lv left."
            // else if the money is not enough "Not enough money! {Math.Abs(totalPrice - budged)} lv needed."
            // the abs method return the absolute value of the number if goes to else will be a negative number and the budged is not gonna be enough
            if (totalPrice >= excursionPrice)
            {
                Console.WriteLine($"Yes! {totalPrice - excursionPrice:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {Math.Abs(totalPrice - excursionPrice):f2} lv needed.");
            }
        }
    }
}
