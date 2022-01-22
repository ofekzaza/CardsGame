﻿using CardGame.Mocks;
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
        public static CardKeeper_Funcs PlayersCards { get; set; }

        public GetANewCard() : base ()
        {
            CardList = Cards;
            A = new AskForActions();
            PlayersCards = new CardKeeper_Funcs();
        }

        public void GetNewCard()
        {
            A.AskToTakeACard();
            Card = CardList[0];
            CardList.RemoveAt(0);
            A.ChosenCard(Card);
        }

        public static void RestartList()
        {
            //PlayersCards = new CardsKeeper();
            CardList = Cards;
            //Console.WriteLine("first: " + CardList[0]);
        }
    }
}
