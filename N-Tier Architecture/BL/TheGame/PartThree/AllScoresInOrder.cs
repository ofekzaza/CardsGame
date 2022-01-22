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
        public int MaxIndex { get; set; }
        public int MaxValue { get; set; }

        public AllScoresInOrder(int[,] Score) : base()
        {
            scores = Score;
            Scores = new List<int>();
            ScoresInOrder = new List<int>();
            MaxIndex = 0;
            MaxValue = 0;
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
            FindMaxInTheWholeList();
            RemoveFoundMaxFromList();

            return (MaxValue);
        }

        public void RemoveFoundMaxFromList()
        {
            Scores.RemoveAt(MaxIndex);
        }

        public void FindMaxInTheWholeList()
        {
            for (int i = 0; i < Scores.Count; i++)
            {
                CheckIfBiggerThanMax(i);
            }
        }

        public void CheckIfBiggerThanMax(int i)
        {
            if (Scores[i] > MaxValue)
            {
                SetMaxProperties(i);
            }
        }

        public void SetMaxProperties(int i)
        {
            MaxValue = Scores[i];
            MaxIndex = i;
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
