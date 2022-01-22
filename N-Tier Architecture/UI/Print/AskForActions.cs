using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame.N_Tier_Architecture.UI.Print
{
    class AskForActions
    {
        public void AskToTakeACard()
        {
            Console.WriteLine("You Are Taking One Card Out.");
        }

        public void ChosenCard(int number)
        {
            Console.WriteLine("The Card You Got Is: " + number);
        }

        public void TheNumberIsInTheWrongRange()
        {
            Console.WriteLine("The Number Is In The Wrong Range. It must be between 1 and 13.");
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

        public void ChooseValueOfCard()
        {
            Console.WriteLine("Since You Picked An Ace, You Choose This Card's Value. Press 1 Or 11.");
        }

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

        public void PlayersWinAmount(int win)
        {
            Console.WriteLine("You Have Won " + win + " Times!");
        }

        // Part Two
        public void NewRound()
        {
            Console.WriteLine("Do You Want To Play A New And Harder Round? Press 1 to continue and 0 to stop.");
        }

        public void HarderLevel()
        {
            Console.WriteLine("The Level Got Harder. Computer Starts Guessing From A Bigger Start.");
        }

        // Part Three
        public void HowManyPlayers()
        {
            Console.WriteLine("Decide How Many Players Will Play This Game: ");
        }

        public void PlayerNumberX(int number)
        {
            Console.WriteLine("\nPlayer Number {0}: ", number);
        }

        public void PlayersMatrixPrint(int[,] players)
        {
            Console.WriteLine("\n");
            for (int i = 0; i < players.GetLength(0); i++)
            {
                for (int j = 0; j < players.GetLength(1); j++)
                {
                    Console.WriteLine("Player number " + (j + 1) + " , score: " + players[i, j]);
                }
            }
        }

        public void RoundIsOver()
        {
            Console.WriteLine("The Round Is Over. Do You Want To Continue Playing? press 1 to continue, and 0 to stop.");
        }

        public void DoYouWantComputerPlayers()
        {
            Console.WriteLine("Do You Want To Have Computer Players? Press 1 for yes, and 1 for no.");
        }

        public void HowManyComputerPlayersDoYouWantToPlayWith()
        {
            Console.WriteLine("How Many Computer Players Do You Want To Play With?");
        }

        public void TheNumberComputerChooseIs(int index, int number)
        {
            Console.WriteLine("Computer Number {0} Choose: {1}", index + 1, number);
        }

        public void MaxComputerPlayer(int j, int value)
        {
            Console.WriteLine("Computer With The Higher Guess Is: {0}, And It's Guess Was: {1}", j + 1, value);
        }

        public void NoComputerPlayers()
        {
            Console.WriteLine("The Users Have Chosen Not To Have Computer Players.");
        }
    }
}
