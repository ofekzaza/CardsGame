using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame.N_Tier_Architecture.BL.ComputerPlayer
{
    class ComputerMakesItsMove
    {
        private Random _rnd;

        public ComputerMakesItsMove()
        {
            _rnd = new Random();
        }

        public int ChooseARandomNumber()
        {
            return _rnd.Next(15, 22);
        }
    }
}
