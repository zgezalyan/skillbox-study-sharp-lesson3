using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            int currentCheck = 2;
            bool isPrime = true;

            Console.Write("Введите целое число: ");
            number = int.Parse(Console.ReadLine());

            while (currentCheck < number)
            {
                if (number % currentCheck == 0)
                {
                    isPrime = false;
                    break;
                }
                currentCheck++;
            }

            if (isPrime)
            {
                Console.WriteLine("Введенное число является простым");
            }
            else
            {
                Console.WriteLine($"Введенное число не является простым - оно делится на {currentCheck}");
            }
            Console.ReadKey();
        }
    }
}
