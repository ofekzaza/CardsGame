using CardGame.Mocks;
using CardGame.N_Tier_Architecture.UI.Print;
using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame.N_Tier_Architecture.BL.TheGame
{
    class IfWantsToKeepPlaying : Cards_Funcs
    {
        public const int KeepPlaying = 1;
        public const int StopPlaying = 0;
        public PlayersAndComPlayersActions B { get; set; }

        public IfWantsToKeepPlaying() : base ()
        {
            B = new PlayersAndComPlayersActions();
        }

        public bool doestThePlayerWantsToTakeOutANewCard()
        {
            return ValidatePlayersAsnwer(GetPlayersAnswerForKeepPlayingTheGame()) == KeepPlaying;
        }

        public bool doestThePlayerWantsToStartANewRound()
        {
            return ValidatePlayersAsnwer(GetPlayersAnswerForNewRound()) == KeepPlaying;
        }

        public int GetPlayersAnswerForNewRound()
        {
            B.RoundIsOver();
            return int.Parse(Console.ReadLine());
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

        public void GetACorrectAnswer(int answer)
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
