using CardGame.Mocks;
using CardGame.N_Tier_Architecture.BL.Cards;
using CardGame.N_Tier_Architecture.BL.Cards.SpecialCards;
using CardGame.N_Tier_Architecture.BL.ComputerPlayer;
using CardGame.N_Tier_Architecture.UI.Print;
using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame.N_Tier_Architecture.BL.TheGame
{
    class TheGame_Func
    {
        public IfWantsToKeepPlaying WantToPlay { get; set; }
        public ComputerMakesItsMove ComMove { get; set; }
        public GetANewCard GetCard { get; set; }
        public Cards_Funcs RegularCard { get; set; }
        public AceCard_Funcs AceCard { get; set; }
        public Cards_Funcs CardsFuncs { get; set; }
        public AskForActions A { get; set; }
        public PrinceOrQueenOrKing_Funcs SpecialCards { get; set; }
        public const int ace = 1;
        public const int prince = 11;
        public const int queen = 12;
        public const int king = 11;
        public bool PlayerWon { get; set; }
        public int ComputersMove { get; set; }

        public TheGame_Func()
        {
            WantToPlay = new IfWantsToKeepPlaying();
            ComMove = new ComputerMakesItsMove();
            GetCard = new GetANewCard();
            RegularCard = new Cards_Funcs();
            AceCard = new AceCard_Funcs();
            CardsFuncs = new Cards_Funcs();
            A = new AskForActions();
            SpecialCards = new PrinceOrQueenOrKing_Funcs();
            PlayerWon = false;
        }

        public void Play()
        {
            while (CanKeepPlaying())
            {
                GetCard.GetNewCard();
                ActionsOnCard();
            }
        }

        public void ActionsOnCard()
        {
            if (IsAce())
            {
                AceCard.NewCard(GetCard.Card);
            }
            else if (isPrinceOrQueenOrKing())
            {
                SpecialCards.NewCard(GetCard.Card);
            }
            else 
            {
                RegularCard.NewCard(GetCard.Card);
            }
        }

        public bool isPrinceOrQueenOrKing()
        {
            return (IsPrince() || IsQueen() || IsKing());
        }

        public bool IsKing()
        {
            if (GetCard.Card == king)
            {
                A.PickedKing();
                return (true);
            }

            return (false);
        }

        public bool IsQueen()
        {
            if (GetCard.Card == queen)
            {
                A.PickedQueen();
                return (true);
            }

            return (false);
        }

        public bool IsPrince()
        {
            if (GetCard.Card == prince)
            {
                A.PickedPrince();
                return (true);
            }

            return (false);
        }

        public bool IsAce()
        {
            return (GetCard.Card == ace);
        }

        public void PlayerChooseToStopPlaying()
        {
            if (!GetANewCard.PlayersCards.GetCardsPackage())
                WinningAnnouncment();
        }

        public void WinningAnnouncment()
        {
            if (DoesPlayerWin())
            {
                PlayerWon = true;
                GetANewCard.PlayersCards.WinningCount++;
                A.PlayerWonTheGame();
            }
            else
            {
                PlayerWon = false;
                A.ComputerWonTheGame(ComputersMove, GetANewCard.PlayersCards.CardsPackage);
            }
        }

        public bool DoesPlayerWin()
        {
            ComputersMove = GetComputerNumber();
            return (GetANewCard.PlayersCards.CardsPackage >= ComputersMove);
        }

        public int GetComputerNumber()
        {
            return ComMove.ChooseARandomNumber();
        }

        public bool CanKeepPlaying()
        {
            return (GetANewCard.PlayersCards.ValidatePackageWorth() && WantToPlay.doestThePlayerWantsToTakeOutANewCard());
        }
    }
}
