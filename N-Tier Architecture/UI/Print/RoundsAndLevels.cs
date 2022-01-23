using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame.N_Tier_Architecture.UI.Print
{
    class RoundsAndLevels
    {
        public void NewRound()
        {
            Console.WriteLine("\nDo You Want To Play A New And Harder Round? Press 1 to continue and 0 to stop.");
        }

        public void HarderLevel()
        {
            Console.WriteLine("\nThe Level Got Harder. Computer Starts Guessing From A Bigger Start.");
        }
    }
}
