using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame.N_Tier_Architecture.UI.Print
{
    class PlayersAndComPlayersActions
    {
        public void HowManyPlayers()
        {
            Console.WriteLine("Decide How Many Players Will Play This Game: ");
        }

        public void PlayerNumberX(int number)
        {
            Console.WriteLine("\nPlayer Number {0}: ", number);
        }

        public void PlayersMatrixPrint(int[,] players)
        {
            Console.WriteLine("\nAll Players Scores From The Game:");
            for (int i = 0; i < players.GetLength(0); i++)
            {
                for (int j = 0; j < players.GetLength(1); j++)
                {
                    Console.WriteLine("Player number " + (j + 1) + " , score: " + players[i, j]);
                }
            }
        }
        public void PrintScoresInOrder(List<int> Scores)
        {
            Console.WriteLine("\nAll Scores In Order:");

            for (int i = 0; i < Scores.Count - 1; i++)
            {
                Console.Write(Scores[i] + " -> ");
            }

            Console.WriteLine(Scores[Scores.Count - 1]);
        }

        public void RoundIsOver()
        {
            Console.WriteLine("\nThe Round Is Over. Do You Want To Continue Playing? press 1 to continue, and 0 to stop.");
        }

        public void DoYouWantComputerPlayers()
        {
            Console.WriteLine("Do You Want To Have Computer Players? Press 1 for yes, and 1 for no.");
        }

        public void HowManyComputerPlayersDoYouWantToPlayWith()
        {
            Console.WriteLine("How Many Computer Players Do You Want To Play With?");
        }

        public void TheNumberComputerChooseIs(int index, int number)
        {
            Console.WriteLine("Computer Number {0} Choose: {1}", index + 1, number);
        }

        public void MaxComputerPlayer(int j, int value)
        {
            Console.WriteLine("Computer With The Higher Guess Is: {0}, And It's Guess Was: {1}", j + 1, value);
        }

        public void NoComputerPlayers()
        {
            Console.WriteLine("The Users Have Chosen Not To Have Computer Players.");
        }
    }
}
