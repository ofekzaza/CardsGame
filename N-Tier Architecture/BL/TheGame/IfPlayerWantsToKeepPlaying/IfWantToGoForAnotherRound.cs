using CardGame.N_Tier_Architecture.UI.Print;
using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame.N_Tier_Architecture.BL.TheGame.IfPlayerWantsToKeepPlaying
{
    class IfWantToGoForAnotherRound : IfWantsToKeepPlaying
    {
        public RoundsAndLevels C { get; set; }
        public IfWantToGoForAnotherRound() : base()
        {
            C = new RoundsAndLevels();
        }

        public new bool doestThePlayerWantsToTakeOutANewCard()
        {
            return ValidatePlayersAsnwer(GetPlayersAnswerForKeepPlayingTheGame()) == KeepPlaying;
        }

        public new int GetPlayersAnswerForKeepPlayingTheGame()
        {
            C.NewRound();
            return int.Parse(Console.ReadLine());
        }
    }
}
