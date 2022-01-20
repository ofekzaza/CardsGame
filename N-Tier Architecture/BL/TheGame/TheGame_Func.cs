using CardGame.Mocks;
using CardGame.N_Tier_Architecture.BL.ComputerPlayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame.N_Tier_Architecture.BL.TheGame
{
    class TheGame_Func : Cards_Funcs
    {
        public IfWantsToKeepPlaying WantToPlay { get; set; }
        public ComputerMakesItsMove ComMove { get; set; }

        public TheGame_Func() : base ()
        {
            WantToPlay = new IfWantsToKeepPlaying();
            ComMove = new ComputerMakesItsMove();
        }

        public void IfWantsToPlay_GetANewCard()
        {
            while (CanKeepPlaying())
            {
                NewCard();
            }

            if (!PlayersCards.GetCardsPackage())
                WinningAnnouncment();
        }

        public void WinningAnnouncment()
        {
            if (DoesPlayerWin())
            {
                A.PlayerWonTheGame();
            }
            else
            {
                A.ComputerWonTheGame(GetComputerNumber(), PlayersCards.CardsPackage);
            }
        }

        public bool DoesPlayerWin()
        {
            return (PlayersCards.CardsPackage >= GetComputerNumber());
        }

        public int GetComputerNumber()
        {
            return ComMove.ChooseARandomNumber();
        }

        public bool CanKeepPlaying()
        {
            return (PlayersCards.ValidatePackageWorth() && WantToPlay.doestThePlayerWantsToTakeOutANewCard());
        }
    }
}
