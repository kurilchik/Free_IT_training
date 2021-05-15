using System;

namespace week_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            int[] firstArray = MyArray("Введите первое целое число:");
            int[] secondArray = MyArray("Введите второе целое число:");

            int lenghtArray;

            if (firstArray.Length > secondArray.Length)
            {
                lenghtArray = firstArray.Length;
                Array.Resize(ref secondArray, firstArray.Length);   
            }
            
            else
            {
                lenghtArray = secondArray.Length;
                Array.Resize(ref firstArray, secondArray.Length);
            }
            
            FinalArray(firstArray, secondArray, lenghtArray);


        }

        static int[] MyArray(string text)
        {
            Console.WriteLine(text);
            string userInput = Console.ReadLine();

            int inputLenght = userInput.Length;
            int userInputInt = int.Parse(userInput);
            
            int[] myArray = new int[inputLenght];
            for (int i = myArray.Length - 1; i >= 0; i--)
            {
                myArray[i] = userInputInt % 10;
                userInputInt /= 10;
            }

            Array.Reverse(myArray);

            return myArray;
        }

        static void FinalArray(int[] firstArray, int [] secondArray, int lenghtArray)
        {
            int[] finalArray = new int[lenghtArray];

            int rest = 0;

            for (int i = 0; i < finalArray.Length; i++)
            {
                int sum = firstArray[i] + secondArray[i] + rest;
                finalArray[i] = sum % 10;
                rest = sum / 10;
            }

            if (rest > 0)
            {
                finalArray[finalArray.Length - 1] += 10;
            }

            for (int i = 0; i < finalArray.Length; i++)
            {
                finalArray[i] = (int)(finalArray[i] * Math.Pow(10, i));
            }

            int result = 0;

            foreach (int n in finalArray)
            {
                result += n;
            }
            Console.WriteLine($"Результат вычислений равен: {result}");
        }
    }
}
