using CardGame.Mocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame.N_Tier_Architecture.BL.Cards.SpecialCards
{
    class PrinceOrQueenOrKing_Funcs : Cards_Funcs
    {
        public const int CardNumber = 11 | 12 | 13;
        public const int Value = 10;
        public PrinceOrQueenOrKing_Funcs() : base ()
        {
        }

        public new void NewCard(int Card)
        {
            AllValidationsOnNumber(Card);
            PlayersCards.PutNewCardToPackage(Value);
        }
    }
}
