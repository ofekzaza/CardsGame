using CardGame.Mocks;
using CardGame.N_Tier_Architecture.BL.Player;
using CardGame.N_Tier_Architecture.UI.Print;
using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame.N_Tier_Architecture.BL.Cards
{
    class GetANewCard : CreateCardPackage
    {
        public static List<int> CardList;
        public int Card { get; set; }
        public AskForActions A;
        public static CardsKeeper PlayersCards { get; set; }

        public GetANewCard() : base ()
        {
            CardList = Cards;
            A = new AskForActions();
            PlayersCards = new CardsKeeper();
        }

        public void GetNewCard()
        {
            A.AskToTakeACard();
            GetUsersInputForCard();
            GetACorrectAnswer(Card);
        }

        public void GetUsersInputForCard()
        {
            Card = int.Parse(Console.ReadLine());
        }

        public void GetACorrectAnswer(int answer)
        {
            while (!ValidateRange(answer))
            {
                answer = int.Parse(Console.ReadLine());
            }
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
            return (number > 0 && number <= 13);
        }

        public static void RestartList()
        {
            CardList = Cards;
        }
    }
}
