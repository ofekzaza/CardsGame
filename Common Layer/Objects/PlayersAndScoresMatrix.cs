using CardGame.N_Tier_Architecture.UI.Print;
using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame.Common_Layer.Objects
{
    class PlayersAndScoresMatrix 
    {
        public AskForActions A { get; set; }
        public int playersAmount { get; set; }

        public PlayersAndScoresMatrix()
        {
            A = new AskForActions();
        }

        public int HowManyPlayersPlayTheGame()
        {
            A.HowManyPlayers();
            return int.Parse(Console.ReadLine());
        }

        public int[,] SetPlayersAndScores()
        {
            playersAmount = HowManyPlayersPlayTheGame();
            return (new int[1, playersAmount]);
        }
    }
}
