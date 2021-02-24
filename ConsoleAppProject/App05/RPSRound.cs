using System;
namespace ConsoleAppProject.App05
{
    public class RPSRound
    {
        public RPSRound()
        {
            
        }

        public int Play()
        {
            int result = -1;

            Console.WriteLine("Do you choose Rock, Paper or Scissors");
            while (result == -1)
            {
                string UserChoice = Console.ReadLine();
                if (UserChoice == "Rock") GameImages.DrawRock();
                else if (UserChoice == "Paper") GameImages.DrawPaper();
                else if (UserChoice == "Scissors") GameImages.DrawScissors();

                Console.WriteLine("YOU HAVE WON");
                GameImages.DrawThumbsUp();

                Console.WriteLine("YOU HAVE LOST");
                GameImages.DrawThumbsDown();


                Random r = new Random();
                int computerChoice = r.Next(1, 4);

                if (computerChoice == 1)//computer chooses rock
                {
                    if (UserChoice == "Rock")
                    {
                        Console.WriteLine("The computer has chosen Rock");
                        Console.WriteLine("It is a tie");
                        result = 1;
                    }
                    else if (UserChoice == "Paper")
                    {

                        Console.WriteLine("The computer chose Rock");
                        Console.WriteLine("Paper has beaten Rock, YOU HAVE WON!");
                        result = 0;
                    }
                    else if (UserChoice == "Scissors")
                    {
                        Console.WriteLine("The computer chose Rock");
                        Console.WriteLine("Rock has beaten Scissors, YOU HAVE LOST!");
                        result = 2;

                    }
                    else
                    {
                        Console.WriteLine("Choose either Rock, Paper or Scissors");
                    }

                }
                else if (computerChoice == 2)//computer choses paper 
                {
                    if (UserChoice == "Rock")
                    {
                        Console.WriteLine("The computer chose paper");
                        Console.WriteLine("Paper has beaten Rock, YOU HAVE LOST!");
                        result = 2;
                    }
                    else if (UserChoice == "Paper")
                    {
                        Console.WriteLine("The computer has chosen Paper");
                        Console.WriteLine("It is a tie");
                        result = 1;
                    }
                    else if (UserChoice == "Scissors")
                    {
                        Console.WriteLine("The computer chose Paper");
                        Console.WriteLine("Scissors has beaten Paper, YOU HAVE WON");
                        result = 0;
                    }
                    else
                    {
                        Console.WriteLine("Choose either Rock, Paper or Scissors");
                    }
                }
                else if (computerChoice == 3)//computer choses scissors
                {
                    if (UserChoice == "Rock")
                    {
                        Console.WriteLine("The computer chose Scissors");
                        Console.WriteLine("Rock has beaten Scissors, YOU HAVE WON");
                        result = 0;
                    }
                    else if (UserChoice == "Paper")
                    {
                        Console.WriteLine("The computer chose Scissors");
                        Console.WriteLine("Scissors has beaten Paper, YOU HAVE LOST!");
                        result = 2;
                    }
                    else if (UserChoice == "Scissors")
                    {
                        Console.WriteLine("The computer chose Scissors");
                        Console.WriteLine("It is a tie");
                        result = 1;
                    }
                    else
                    {
                        Console.WriteLine("Choose either Rock, Paper or Scissors");
                    }
                   
                }
            }


            return result;    
        }
    }
}
