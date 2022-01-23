using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame.N_Tier_Architecture.BL.ComputerPlayer
{
    class ComputerMakesItsMove
    {
        private Random _rnd;
        public int startGuessingFrom { get; set; }

        public ComputerMakesItsMove()
        {
            _rnd = new Random();
            startGuessingFrom = 15;
        }

        public int ChooseARandomNumber()
        {
            return _rnd.Next(startGuessingFrom, 22);
        }

        public bool IsOver21()
        {
            return (startGuessingFrom > 21);
        }
    }
}
