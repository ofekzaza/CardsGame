using CardGame.N_Tier_Architecture.BL.Player;
using CardGame.N_Tier_Architecture.UI.Print;
using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame.Mocks
{
    class Cards_Funcs : CreateCardPackage
    {
        public List<int> CardList;
        public int Card { get; set; }
        public AskForActions A;
        public CardsKeeper PlayersCards;

        public Cards_Funcs() : base ()
        {
            CardList = base.Cards;
            A = new AskForActions();
            PlayersCards = new CardsKeeper();
        } 
        public void NewCard()
        {
            A.AskToTakeACard();
            GetUsersInputForCard();
            AllValidationsOnNumber(Card);
            PlayersCards.PutNewCardToPackage(Card);
        }

        public void GetUsersInputForCard()
        {
            Card = int.Parse(Console.ReadLine());
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
            return (ValidateRange(number) && ValidateNumberExistingInTheList(number) && PlayersCards.ValidatePackageWorth());
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

        public bool ValidateRange(int number)
        {
            if (!IsNumberInTheRightRange(number))
            {
                A.TheNumberIsInTheWrongRange();
                return (false);
            }

            return (true);
        }

        public bool IsNumberInTheRightRange(int number)
        {
            return (number > 0 && number <= 10);
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
