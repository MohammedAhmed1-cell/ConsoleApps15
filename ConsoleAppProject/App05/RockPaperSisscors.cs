using System;
namespace ConsoleAppProject.App05
{
    public class RockPaperScisscors
    {

        private String PlayerName = "";
        private int RoundNumber = 0;
        private int PlayerScore = 0;

        public void OutputIntroduction()
        {
            Console.WriteLine("Welcome to Rock Paper Scissors");
        }

        public void GetNameAndRounds()
        {
            Console.WriteLine("Please enter your name > ");
            PlayerName = Console.ReadLine();

            Console.WriteLine("How many rounds do you want to play > ");
            string value = Console.ReadLine();
            RoundNumber = Convert.ToInt32(value);
        }

        public void Play()
        {
            OutputIntroduction();
            GetNameAndRounds();
            RPSRound RPS = new RPSRound();
            for (int i = 0; i < RoundNumber; i++)
            {
                //PlayerScore = PlayerScore + RPS.Play();
            }
        }

    }
}
