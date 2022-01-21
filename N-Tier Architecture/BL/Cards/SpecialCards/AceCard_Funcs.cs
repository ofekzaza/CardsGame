using CardGame.Mocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame.N_Tier_Architecture.BL.Cards
{
    class AceCard_Funcs : Cards_Funcs
    {
        public const int CardNumber = 1;
        public const int Value = 11;

        public AceCard_Funcs() : base ()
        {
        }

        public new void NewCard(int Card)
        {
            A.ChooseValueOfCard();
            GetUsersInputForCard();
            PressCorrectValue();     
            AllValidationsOnNumber(Card);
            AddValueToPlayersCardPackage();
        }

        public void AddValueToPlayersCardPackage()
        {
            if (Card == CardNumber)
            {
                PlayersCards.PutNewCardToPackage(CardNumber);
            }
            else
            {
                PlayersCards.PutNewCardToPackage(Value);
            }
        }

        public void PressCorrectValue()
        {
            if (!IsCorrectValue())
            {
                GetCorrectValue();
            }
        }

        public void GetCorrectValue()
        {
            while (!IsCorrectValue())
            {
                A.WrongInputForAce();
                GetUsersInputForCard();
            }
        }

        public bool IsCorrectValue()
        {
            return (Card == CardNumber || Card == Value);
        }

        public void AllValidationsOnNumber()
        {
            if (PermissionToRemoveCardFromPackage(CardNumber))
            {
                RemoveChosenCardFronPackage(CardNumber);
                A.CardIsTakenOut(CardNumber);
            }
        }

        public new bool PermissionToRemoveCardFromPackage(int number)
        {
            return (ValidateNumberExistingInTheList(number) && PlayersCards.ValidatePackageWorth());
        }

        public bool ValidateNumberExistingInTheList()
        {
            if (!DoesNumberExistInTheList(CardNumber))
            {
                A.TheNumberIsNotFoundInTheList();
                return (false);
            }

            return (true);
        }

        public bool DoesNumberExistInTheList()
        {
            // CardList.ForEach(c => if (c == number) { return true; });
            foreach (int card in CardList)
            {
                if (card == CardNumber)
                    return true;
            }

            return false;
        }

        public void RemoveChosenCardFronPackage()
        {
            CardList.Remove(CardNumber);
        }
    }
}
