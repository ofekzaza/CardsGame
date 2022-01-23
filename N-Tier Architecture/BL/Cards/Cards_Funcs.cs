using CardGame.N_Tier_Architecture.BL.Cards;
using CardGame.N_Tier_Architecture.BL.Player;
using CardGame.N_Tier_Architecture.UI.Print;
using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame.Mocks
{
    class Cards_Funcs : GetANewCard
    {
        public Cards_Funcs() : base ()
        {
            A = new CardsActions();
        } 
        public void NewCard(int Card)
        {
            if (PermissionToRemoveCardFromPackage(Card))
            {
                PlayersCards.PutNewCardToPackage(Card);
            }
        }

        public bool PermissionToRemoveCardFromPackage(int number)
        {
            return (PlayersCards.ValidatePackageWorth());
        }
    }
}
