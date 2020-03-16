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
            //initialize starting conditions of the rolling variables
            bool diceIsSelected = false;
            int whichDiceSelected = 0;
            //ask user for number of sides on the die to be rolled
            Console.WriteLine("Please enter the number of sides on the die you wish to roll.");
            Console.WriteLine("Enter 2 to flip a coin, 0 to exit.");
            //when you don't have a roll selection yet...
            while (!diceIsSelected)
            {
                Console.Write(":");
                //put the number selected into a holding string
                string chosenSides = Console.ReadLine();
                //initialize a holding integer
                int chosenDice = 0;
                //try to put the content of the holding string into the holding integer
                bool result = int.TryParse(chosenSides, out chosenDice);
                //if that fails...
                if (!result)
                {
                    //tell the user that it failed and start over
                    Console.WriteLine("invalid entry");
                    diceIsSelected = false;
                }
                //if it succeeds...
                else if (result)
                {
                    //if they chose "0"...
                    if (chosenDice == 0)
                    {
                        //exit the program
                        Console.WriteLine("Bye!");
                        whichDiceSelected = chosenDice;
                        diceIsSelected = true;
                        Environment.Exit(0);
                    }
                    //if they chose a number smaller than two that isn't zero...
                    else if (chosenDice < 2)
                    {
                        //ridicule them for not understanding how three dimensional objects work and try again
                        Console.WriteLine("is that even possible??? a " + chosenDice + " sided object?");
                    }
                    //if they choose a number larger than one...
                    else if (chosenDice > 1)
                    {
                        //put the content of the holding integer into the rolling integer
                        whichDiceSelected = chosenDice;
                        //exit this input deciding loop
                        diceIsSelected = true;
                    }
                    //if they choose something that isn't possible...
                    else
                    {
                        //tell the user that it's not possible
                        Console.WriteLine("Error: Enumeration Failed!");
                        //get out of the loop
                        whichDiceSelected = chosenDice;
                        diceIsSelected = true;
                        //exit the program
                        Environment.Exit(0);
                    }
                }
                //if it neither succeeds or fails...
                else
                {
                    //tell user they have found a quantum bit unafected by observation
                    Console.WriteLine("Error: Uncollapsed Quantum State!");
                    //get out of the loop
                    whichDiceSelected = chosenDice;
                    diceIsSelected = true;
                    //exit the program
                    Environment.Exit(0);
                }
            }
            //when you have a successful roll selection...
            while (diceIsSelected)
            {
                //tell user what die was selected
                Console.WriteLine("Die Selected:");
                Console.WriteLine("1D" + whichDiceSelected);
                Console.WriteLine("");
                //allow key entry to be used
                ConsoleKeyInfo keyEntry;
                //tell user how to exit the program
                Console.WriteLine("Press Escape (Esc) key to exit.");
                Console.WriteLine("Press any other key to continue.");
                //execute the following code then check the condition in "while"
                do
                {
                    //assign key entry to whatever key is pressed
                    keyEntry = Console.ReadKey();
                    //create a result variable
                    int resultNumber = 0;
                    Console.WriteLine("");
                    Console.WriteLine("");
                    //set result to the output of the roller and give it a die as input
                    resultNumber = diceResult(whichDiceSelected);
                    //if a coin is selected...
                    if (whichDiceSelected == 2)
                    {
                        Console.WriteLine("1 coin flipped:");
                        //show heads result
                        if (resultNumber == 1)
                        {
                            Console.WriteLine("Heads");
                        }
                        //show tails result
                        else if (resultNumber == 2)
                        {
                            Console.WriteLine("Tails");
                        }
                        //show side result
                        else
                        {
                            //congratulate the user
                            Console.WriteLine("Wow! It landed on the side, somehow! That's extremely rare!");
                        }
                        Console.WriteLine("");
                    }
                    //if any other die is selected...
                    else
                    {
                        //show output to user
                        Console.WriteLine("1D" + whichDiceSelected + " rolled:");
                        Console.WriteLine(resultNumber);
                        Console.WriteLine("");
                    }
                }
                //then check that the condition for continuation of looping is true
                //if true, then go back to "do"
                while (keyEntry.Key != ConsoleKey.Escape);
                //when exiting the loop, deselect the die
                diceIsSelected = false;
            }
            
        }
        //roller method takes an integer as input
        public static int diceResult(int input)
        {
            //create output variable
            int output = 0;
            //if the coin is selected...
            if (input == 2)
            {
                //create the chance of landing on the side
                int sideDeterminant = _random.Next(2147483646);
                if (sideDeterminant == 284941827)
                {
                    //set output to something that will trigger the "else" condition
                    output = 3;
                }
                else
                {
                    //call randomizer method and set output variable to output of the method called
                    output = randR(input);
                }
            }
            //if any other die is selected...
            else
            {
                //call randomizer method and set output variable to output of the method called
                output = randR(input);
            }
            //return output to where the method is called
            return output;
        }
        //randomizer method takes in an integer
        public static int randR(int randInp)
        {
            //set output as random number with die as input
            int randOut = _random.Next(randInp);
            //add one to output to avoid an output of zero
            randOut = randOut + 1;
            //send out the output
            return randOut;
        }
    }
}
