using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame.Common_Layer.Objects
{
    class CompuerPlayersMatrix : PlayersAndScoresMatrix
    {
        public CompuerPlayersMatrix() : base ()
        {

        }

        public int HowManyComputerPlayersPlayTheGame()
        {
            A.HowManyComputerPlayersDoYouWantToPlayWith();
            return int.Parse(Console.ReadLine());
        }

        public int[,] SetComputerPlayers()
        {
            playersAmount = HowManyComputerPlayersPlayTheGame();
            return (new int[1, playersAmount]);
        }
    }
}
