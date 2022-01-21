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
            A = new AskForActions();
        } 
        public void NewCard(int Card)
        {
            AllValidationsOnNumber(Card);
            PlayersCards.PutNewCardToPackage(Card);
        }

        public void AllValidationsOnNumber(int number)
        {
            if (PermissionToRemoveCardFromPackage(number))
            {
                RemoveChosenCardFronPackage(number);
                A.CardIsTakenOut(number);
            }
        }

        public bool PermissionToRemoveCardFromPackage(int number)
        {
            return (ValidateNumberExistingInTheList(number) && PlayersCards.ValidatePackageWorth());
        }

        public bool ValidateNumberExistingInTheList(int number)
        {
            if (!DoesNumberExistInTheList(number))
            {
                A.TheNumberIsNotFoundInTheList();
                return (false);
            }

            return (true);
        }

        public bool DoesNumberExistInTheList(int number)
        {
            // CardList.ForEach(c => if (c == number) { return true; });
            foreach (int card in CardList)
            {
                if (card == number)
                    return true;
            }

            return false;
        }

        public void RemoveChosenCardFronPackage(int number)
        {
            CardList.Remove(number);
        }
    }
}
