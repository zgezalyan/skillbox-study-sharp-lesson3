using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCards;
            int sumOfCards = 0;

            Console.Write("Введите количество карт на руке: ");
            numberOfCards = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < numberOfCards; i++)
            {
                string currentCard;

                Console.Write("Введите карту: ");
                currentCard = Console.ReadLine();

                switch (currentCard)
                {
                    case "2":
                    case "3":
                    case "4":
                    case "5":
                    case "6":
                    case "7":
                    case "8":
                    case "9":
                    case "10":
                        sumOfCards += int.Parse(currentCard);
                        break;
                    case "J":
                    case "Q":
                    case "K":
                    case "A":
                        sumOfCards += 10;
                        break;
                    default:
                        Console.WriteLine("Введена несуществующая карта - значение не будет зачтено");
                        break;

                }
            }

            Console.WriteLine();
            Console.WriteLine($"Сумма карт: {sumOfCards}");
            Console.ReadKey();
        }
    }
}
