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
            //Kullanıcıdan rock için r , paper için p , scissors için s tuşlamasını isteyiniz. r için => R yada rock olma durumunda da r kabul ediniz. exit için ise e yada E/exit tuşlasın.
            //Kullanıcı çıkış tuşuna basmadığı sürece giriş yaptığı ve bilgisayarında rastgele bir seçim yaparak her tur için kim kazanırsa onun puanını artırınız.(playerScore, computerScore)
            //Her tur sonunda kimin kazandığını yada beraber olma durumunu bilgilendiriniz ve aynı zamanda scorelarıda ekrana yazdırınız.
            //Her tur bittikten sonra yeni tur başladığında ise console ekranını temizleyiniz.
            //Kullanıcı çıkış tuşuna bastığında console'u kapatınız.
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
