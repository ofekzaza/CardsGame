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
        public int[,] AllPlayers { get; set; }
        public AskForActions A { get; set; }
        public ComputerPlayers() : base ()
        {
            doesWantPlayers = new IfWantsComputerPlayers();
            Players = new CompuerPlayersMatrix();
            A = new AskForActions();
        }

        public void Play()
        {
            if (CreateComputerPlayers())
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
        }

        public bool CreateComputerPlayers()
        {
            if (doesWantPlayers.DoTheyWantToHaveComputerPlayers())
            {
                AllPlayers = Players.SetComputerPlayers(); // יצר את שחקני המחשב
                return (true);
            }

            return (false);
        }

        public void GetMaxComputerPlayer()
        {
            int maxI = 0;
            int maxJ = 0;
            int maxValue = 0;

            for (int i = 0; i < AllPlayers.GetLength(0); i++)
            {
                for (int j = 0; j < AllPlayers.GetLength(1); j++)
                {
                    if (AllPlayers[i, j] > maxValue)
                    {
                        maxValue = AllPlayers[i, j];
                        maxI = i;
                        maxJ = j;
                    }
                }
            }

            A.MaxComputerPlayer(maxJ, maxValue);
        }
    }
}
