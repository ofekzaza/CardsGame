using CardGame.N_Tier_Architecture.BL.TheGame;
using System;

namespace CardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            TheGame newGame = new TheGame();
            newGame.StartPlaying();
        }
    }
}
