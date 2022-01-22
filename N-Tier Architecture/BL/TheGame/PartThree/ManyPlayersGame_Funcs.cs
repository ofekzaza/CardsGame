using CardGame.Common_Layer.Objects;
using CardGame.N_Tier_Architecture.BL.Cards;
using CardGame.N_Tier_Architecture.BL.Player;
using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame.N_Tier_Architecture.BL.TheGame.PartThree
{
    class ManyPlayersGame_Funcs : TheGame_Func
    {
        public PlayersAndScoresMatrix Players { get; set; }
        public IfWantsToKeepPlaying DoTheyWantAnotherRound { get; set; }
        public ComputerPlayers CompPlayers { get; set; }

        public int[,] PlayersAndScores { get; set; }

        public ManyPlayersGame_Funcs() : base ()
        {
            Players = new PlayersAndScoresMatrix();
            DoTheyWantAnotherRound = new IfWantsToKeepPlaying();
            CompPlayers = new ComputerPlayers();
        }

        public void SetPlayers()
        {
            PlayersAndScores = Players.SetPlayersAndScores();
        }

        public void DoesWantToPlay()
        {
            SetPlayers();
            InitMatrix();
            GetPerPlayer();

            while (DoTheyWantAnotherRound.doestThePlayerWantsToStartANewRound())
            {
                GetPerPlayer();
            }
            CompPlayers.Play();
            CompPlayers.GetMaxComputerPlayer();

            A.PlayersMatrixPrint(PlayersAndScores);
        }

        public void GetPerPlayer()
        {
            for (int i = 0; i < PlayersAndScores.GetLength(0); i++)
            {
                for (int j = 0; j < PlayersAndScores.GetLength(1); j++)
                {
                    A.PlayerNumberX(j + 1);
                    if (CanKeepPlaying())
                    {
                        Game();
                        PlayersAndScores[i, j] += GetScore();
                        RestartPackage();
                    }
                }
            }           
        }

        public int GetScore()
        {
            return GetANewCard.PlayersCards.CardsPackage;
        }

        public void RestartPackage()
        {
            GetANewCard.PlayersCards.CardsPackage = 0;
        }

        public void InitMatrix()
        {
            for (int i = 0; i < PlayersAndScores.GetLength(0); i++)
            {
                for (int j = 0; j < PlayersAndScores.GetLength(1); j++)
                {
                    PlayersAndScores[i, j] = 0;
                }
            }
        }
        //public new bool CanKeepPlaying()
        //{
        //    return (GetANewCard.PlayersCards.ValidatePackageWorth() && WantToPlay.doestThePlayerWantsToTakeOutANewCard());
        //}

    }
}
