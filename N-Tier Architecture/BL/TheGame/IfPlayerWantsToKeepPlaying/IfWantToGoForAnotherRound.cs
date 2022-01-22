using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame.N_Tier_Architecture.BL.TheGame.IfPlayerWantsToKeepPlaying
{
    class IfWantToGoForAnotherRound : IfWantsToKeepPlaying
    {
        public IfWantToGoForAnotherRound() : base()
        {
        }

        public new bool doestThePlayerWantsToTakeOutANewCard()
        {
            return ValidatePlayersAsnwer(GetPlayersAnswerForKeepPlayingTheGame()) == KeepPlaying;
        }

        public new int GetPlayersAnswerForKeepPlayingTheGame()
        {
            A.NewRound();
            return int.Parse(Console.ReadLine());
        }
    }
}
