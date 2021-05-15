using System;
using System.Collections.Generic;
using System.Text;

namespace week_6
{
    class Question
    {
        public Question(string questionText)
        {
            this.QuestionText = questionText;
        }

        public string QuestionText;
        public Answer[] Answers;

        public void Print(Question question)
        {
            Console.WriteLine(question.QuestionText);

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"{i + 1}. {question.Answers[i].AnswerText}");
            }

        }

    }

}
