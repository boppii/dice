//Dice by Nikole Tiffany Powell
using System;
//these came with the initialization
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//useful thingsies
using System.IO;
using System.Threading;
using System.Reflection;

namespace dice
{
    //make this public so it can be called from outside
    public class Program
    {
        //class-wide random number generator
        public static Random _random = new Random();
        //main program starting method is also public
        public static void Main(string[] args)
        {
            /*
            int randomNumberA = _random.Next(2147483646);
            Console.WriteLine("your random number is: " + randomNumberA);
            */
            bool diceIsSelected = false;
            int whichDiceSelected = 0;
            Console.WriteLine("Please enter the number of sides on the die you wish to roll.");
            Console.WriteLine("Enter 2 to flip a coin, 0 to exit.");
            while (!diceIsSelected)
            {
                Console.Write(":");
                string chosenSides = Console.ReadLine();
                int chosenDice = 0;
                bool result = int.TryParse(chosenSides, out chosenDice);
                if (!result)
                {
                    Console.WriteLine("invalid entry");
                }
                else if (result)
                {
                    if (chosenDice == 0)
                    {
                        Console.WriteLine("Bye!");
                        whichDiceSelected = chosenDice;
                        diceIsSelected = true;
                        Environment.Exit(0);
                    }
                    else if (chosenDice < 2)
                    {
                        Console.WriteLine("is that even possible??? a " + chosenDice + " sided object?");
                    }
                    else if (chosenDice > 1)
                    {
                        whichDiceSelected = chosenDice;
                        diceIsSelected = true;
                    }
                    else
                    {
                        Console.WriteLine("Error: Enumeration Failed!");
                        whichDiceSelected = chosenDice;
                        diceIsSelected = true;
                        Environment.Exit(0);
                    }
                }
                else
                {
                    Console.WriteLine("Error: Uncollapsed Quantum State!");
                    whichDiceSelected = chosenDice;
                    diceIsSelected = true;
                    Environment.Exit(0);
                }
            }
            while (diceIsSelected)
            {
                Console.WriteLine("Die Selected:");
                Console.WriteLine("1D" + whichDiceSelected);
                Console.WriteLine("");
                ConsoleKeyInfo keyEntry;
                Console.WriteLine("Press Escape (Esc) key to exit.");
                Console.WriteLine("Press any other key to continue.");
                do
                {
                    keyEntry = Console.ReadKey();
                    int resultNumber = 0;
                    Console.WriteLine("");
                    Console.WriteLine("");
                    if (whichDiceSelected == 2)
                    {
                        resultNumber = diceResult(whichDiceSelected);
                        Console.WriteLine("1 coin flipped:");
                        if (resultNumber == 1)
                        {
                            Console.WriteLine("Heads");
                            Console.WriteLine("");
                        }
                        else if (resultNumber == 2)
                        {
                            Console.WriteLine("Tails");
                            Console.WriteLine("");
                        }
                        else
                        {
                            Console.WriteLine("Error: " + resultNumber);
                            Console.WriteLine("");
                        }
                    }
                    else
                    {
                        resultNumber = diceResult(whichDiceSelected);
                        Console.WriteLine("1D" + whichDiceSelected + " rolled:");
                        Console.WriteLine(resultNumber);
                        Console.WriteLine("");
                    }
                }
                while (keyEntry.Key != ConsoleKey.Escape);
                diceIsSelected = false;
            }
            
        }
        public static int diceResult(int input)
        {
            int output = _random.Next(input);
            output = output + 1;
            return output;
        }
    }
}

