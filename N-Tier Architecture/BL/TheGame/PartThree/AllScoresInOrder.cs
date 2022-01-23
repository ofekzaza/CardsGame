using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame.N_Tier_Architecture.BL.TheGame.PartThree
{
    class AllScoresInOrder
    {
        public List<int> Scores { get; set; }
        public List<int> ScoresInOrder { get; set; }
        public int MaxIndex { get; set; }
        public int MaxValue { get; set; }

        public AllScoresInOrder() 
        {
            Scores = new List<int>();
            ScoresInOrder = new List<int>();
            MaxIndex = 0;
            MaxValue = 0;
        }

        public void OrderScoreListint(int[,] scoresPerPlayer)
        {
            Scores = GetAllScores(scoresPerPlayer);

            while (IsListGood())
            {
                FindMaxInTheWholeList();
                ScoresInOrder.Add(MaxValue);
                RemoveFoundMaxFromList();
                RestartMaxProperties();
            }
        }

        public void RestartMaxProperties()
        {
            MaxIndex = 0;
            MaxValue = 0;
        }

        public bool IsListGood()
        {
            return (Scores != null && Scores.Count != 0);
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

        public List<int> GetAllScores(int[,] scoresPerPlayer)
        {
            List<int> newList = new List<int>();

            for (int i = 0; i < scoresPerPlayer.GetLength(0); i++)
            {
                for (int j = 0; j < scoresPerPlayer.GetLength(1); j++)
                {
                    newList.Add(scoresPerPlayer[i, j]);
                }
            }

            return newList;
        }
    }
}
