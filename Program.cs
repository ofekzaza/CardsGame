using CardGame.N_Tier_Architecture.BL.Player;
using CardGame.N_Tier_Architecture.BL.TheGame;
using CardGame.N_Tier_Architecture.BL.TheGame.PartThree;
using System;

namespace CardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //TheGame newGame = new TheGame();
            //newGame.StartPlaying();

            ManyPlayersGame_Funcs game = new ManyPlayersGame_Funcs();
            game.DoesWantToPlay();


            //int[,] scores = game.PlayersAndScores;

            //AllScoresInOrder ScoresInOrder = new AllScoresInOrder(scores);
            //ScoresInOrder.OrderScoreList();
            //foreach (int score in ScoresInOrder.ScoresInOrder)
            //{
            //    Console.WriteLine(score + " -> ");
            //}
    }
    }
}
