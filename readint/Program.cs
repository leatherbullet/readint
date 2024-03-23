using System;

namespace readint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            string userInput;
            bool isSuccess = true;

            while (isSuccess)
            {
                Console.WriteLine("введите число:");
                userInput = Console.ReadLine();

                bool canConvert = int.TryParse(userInput, out number);

                if(canConvert)
                {
                    Console.WriteLine($"преобразование '{userInput}' в {number} успешно");
                    isSuccess = false;
                }
                else
                {
                    Console.WriteLine($"Попытка преобразования '{userInput}' не получилось");
                }
            }
        }
    }
}
