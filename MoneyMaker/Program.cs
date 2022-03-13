using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyMaker
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            Money Maker with C#.

            This program finds the minimum of coins needed that equals a certain value.

            You have four types of coins:

            A penny coin is worth 1 cent
            A nickel coin is worth 5 cents
            A dime coin is worth 10 cents
            A quarter coin is worth 25 cents
                        
            I.E. For example, 16 cents could be:

                16 pennys,
                3 nickels and 1 penny, or
                1 dime, 1 nickel, 1 penny
            
            I.E. For example, 16 cents could be:

                16 bronze coins,
                3 silver coins and 1 bronze coin, or
                1 gold coin, 1 silver coin, 1 bronze coin

            Overall, developing it helps me to practice my skills of working with Data Types and Variables in C#.

            Author: Ricardo Carvalheira
            */


            // Let the user know that the program is starting:
            string title = "Money Maker";
            Console.WriteLine($"\r\n    Welcome to {title}!");
            Console.WriteLine("\r\n     Press Enter to start...");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("There are four types of coins: " +
             "\r\n    • A penny coin is worth 1 cent" +
             "\r\n    • A nickel coin is worth 5 cents" +
             "\r\n    • A dime coin is worth 10 cents" +
             "\r\n    • A quarter coin is worth 25 cents");
            string totalValueAsString;
            Console.Write("\r\nEnter the amount to convert to coins: ");
            totalValueAsString = Console.ReadLine();

            double totalValueAsDouble = Math.Floor(Convert.ToDouble(totalValueAsString));

            Console.WriteLine($"\r\n{totalValueAsDouble} cents is equals to...");

            int quarterValue = 25;
            int dimeValue = 10;
            int nickelValue = 5;

            double totalQuarters;
            double totalDimes;
            double totalNickels;

            totalQuarters = Math.Floor(totalValueAsDouble / quarterValue);

            double remainder = totalValueAsDouble % quarterValue;

            totalDimes = Math.Floor(remainder / dimeValue);

            remainder = remainder % dimeValue;

            totalNickels = Math.Floor(remainder / nickelValue);

            remainder = remainder % nickelValue;

            Console.WriteLine($"Quarters: {totalQuarters}\r\nDimes: {totalDimes}\r\nNickels: {totalNickels}\r\nPennys: {remainder}");

            Console.WriteLine("\r\n     Press Enter to close tab...");
            Console.ReadLine();
            Console.Clear();

        }
    }
}
