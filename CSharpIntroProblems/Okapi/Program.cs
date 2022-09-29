using System;
using System.Linq;

/*
 * Okapi
 * 
 * The game of Okapi is played by rolling three dice. A payout in dollars is determined by
 * the rolled numbers according to the following rule:
 * 
 * • If the three numbers are the same, the player wins the sum of those three numbers.
 * • If only two of the numbers are the same, the player wins the sum of the two equal numbers.
 * • For three different numbers, the player wins nothing.
 *
 * Write a program that prompts the user for three dice rolls and outputs the payout.
 * 
 * The following test cases illustrate the required I/O format.
 *
 * Enter dice rolls: 3 3 3
 * The payout is $9.
 *
 * Enter dice rolls: 5 3 5
 * The payout is $10.
 *
 * Enter dice rolls: 5 4 6
 * The payout is $0.
 */

namespace Okapi
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int r = 0; r < 3; r++)
            {
                Console.Write("Enter dice rolls: ");

                // This is Linq.  Linq can make your life pretty easy
                var nums = Console.ReadLine() // Read a string from the user
                    .Split(" ") // Split the text input into an array of strings
                    .Select(n => Convert.ToInt32(n)) // Select each string and convert it to an integer
                    .ToList(); // Now turn the integer collection into a List

                int[] dice = { nums[0], nums[1], nums[2] };
                int payout = 0;
                bool foundMatch = false;

                //this is such a dumb way to do thisssss
                for (int i = 1; i < dice.Length; i++)
                {
                    if (dice[i] == dice[0])
                    {
                        payout += dice[0];
                        foundMatch = true;
                    }
                }
                if (foundMatch) payout += dice[0];
                else
                {
                    if (dice[1] == dice[2])
                    {
                        payout += dice[1] * 2;
                    }
                }
                Console.Write($"The payout is ${payout}.");
                Console.WriteLine();
                
            }
            
        }
    }
}