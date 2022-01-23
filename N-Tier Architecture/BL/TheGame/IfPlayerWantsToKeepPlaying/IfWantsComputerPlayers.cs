using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame.N_Tier_Architecture.BL.TheGame.IfPlayerWantsToKeepPlaying
{
    class IfWantsComputerPlayers : IfWantToGoForAnotherRound
    {
        public IfWantsComputerPlayers() : base ()
        {
        }

        public bool DoTheyWantToHaveComputerPlayers()
        {
            return ValidatePlayersAsnwer(GetPlayersAnswerForKeepPlayingTheGame()) == KeepPlaying;
        }

        public new int GetPlayersAnswerForKeepPlayingTheGame()
        {
            B.DoYouWantComputerPlayers();
            return int.Parse(Console.ReadLine());
        }
    }
}
