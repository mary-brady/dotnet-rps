using System;
using System.Collections.Generic;
using rock_paper_scissors.Models;


namespace rock_paper_scissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("RPS TOWN!");
            List<string> choices = new List<string>() { "rock", "paper", "scissors" };
            bool playing = true;

            Random random = new Random();
            int ComputerChoice = random.Next(0, 3);
            while (playing)
            {
                Console.WriteLine("Choose your weapon:");

                choices.ForEach(choice => Console.WriteLine(choice));

                string PlayerChoice = Console.ReadLine().ToLower();

                if (PlayerChoice == choices[ComputerChoice])
                {
                    Console.WriteLine("Tie game...Play Again? (Y/N)");
                    string response = Console.ReadLine();
                    if (response.ToUpper() != "Y")
                    {
                        playing = false;
                    }
                }

                if (PlayerChoice == "rock")
                {
                    if (ComputerChoice == 1)
                    {
                        Console.WriteLine($"Computer chose {choices[ComputerChoice]}, Computer wins! Play again? (Y/N)");
                        string response = Console.ReadLine();
                        if (response.ToUpper() != "Y")
                        {
                            playing = false;
                        }
                    }
                    else
                    {
                        Console.WriteLine($"You chose {PlayerChoice}- you won! Computer chose {choices[ComputerChoice]}. Play again? (Y/N)");
                        string response = Console.ReadLine();
                        if (response.ToUpper() != "Y")
                        {
                            playing = false;
                        }
                    }
                }
                else if (PlayerChoice == "paper")
                {
                    if (ComputerChoice == 2)
                    {
                        Console.WriteLine($"Computer chose {choices[ComputerChoice]}, Computer wins! Play again? (Y/N)");
                        string response = Console.ReadLine();
                        if (response.ToUpper() != "Y")
                        {
                            playing = false;
                        }
                    }
                    else
                    {
                        Console.WriteLine($"You chose {PlayerChoice} - you won! Computer chose {choices[ComputerChoice]}. Play again? (Y/N)");
                        string response = Console.ReadLine();
                        if (response.ToUpper() != "Y")
                        {
                            playing = false;
                        }
                    }
                }
                else
                {
                    if (PlayerChoice == "scissors")
                    {
                        Console.WriteLine($"Computer chose {choices[ComputerChoice]}, Computer wins! Play again? (Y/N)");
                        string response = Console.ReadLine();
                        if (response.ToUpper() != "Y")
                        {
                            playing = false;
                        }
                    }
                }

            }
        }

    }
}