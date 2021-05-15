using System;
using System.Collections.Generic;
using System.Text;

namespace week_6
{
    abstract class Answer
    {
        public Answer(string answerText)
        {
            this.AnswerText = answerText;
        }

        public string AnswerText;

        public abstract void Choose();

    }

    class CorrectAnswer : Answer
    {
        public CorrectAnswer(string answerText) : base(answerText)
        {

        }

        public override void Choose()
        {
            Score.MultiplicationScore();

            Game.NumberQuestion++;

            if (Game.NumberQuestion < Game.AmountQuestions)
            {              
                Console.WriteLine($"Ваш выигрыш составляет {Score.UserScore} BYN\n");                
                string userChoice = UserChoice();
                if (userChoice == "2")
                {
                    Console.WriteLine($"{User.UserName}, игра окончена. Ваш выигрыш составляет {Score.UserScore} BYN");
                    Score.UserScore = 0;
                }

            }
            else
                Console.WriteLine($"{User.UserName}, Вы победили, ответив на все вопросы. Ваш выигрыш составляет {Score.UserScore} BYN\n");
        }

        private string UserChoice()
        {
            Console.WriteLine("Чтобы продолжить игру, введите 1\nЧтобы забрать деньги, введите 2");
            string userChoice = Console.ReadLine();

            if (userChoice == "1" || userChoice == "2")
            {
                return userChoice;
            }
            else
                return UserChoice();

        }

    }

    class WrongAnswer : Answer
    {
        public WrongAnswer(string answerText) : base(answerText)
        {

        }

        public override void Choose()
        {
            Console.WriteLine($"{User.UserName}, ты проиграл, и уходишь домой без денег :(");
            Score.UserScore = 0;
        }

    }

}
