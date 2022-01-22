using CardGame.Common_Layer.Objects;
using CardGame.N_Tier_Architecture.BL.ComputerPlayer;
using CardGame.N_Tier_Architecture.BL.TheGame.IfPlayerWantsToKeepPlaying;
using CardGame.N_Tier_Architecture.UI.Print;
using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame.N_Tier_Architecture.BL.Player
{
    class ComputerPlayers : ComputerMakesItsMove
    {
        public IfWantsComputerPlayers doesWantPlayers { get; set; }
        public CompuerPlayersMatrix Players { get; set; }
        public AskForActions A { get; set; }
        public int[,] AllPlayers { get; set; }
        public int MaxI { get; set; }
        public int MaxJ { get; set; }
        public int MaxValue { get; set; }
        public ComputerPlayers() : base ()
        {
            doesWantPlayers = new IfWantsComputerPlayers();
            Players = new CompuerPlayersMatrix();
            A = new AskForActions();
            MaxI = 0;
            MaxJ = 0;
            MaxValue = 0;
        }

        public void Play()
        {
            if (CreateComputerPlayers())
            {
                EachPlayerChoosesValue();
            }
        }

        public void EachPlayerChoosesValue()
        {
            for (int i = 0; i < AllPlayers.GetLength(0); i++)
            {
                for (int j = 0; j < AllPlayers.GetLength(1); j++)
                {
                    AllPlayers[i, j] = ChooseARandomNumber();
                    A.TheNumberComputerChooseIs(j, AllPlayers[i, j]);
                }
            }
        }

        public bool CreateComputerPlayers()
        {
            if (WantComputerPlayers())
            {
                AllPlayers = Players.SetComputerPlayers(); 
                return (true);
            }

            return (false);
        }

        public bool WantComputerPlayers()
        {
            return (doesWantPlayers.DoTheyWantToHaveComputerPlayers());
        }

        public void GetMaxComputerPlayer()
        {
            if (AllPlayers != null)
            {
                GoAllOverThePlayersAndFindMax();
                A.MaxComputerPlayer(MaxJ, MaxValue);
            }
            else
            {
                A.NoComputerPlayers();
            }
        }

        public void GoAllOverThePlayersAndFindMax()
        {
            for (int i = 0; i < AllPlayers.GetLength(0); i++)
            {
                for (int j = 0; j < AllPlayers.GetLength(1); j++)
                {
                    FindMaxInList(i, j);
                }
            }
        }

        public void FindMaxInList(int i, int j)
        {
            if (CheckIfBiggerThanMax(i, j))
            {
                SetAllMaxProperties(i, j);
            }
        }

        public void SetAllMaxProperties(int i, int j)
        {
            MaxValue = AllPlayers[i, j];
            MaxI = i;
            MaxJ = j;
        }

        public bool CheckIfBiggerThanMax(int i, int j)
        {
            return (AllPlayers[i, j] > MaxValue);
        }
    }
}
