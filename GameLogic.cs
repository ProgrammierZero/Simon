using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Simon
{
    class GameLogic
    {
        GameDesign Design = new GameDesign();
        Random random = new Random();
        string Note = "";
        string checkNote = "";
        bool isGame = true;
        int[] realNotes;
        public GameLogic()
        {
            InitGame();
        }

        private void InitGame()
        {
            while(isGame)
            {
                Note = "";
                checkNote = "";
                realNotes = null;
                GenerateNotes(Design.proper.Difficult);
                
                PlayNotes();
                if(CheckPlayerTry())
                {
                    IncreaseScore(2);
                    IncreaseDifficult(1);
                    
                }
                else
                {
                    ShowGameOver();
                }
                
            }
        }

        private void GenerateNotes(int difficult)
        {
            for(int i = 0; i < difficult; i++)
            {
                string rand = random.Next(1, 5).ToString();
                checkNote += rand;
                if (i == difficult - 1)
                {
                    Note += rand;
                    break;
                }
                Note += rand + " " ;

            }
            
        }
        private void PlayNotes()
        {
            string[] Notes = Note.Split(' ');
            realNotes = new int[Notes.Length];
            for(int i = 0; i < Notes.Length; i++)
            {
                realNotes[i] = Convert.ToInt32(Notes[i]);
            }

            for(int i = 0; i < realNotes.Length; i++)
            {

                
                Design.GenerateMap(realNotes[i]);
                Thread.Sleep(1000);
                Console.Clear();

            }
            Design.GenerateMap(0);
            ShowScore();
        }
        private bool CheckPlayerTry()
        {
            Console.WriteLine();
            Console.WriteLine("Введите порядок нот (цифрами)");
            string playerTry = Console.ReadLine();
            if(playerTry == checkNote)
            {
                Console.Clear();
                return true;
            } 
            else
            {
                Console.Clear();
                return false;
            }
        }
        private void IncreaseScore(int value)
        {
            Design.proper.Score += value;
        }
        private void IncreaseDifficult(int value)
        {
            Design.proper.Difficult += value;
        }
        private void ShowGameOver()
        {
            Console.WriteLine("You lose!");
            Console.WriteLine("Your score: " + Design.proper.Score);
            isGame = false;
            Console.ReadKey();

        }
        private void ShowScore()
        {
            Console.WriteLine();
            Console.WriteLine("Your score: " + Design.proper.Score);
        }
    }
}
