using System;

namespace ConditionsAndCyclesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isEven;            
            int number;

            Console.Write("Введите целое число: ");
            number = int.Parse(Console.ReadLine());
            isEven = number % 2 == 0 ? true : false;   

            if (isEven)
            {
                Console.WriteLine("Введенное число четное");
            }
            else
            {
                Console.WriteLine("Введенное число нечетное");
            }

            Console.ReadKey();
        }
    }
}
