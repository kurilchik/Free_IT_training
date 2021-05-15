using System;

namespace week_2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.InputEncoding = System.Text.Encoding.Unicode;
                Console.OutputEncoding = System.Text.Encoding.Unicode;

                decimal fisrtValue = UserInputValue("Введите первое число:");
                string userOperation = UserInputOperation();
                decimal secondValue = UserInputValue("Введите второе число:");

                if (userOperation == "+")
                {
                    Console.WriteLine("Результат вычисления равен: " + (fisrtValue + secondValue));
                }
                else if (userOperation == "-")
                {
                    Console.WriteLine("Результат вычисления равен: " + (fisrtValue - secondValue));
                }
                else if (userOperation == "*")
                {
                    Console.WriteLine("Результат вычисления равен: " + (fisrtValue * secondValue));
                }
                else if (userOperation == "/")
                {
                    if (secondValue == 0)
                    {
                        Console.WriteLine("Деление на 0 недопустимо!");
                    }
                    else
                    {
                        Console.WriteLine("Результат вычисления равен: " + (fisrtValue / secondValue));
                    }

                }
                Console.ReadLine();
            }

        }
        static decimal UserInputValue(string text)
        {
            Console.WriteLine(text);
            string userInput = Console.ReadLine();
            try
            {
                return decimal.Parse(userInput);
            }
            catch (Exception)
            {
                Console.WriteLine("Можно вводить только цифры!");
                return UserInputValue(text);
            }
        }
        static string UserInputOperation()
        {
            Console.WriteLine("Введите операцию, которую необходимо выполнить(+, -, * или /):");
            string userInput = Console.ReadLine();
            if (userInput == "+" || userInput == "-" || userInput == "*" || userInput == "/")
                return userInput;
            else
            {
                Console.WriteLine("Неизвестное действие!");
                return UserInputOperation();
            }
        }
    }
}
