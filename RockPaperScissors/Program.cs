using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int playerScore = 0;
            int computerScore = 0;
            while (true)//sonsuz döngü
            {
                Console.Clear();
                Console.WriteLine("Rock - Paper - Scissors");
            GetInput:
                Console.WriteLine("Choose [r]ock, [p]aper, [s]cissors or [e]xit");
                string playerMove = "";
                switch (Console.ReadLine().ToLower())
                {
                    case "r":
                    case "rock":
                        playerMove = "rock";
                        break;
                    case "p":
                    case "paper":
                        playerMove = "paper";
                        break;
                    case "s":
                    case "scissors":
                        playerMove = "scissors";
                        break;
                    case "e":
                    case "exit":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid input. Try again..");
                        goto GetInput;
                }
                Console.WriteLine($"Your choose {playerMove}");
                Random rnd = new Random();
                int random = rnd.Next(3);//0,1,2
                string computerMove = "";
                switch (random)
                {
                    case 0:
                        computerMove = "paper";
                        break;
                    case 1:
                        computerMove = "rock";
                        break;
                    case 2:
                        computerMove = "scissors";
                        break;
                }
                Console.WriteLine($"Computer choose {computerMove}");
                if ((computerMove == "paper" && playerMove == "rock") || (computerMove == "scissors" && playerMove == "paper") || (computerMove == "rock" && playerMove == "scissors"))//bilgisayarın kazandığı durumlar
                {
                    computerScore++;
                    Console.WriteLine("You lose. Computer wins!");
                }
                else if ((playerMove == "rock" && computerMove == "scissors") || (playerMove == "paper" && computerMove == "rock") || (playerMove == "scissors" && computerMove == "paper"))//oyuncunun kazandığı durumlar
                {
                    playerScore++;
                    Console.WriteLine("You win! Computer lose.");
                }
                else//berabere
                {
                    Console.WriteLine("This game was a draw.");
                }
                Console.WriteLine($"Your score: {playerScore} - ComputerScore: {computerScore}");
                Console.WriteLine("Press enter to continue..");
                Console.ReadLine();

            }



        }
    }
}
