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
        public CardsActions A;
        public static CardKeeper_Funcs PlayersCards { get; set; }

        public GetANewCard() : base ()
        {
            CardList = Cards;
            A = new CardsActions();
            PlayersCards = new CardKeeper_Funcs();
        }

        public void GetNewCard()
        {
            A.AskToTakeACard();
            TakeOutAndRemoveFirstCardInTheList();
            A.ChosenCard(Card);
        }

        public void TakeOutAndRemoveFirstCardInTheList()
        {
            if (!IsCardsListEmpty() && !(CardList.Count == 0))
            {
                Card = CardList[0];
                CardList.RemoveAt(0);
            }
        }

        public static void RestartList()
        {
            //PlayersCards = new CardsKeeper();
            CardList = Cards;
            //Console.WriteLine("first: " + CardList[0]);
        }

        public static bool IsCardsListEmpty()
        {
            return (CardList is null );
        }
    }
}
