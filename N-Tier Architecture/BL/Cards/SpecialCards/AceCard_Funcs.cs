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

        public bool IsCorrectValue()
        {
            return (Card == CardNumber || Card == Value);
        }

        public void GetCorrectValue()
        {
            while (!IsCorrectValue())
            {
                A.WrongInputForAce();
                GetUsersInputForCard();
            }
        }

        public void GetUsersInputForCard()
        {
            Card = int.Parse(Console.ReadLine());
        }

    }
}
