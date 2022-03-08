using System;
using System.Collections.Generic;
using System.Text;

namespace HiLoGame //Chapter 4 - Types and References
{
    static class HiLoGame
    {
        public const int MAXIMUM = 10;
        //private static Random random = new Random();
        public static Random random = new Random(); //swap in with above line to cheat
        private static int currentNumber = random.Next(1, MAXIMUM + 1);
        private static int nextNumber = random.Next(1, MAXIMUM + 1); //code correction on GitHub
        private static int pot = 10;

        public static int GetPot() { return pot; }

        public static void Guess(bool higher)
        {
            //int nextNumber = random.Next(1, MAXIMUM + 1); //code correction on GitHub
            if ((higher && nextNumber >= currentNumber) ||
                    (!higher && nextNumber <= currentNumber))
            {
                Console.WriteLine("You guessed right!");
                pot++;
            }
            else
            {
                Console.WriteLine("Bad luck, you guessed wrong.");
                pot--;
            }
            currentNumber = nextNumber;
            nextNumber = random.Next(1, MAXIMUM + 1);
            Console.WriteLine($"The current number is {currentNumber}");
        }

        public static void Hint()
        {
            int half = MAXIMUM / 2;
            //code correction on GitHub - replace messages with better messages
            //if (currentNumber >= half)
            //    Console.WriteLine($"The number is at least {half}");
            //else Console.WriteLine($"The number is at most {half}");
            if (nextNumber >= half)
                Console.WriteLine($"The current number is {currentNumber}, the next number is at least {half}");
            else Console.WriteLine($"The current number is {currentNumber}, the next is at most {half}");
            pot--;
        }
    }
}
