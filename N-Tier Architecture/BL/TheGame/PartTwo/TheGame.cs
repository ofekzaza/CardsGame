﻿using CardGame.Mocks;
using CardGame.N_Tier_Architecture.BL.Cards;
using CardGame.N_Tier_Architecture.BL.TheGame.PartTwo;
using CardGame.N_Tier_Architecture.UI.Print;
using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame.N_Tier_Architecture.BL.TheGame
{
    class TheGame : TheGame_Func
    {
        public TheGame_Func gameFuncs { get; set; }
        public PlayManyRounds manyRounds { get; set; }
        public WinningAnouncment B { get; set; }

        public TheGame() : base()
        {
            gameFuncs = new TheGame_Func();
            manyRounds = new PlayManyRounds();
            B = new WinningAnouncment();
        }

        public void StartPlaying()
        {
            gameFuncs.Play();
            gameFuncs.PlayerChooseToStopPlaying();

            IfWonTheFirstGame_CanChooseToGoForManyRounds();

            WinningAmount();
        }

        public void IfWonTheFirstGame_CanChooseToGoForManyRounds()
        {
            if (gameFuncs.PlayerWon)
            {
                manyRounds.Play();
            }
        }

        public void WinningAmount()
        {
            B.PlayersWinAmount(GetANewCard.PlayersCards.WinningCount);
        }
    }
}
