using CardGame.N_Tier_Architecture.UI.Print;
using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame.Common_Layer.Objects
{
    class PlayersAndScoresMatrix 
    {
        public PlayersAndComPlayersActions A { get; set; }
        public int playersAmount { get; set; }

        public PlayersAndScoresMatrix()
        {
            A = new PlayersAndComPlayersActions();
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
