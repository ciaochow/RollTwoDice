using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollTwoDice
{
    class Program
    {
        static void Main(string[] args)
        {
            Random R = new Random();
            int[] counters = new int[13];
            Dictionary<int, int> dictionary = new Dictionary<int, int>();

            for (int i = 2; i < 13; i++)
            {
                dictionary.Add(i, 0);
            }

            for (int numberofrolls = 0; numberofrolls < 100; numberofrolls++)
            {
                int die1 = R.Next(1, 7);
                int die2 = R.Next(1, 7);
                int dietotal = die1 + die2;
                dictionary[dietotal]++;
            }

            // you can use the for loop or foreach loop below. To switch, just uncomment one 
            // and comment out the other.

            //foreach (var VARIABLE in dictionary)
            //{
            //    Console.WriteLine("You rolled a {0} a total of {1} times", VARIABLE.Key, VARIABLE.Value);
            //}
            Console.WriteLine("--- Roll Two 6-sided Dice a total of 100 times ---");
            Console.WriteLine();
            // using a for loop instead of foreach loop.
            for (int i = 2; i < 13; i++)
            {
                Console.WriteLine("You rolled a {0} a total of {1} times.", i, dictionary[i]);
            }
            Console.WriteLine();
            Console.Write("Press any key to quit: ");
            Console.ReadKey();
        }
    }
}
