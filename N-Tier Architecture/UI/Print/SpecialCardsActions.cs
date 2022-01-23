using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame.N_Tier_Architecture.UI.Print
{
    class SpecialCardsActions
    {
        public void WrongInputForAce()
        {
            Console.WriteLine("Wrong Input. Press 11 or 1 As Card's Value.");
        }

        public void PickedPrince()
        {
            Console.WriteLine("You Got The Prince Card! It's Value Is 10!");
        }

        public void PickedQueen()
        {
            Console.WriteLine("You Got The Queen Card! It's Value Is 10!");
        }

        public void PickedKing()
        {
            Console.WriteLine("You Got The King Card! It's Value Is 10!");
        }

        public void ChooseValueOfCard()
        {
            Console.WriteLine("Since You Picked An Ace, You Choose This Card's Value. Press 1 Or 11.");
        }
    }
}
