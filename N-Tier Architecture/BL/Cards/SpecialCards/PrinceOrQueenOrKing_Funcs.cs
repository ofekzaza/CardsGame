using CardGame.Mocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame.N_Tier_Architecture.BL.Cards.SpecialCards
{
    class PrinceOrQueenOrKing_Funcs : AceCard_Funcs
    {
        public new const int Value = 10;
        public List<int> PossibleValues { get; set; }
        public PrinceOrQueenOrKing_Funcs() : base ()
        {
            PossibleValues = new List<int> { 11, 12, 13 };
        }

        public new void NewCard(int Card)
        {
            AddValueToPlayersCardPackage();
        }

        public new void AddValueToPlayersCardPackage()
        {
            PlayersCards.PutNewCardToPackage(Value);
        }

        //public bool IsASpecialCard(int number)
        //{
        //    PossibleValues.ForEach(specialCard => { if (IfSpecial(specialCard, number)) { return true; } });
        //    return (false);
        //}

        public bool IfSpecial(int specialCard, int newValue)
        {
            return (specialCard == newValue);
        }
    }
}
