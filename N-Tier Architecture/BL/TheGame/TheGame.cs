using CardGame.Mocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame.N_Tier_Architecture.BL.TheGame
{
    class TheGame : TheGame_Func
    {
        public TheGame_Func gameFuncs { get; set; }

        public TheGame() : base()
        {
            gameFuncs = new TheGame_Func();
        }

        public void StartPlaying()
        {
            gameFuncs.IfWantsToPlay_GetANewCard();
        }
    }
}
