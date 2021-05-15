using System;
using System.Data.Common;

namespace week_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Console.WriteLine("Добро пожаловать в игру «КТО ХОЧЕТ СТАТЬ МИЛЛИОНЕРОМ?»!\n");
            Console.WriteLine("Ознакомитесь с правилами игры:\n- Игроку необходимо ответить на серию вопросом.\n- Первый правильный ответ приносит игроку 100 BYN.\n- Каждый следующий правильный ответ удваивает количество выигранных денег.\n- Если игрок ответил неверно, весь выигрыш сгорает.\n");

            Console.WriteLine("Введите ваше имя:");
            string userName = Console.ReadLine();

            Console.Clear();

            int userMoney = 50;

            Question[] questions = new Question[9];
            questions[0] = new Question(1, "Как правильно продолжить припев детской песни: \"Тили - тили...\"?", "хали-гали", "трали-вали", "жили-были", "ели-пили", 2);
            questions[1] = new Question(2, "Что понадобится, чтобы взрыхлить землю на грядке?", "тяпка", "бабка", "скобка", "тряпка", 1);
            questions[2] = new Question(3, "Как называется экзотическое животное из Южной Америки?", "пчеложор", "термитоглот", "муравьед", "комаролов", 3);
            questions[3] = new Question(4, "Во что превращается гусеница?", "в мячик", "в пирамидку", "в машинку", "в куколку", 4);
            questions[4] = new Question(5, "К какой группе музыкальных инструментов относится валторна?", "струнные", "клавишные", "ударные", "духовые", 4);
            questions[5] = new Question(6, "В какой басне Крылова среди действующих лиц есть человек?", "\"Лягушка и Вол\"", "\"Свинья под Дубом\"", "\"Осел и Соловей\"", "\"Волк на псарне\"", 4);
            questions[6] = new Question(7, "Какой фильм сделал знаменитой песню в исполнении Уитни Хьюстон?", "\"Красотка\"", "\"Телохранитель\"", "\"Форрест Гамп\"", "\"Пятый элемент\"", 2);
            questions[7] = new Question(8, "Какой писатель сформулировал Три закона робототехники?", "Карел Чапек", "Айзек Азимов", "Станислав Лем", "Курт Воннегут", 2);
            questions[8] = new Question(9, "Чем увлекался знаменитый сказочник Ганс-Христан Андерсен?", "вязанием", "вырезанием из бумаги", "выжиганием", "выпиливанием лобзиком", 2);

            for (int i = 0; i < 9; i++)
            {
                if (userMoney > 0)
                    userMoney = AskingQuestion(userMoney, userName, questions[i]);
                else
                    break;
            }

            if (userMoney > 0)
            {
                Question finalQuestion = new Question(10, "Во что оборачивают на время созревания сыр ярг, который производят в английском графстве Корнуолл?", "в листья винограда", "в мох", "в листья крапивы", "в торф", 3);
                int userAnswewr = Print(finalQuestion);

                if (userAnswewr == finalQuestion.trueAnswer)
                {
                    userMoney *= 2;
                    Console.WriteLine($"{userName}, Вы победили, ответив на все вопросы. Ваш выигрыш составляет {userMoney} BYN\n");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine($"{userName} ты проиграл, и уходишь домой без денег:(");
                    Console.ReadLine();
                }
            }

        }

        static int AskingQuestion(int userMoney, string userName, Question question)
        {

            int userAnswewr = Print(question);

            if (userAnswewr == question.trueAnswer)
            {
                userMoney *= 2;
                Console.WriteLine($"Ответ верный. Ваш выигрыш составляет {userMoney} BYN\n");

                int userChoice = UserChoice();

                if (userChoice == 1)
                {
                    Console.Clear();
                    return userMoney;
                }
                else if (userChoice == 2)
                {
                    Console.WriteLine($"{userName}, игра окончена. Ваш выигрыш составляет {userMoney} BYN");
                    Console.ReadLine();
                    userMoney = 0;
                }
            }
            else
            {
                Console.WriteLine($"{userName}, ты проиграл, и уходишь домой без денег:(");
                Console.ReadLine();
                userMoney = 0;
            }

            return userMoney;

        }


        static int Print(Question question)
        {
            Console.WriteLine($"Вопрос №{question.questionNumber}\n{question.question}");
            Console.WriteLine($"1. {question.firstAnswer}");
            Console.WriteLine($"2. {question.secondAnswer}");
            Console.WriteLine($"3. {question.thirdAnswer}");
            Console.WriteLine($"4. {question.fourthAnswer}");

            Console.WriteLine("Введите номер правильного ответа:");
            int userAnswer = UserAnswer();

            return userAnswer;
        }

        static int UserAnswer()
        {
            string userAnswer = Console.ReadLine();

            if (userAnswer == "1" || userAnswer == "2" || userAnswer == "3" || userAnswer == "4")
            {
                return int.Parse(userAnswer);
            }
            else
            {
                Console.WriteLine("Чтобы ответить на вопрос, введите 1, 2, 3 или 4!");
                return UserAnswer();
            }

        }

        static int UserChoice()
        {
            Console.WriteLine("Чтобы продолжить игру, введите 1\nЧтобы забрать деньги, введите 2");
            string userChoice = Console.ReadLine();

            if (userChoice == "1" || userChoice == "2")
            {
                return int.Parse(userChoice);
            }
            else
                return UserChoice();

        }


    }

    class Question
    {
        public Question(int questionNumber, string question, string firstAnswer, string secondAnswer, string thirdAnswer, string fourthAnswer, int trueAnswer)
        {
            this.questionNumber = questionNumber;
            this.question = question;
            this.firstAnswer = firstAnswer;
            this.secondAnswer = secondAnswer;
            this.thirdAnswer = thirdAnswer;
            this.fourthAnswer = fourthAnswer;
            this.trueAnswer = trueAnswer;
        }
        public int questionNumber;
        public string question;
        public string firstAnswer;
        public string secondAnswer;
        public string thirdAnswer;
        public string fourthAnswer;
        public int trueAnswer;
    }
}
