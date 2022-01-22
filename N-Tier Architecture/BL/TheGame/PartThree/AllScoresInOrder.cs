using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame.N_Tier_Architecture.BL.TheGame.PartThree
{
    class AllScoresInOrder : ManyPlayersGame_Funcs
    {
        public List<int> Scores { get; set; }
        public List<int> ScoresInOrder { get; set; }
        public int[,] scores;

        public AllScoresInOrder(int[,] Score) : base()
        {
            scores = Score;
            Scores = new List<int>();
            ScoresInOrder = new List<int>();
        }

        public void OrderScoreList()
        {
            while (Scores != null)
            {
                ScoresInOrder.Add(FindMaxValue());
            }
        }

        public int FindMaxValue()
        {
            GetAllScores();
            int index = 0;
            int maxValue = 0; 
            for (int i = 0; i < Scores.Count; i++)
            {
                if (Scores[i] > maxValue)
                {
                    maxValue = Scores[i];
                    index = i;
                }
            }

            Scores.RemoveAt(index);
            return maxValue;
        }

        public void GetAllScores()
        {
            for (int i = 0; i < scores.GetLength(0); i++)
            {
                for (int j = 0; j < scores.GetLength(1); j++)
                {
                    Scores.Add(scores[i, j]);
                }
            }
        }
    }
}
