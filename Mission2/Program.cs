using System;

namespace Mission2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string temp = ""; //This declares a string I will use later

            int rolls = 0; //This declares the rolls int
            Random r = new Random();

            int[] rollTotals = new int[12]; //This simulates the roll of two dice

            Console.WriteLine("Welcome to the dice throwing simulator!");
            Console.Write("How many dice rolls would you like to simulate? "); //This gets user input for amount of dice rolls

            rolls = int.Parse(Console.ReadLine());

            for (int i = 0; i < rolls; i++)
            {
                int roll = r.Next(2, 12); //This sets the available sum of the two dice to a value between 2 and 12
                

                rollTotals[roll]++;
            }

            for (int i = 1; i < 12; i++)
            {
                temp = "";
                for (int j = 0; j < (rollTotals[i]); j++)
                {
                    temp += "*"; //This adds asterisks equal to the number of times the diec roll outcome equaled that number
                }
                Console.WriteLine((i + 1) + ": " + temp); //This prints the histogram of asterisks
            }
        }
    }
}
