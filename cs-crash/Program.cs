using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            string player;
            string computer;
            string answer;

            while (playAgain)
            {
                player = "";
                computer = "";
                answer = "";

                while(player != "ROCK" && player != "PAPER" & player != "SCISSORS") {
                    Console.WriteLine("Enter ROCK, PAPER OR SCISSORS: ");
                    player = Console.ReadLine();
                    player = player.ToUpper();
                    Console.WriteLine(player);

                    switch(random.Next(1, 4))
                    {
                        case 1:
                            computer = "ROCK";
                            break;
                        case 2:
                            computer = "PAPER";
                            break;
                        case 3:
                            computer = "SCISSORS";
                            break;
                        default:
                            computer = "";
                            break;
                    }
                    Console.WriteLine("Player: " + player);
                    Console.WriteLine("Computer " + computer);

                    switch (player) {
                        case "ROCK":
                            if(computer == "ROCK")
                            {
                                Console.WriteLine("Its a draw");
                            }
                            else if(computer == "PAPER")
                            {
                                Console.WriteLine("You Lose!");
                            } else
                            {
                                Console.WriteLine("You win!");
                            }
                            break;
                        case "PAPER":
                            if (computer == "ROCK")
                            {
                                Console.WriteLine("You win!");
                            }
                            else if (computer == "PAPER")
                            {
                                Console.WriteLine("Its a draw!");
                            }
                            else
                            {
                                Console.WriteLine("You lost!");
                            }
                            break;
                        case "SCISSORS":
                            if (computer == "ROCK")
                            {
                                Console.WriteLine("You lost!");
                            }
                            else if (computer == "PAPER")
                            {
                                Console.WriteLine("You win!");
                            }
                            else
                            {
                                Console.WriteLine("Its a draw!");
                            }
                            break;
                    }
                    Console.Write("Would you like to play again (Y/N): ");
                    answer = Console.ReadLine();
                    answer = answer.ToUpper();

                    if(answer == "Y")
                    {
                        playAgain = true;
                    } else
                    {
                        playAgain = false;
                    }
                }
                Console.WriteLine("Thanks for playing!");
            }
        }
    }
}