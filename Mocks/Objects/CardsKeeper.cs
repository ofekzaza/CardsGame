using CardGame.N_Tier_Architecture.UI.Print;
using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame.N_Tier_Architecture.BL.Player
{
    class CardsKeeper
    {
        public int CardsPackage { get; set; }
        public CardsActions A;
        public int WinningCount { get; set; }

        public CardsKeeper()
        {
            A = new CardsActions();
            CardsPackage = 0;
            WinningCount = 0;
        }
    }
}
