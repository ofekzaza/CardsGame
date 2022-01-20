﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame.N_Tier_Architecture.UI.Print
{
    class AskForActions
    {
        public void AskToTakeACard()
        {
            Console.WriteLine("Take One Card Out");
        }

        public void TheNumberIsInTheWrongRange()
        {
            Console.WriteLine("The Number Is In The Wrong Range. It must be over zero and under 10.");
        }

        public void TheNumberIsNotFoundInTheList()
        {
            Console.WriteLine("Couldn't Find The Number In The List. You Already Took Out All Of Them.");
        }

        public void CardIsTakenOut(int number)
        {
            Console.WriteLine("The Card Number " + number + " Was Taken Out.");
        }

        public void PackageWorthIsOver21()
        {
            Console.WriteLine("Package Worth Is Over 21. You Lost. Computer Wins!");
        }

        public void DoesWantToTakeCardOute()
        {
            Console.WriteLine("Do You Want To Take A New Card Out? Press 1 to continue and 0 to stop.");
        }

        public void WrongInput()
        {
            Console.WriteLine("Wrong Answer. Press 1 to continue and 0 to stop.");
        }

        public void PlayerWonTheGame()
        {
            Console.WriteLine("You Won The Game!");
        }

        public void ComputerWonTheGame(int comNumber, int playerAmount)
        {
            Console.WriteLine("It Has Chosen " + comNumber + ". Your Worth Is " + playerAmount + ". You Lost. Computer Won This Game.");
        }
    }
}
