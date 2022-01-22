using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame.N_Tier_Architecture.BL.Player
{
    class CardKeeper_Funcs : CardsKeeper
    {
        public const int MaxRange = 21;
        public CardKeeper_Funcs() : base ()
        {
        }

        public void PutNewCardToPackage(int number)
        {
            CardsPackage += number;
        }

        public bool ValidatePackageWorth()
        {
            if (GetCardsPackage())
            {
                a.PackageWorthIsOver21();
                return (false);
            }

            return (true);
        }

        public bool GetCardsPackage()
        {
            return (CardsPackage > MaxRange);
        }
    }
}
