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
        public RoundsAndLevels A { get; set; }

        public PlayManyRounds()
        {
            A = new RoundsAndLevels();
            CompMove = new ComputerMakesItsMove();
            keepPlaying = new IfWantToGoForAnotherRound();
            gameFuncs = new TheGame_Func();
        }

        public void Play()
        {
            DefaultValue();

            while (IfCanAndWantPlay())
            {
                StartPlayingRound();
            }
        }

        public bool IfCanAndWantPlay()
        {
            return (gameFuncs.PlayerWon && keepPlaying.doestThePlayerWantsToTakeOutANewCard());
        }

        public void DefaultValue()
        {
            gameFuncs.PlayerWon = true;
        }

        public void StartPlayingRound()
        {
            RestartAllInfoBeforeStartPlaying();
            PlayActions();
        }

        public void PlayActions()
        {
            if (!IsCardPackageNull())
            {
                MakeOneMoveAndTheChooseIfWantToKeepPlayingOrStop();
            }
        }

        public void MakeOneMoveAndTheChooseIfWantToKeepPlayingOrStop()
        {
            gameFuncs.Play();
            gameFuncs.PlayerChooseToStopPlaying();
        }

        public bool IsCardPackageNull()
        {
            return (GetANewCard.IsCardsListEmpty());
        }

        public void RestartAllInfoBeforeStartPlaying()
        {
            MakeItHarder();
            RestartPackage();
            GetANewCard.RestartList();
        }

        public void RestartPackage()
        {
            GetANewCard.PlayersCards.CardsPackage = 0;
        }

        public void MakeItHarder()
        {
            if (!CompMove.IsOver21())
            {
                A.HarderLevel();
                CompMove.startGuessingFrom++;
            }
        }
    }
}
