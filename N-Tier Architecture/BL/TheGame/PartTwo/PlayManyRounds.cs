using CardGame.N_Tier_Architecture.BL.Cards;
using CardGame.N_Tier_Architecture.BL.ComputerPlayer;
using CardGame.N_Tier_Architecture.BL.TheGame.IfPlayerWantsToKeepPlaying;
using CardGame.N_Tier_Architecture.UI.Print;
using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame.N_Tier_Architecture.BL.TheGame.PartTwo
{
    class PlayManyRounds
    {
        public IfWantToGoForAnotherRound keepPlaying { get; set; }
        public ComputerMakesItsMove CompMove { get; set; }
        public TheGame_Func gameFuncs { get; set; }
        private AskForActions _a;

        public PlayManyRounds()
        {
            _a = new AskForActions();
            CompMove = new ComputerMakesItsMove();
            keepPlaying = new IfWantToGoForAnotherRound();
            gameFuncs = new TheGame_Func();
        }

        public void Play()
        {
            while (keepPlaying.doestThePlayerWantsToTakeOutANewCard())
            {
                StartPlayingRound();
            }
        }

        public void StartPlayingRound()
        {
            RestartAllInfoBeforeStartPlaying();
            PlayActions();
        }

        public void PlayActions()
        {
            gameFuncs.Play();
            gameFuncs.PlayerChooseToStopPlaying();
        }

        public void RestartAllInfoBeforeStartPlaying()
        {
            MakeItHarder();
            RestartPackage();
        }

        public void RestartPackage()
        {
            GetANewCard.PlayersCards.CardsPackage = 0;
        }

        public void MakeItHarder()
        {
            if (!CompMove.IsOver21())
            {
                _a.HarderLevel();
                CompMove.startGuessingFrom++;
            }
        }
    }
}
