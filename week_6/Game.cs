using System;
using System.Collections.Generic;
using System.Text;

namespace week_6
{
    class Game
    {
        public static int AmountQuestions = 10;

        public static int NumberQuestion = 0;

        Question[] question = new Question[Game.AmountQuestions];        

        public static void Rules()
        {            
            Console.WriteLine("Ознакомитесь с правилами игры:\n- Игроку необходимо ответить на серию вопросом.\n- Первый правильный ответ приносит игроку 100 BYN.\n- Каждый следующий правильный ответ удваивает количество выигранных денег.\n- Если игрок ответил неверно, весь выигрыш сгорает.\n");
        }

        private void Questions()
        {       
            question[0] = new Question("Как правильно продолжить припев детской песни: \"Тили - тили...\"?");
            question[0].Answers = new Answer[4];
            question[0].Answers[0] = new WrongAnswer("хали-гали");
            question[0].Answers[1] = new CorrectAnswer("трали-вали");
            question[0].Answers[2] = new WrongAnswer("жили-были");
            question[0].Answers[3] = new WrongAnswer("ели-пили");

            question[1] = new Question("Что понадобится, чтобы взрыхлить землю на грядке?");
            question[1].Answers = new Answer[4];
            question[1].Answers[0] = new CorrectAnswer("тяпка");
            question[1].Answers[1] = new WrongAnswer("бабка");
            question[1].Answers[2] = new WrongAnswer("скобка");
            question[1].Answers[3] = new WrongAnswer("тряпка");

            question[2] = new Question("Как называется экзотическое животное из Южной Америки?");
            question[2].Answers = new Answer[4];
            question[2].Answers[0] = new WrongAnswer("пчеложор");
            question[2].Answers[1] = new WrongAnswer("термитоглот");
            question[2].Answers[2] = new CorrectAnswer("муравьед");
            question[2].Answers[3] = new WrongAnswer("комаролов");
            
            question[3] = new Question("Во что превращается гусеница?");
            question[3].Answers = new Answer[4];
            question[3].Answers[0] = new WrongAnswer("в мячик");
            question[3].Answers[1] = new WrongAnswer("в пирамидку");
            question[3].Answers[2] = new WrongAnswer("в машинку");
            question[3].Answers[3] = new CorrectAnswer("в куколку");

            question[4] = new Question("К какой группе музыкальных инструментов относится валторна?");
            question[4].Answers = new Answer[4];
            question[4].Answers[0] = new WrongAnswer("струнные");
            question[4].Answers[1] = new WrongAnswer("клавишные");
            question[4].Answers[2] = new WrongAnswer("ударные");
            question[4].Answers[3] = new CorrectAnswer("духовые");
            
            question[5] = new Question("В какой басне Крылова среди действующих лиц есть человек?");
            question[5].Answers = new Answer[4];
            question[5].Answers[0] = new WrongAnswer("\"Лягушка и Вол\"");
            question[5].Answers[1] = new WrongAnswer("\"Свинья под Дубом\"");
            question[5].Answers[2] = new WrongAnswer("\"Осел и Соловей\"");
            question[5].Answers[3] = new CorrectAnswer("\"Волк на псарне\"");

            question[6] = new Question("Какой фильм сделал знаменитой песню в исполнении Уитни Хьюстон?");
            question[6].Answers = new Answer[4];
            question[6].Answers[0] = new WrongAnswer("\"Красотка\"");
            question[6].Answers[1] = new CorrectAnswer("\"Телохранитель\"");
            question[6].Answers[2] = new WrongAnswer("\"Форрест Гамп\"");
            question[6].Answers[3] = new WrongAnswer("\"Пятый элемент\"");

            question[7] = new Question("Какой писатель сформулировал Три закона робототехники?");
            question[7].Answers = new Answer[4];
            question[7].Answers[0] = new WrongAnswer("Карел Чапек");
            question[7].Answers[1] = new CorrectAnswer("Айзек Азимов");
            question[7].Answers[2] = new WrongAnswer("Станислав Лем");
            question[7].Answers[3] = new WrongAnswer("Курт Воннегут");

            question[8] = new Question("Чем увлекался знаменитый сказочник Ганс-Христан Андерсен?");
            question[8].Answers = new Answer[4];
            question[8].Answers[0] = new WrongAnswer("вязанием");
            question[8].Answers[1] = new CorrectAnswer("вырезанием из бумаги");
            question[8].Answers[2] = new WrongAnswer("выжиганием");
            question[8].Answers[3] = new WrongAnswer("выпиливанием лобзиком");

            question[9] = new Question("Во что оборачивают на время созревания сыр ярг, который производят в английском графстве Корнуолл?");
            question[9].Answers = new Answer[4];
            question[9].Answers[0] = new WrongAnswer("в листья винограда");
            question[9].Answers[1] = new WrongAnswer("в мох");
            question[9].Answers[2] = new CorrectAnswer("в листья крапивы");
            question[9].Answers[3] = new WrongAnswer("в торф");
            
        }
                
        public void Start()
        {
            Questions();

            for (int i = 0; i < question.Length; i++)
            {
                Console.Clear();                             

                Console.WriteLine($"Вопрос № {i + 1}");
                question[i].Print(question[i]);

                int j = UserAnswer();

                Answer UserChoice = question[i].Answers[j];
                UserChoice.Choose();

                if (Score.UserScore == 0)
                    break;
            }

        }

        private int UserAnswer()
        {
            Console.WriteLine("Введите номер правильного ответа:");
            string userInput = Console.ReadLine();
            int j = 0;

            if (userInput == "1")
            {
                return j;
            }
            else if (userInput == "2")
            {
                j = 1;
                return j;
            }
            else if (userInput == "3")
            {
                j = 2;
                return j;
            }
            else if (userInput == "4")
            {
                j = 3;
                return j;
            }
            else
            {
                Console.WriteLine("!!!Чтобы ответить на вопрос, введите 1, 2, 3 или 4!!!");
                return UserAnswer();
            }

        }               

    }

}
