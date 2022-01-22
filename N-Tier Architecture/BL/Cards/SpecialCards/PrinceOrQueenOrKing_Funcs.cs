using CardGame.Mocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame.N_Tier_Architecture.BL.Cards.SpecialCards
{
    class PrinceOrQueenOrKing_Funcs : AceCard_Funcs
    {
        public new const int Value = 10;
        public PrinceOrQueenOrKing_Funcs() : base ()
        {
        }

        public new void NewCard(int Card)
        {
            A.ChooseValueOfCard();
            GetUsersInputForCard();
            PressCorrectValue();
            AddValueToPlayersCardPackage();
        }

        public new void AddValueToPlayersCardPackage()
        {
            PlayersCards.PutNewCardToPackage(Value);
        }
    }
}
