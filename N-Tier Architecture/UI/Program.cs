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
            ManyPlayersGame game = new ManyPlayersGame();
            game.StartTheGame();
        }
    }
}
