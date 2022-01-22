using CardGame.Mocks;
using CardGame.N_Tier_Architecture.BL.Cards;
using CardGame.N_Tier_Architecture.BL.TheGame.PartTwo;
using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame.N_Tier_Architecture.BL.TheGame
{
    class TheGame : TheGame_Func
    {
        public TheGame_Func gameFuncs { get; set; }
        public PlayManyRounds manyRounds { get; set; }

        public TheGame() : base()
        {
            gameFuncs = new TheGame_Func();
            manyRounds = new PlayManyRounds();
        }

        public void StartPlaying()
        {
            gameFuncs.Play();
            gameFuncs.PlayerChooseToStopPlaying();

            if (gameFuncs.PlayerWon)
            {
                manyRounds.Play();
            }

            A.PlayersWinAmount(GetANewCard.PlayersCards.WinningCount);
        }
    }
}
