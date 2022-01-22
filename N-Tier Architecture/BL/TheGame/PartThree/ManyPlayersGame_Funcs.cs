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

        public void StartPlayingTheWholeGame()
        {
            PlayOnlyTheFirstRound();
            IfWantsToPlayAnotherRoundThenStartPlaying();
            ComputerPlayersPlayTheirTurn();

            A.PlayersMatrixPrint(PlayersAndScores);
        }

        public void ComputerPlayersPlayTheirTurn()
        {
            CompPlayers.Play();
            CompPlayers.GetMaxComputerPlayer();
        }

        public void PlayOnlyTheFirstRound()
        {
            SetPlayers();
            InitMatrix();
            GetScorePerPlayer();
        }

        public void IfWantsToPlayAnotherRoundThenStartPlaying()
        {
            while (DoTheyWantAnotherRound.doestThePlayerWantsToStartANewRound())
            {
                GetScorePerPlayer();
            }
        }

        public void GetScorePerPlayer()
        {
            for (int i = 0; i < PlayersAndScores.GetLength(0); i++)
            {
                for (int j = 0; j < PlayersAndScores.GetLength(1); j++)
                {
                    PlayTheGame(i, j);
                }
            }           
        }

        public void PlayTheGame(int i, int j)
        {
            A.PlayerNumberX(j + 1);

            if (CanKeepPlaying())
            {
                Game();
                SetNewScore(i, j);
                RestartPackage();
            }
        }

        public void SetPlayers()
        {
            PlayersAndScores = Players.SetPlayersAndScores();
        }

        public void SetNewScore(int i, int j)
        {
            PlayersAndScores[i, j] += GetScore();
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
