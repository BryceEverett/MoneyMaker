using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money_Maker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Money Maker!");
            Console.Write("Convert Money: ");
            double chosenAmount = double.Parse(Console.ReadLine());
            Console.WriteLine($"{chosenAmount} cents is equal to ....");
            double goldValue = 10;
            double silverValue = 5;
            double goldCoins = Math.Floor(chosenAmount / goldValue);
            double Remainder = chosenAmount % goldValue;
            Console.WriteLine($"{goldCoins} gold coins");
            double silverCoins = Math.Floor(Remainder / silverValue);
            double silverRemainder = Remainder % silverValue;
            Console.WriteLine($"{silverCoins} silver coins");
            Console.WriteLine($"{silverRemainder} bronze coins");
            Console.ReadKey();
        }
    }
}
