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
        public CardsActions A { get; set; }
        public SpecialCardsActions B { get; set; }
        public WinningAnouncment C { get; set; }
        public PrinceOrQueenOrKing_Funcs SpecialCards { get; set; }    
        public bool PlayerWon { get; set; }
        public int ComputersMove { get; set; }
        //public const List<int> SpecialCards = new List<int> { 11, 12, 13 };
        public const int ace = 1;
        public const int prince = 11;
        public const int queen = 12;
        public const int king = 13;


        public TheGame_Func()
        {
            WantToPlay = new IfWantsToKeepPlaying();
            ComMove = new ComputerMakesItsMove();
            GetCard = new GetANewCard();
            RegularCard = new Cards_Funcs();
            AceCard = new AceCard_Funcs();
            A = new CardsActions();
            B = new SpecialCardsActions();
            C = new WinningAnouncment();
            SpecialCards = new PrinceOrQueenOrKing_Funcs();
            PlayerWon = false;
        }

        public void Play()
        {
            while (CanKeepPlaying())
            {
                Game();
            }
        }

        public void Game()
        {
            GetCard.GetNewCard();
            ActionsOnCard();
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
                B.PickedKing();
                return (true);
            }

            return (false);
        }

        public bool IsQueen()
        {
            if (GetCard.Card == queen)
            {
                B.PickedQueen();
                return (true);
            }

            return (false);
        }

        public bool IsPrince()
        {
            if (GetCard.Card == prince)
            {
                B.PickedPrince();
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
            {
                WinningAnnouncment();
            }
            else
            {
                PlayerWon = false;
            }
        }

        public void WinningAnnouncment()
        {
            if (DoesPlayerWin())
            {
                PlayerWon = true;
                GetANewCard.PlayersCards.WinningCount++;
                C.PlayerWonTheGame();
            }
            else
            {
                PlayerWon = false;
                C.ComputerWonTheGame(ComputersMove, GetANewCard.PlayersCards.CardsPackage);
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
