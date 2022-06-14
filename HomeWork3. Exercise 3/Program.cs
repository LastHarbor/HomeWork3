using System;

namespace HomeWork3._Exercise_3
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите число - ");
            int number = int.Parse(Console.ReadLine());
            int counter = 1;

            while (counter < number - 1)
            {
                counter++;
                if (number % counter == 0)
                {
                    
                    Console.WriteLine("Число с остатком!");
                    break;
                }
                else if (number % counter !=0)
                {
                    Console.WriteLine("Число простое!");
                    break;
                }
                
            }

            Console.ReadKey();
        }
    }
}
