using CardGame.N_Tier_Architecture.UI.Print;
using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame.N_Tier_Architecture.BL.Player
{
    class CardsKeeper
    {
        public int CardsPackage { get; set; }
        public AskForActions a;

        public CardsKeeper()
        {
            a = new AskForActions();
            CardsPackage = 0;
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
            return (CardsPackage > 21);
        }
    }
}
