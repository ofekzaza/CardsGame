using CardGame.Mocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame.N_Tier_Architecture.BL.TheGame
{
    class IfWantsToKeepPlaying : Cards_Funcs
    {
        public const int KeepPlaying = 1;
        public const int StopPlaying = 0;
        public IfWantsToKeepPlaying() : base ()
        {
        }

        public bool doestThePlayerWantsToTakeOutANewCard()
        {
            return ValidatePlayersAsnwer(GetPlayersAnswerForKeepPlayingTheGame()) == KeepPlaying;
        }

        public int GetPlayersAnswerForKeepPlayingTheGame()
        {
            A.DoesWantToTakeCardOute();
            return int.Parse(Console.ReadLine());
        }

        public int ValidatePlayersAsnwer(int answer)
        {
            if (!IsAnswerCorrect(answer))
            {
                GetACorrectAnswer(answer);
            }

            return (answer);
        }

        public new void GetACorrectAnswer(int answer)
        {
            while (!IsAnswerCorrect(answer))
            {
                A.WrongInput();
                answer = int.Parse(Console.ReadLine()); 
            }
        }

        public bool IsAnswerCorrect(int answer)
        {
            return (answer == KeepPlaying || answer == StopPlaying);
        }
    }
}
