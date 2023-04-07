using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length;
            int currentNumber;
            int minNumber = int.MaxValue;
            

            Console.Write("Введите длину последовательности: ");
            length = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < length; i++)
            {
                Console.Write($"Введите {i + 1} число последовательности: ");
                currentNumber = int.Parse(Console.ReadLine());
                if (currentNumber < minNumber)
                {
                    minNumber = currentNumber;
                }
            }

            Console.WriteLine();
            Console.Write($"Минимальное число последовательности: {minNumber}");
            Console.ReadKey();
        }
    }
}
