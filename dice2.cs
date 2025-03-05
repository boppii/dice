//Dice by Nikole Tiffany Powell
//these came with the initializationk
using System.Text;
using Redzen.Random;

// none of those are ever used except for System.IO and System, why are we keeping them???? --erika
namespace dice
{
	//make this public so it can be called from outside
	public class Program
	{
		//class-wide random number generator
		public static Xoshiro512StarStarRandom _random = new();
		
		//main program starting method is also public
		public static void Main(string[] args)

		
		{
			//initialize starting conditions of the rolling variables
			bool diceIsSelected = false;
			int whichDiceSelected = 0;
			
			//setup console window
			//Console.OutputEncoding = Encoding.Unicode;
			
			try
			{
				Console.Title = "Dice";
			}
			catch{};
			//when you don't have a roll selection yet...
			while (!diceIsSelected)
			{
				//ask user for number of sides on the die to be rolled
				//clear screen when run -boppi
				Console.Clear();
				Console.WriteLine("╔═════════════════════════════════════════════════════════════╗");
				Console.WriteLine("║Please enter the number of sides on the die you wish to roll.║");
				Console.WriteLine("║                  Enter '2' to flip a coin.                  ║");
				Console.WriteLine("║                     Enter '0' to exit.                      ║");
				Console.WriteLine("╚═════════════════════════════════════════════════════════════╝");
				Console.Write("->");
				
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
					Console.Clear();
					Console.WriteLine("╔═════════════════════════════════════════════════════════════╗");
					Console.WriteLine("║                                                             ║");
					Console.WriteLine("║                       !invalid entry!                       ║");
					Console.WriteLine("║                                                             ║");
					Console.WriteLine("╚═════════════════════════════════════════════════════════════╝");
					Thread.Sleep(850);
					Console.Clear();
					diceIsSelected = false;
				}

				//if it succeeds...
				else if (result)
				{
					//if they chose "0"...
					if (chosenDice == 0)
					{
						//exit the program
						Console.Clear();
						Console.WriteLine("Bye!");
						Thread.Sleep(1000);
						Console.Clear();
						whichDiceSelected = chosenDice;
						diceIsSelected = true;
						Environment.Exit(0);
					}
					//if they chose a number smaller than two that isn't zero...
					else if (chosenDice < 2)
					{

						//ridicule them for not understanding how three dimensional objects work and try again
						//gonna make this work because funny lol -boppi
						Console.Clear();
						if (chosenDice < 0)
						{
							Console.WriteLine("╔═════════════════════════════════════════════════════════════╗");
							Console.WriteLine("║         is that even possible??? a " + chosenDice + " sided object?         ║");
							Console.WriteLine("║            atleast make it a positive like c'mon            ║");
							Console.WriteLine("║                                                             ║");
							Console.WriteLine("╚═════════════════════════════════════════════════════════════╝");
							Thread.Sleep(850);
							Environment.Exit(0);
						}
						else
						{
							Console.WriteLine("╔═════════════════════════════════════════════════════════════╗");
							Console.WriteLine("║                                                             ║");
							Console.WriteLine("║          is that even possible??? a " + chosenDice + " sided object?         ║");
							Console.WriteLine("║                                                             ║");
							Console.WriteLine("╚═════════════════════════════════════════════════════════════╝");
						}
						Thread.Sleep(850);
						whichDiceSelected = chosenDice;
						diceIsSelected = true;
					}
					
					else if (chosenDice > 999)
					{
						Console.Clear();
						if (OperatingSystem.IsWindows())
						{
							Console.Beep();
						}
						Console.WriteLine("╔═════════════════════════════════════════════════════════════╗");
						Console.WriteLine("║                                                             ║");
						Console.WriteLine("║           Why, why do you need that big of a die?           ║");
						Console.WriteLine("║                                                             ║");
						Console.WriteLine("╚═════════════════════════════════════════════════════════════╝");
						Thread.Sleep(10000);
						Environment.Exit(0);
					}
					else if (chosenDice > 1)
					{
						
						whichDiceSelected = chosenDice;
						
						
						diceIsSelected = true;
					}
					

					//if they choose something that isn't possible...
					//else
					//{
					//	//tell the user that it's not possible
					//	Console.WriteLine("Error: Enumeration Failed!");
					//	
					//	//get out of the loop
					//	whichDiceSelected = chosenDice;
					//	diceIsSelected = true;
					//	
					//	//exit the program
					//	Environment.Exit(0);
					//}
				}
				//if it neither succeeds or fails...
				else
				{
					//tell user they have found a quantum bit unafected by observation
					
					Console.Clear();
					Console.WriteLine("╔═════════════════════════════════════════════════════════════╗");
					Console.WriteLine("║                                                             ║");
					Console.WriteLine("║              Error: Uncollapsed Quantum State!              ║");
					Console.WriteLine("║                                                             ║");
					Console.WriteLine("╚═════════════════════════════════════════════════════════════╝");
					Thread.Sleep(850);
					
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
				
				if (whichDiceSelected == 2){
				Console.WriteLine("╔═════════════════════════════════════════════════════════════╗");
				Console.WriteLine("║                            COIN!                            ║");
				Console.WriteLine("║               Press Escape (Esc) key to exit.               ║");
				Console.WriteLine("║               Press any other key to continue.              ║");
				Console.WriteLine("╚═════════════════════════════════════════════════════════════╝");
				}
				
				else if (whichDiceSelected < 10){
				Console.WriteLine("╔═════════════════════════════════════════════════════════════╗");
				Console.WriteLine("║               Die Selected: " + whichDiceSelected + " Sided Die                     ║");
				Console.WriteLine("║               Press Escape (Esc) key to exit.               ║");
				Console.WriteLine("║               Press any other key to continue.              ║");
				Console.WriteLine("╚═════════════════════════════════════════════════════════════╝");
				}

				else if (whichDiceSelected < 100){
				Console.WriteLine("╔═════════════════════════════════════════════════════════════╗");
				Console.WriteLine("║               Die Selected: " + whichDiceSelected + " Sided Die                    ║");
				Console.WriteLine("║               Press Escape (Esc) key to exit.               ║");
				Console.WriteLine("║               Press any other key to continue.              ║");
				Console.WriteLine("╚═════════════════════════════════════════════════════════════╝");
				}

				else if (whichDiceSelected < 1000){
				Console.WriteLine("╔═════════════════════════════════════════════════════════════╗");
				Console.WriteLine("║               Die Selected: " + whichDiceSelected + " Sided Die                   ║");
				Console.WriteLine("║               Press Escape (Esc) key to exit.               ║");
				Console.WriteLine("║               Press any other key to continue.              ║");
				Console.WriteLine("╚═════════════════════════════════════════════════════════════╝");
				}
				
				//allow key entry to be used
				ConsoleKeyInfo keyEntry;
				
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
						Console.Clear();
						Console.WriteLine("╔═════════════════════════════════════════════════════════════╗");
						Console.WriteLine("║                         coin flipped                        ║");
						
						
						//show heads result
						if (resultNumber == 1)
						{
							Console.WriteLine("║                            Heads                            ║");
						}
						
						//show tails result
						else if (resultNumber == 2)
						{
							Console.WriteLine("║                            Tails                            ║");
						}
						
						//show side result
						else
						{
							//congratulate the user
							Console.WriteLine("║ Wow! It landed on the side, somehow! That's extremely rare! ║");
						}
						
						Console.WriteLine("║  Press Escape (Esc) key to exit. Press Any Key To Continue  ║");
						Console.WriteLine("╚═════════════════════════════════════════════════════════════╝");
						Console.WriteLine("");
					}
					
					//if any other die is selected...
					else
					{
						//show output to user
						Console.WriteLine("1D" + whichDiceSelected + " rolled:");
						Console.WriteLine(resultNumber);
						Console.Clear();
						Console.WriteLine("╔═════════════════════════════════════════════════════════════╗");
						if (whichDiceSelected < 10){
							Console.WriteLine("║                        1D" + whichDiceSelected + " rolled:                          ║");
						}
						else if (whichDiceSelected < 100){
							Console.WriteLine("║                        1D" + whichDiceSelected + " rolled:                         ║");
						}
						else if (whichDiceSelected < 1000){
							Console.WriteLine("║                        1D" + whichDiceSelected + " rolled:                        ║");
						}
						if (resultNumber < 10){
							Console.WriteLine("║                             " + resultNumber + "                               ║");
						}
						else if (resultNumber < 100){
							Console.WriteLine("║                             " + resultNumber + "                              ║");
						}
						else if (resultNumber < 1000){
							Console.WriteLine("║                             " + resultNumber + "                             ║");
						} 
						Console.WriteLine("║  Press Escape (Esc) key to exit. Press Any Key To Continue  ║");
						Console.WriteLine("╚═════════════════════════════════════════════════════════════╝");

					
					
					}

				}
				//then check that the condition for continuation of looping is true
				//if true, then go back to "do"
				while (keyEntry.Key != ConsoleKey.Escape);
				{
					Console.Clear();
					Console.WriteLine("Bye!");
					Thread.Sleep(1000);
					Console.Clear();
					Environment.Exit(0);
				}
				
				//when exiting the loop, deselect the die
				diceIsSelected = false;
				Console.Clear();
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
				int sideDeterminant = _random.Next(1073741823);
				if (sideDeterminant == 1073741823)
				{
					//set output to something that will trigger the "else" condition on line 134
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


//template box
//Console.WriteLine("╔═════════════════════════════════════════════════════════════╗");
//Console.WriteLine("║                                                             ║");
//Console.WriteLine("║                                                             ║");
//Console.WriteLine("║                                                             ║");
//Console.WriteLine("╚═════════════════════════════════════════════════════════════╝");
