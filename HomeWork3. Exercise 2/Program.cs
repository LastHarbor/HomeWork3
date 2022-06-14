using System;
using System.Diagnostics.CodeAnalysis;

namespace HomeWork3._Exercise_2
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите имя:"); string player = Console.ReadLine(); //Считывание имени игрока

            Console.WriteLine($"Здравствуйте - {player}, сколько у вас карт на руках?"); //Приветствие по имени
            int numCards = int.Parse(Console.ReadLine());
            int sum = 0;
            
            for (int i = 0; i < numCards; i++)
            {
                Console.WriteLine("Введите номинал карты - ");
                string nom = Console.ReadLine();                //nom - номинал карт
                switch (nom)                                                           //Проверка значения переменной nom
                {
                    case "2":
                        sum += 2;
                        break;

                    case "3":
                        sum += 3;
                        break;
                    
                    case "4":
                        sum += 4;
                        break;
                    
                    case "5":
                        sum += 5;
                        break;

                    case "6": 
                        sum += 6;
                        break;

                    case "7":
                        sum += 7;
                        break;

                    case "8":
                        sum += 8;
                        break;

                    case "9":
                        sum += 9;
                        break;

                    case "10":
                        sum += 10;
                        break;

                    case "J":
                        sum += 10;
                        break;

                    case "Q":
                        sum += 10;
                        break;

                    case "K":
                        sum += 10;
                        break;

                    case "T":
                        sum += 10;
                        break;
                    default:
                        Console.WriteLine("Out of Range");              //Означает, что введено неверное значение номинала карты.
                        break;


                }
            }
            Console.Clear(); //Очищение консоли
            if (sum == 21) Console.WriteLine("Сумма карт 21, вы выйграли!"); //Условия проверки на выйгрыш.
            else Console.WriteLine($"Сумма карт - {sum}, вы не выйграли..");    
            Console.ReadKey();
        }
    }
}
