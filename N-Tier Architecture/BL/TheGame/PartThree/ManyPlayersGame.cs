using CardGame.N_Tier_Architecture.UI.Print;
using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame.N_Tier_Architecture.BL.TheGame.PartThree
{
    class ManyPlayersGame
    {
        public ManyPlayersGame_Funcs Game { get; set; }
        public AllScoresInOrder OrderList { get; set; }
        public PlayersAndComPlayersActions A { get; set; }
        public ManyPlayersGame()
        {
            Game = new ManyPlayersGame_Funcs();
            OrderList = new AllScoresInOrder();
            A = new PlayersAndComPlayersActions();
        }

        public void StartTheGame()
        {
            Game.StartPlayingTheWholeGame();
            OrderScoresList();
        }

        public void OrderScoresList()
        {
            OrderList.OrderScoreListint(Game.PlayersAndScores);
            A.PrintScoresInOrder(OrderList.ScoresInOrder);
        }
    }
}
