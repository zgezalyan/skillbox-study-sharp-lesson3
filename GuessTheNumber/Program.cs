using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxValue;
            int number;
            int enteredNumber;
            int numberOfTries = 0;
            Random random = new Random();

            Console.Write("Введите максимальное загадываемое число: ");
            maxValue = int.Parse(Console.ReadLine()) + 1;
            Console.WriteLine();
            number = random.Next(0, maxValue);

            while (true)
            {
                string entered;
                Console.Write("Ваша догадка: ");
                entered = Console.ReadLine();
                Console.WriteLine();

                if (entered == "")
                {
                    Console.WriteLine("В следующий раз точно получится!");
                    break;
                }

                enteredNumber = int.Parse(entered);
                numberOfTries++;

                if (enteredNumber < number)
                {
                    Console.WriteLine("Введеное число меньше загаданного, попробуйте ещё раз");                    
                }
                else if (enteredNumber > number)
                {
                    Console.WriteLine("Введеное число больше загаданного, попробуйте ещё раз");
                    
                }
                else
                {                    
                    Console.WriteLine($"Верно! Вы угадали за {numberOfTries} попыток");
                    break;
                }
            }

            Console.WriteLine($"Загаданное число: {number}");
            Console.ReadKey();
        }
    }
}
