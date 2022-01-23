using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame.N_Tier_Architecture.UI.Print
{
    class WinningAnouncment
    {
        public void PlayerWonTheGame()
        {
            Console.WriteLine("You Won The Game!");
        }

        public void ComputerWonTheGame(int comNumber, int playerAmount)
        {
            Console.WriteLine("It Has Chosen " + comNumber + ". Your Worth Is " + playerAmount + ". You Lost. Computer Won This Game.");
        }


        public void PlayersWinAmount(int win)
        {
            Console.WriteLine("You Have Won " + win + " Times!");
        }
    }
}
